using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphaneotomasyonu
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
       
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            
        }
         FRM_KISIKAYDET formkaydet;
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        FRM_KITAPLAR formkitap;
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


        }
        FRM_ODUNC formodunc;
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        FRM_RAPOR raporform;
        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void FRM_RAPOR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Application.OpenForms["FRM_RAPOR"] == null)
            {
                raporform = new FRM_RAPOR();
                raporform.MdiParent = this;
                raporform.Show();
            }

        }

        private void FRM_ODUNC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FRM_ODUNC"] == null)
            {
                formodunc = new FRM_ODUNC();
                formodunc.MdiParent = this;
                formodunc.Show();
            }

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Application.OpenForms["FRM_KITAPLAR"] == null)
            {
                formkitap = new FRM_KITAPLAR();
                formkitap.MdiParent = this;
                formkitap.Show();

            }

        }

        private void FRM_KISIKAYDET_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["FRM_KISIKAYDET"] == null)
            {
                formkaydet = new FRM_KISIKAYDET();
                formkaydet.MdiParent = this;
                formkaydet.Show();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e){
            if (Application.OpenForms["FRM_ODUNC"] == null)
            {
                formodunc = new FRM_ODUNC();
                formodunc.MdiParent = this;
                formodunc.Show();
            }
      

        }

    }
}
