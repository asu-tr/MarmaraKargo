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
    public partial class FormTrack : Form
    {
        public FormTrack()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            this.Hide();
            frm.Show();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            long trackno = long.Parse(textBoxTrack.Text);
           
            List<DETAILS> listTrackInfo = Context.Conn.DETAILS.Where(x => x.TrackNo == trackno).ToList();
            if (listTrackInfo.Count == 0)
            {
                MessageBox.Show("takip numarası hatalı");
            }
            else
            {
                List<USERS> listSube = Context.Conn.USERS.ToList();
                List<USERS> listVaris = Context.Conn.USERS.ToList();
                List<STATUSES> listStatuses = Context.Conn.STATUSES.ToList();
                var listDGV = (from info in listTrackInfo
                               from stat in listStatuses
                               from sube in listSube
                               from varis in listVaris
                               where info.StatusID == stat.ID
                               where info.InformantID == sube.ID
                               where info.ReceiverID == varis.ID
                    select new {
                        TakipNumarasi = info.TrackNo,
                        Tarih = info.DateTime,
                        Sube = sube.Name,
                        Durum = stat.Comments,
                        Varis = varis.Name,
                        Bilgi = info.DeliveryInfo
                    }).ToList();

                BindingSource trackBindingSource = new BindingSource();
                trackBindingSource.DataSource = listDGV;
                dataGridViewTrack.DataSource = trackBindingSource;

                dataGridViewTrack.Columns["TakipNumarasi"].HeaderText = "Takip Numarası";
                dataGridViewTrack.Columns["Tarih"].HeaderText = "Tarih";
                dataGridViewTrack.Columns["Sube"].HeaderText = "Şube";
                dataGridViewTrack.Columns["Durum"].HeaderText = "Durum";
                dataGridViewTrack.Columns["Varis"].HeaderText = "Varış Şube";
                dataGridViewTrack.Columns["Bilgi"].HeaderText = "Bilgi";

                dataGridViewTrack.AutoResizeColumns();
            }
        }
    }
}
