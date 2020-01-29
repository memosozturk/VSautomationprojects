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
    public partial class GIRISFORM : DevExpress.XtraEditors.XtraForm
    {
        public GIRISFORM()
        {
            this.ControlBox = true;
            this.ShowInTaskbar = true;
            InitializeComponent();
            
            
        }
        
        private void labelControl1_Click(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        
        private void GIRISFORM_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGIRIS_Click(object sender, EventArgs e)
        {


        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGIRIS_Click_1(object sender, EventArgs e)
        {

            String k_adi = txtKullanıcı.Text.ToString();
            String sifre = txtSifre.Text.ToString();
            SqlCommand komut = new SqlCommand("Select *from TBL_KULLANICI where KULLANICIADI='" + k_adi + "' AND SIFRE='" + sifre + "'",
                bgl.baglanti());
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form1 anaform = new Form1();
                anaform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre Girişi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            bgl.baglanti().Close();
            Properties.Settings.Default.Kullanıcı = txtKullanıcı.Text;
            Properties.Settings.Default.Şifre = txtSifre.Text;
            Properties.Settings.Default.Save();
        }
    }
}
