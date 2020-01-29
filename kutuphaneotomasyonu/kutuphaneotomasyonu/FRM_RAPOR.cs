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
    public partial class FRM_RAPOR : Form
    {
        public FRM_RAPOR()
        {
            InitializeComponent();
        }

        private void FRM_RAPOR_Load(object sender, EventArgs e)
        {
            
            this.TBL_ODUNCTableAdapter.Fill(this.KutuphaneOtomasyonDataSet.TBL_ODUNC);

            this.reportViewer1.RefreshReport();
        }
    }
}
