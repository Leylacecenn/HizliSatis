using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HizliSatis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            Home home = new Home();
            this.Controls.Add(home);
            home.BringToFront();
            home.Location = new Point(215, 149);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            HizliSatis hizli = new HizliSatis();
            this.Controls.Add(hizli);
            hizli.BringToFront();
            hizli.Location = new Point(215, 149);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            Home home = new Home();
            this.Controls.Add(home);
            home.BringToFront();
            home.Location = new Point(215, 149);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            UrunUserForm urunler = new UrunUserForm();
            this.Controls.Add(urunler);
            urunler.BringToFront();
            urunler.Location = new Point(215, 149);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            Satislarr rapor = new Satislarr();
            this.Controls.Add(rapor);
            rapor.BringToFront();
            rapor.Location = new Point(215, 149);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button4.Top;
            raporlar rapor = new raporlar();
            this.Controls.Add(rapor);
            rapor.BringToFront();
            rapor.Location = new Point(215, 149);
        }
    }
}
