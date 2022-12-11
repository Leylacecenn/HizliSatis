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
    public partial class SatisDetay : UserControl
    {
        public SatisDetay()
        {
            InitializeComponent();
           // this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));

        }
         hizlisatisEntities2 entities = new hizlisatisEntities2();
        //hizlisatisEntities3 entities = new hizlisatisEntities3();
        public void SatisDetay_Load(object sender, EventArgs e)
        {
          
           
        }


        private void button13_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
