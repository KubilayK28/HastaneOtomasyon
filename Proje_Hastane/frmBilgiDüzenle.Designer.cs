namespace Proje_Hastane
{
    partial class frmBilgiDüzenle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBilgiDüzenle));
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.Color.Tomato;
            this.btnBilgiGüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(194, 322);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(200, 44);
            this.btnBilgiGüncelle.TabIndex = 7;
            this.btnBilgiGüncelle.Text = "Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(194, 263);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(200, 36);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(194, 171);
            this.mskTel.Mask = "(999) 000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(200, 36);
            this.mskTel.TabIndex = 4;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(194, 122);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(200, 36);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(194, 217);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(194, 74);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "CİNSİYET:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 18;
            this.label4.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 29);
            this.label2.TabIndex = 16;
            this.label2.Text = "TELEFON:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(194, 29);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 36);
            this.txtAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD:";
            // 
            // frmBilgiDüzenle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(460, 413);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "frmBilgiDüzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.frmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBilgiGüncelle;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
    }
}