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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTc.Text = TCnumara;

            //Ad Soyad

            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblTc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları Datagride Aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //Doktorları listeye aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar',DoktorBrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //Branşı Comboboxa aktarma

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
            
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into tbl_duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
            rchDuyuru.Clear();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli drp = new frmDoktorPaneli();
            drp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBrans frb = new frmBrans();
            frb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frl = new frmRandevuListesi();
            frl.Show();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }
    }
}
