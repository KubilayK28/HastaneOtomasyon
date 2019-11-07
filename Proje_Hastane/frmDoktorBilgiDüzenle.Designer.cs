namespace Proje_Hastane
{
    partial class frmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorBilgiDüzenle));
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBilgiGüncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(192, 105);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(200, 36);
            this.mskTc.TabIndex = 37;
            this.mskTc.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(192, 217);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(200, 36);
            this.txtSifre.TabIndex = 35;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(192, 57);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 36);
            this.txtSoyad.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 29);
            this.label4.TabIndex = 31;
            this.label4.Text = "SOYAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(192, 12);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 36);
            this.txtAd.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "AD:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(192, 165);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(200, 36);
            this.cmbBrans.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "BRANŞ :";
            // 
            // btnBilgiGüncelle
            // 
            this.btnBilgiGüncelle.BackColor = System.Drawing.Color.Tomato;
            this.btnBilgiGüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBilgiGüncelle.Location = new System.Drawing.Point(192, 264);
            this.btnBilgiGüncelle.Name = "btnBilgiGüncelle";
            this.btnBilgiGüncelle.Size = new System.Drawing.Size(200, 44);
            this.btnBilgiGüncelle.TabIndex = 39;
            this.btnBilgiGüncelle.Text = "Güncelle";
            this.btnBilgiGüncelle.UseVisualStyleBackColor = false;
            this.btnBilgiGüncelle.Click += new System.EventHandler(this.btnBilgiGüncelle_Click);
            // 
            // frmDoktorBilgiDüzenle
            // 
            this.AcceptButton = this.btnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(424, 320);
            this.Controls.Add(this.btnBilgiGüncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDoktorBilgiDüzenle";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.frmDoktorBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBilgiGüncelle;
    }
}