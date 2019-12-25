using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarmaraKargo.Models;

namespace MarmaraKargo
{
    public partial class FormNew : Form
    {
        public FormNew()
        {
            InitializeComponent();
        }

        private void FormNew_Load(object sender, EventArgs e)
        {
            List<int> listCityIDs = Context.Conn.USERS.Select(x => x.CityID).Distinct().ToList();
            List<CITIES> listCities = Context.Conn.CITIES.ToList();

            Dictionary<int, string> comboCitySource = new Dictionary<int, string>();

            foreach (CITIES city in listCities)
            {
                for (int i = 0; i < listCityIDs.Count; i++)
                {
                    if (city.ID == listCityIDs[i])
                    {
                        comboCitySource.Add(city.ID, city.Name);
                    }
                }
            }

            comboBoxCity.DataSource = new BindingSource(comboCitySource, null);
            comboBoxCity.DisplayMember = "Value";
            comboBoxCity.ValueMember = "Key";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            string wei = textBoxWeight.Text;

            if (wei == null)
            {
                MessageBox.Show("Ağırlık giriniz.");
            }

            else
            {
                int weight = Convert.ToInt32(wei);
                float price = Context.CalculatePrice(weight);
                textBoxPrice.Text = price.ToString() + "₺";
            }
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = ((KeyValuePair<int, string>)comboBoxCity.SelectedItem).Key;
            List<USERS> listBranches = Context.Conn.USERS.Where(x => x.CityID == key && x.Type == 3).ToList();

            comboBoxBranch.DataSource = null;
            comboBoxBranch.Items.Clear();

            Dictionary<int, string> comboBranchSource = new Dictionary<int, string>();
            foreach (USERS branch in listBranches)
            {
                comboBranchSource.Add(branch.ID, branch.Name);
            }

            comboBoxBranch.DataSource = new BindingSource(comboBranchSource, null);
            comboBoxBranch.DisplayMember = "Value";
            comboBoxBranch.ValueMember = "Key";
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            int day = (Convert.ToInt32(System.DateTime.Now.Day) + 10);
            int month = Convert.ToInt32(System.DateTime.Now.Month);
            int year = Convert.ToInt32(System.DateTime.Now.ToString("yy"));
            int hour = Convert.ToInt32(System.DateTime.Now.Hour);
            int min = Convert.ToInt32(System.DateTime.Now.Minute);
            int senderID = Context.UserID + 10;
            int receiverID = ((KeyValuePair<int, string>)comboBoxBranch.SelectedItem).Key + 10;

            SHIPMENTS newShipment = new SHIPMENTS();
            newShipment.TrackNo = day * 1000000000000 + month * 10000000000 + year * 100000000 + hour * 1000000 + min * 10000 + senderID * 100 + receiverID;
            newShipment.SenderID = Context.UserID;
            newShipment.ReceiverID = ((KeyValuePair<int, string>)comboBoxBranch.SelectedItem).Key;
            newShipment.StatusID = 1;
            newShipment.SenderName = textBoxSender.Text;
            newShipment.ReceiverName = textBoxReceiver.Text;
            newShipment.Weight = Convert.ToInt32(textBoxWeight.Text);

            string wei = textBoxWeight.Text;
            if (wei == null)
            {
                MessageBox.Show("Ağırlık giriniz.");
            }
            else
            {
                int weight = Convert.ToInt32(wei);
                float price = Context.CalculatePrice(weight);
                newShipment.Price = price;
            }

            Context.Conn.SHIPMENTS.Add(newShipment);
            Context.Conn.SaveChanges();

            DETAILS newDetails = new DETAILS();

            newDetails.TrackNo = newShipment.TrackNo;
            newDetails.DateTime = DateTime.Now;
            newDetails.InformantID = newShipment.SenderID;
            newDetails.StatusID = 1;
            int recID = Context.Conn.SENIORS.Where(x => x.UserID == newShipment.ReceiverID).Select(x => x.SeniorID).First();
            newDetails.ReceiverID = recID;

            Context.Conn.DETAILS.Add(newDetails);
            Context.Conn.SaveChanges();

            MessageBox.Show("Kargonuz başarıyla oluşturuldu.\nTakip numarası: " + newDetails.TrackNo);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDashboard frm = new FormDashboard();
            this.Hide();
            frm.Show();
        }
    }
}
