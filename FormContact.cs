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
    public partial class FormContact : Form
    {
        public FormContact()
        {
            InitializeComponent();
        }

        private void FormContact_Load(object sender, EventArgs e)
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxContact.Text = "";
            int key = ((KeyValuePair<int, string>)comboBoxCity.SelectedItem).Key;
            List<USERS> listBranches = Context.Conn.USERS.Where(x => x.CityID == key && (x.Type == 2 || x.Type == 3)).OrderBy(x => x.Name).ToList();

            foreach (USERS office in listBranches)
            {
                string tel = office.Telephone.ToString();
                tel = "(0" + tel.Substring(0, 3) + ") " + tel.Substring(3, 3) + " " + tel.Substring(6, 2) + " " + tel.Substring(8, 2);
                textBoxContact.Text += office.Name;
                textBoxContact.Text += Environment.NewLine;
                textBoxContact.Text += office.Address;
                textBoxContact.Text += Environment.NewLine;
                textBoxContact.Text += tel;
                textBoxContact.Text += Environment.NewLine + Environment.NewLine;
            }
        }
    }
}
