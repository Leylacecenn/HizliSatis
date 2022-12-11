using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HizliSatis
{
    public partial class raporlar : UserControl
    {
         hizlisatisEntities2 entities = new hizlisatisEntities2();
        //hizlisatisEntities3 entities = new hizlisatisEntities3();
        public raporlar()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            btngunluksatislist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
        }

        private void btngunluksatislist_Click(object sender, EventArgs e)
        {
            dataGridView1.BringToFront();
            dataGridView1.DataSource = entities.TARIHsatisListesi(Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), dateTimePicker2.Value).ToList();
            lbltoplamsatis.Text = Convert.ToString(dataGridView1.RowCount);
            lblgelir.Text = entities.TARIHsatisListesiToplami(Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), dateTimePicker2.Value).Sum().ToString();
            lblgider.Text = entities.TARIHsatisListesiGider(Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()), dateTimePicker2.Value).Sum().ToString();
            // lblgelir.Text = (from c in entities.Satislars where c.Tarih >= tarih1 & c.Tarih <= tarih2 select c.ToplamTutar).Sum().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.BringToFront();
            dataGridView2.DataSource = entities.TARIHIGecenUrunListesi().ToList();
        }
        public int SatisID = 0;
        SatisDetay detay = new SatisDetay();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detay.Visible = true;
            DataGridViewRow row = dataGridView1.CurrentRow;
            SatisID = Convert.ToInt32(row.Cells["SatisId"].Value);//todo:
            this.Controls.Add(detay);
            detay.BringToFront();
            detay.dataGridView1.DataSource = entities.SatisIDBySatisListesi(SatisID);
            detay.Location = new Point(10, 149);

        }

    }
}
