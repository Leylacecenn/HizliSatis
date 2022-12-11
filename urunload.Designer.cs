namespace HizliSatis
{
    partial class urunload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(urunload));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblfiyat = new System.Windows.Forms.Label();
            this.lblurunadi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(9, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 90);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // lblfiyat
            // 
            this.lblfiyat.AutoSize = true;
            this.lblfiyat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(126)))), ((int)(((byte)(25)))));
            this.lblfiyat.Location = new System.Drawing.Point(5, 34);
            this.lblfiyat.Name = "lblfiyat";
            this.lblfiyat.Size = new System.Drawing.Size(66, 25);
            this.lblfiyat.TabIndex = 6;
            this.lblfiyat.Text = "12,54";
            // 
            // lblurunadi
            // 
            this.lblurunadi.AutoSize = true;
            this.lblurunadi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblurunadi.Location = new System.Drawing.Point(5, 9);
            this.lblurunadi.Name = "lblurunadi";
            this.lblurunadi.Size = new System.Drawing.Size(70, 19);
            this.lblurunadi.TabIndex = 7;
            this.lblurunadi.Text = "Urunadi";
            this.lblurunadi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // urunload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblfiyat);
            this.Controls.Add(this.lblurunadi);
            this.Name = "urunload";
            this.Size = new System.Drawing.Size(141, 153);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblfiyat;
        public System.Windows.Forms.Label lblurunadi;
    }
}
