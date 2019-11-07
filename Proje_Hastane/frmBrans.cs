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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        SqlBaglantisi bgl = new SqlBaglantisi();   
        private void frmBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable(); //DataTable sınıfından türetilen bir nesne, bir tabloyu ve elemanları bellekte kendisi için ayrılan yerde tutar.DataTable nesnesi içerisinde satırları  row koleksiyonuna ait DataRow , sütunları da colomns koleksiyonuna ait DataColumn nesneleri temsil eder.
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", bgl.baglanti());//Select sorgusu ile verileri DataSet ya da DataTable' a doldurmaktır. SqlDataAdapter nesnesini kullanmak için bir select sorgusuna ihtiyaç vardır.DataAdapter nesnesi Connected ve Disconnected bağlantı yapısı ile veri arasında köprü vazifesi görür.
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete from tbl_branslar where Bransid=@b1", bgl.baglanti());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_branslar set bransad=@p1 where bransid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBransAd.Text);
            komut.Parameters.AddWithValue("@p2", txtBransId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Brans Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
