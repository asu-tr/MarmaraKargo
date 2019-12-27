using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using Dapper;
using MarmaraKargo.Models;

namespace MarmaraKargo
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            List<USERS> listUsernames = Context.Conn.USERS.ToList();

            string tbUsername = textBoxUsername.Text;
            string tbPassword = textBoxPassword.Text;

            USERS user = Context.Conn.USERS.Where(x => x.Username == tbUsername && x.Password == tbPassword).FirstOrDefault();

            if (user != null)
            {
                Context.UserID = user.ID;
                Context.UserType = user.Type;
                Context.Name = user.Name;

                FormDashboard frm = new FormDashboard();
                this.Hide();
                frm.Show();
            }

            else
            {
                MessageBox.Show("HATALI GİRİŞ!");
            }
            

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 8;
        }

        private void textBoxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogIn.PerformClick();
                e.Handled = true;
            }
        }
    }
}
