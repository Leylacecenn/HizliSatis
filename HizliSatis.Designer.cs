namespace HizliSatis
{
    partial class HizliSatis
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Sayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Urun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvturtar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sil = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lbltoplam = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblkdvtoplam = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hızlı Satış";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(674, 99);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(469, 536);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(674, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(469, 90);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sayi,
            this.Urun,
            this.Fiyat,
            this.Miktar1,
            this.Kdv,
            this.BirimToplamTutar,
            this.kdvturtar,
            this.NetTutar,
            this.Sil});
            this.dataGridView1.Location = new System.Drawing.Point(11, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 263);
            this.dataGridView1.TabIndex = 5;
            // 
            // Sayi
            // 
            this.Sayi.HeaderText = "";
            this.Sayi.Name = "Sayi";
            this.Sayi.Width = 21;
            // 
            // Urun
            // 
            this.Urun.HeaderText = "Urun";
            this.Urun.Name = "Urun";
            this.Urun.Width = 55;
            // 
            // Fiyat
            // 
            this.Fiyat.HeaderText = "Fiyat";
            this.Fiyat.Name = "Fiyat";
            this.Fiyat.Width = 54;
            // 
            // Miktar1
            // 
            this.Miktar1.HeaderText = "Miktar";
            this.Miktar1.Name = "Miktar1";
            this.Miktar1.Width = 61;
            // 
            // Kdv
            // 
            this.Kdv.HeaderText = "Kdv";
            this.Kdv.Name = "Kdv";
            this.Kdv.Width = 51;
            // 
            // BirimToplamTutar
            // 
            this.BirimToplamTutar.HeaderText = "Birim Toplam Tutar";
            this.BirimToplamTutar.Name = "BirimToplamTutar";
            this.BirimToplamTutar.Width = 110;
            // 
            // kdvturtar
            // 
            this.kdvturtar.HeaderText = "KDV Turtar";
            this.kdvturtar.Name = "kdvturtar";
            this.kdvturtar.Width = 79;
            // 
            // NetTutar
            // 
            this.NetTutar.HeaderText = "Net Tutar";
            this.NetTutar.Name = "NetTutar";
            this.NetTutar.Width = 71;
            // 
            // Sil
            // 
            this.Sil.HeaderText = "Sil";
            this.Sil.Name = "Sil";
            this.Sil.Width = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "TOPLAM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 472);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ödeme Türü";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(173, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 33);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nakit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(333, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Pos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(493, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 33);
            this.button3.TabIndex = 10;
            this.button3.Text = "Multinet";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbltoplam
            // 
            this.lbltoplam.AutoSize = true;
            this.lbltoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoplam.Location = new System.Drawing.Point(627, 407);
            this.lbltoplam.Name = "lbltoplam";
            this.lbltoplam.Size = new System.Drawing.Size(15, 16);
            this.lbltoplam.TabIndex = 11;
            this.lbltoplam.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürün Listesi :";
            // 
            // lblkdvtoplam
            // 
            this.lblkdvtoplam.AutoSize = true;
            this.lblkdvtoplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkdvtoplam.Location = new System.Drawing.Point(627, 377);
            this.lblkdvtoplam.Name = "lblkdvtoplam";
            this.lblkdvtoplam.Size = new System.Drawing.Size(15, 16);
            this.lblkdvtoplam.TabIndex = 14;
            this.lblkdvtoplam.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "KDV TOPLAM";
            // 
            // HizliSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblkdvtoplam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbltoplam);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Name = "HizliSatis";
            this.Size = new System.Drawing.Size(1155, 645);
            this.Load += new System.EventHandler(this.HizliSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label lbltoplam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Urun;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdv;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvturtar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetTutar;
        private System.Windows.Forms.DataGridViewImageColumn Sil;
        public System.Windows.Forms.Label lblkdvtoplam;
        private System.Windows.Forms.Label label6;
    }
}
