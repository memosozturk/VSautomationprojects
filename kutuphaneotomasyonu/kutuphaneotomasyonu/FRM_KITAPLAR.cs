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

namespace kutuphaneotomasyonu
{
    public partial class FRM_KITAPLAR : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_KITAPLAR", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRM_KITAPLAR()
        {
            InitializeComponent();
        }

        private void FRM_KITAPLAR_Load(object sender, EventArgs e)
        {
            listele();
        }
        //Kaydet Butonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_KITAPLAR(KITAPADI,YAZAR) values (@p1,@p2)  ",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtKITAPADI.Text);
            komut.Parameters.AddWithValue("@p2",txtYAZAR.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap veritabanına eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
            txtID.Clear();
            txtKITAPADI.Clear();
            txtYAZAR.Clear();

        }
        //Sil Butonu
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBL_KITAPLAR where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Veritabanından silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text = dr["id"].ToString();
            txtKITAPADI.Text = dr["KITAPADI"].ToString();
            txtYAZAR.Text = dr["YAZAR"].ToString();
        }
        //Güncelle Butonu
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_KITAPLAR set KITAPADI=@p1,YAZAR=@p2 where id=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKITAPADI.Text);
            komut.Parameters.AddWithValue("@p2", txtYAZAR.Text);
            komut.Parameters.AddWithValue("p3",txtID.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kitap Bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void lblAD_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
