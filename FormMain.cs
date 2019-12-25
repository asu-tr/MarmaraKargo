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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBranchLogIn_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            this.Hide();
            frm.Show();
        }

        private void buttonTrack_Click(object sender, EventArgs e)
        {
            FormTrack frm = new FormTrack();
            this.Hide();
            frm.Show();
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            FormContact frm = new FormContact();
            this.Hide();
            frm.Show();
        }
    }
}
