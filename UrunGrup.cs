using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class UrunGrup : UserControl
    {
        hizlisatisEntities2 entities = new hizlisatisEntities2();
        // hizlisatisEntities3 entities = new hizlisatisEntities3();
        public UrunGrup()
        {
            InitializeComponent();
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
        }

        private void UrunGrup_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            dataGridView1.DataSource = entities.UrunGruplaris.ToList();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunGruplari grup = new UrunGruplari();
            grup.UrunGrup = txturungrup.Text;
            entities.UrunGruplaris.Add(grup);
            int sonuc = entities.SaveChanges();
            if (sonuc <= 0)
            {
                MessageBox.Show("Bir sorun oluştu");
            }
            else
            {
                lblhata.Text = "Başarılı Bir şekilde Eklendi";
            }
            listele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            var sil = entities.UrunGruplaris.Where(x => x.UrunGrupId == id).FirstOrDefault();
            entities.UrunGruplaris.Remove(sil);
            entities.SaveChanges();
            listele();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            txturungrup.Text = row.Cells[1].Value.ToString();
            lblid.Text = row.Cells[0].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblid.Text);
            var yenile = entities.UrunGruplaris.Where(x => x.UrunGrupId == id).FirstOrDefault();
            yenile.UrunGrup = txturungrup.Text;            
            int sonuc = entities.SaveChanges();
            if (sonuc <= 0)
            {
                MessageBox.Show("Bir sorun oluştu");
            }
            else
            {
                lblhata.Text = "Başarılı Bir şekilde Güncellendi";
            }
            listele();
        }
    }
}
