using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarmaraKargo
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            labelName.Text = Context.Name;
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Context.Name = "";
            Context.UserID = 0;
            Context.UserType = 0;

            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void buttonNewShipment_Click(object sender, EventArgs e)
        {
            FormNew frm = new FormNew();
            this.Hide();
            frm.Show();
        }
    }
}
