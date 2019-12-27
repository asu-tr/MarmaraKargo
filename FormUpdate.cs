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
    public partial class FormUpdate : Form
    {
        public FormUpdate()
        {
            InitializeComponent();
        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {
            List<DETAILS> listDetails = Context.Conn.DETAILS.GroupBy(d => d.TrackNo).Select(g => g.OrderByDescending(a => a.ID).FirstOrDefault()).Where(x => x.StatusID != 6 && (x.InformantID == Context.UserID && (x.StatusID == 1 || x.StatusID == 4 || x.StatusID == 5 || x.StatusID == 7 || x.StatusID == 8)) || (x.ReceiverID == Context.UserID && (x.StatusID == 2 || x.StatusID == 3 || x.StatusID == 4 || x.StatusID == 5 || x.StatusID == 7 || x.StatusID == 8))).ToList();
            
            foreach (DETAILS shipment in listDetails)
            {
                comboBoxShipment.Items.Add(shipment.TrackNo);
            }
        }

        private void comboBoxShipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            long trackno = long.Parse(comboBoxShipment.SelectedItem.ToString());
            DETAILS detail = Context.Conn.DETAILS.Where(x => x.TrackNo == trackno).OrderByDescending(x => x.DateTime).FirstOrDefault();
            int durum = detail.StatusID;
            
            string myText = "";
            switch (durum)
            {
                case 1:
                    myText = "Kabul Edildi";
                    break;

                case 2:
                    myText = "Transfer Sürecinde";
                    break;

                case 3:
                    myText = "Şubeye Sevk Edildi";
                    break;

                case 4:
                    myText = "Şubeye Geldi";
                    break;

                case 5:
                    myText = "Dağıtıma Çıkarıldı";
                    break;

                case 6:
                    myText = "Teslim Edildi";
                    break;

                case 7:
                    myText = "Teslim Edilemedi";
                    break;

                case 8:
                    myText = "İade Talebi Oluşturuldu";
                    break;

                case 9:
                    myText = "İade Edildi";
                    break;

                default:
                    break;
            }
            labelStatusInfo.Text = myText;

            List<STATUSES> listStatus = new List<STATUSES>();

            switch (detail.StatusID)
            {
                case 1:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 2 || x.ID == 5 || x.ID == 6).ToList();
                    break;

                case 2:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 2 || x.ID == 3 || x.ID == 4).ToList();
                    break;

                case 3:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 4).ToList();
                    break;

                case 4:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 5 || x.ID == 6).ToList();
                    break;

                case 5:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 6 || x.ID == 7).ToList();
                    break;

                case 7:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 2 || x.ID == 6 || x.ID == 7).ToList();
                    break;

                case 8:
                    listStatus = Context.Conn.STATUSES.Where(x => x.ID == 2 || x.ID == 6).ToList();
                    break;

                default:
                    listStatus = Context.Conn.STATUSES.ToList();
                    break;
            }

            Dictionary<int, string> comboLastSource = new Dictionary<int, string>();

            foreach (STATUSES stat in listStatus)
            {
                comboLastSource.Add(stat.ID, stat.Comments);
            }

            comboBoxLast.DataSource = new BindingSource(comboLastSource, null);
            comboBoxLast.DisplayMember = "Value";
            comboBoxLast.ValueMember = "Key";

            int recID = Context.Conn.SHIPMENTS.Where(x => x.TrackNo == trackno).Select(x => x.ReceiverID).First();
            int recSeniorID = Context.Conn.SENIORS.Where(x => x.UserID == recID).Select(x => x.SeniorID).First();
            int senSeniorID = Context.Conn.SENIORS.Where(x => x.UserID == Context.UserID).Select(x => x.SeniorID).First();

            List<USERS> listRec = Context.Conn.USERS.Where(x => x.ID == recID || x.ID == recSeniorID || x.ID == senSeniorID).ToList();

            Dictionary<int, string> comboRecSource = new Dictionary<int, string>();
            foreach (USERS user in listRec)
            {
                comboRecSource.Add(user.ID, user.Name);
            }
            comboBoxRec.DataSource = new BindingSource(comboRecSource, null);
            comboBoxRec.DisplayMember = "Value";
            comboBoxRec.ValueMember = "Key";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormDashboard frm = new FormDashboard();
            this.Hide();
            frm.Show();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            DETAILS newDetail = new DETAILS();
            newDetail.TrackNo = long.Parse(comboBoxShipment.SelectedItem.ToString());
            newDetail.DateTime = System.DateTime.Now;
            newDetail.InformantID = Context.UserID;
            newDetail.StatusID = ((KeyValuePair<int, string>)comboBoxLast.SelectedItem).Key;
            newDetail.ReceiverID = ((KeyValuePair<int, string>)comboBoxRec.SelectedItem).Key;
            if (textBoxExtra.Text != null)
            {
                newDetail.DeliveryInfo = textBoxExtra.Text;
            }

            Context.Conn.DETAILS.Add(newDetail);
            Context.Conn.SaveChanges();

            SHIPMENTS shipment = Context.Conn.SHIPMENTS.First(x => x.TrackNo == newDetail.TrackNo);
            shipment.StatusID = newDetail.StatusID;
            Context.Conn.SaveChanges();

            if (MessageBox.Show("Kayıt başarıyla güncellendi.", "Tamam", MessageBoxButtons.OK) == System.Windows.Forms.DialogResult.OK)
            {
                FormDashboard frm = new FormDashboard();
                this.Hide();
                frm.Show();
            }
        }
    }
}
