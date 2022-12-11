using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HizliSatis
{
    public partial class UrunUserForm : UserControl
    {

        hizlisatisEntities2 entities = new hizlisatisEntities2();
        // hizlisatisEntities3 entities = new hizlisatisEntities3();

        public UrunUserForm()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
        }

        private void UrunUserForm_Load(object sender, EventArgs e)
        {
            listele();
            gruplistele();
        }

        private void gruplistele()
        {
            comboBox1.DataSource = entities.UrunGruplaris.ToList();
            comboBox1.DisplayMember = "UrunGrup";
            comboBox1.ValueMember = "UrunGrupId";
        }

        private void listele()
        {
            IList<Urunler> urunlist = entities.Urunlers.ToList();

            var orderByDescendingResult = from s in urunlist
                                          orderby s.UrunId descending
                                          select s;

            dataGridView2.DataSource = orderByDescendingResult.ToList();
        }
        public string SeciliResim = "";
        string guncelleme = "..\\image\\";
        public string gorselkontrol()
        {
            string gorselveri = "";
            if (guncelleme == "..\\images\\")
            {
                gorselveri = "..\\image\\no-image.png";
            }
            else
            {
                gorselveri = guncelleme;
            }

            return gorselveri;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            guncelleme = "..\\image\\";
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "JPG (*.jpg,*.jpeg)|*.jpg;*.jpeg";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                guncelleme += Path.GetFileName(theDialog.FileName);
                SeciliResim = theDialog.FileName.ToString();
                pictureBox1.Image = Image.FromFile(guncelleme);
                theDialog.FileName = "";
            }

        }
        private void Clear()
        {
            txturun.Text = "";
            txtalis.Text = "";
            txtkdv.Text = "";
            txtsatis.Text = "";
            sonkullanmatarihi.Text = "";
            uretimtarihi.Text = "";
            pictureBox1.Image = null;
            SeciliResim = "";
            guncelleme = "..\\image\\";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunGrup urunGrup = new UrunGrup();

            this.Controls.Add(urunGrup);
            urunGrup.BringToFront();
            urunGrup.dataGridView1.DataSource = entities.UrunGruplaris.ToList();
            urunGrup.Location = new Point(433, 48);


        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string gorselveri = gorselkontrol();
                Urunler urun = new Urunler();
                urun.Rafomru = DateTime.Parse(sonkullanmatarihi.Text);
                urun.Kdv = Convert.ToInt32(txtkdv.Text);
                urun.UrunAdi = txturun.Text;
                UrunGruplari grup = comboBox1.SelectedItem as UrunGruplari;
                if (grup != null)
                {
                    urun.GrupId = grup.UrunGrupId;
                }
                urun.AlisFiyati = Convert.ToInt32(txtalis.Text);
                urun.SatisFiyat = Convert.ToInt32(txtsatis.Text);
                urun.Gorsel = gorselveri;
                urun.UretimTarihi = DateTime.Parse(uretimtarihi.Text);
                entities.Urunlers.Add(urun);
                entities.SaveChanges();
                lblhata.Text = "Başarılı Bir şekilde eklendi";
            }
            catch (Exception ex)
            {

                lblhata.Text = "Bir hata oluştu. : " + ex.Message;
            }
            listele();
            Clear();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gorselveri = gorselkontrol();
            int id = Convert.ToInt32(lblid.Text);
            var urun = entities.Urunlers.Where(c => c.UrunId == id).FirstOrDefault();
            urun.Rafomru = DateTime.Parse(sonkullanmatarihi.Text);
            urun.Kdv = Convert.ToInt32(txtkdv.Text);
            urun.UrunAdi = txturun.Text;

            urun.GrupId = Convert.ToInt32(comboBox1.Tag);

            urun.AlisFiyati = Convert.ToInt32(txtalis.Text);
            urun.SatisFiyat = Convert.ToInt32(txtsatis.Text);
            urun.Gorsel = gorselveri;
            urun.UretimTarihi = DateTime.Parse(uretimtarihi.Text);
            entities.SaveChanges();

            listele();
            Clear();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.CurrentRow;
            //UrunId UrunAdi AlisFiyati SatisFiyat Gorsel Kdv UretimTarihi Rafomru GrupId
            lblid.Text = row.Cells["UrunId"].Value.ToString();
            txturun.Text = row.Cells["UrunAdi"].Value.ToString();
            txtalis.Text = row.Cells["AlisFiyati"].Value.ToString();
            txtsatis.Text = row.Cells["SatisFiyat"].Value.ToString();
            txtkdv.Text = row.Cells["Kdv"].Value.ToString();
            if (row.Cells["UretimTarihi"].Value != null || row.Cells["Rafomru"].Value != null)
            {

                uretimtarihi.Text = row.Cells["UretimTarihi"].Value.ToString();
                sonkullanmatarihi.Text = row.Cells["Rafomru"].Value.ToString();
            }

            int grupid = Convert.ToInt32(row.Cells["GrupId"].Value.ToString());
            var grup = entities.UrunGruplaris.Where(x => x.UrunGrupId == grupid).FirstOrDefault();

            comboBox1.Text = "";
            comboBox1.Text = grup.UrunGrup;
            comboBox1.Tag = grup.UrunGrupId;

            try
            {
                pictureBox1.Image = Image.FromFile(row.Cells["Gorsel"].Value.ToString());
                guncelleme = row.Cells["Gorsel"].Value.ToString();
            }
            catch (Exception)
            {
                pictureBox1.Image = Image.FromFile("..\\image\\no-image.png");
            }
            finally
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Tag=comboBox1.SelectedValue;
        }

        private void txtara_TextChanged(object sender, EventArgs e)
        {
            string ara = txtara.Text;
            dataGridView2.DataSource = entities.Urunlers.Where(s => s.UrunAdi.Contains(ara)).ToList();
        }
    }
}
