using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace HizliSatis
{
    public partial class HizliSatis : UserControl
    {
        public HizliSatis()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(240)))));
            button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
        }

         hizlisatisEntities2 entities = new hizlisatisEntities2();
        // hizlisatisEntities3 entities = new hizlisatisEntities3();
        private void HizliSatis_Load(object sender, EventArgs e)
        {
            grupload();
            urunload(1);

        }

        private void grupload()
        {
            List<UrunGruplari> list = entities.UrunGruplaris.ToList();

            for (int a = 0; a < list.Count; a++)
            {
                System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
                btn.Text = list[a].UrunGrup.ToString();
                btn.Size = new Size(121, 38);
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
                btn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.ForeColor = System.Drawing.Color.White;
                flowLayoutPanel2.Controls.Add(btn);
                int id = list[a].UrunGrupId;
                // btn.Click += new System.EventHandler();
                btn.Click += (sender, args) =>
                {
                    urunload(id);

                };
            }


        }

        private void urunload(int grupID)
        {
            if (grupID != null)
            {
                flowLayoutPanel1.Controls.Clear();
                List<Urunler> list = entities.Urunlers.Where(x => x.GrupId == grupID).ToList();
                for (int a = 0; a < list.Count; a++)
                {
                    urunload load = new urunload();
                    load.lblfiyat.Text = list[a].SatisFiyat.ToString();
                    load.lblurunadi.Text = list[a].UrunAdi.ToString();
                    try
                    {
                        load.pictureBox2.Image = Image.FromFile("..\\image\\" + list[a].Gorsel.ToString());
                    }
                    catch (Exception)
                    {
                        load.pictureBox2.Image = Image.FromFile("..\\image\\no-image.png");
                    }

                    flowLayoutPanel1.Controls.Add(load);
                    string urunadi = list[a].UrunAdi;
                    double fiyat = list[a].SatisFiyat.Value;
                    int urunid = list[a].UrunId;
                    double kdv = list[a].Kdv.Value;
                    load.Click += (sender, args) =>
                    {
                        hesaplama(urunadi, fiyat, urunid, kdv);
                    };
                    load.lblfiyat.Click += (sender, args) =>
                    {
                        hesaplama(urunadi, fiyat, urunid, kdv);
                    };
                    load.lblurunadi.Click += (sender, args) =>
                    {
                        hesaplama(urunadi, fiyat, urunid, kdv);
                    };
                    load.pictureBox2.Click += (sender, args) =>
                    {
                        hesaplama(urunadi, fiyat, urunid, kdv);
                    };
                }
            }
        }
        int miktar = 0;
        double lbltoplami = 0;
        double lblkdvtoplami = 0;
        double birimtoplam = 0;
        double kdvtoplam = 0;
        double toplam = 0;
        int aktifkolon = 0;
        private void hesaplama(string urunadi, double fiyat, int urunid, double kdv)
        {
            //gondericeklerin urunıd, miktar, birimfiyat, kdv, birimtoplamtutar, kdvturtar, nettutar, tarih 
            bool durum = rowkontrol(urunid);
            if (durum == false)
            {
                miktar++;
                birimtoplam = fiyat + ((kdv / 100) * fiyat);
                kdvtoplam = (Convert.ToDouble(fiyat) * kdv) / 100;
                toplam = birimtoplam * miktar;
                this.dataGridView1.Rows.Insert(0, urunid, urunadi, fiyat, miktar, kdv, birimtoplam, kdvtoplam, toplam);

                lbltoplami = Convert.ToDouble(lbltoplam.Text);
                lbltoplami += Convert.ToDouble(toplam);
                lbltoplam.Text = Convert.ToString(lbltoplami);

                lblkdvtoplami = Convert.ToDouble(lblkdvtoplam.Text);
                lblkdvtoplami += Convert.ToDouble(kdvtoplam);
                lblkdvtoplam.Text = Convert.ToString(lblkdvtoplami);

                lbltoplami = 0;
                miktar = 0;
                birimtoplam = 0;
                kdvtoplam = 0;
                toplam = 0;
                aktifkolon = 0;
            }
            else
            {
                double fiyat1 = 0;
                miktar = Convert.ToInt32(dataGridView1.Rows[aktifkolon].Cells["Miktar1"].Value);
                miktar++;
                birimtoplam = Convert.ToDouble(dataGridView1.Rows[aktifkolon].Cells["BirimToplamTutar"].Value);
                fiyat1 = Convert.ToDouble(dataGridView1.Rows[aktifkolon].Cells["Fiyat"].Value);
                // kdvtoplam = Convert.ToDouble(dataGridView1.Rows[aktifkolon].Cells["kdvturtar"].Value);

                toplam += birimtoplam * miktar;
                kdvtoplam = ((kdv / 100) * fiyat1 * miktar);

                this.dataGridView1.Rows[aktifkolon].Cells["Miktar1"].Value = miktar;
                this.dataGridView1.Rows[aktifkolon].Cells["BirimToplamTutar"].Value = birimtoplam;
                this.dataGridView1.Rows[aktifkolon].Cells["kdvturtar"].Value = kdvtoplam;
                this.dataGridView1.Rows[aktifkolon].Cells["NetTutar"].Value = toplam;

                lbltoplami = Convert.ToDouble(lbltoplam.Text);
                lbltoplami += Convert.ToDouble(birimtoplam);
                lbltoplam.Text = Convert.ToString(lbltoplami);

                lblkdvtoplami = Convert.ToDouble(lblkdvtoplam.Text);
                lblkdvtoplami += ((kdv / 100) * fiyat1); ;
                lblkdvtoplam.Text = Convert.ToString(lblkdvtoplami);

                lbltoplami = 0;
                miktar = 0;
                birimtoplam = 0;
                kdvtoplam = 0;
                toplam = 0;
                aktifkolon = 0;

            }
        }

        private bool rowkontrol(int urunid)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value) == urunid)
                {
                    aktifkolon = i;
                    return true;
                }
            }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string odeme = "nakit";
            odemeyazdir(odeme);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string odeme = "pos";
            odemeyazdir(odeme);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string odeme = "multinet";
            odemeyazdir(odeme);
        }

        private void odemeyazdir(string odeme)
        {
            try
            {
                // satıs girilecek ilk
                Satislar satis = new Satislar();
                satis.Tarih = DateTime.Now;
                satis.ToplamTutar = Convert.ToDouble(lbltoplam.Text);
                satis.ToplamKDV = Convert.ToDouble(lblkdvtoplam.Text);
                satis.NetToplam = Convert.ToDouble(lbltoplam.Text) - Convert.ToDouble(lblkdvtoplam.Text); //hatalı işlem temsili yapılmıştır 
                satis.OdemeTuru = odeme;
                entities.Satislars.Add(satis);
                entities.SaveChanges();
                var satisid = satis.SatisId;

                SatisListesi satislist = new SatisListesi();
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    satislist.SatisId = satisid;
                    satislist.UrunID = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                    satislist.Miktar = Convert.ToInt32(dataGridView1.Rows[i].Cells["Miktar1"].Value.ToString());
                    satislist.BirimToplamTutar = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["BirimToplamTutar"].Value);
                    satislist.KdvTutari = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["kdvturtar"].Value);
                    satislist.NetTutar = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["NetTutar"].Value);
                    satislist.Tarih = DateTime.Now;
                    satislist.Birimfiyat = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["Fiyat"].Value);
                    satislist.Kdv = Convert.ToDouble(this.dataGridView1.Rows[i].Cells["Kdv"].Value);

                    entities.SatisListesis.Add(satislist);
                    entities.SaveChanges();
                }
                MessageBox.Show("İşlem Başarılı");
                dataGridView1.Rows.Clear();
                lblkdvtoplam.Text = "0";
                lbltoplam.Text = "0";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir sorun oluştu :"+ex.Message);
            }
        }


    }
}
