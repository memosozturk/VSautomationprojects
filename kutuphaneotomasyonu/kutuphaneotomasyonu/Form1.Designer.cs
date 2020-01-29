namespace kutuphaneotomasyonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl2 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.FRM_KISIKAYDET = new DevExpress.XtraBars.BarButtonItem();
            this.FRM_KITAPLAR = new DevExpress.XtraBars.BarButtonItem();
            this.FRM_ODUNC = new DevExpress.XtraBars.BarButtonItem();
            this.FRM_RAPOR = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager2 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl2
            // 
            this.ribbonControl2.ExpandCollapseItem.Id = 0;
            this.ribbonControl2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonControl2.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl2.ExpandCollapseItem,
            this.FRM_KISIKAYDET,
            this.FRM_KITAPLAR,
            this.FRM_ODUNC,
            this.FRM_RAPOR,
            this.barButtonItem5,
            this.barButtonItem1});
            this.ribbonControl2.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl2.MaxItemId = 7;
            this.ribbonControl2.Name = "ribbonControl2";
            this.ribbonControl2.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl2.Size = new System.Drawing.Size(1924, 182);
            this.ribbonControl2.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above;
            // 
            // FRM_KISIKAYDET
            // 
            this.FRM_KISIKAYDET.Caption = "KİŞİLER";
            this.FRM_KISIKAYDET.Glyph = ((System.Drawing.Image)(resources.GetObject("FRM_KISIKAYDET.Glyph")));
            this.FRM_KISIKAYDET.Id = 1;
            this.FRM_KISIKAYDET.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FRM_KISIKAYDET.ItemAppearance.Normal.Options.UseFont = true;
            this.FRM_KISIKAYDET.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FRM_KISIKAYDET.LargeGlyph")));
            this.FRM_KISIKAYDET.Name = "FRM_KISIKAYDET";
            this.FRM_KISIKAYDET.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FRM_KISIKAYDET_ItemClick);
            // 
            // FRM_KITAPLAR
            // 
            this.FRM_KITAPLAR.Caption = "KİTAPLAR";
            this.FRM_KITAPLAR.Glyph = ((System.Drawing.Image)(resources.GetObject("FRM_KITAPLAR.Glyph")));
            this.FRM_KITAPLAR.Id = 2;
            this.FRM_KITAPLAR.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FRM_KITAPLAR.ItemAppearance.Normal.Options.UseFont = true;
            this.FRM_KITAPLAR.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FRM_KITAPLAR.LargeGlyph")));
            this.FRM_KITAPLAR.Name = "FRM_KITAPLAR";
            this.FRM_KITAPLAR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // FRM_ODUNC
            // 
            this.FRM_ODUNC.Caption = "ÖDÜNÇ SERVİSİ";
            this.FRM_ODUNC.Glyph = ((System.Drawing.Image)(resources.GetObject("FRM_ODUNC.Glyph")));
            this.FRM_ODUNC.Id = 3;
            this.FRM_ODUNC.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FRM_ODUNC.ItemAppearance.Normal.Options.UseFont = true;
            this.FRM_ODUNC.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FRM_ODUNC.LargeGlyph")));
            this.FRM_ODUNC.Name = "FRM_ODUNC";
            this.FRM_ODUNC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FRM_ODUNC_ItemClick);
            // 
            // FRM_RAPOR
            // 
            this.FRM_RAPOR.Caption = "RAPORLAR";
            this.FRM_RAPOR.Glyph = ((System.Drawing.Image)(resources.GetObject("FRM_RAPOR.Glyph")));
            this.FRM_RAPOR.Id = 4;
            this.FRM_RAPOR.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FRM_RAPOR.ItemAppearance.Normal.Options.UseFont = true;
            this.FRM_RAPOR.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("FRM_RAPOR.LargeGlyph")));
            this.FRM_RAPOR.Name = "FRM_RAPOR";
            this.FRM_RAPOR.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FRM_RAPOR_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "DAASDA\r\n";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "MENÜ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.FRM_KISIKAYDET);
            this.ribbonPageGroup2.ItemLinks.Add(this.FRM_KITAPLAR);
            this.ribbonPageGroup2.ItemLinks.Add(this.FRM_ODUNC);
            this.ribbonPageGroup2.ItemLinks.Add(this.FRM_RAPOR);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // xtraTabbedMdiManager2
            // 
            this.xtraTabbedMdiManager2.MdiParent = this;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1924, 952);
            this.Controls.Add(this.ribbonControl2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1942, 999);
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE OTOMASYONU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl2;
        private DevExpress.XtraBars.BarButtonItem FRM_KISIKAYDET;
        private DevExpress.XtraBars.BarButtonItem FRM_KITAPLAR;
        private DevExpress.XtraBars.BarButtonItem FRM_ODUNC;
        private DevExpress.XtraBars.BarButtonItem FRM_RAPOR;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
     

    }
}

