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
    public partial class FRM_KISIKAYDET : Form
    {
        public FRM_KISIKAYDET()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_KISILER", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_KISIKAYDET_Load(object sender, EventArgs e)
        {
            listele();
        }
        //kaydet butonu
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into TBL_KISILER(AD,SOYAD,TC,TELEFON) values (@p1,@p2,@p3,@p4)",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",txtAD.Text);
            komut.Parameters.AddWithValue("@p2",txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3",mskTC.Text.ToString());
            komut.Parameters.AddWithValue("@p4",mskTEL.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kişi veritabanına eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }
        //sil butonu
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("Delete from TBL_KISILER where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kişi Veritabanından silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtID.Text=dr["id"].ToString();
            txtAD.Text=dr["AD"].ToString();
            txtSOYAD.Text=dr["SOYAD"].ToString();
            mskTC.Text=dr["TC"].ToString();
            mskTEL.Text=dr["TELEFON"].ToString();

        }
        //Güncelle Butonu
        private void simpleButton3_Click(object sender, System.EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update TBL_KISILER set AD=@p1,SOYAD=@p2,TC=@p3,TELEFON=@p4 where id=@p5",
                bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAD.Text);
            komut.Parameters.AddWithValue("@p2", txtSOYAD.Text);
            komut.Parameters.AddWithValue("@p3", mskTC.Text.ToString());
            komut.Parameters.AddWithValue("@p4", mskTEL.Text.ToString());
            komut.Parameters.AddWithValue("@p5",txtID.Text.ToString());
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kişi Bilgileri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
