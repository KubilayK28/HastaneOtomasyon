using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt fr = new FrmHastaKayıt();
            fr.Show();
            
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc=@p1 and HastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCKimlikNo.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay fr = new frmHastaDetay();
                fr.tc = mskTCKimlikNo.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Tc & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
