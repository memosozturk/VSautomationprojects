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
    public partial class FRM_ODUNC : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From TBL_ODUNC", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        public FRM_ODUNC()
        {
            InitializeComponent();
        }

        private void lblAD_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            SqlCommand komutsil = new SqlCommand("Delete from TBL_ODUNC where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1", txtID.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ödünç Veritabanından silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            listele();

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void FRM_ODUNC_Load(object sender, EventArgs e)
        {
            kitapcek();
            cmbALAN.DisplayMember = "AdSoyad";
            cmbALAN.ValueMember = "id";
            cmbALAN.DataSource = ComboData();
            listele();
//this.reportViewer1.RefreshReport();
        }
       private void kitapcek(){
       SqlCommand komut=new SqlCommand("Select *from TBL_KITAPLAR",bgl.baglanti());
           SqlDataReader dr;
           dr=komut.ExecuteReader();
           while(dr.Read()){
               cmbKITAP.Items.Add(dr["KITAPADI"]);
           }
           bgl.baglanti().Close();

       }
        
         private DataTable ComboData()
        {
            DataTable ret = new DataTable();
            
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT [id], ([AD] + ' ' + [SOYAD]) AS [AdSoyad] FROM [TBL_KISILER] ", bgl.baglanti()))
                {
                    dataAdapter.Fill(ret);
                }
            
            return ret;
        }

         private void simpleButton1_Click(object sender, EventArgs e)
         {
          String kıtapdogrumu = cmbKITAP.FindStringExact(cmbKITAP.Text).ToString();
          String alandogrumu = cmbALAN.FindStringExact(cmbALAN.Text).ToString();          
             if (alandogrumu.Equals("-1") || kıtapdogrumu.Equals("-1"))
             {
                 MessageBox.Show("GEÇERSİZ KİŞİ VEYA KİTAP", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 
             }

             else {
                 SqlCommand komut = new SqlCommand("insert into TBL_ODUNC(KisiAdısoyadı,KitapAdı,Alıstarihi,Teslimtarihi) values(@p1,@p2,@p3,@p4)", bgl.baglanti());
                 komut.Parameters.AddWithValue("@p1", cmbALAN.Text);
                 komut.Parameters.AddWithValue("@p2", cmbKITAP.Text);
                 komut.Parameters.AddWithValue("@p3", DateTime.Parse(mskALIS.Text));
                 komut.Parameters.AddWithValue("@p4", DateTime.Parse(mskTESLIM.Text));
                 komut.ExecuteNonQuery();
                 bgl.baglanti().Close();
                 MessageBox.Show("Ödünç verme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 listele();
             }
         }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
         {
             DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
             txtID.Text=dr["id"].ToString();
             cmbALAN.Text = dr["KisiAdısoyadı"].ToString();
             cmbKITAP.Text = dr["KitapAdı"].ToString();
             mskALIS.Text = dr["Alıstarihi"].ToString();
             mskTESLIM.Text = dr["Teslimtarihi"].ToString();

         }

         private void btnGUNCELLE_Click(object sender, EventArgs e)
         {
             

             SqlCommand komut = new SqlCommand("Update TBL_ODUNC set KisiAdısoyadı=@p1,KitapAdı=@p2,Alıstarihi=@p3,Teslimtarihi=@p4 where id=@p5 ",bgl.baglanti());
             komut.Parameters.AddWithValue("@p1", cmbALAN.Text);
             komut.Parameters.AddWithValue("@p2", cmbKITAP.Text);
             komut.Parameters.AddWithValue("@p3", DateTime.Parse(mskALIS.Text));
             komut.Parameters.AddWithValue("@p4", DateTime.Parse(mskTESLIM.Text));
             komut.Parameters.AddWithValue("@p5",txtID.Text);
             komut.ExecuteNonQuery();
             bgl.baglanti().Close();
             MessageBox.Show("Ödünç verme işlemi Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
             listele();
         }
         
         private void mskTESLIM_Leave(object sender, EventArgs e)
         {
             if (Convert.ToDateTime(mskALIS.Text) > Convert.ToDateTime(mskTESLIM.Text))
             {
             MessageBox.Show("Alış Tarihi Teslim Tarihinden Büyük Olamaz. Bilgileri Kontrol Ediniz", 
                 "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
             mskTESLIM.Focus();    
             }
         }

         private void cmbKITAP_SelectedIndexChanged(object sender, EventArgs e)
         {

         }
    }
    }

