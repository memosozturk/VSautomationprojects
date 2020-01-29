namespace kutuphaneotomasyonu
{
    partial class FRM_RAPOR
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TBL_ODUNCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.KutuphaneOtomasyonDataSet = new kutuphaneotomasyonu.KutuphaneOtomasyonDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TBL_ODUNCTableAdapter = new kutuphaneotomasyonu.KutuphaneOtomasyonDataSetTableAdapters.TBL_ODUNCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TBL_ODUNCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KutuphaneOtomasyonDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TBL_ODUNCBindingSource
            // 
            this.TBL_ODUNCBindingSource.DataMember = "TBL_ODUNC";
            this.TBL_ODUNCBindingSource.DataSource = this.KutuphaneOtomasyonDataSet;
            // 
            // KutuphaneOtomasyonDataSet
            // 
            this.KutuphaneOtomasyonDataSet.DataSetName = "KutuphaneOtomasyonDataSet";
            this.KutuphaneOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.TBL_ODUNCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "kutuphaneotomasyonu.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1924, 763);
            this.reportViewer1.TabIndex = 0;
            // 
            // TBL_ODUNCTableAdapter
            // 
            this.TBL_ODUNCTableAdapter.ClearBeforeFill = true;
            // 
            // FRM_RAPOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 763);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_RAPOR";
            this.Text = "Raporlar";
            this.Load += new System.EventHandler(this.FRM_RAPOR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TBL_ODUNCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KutuphaneOtomasyonDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TBL_ODUNCBindingSource;
        private KutuphaneOtomasyonDataSet KutuphaneOtomasyonDataSet;
        private KutuphaneOtomasyonDataSetTableAdapters.TBL_ODUNCTableAdapter TBL_ODUNCTableAdapter;
    }
}