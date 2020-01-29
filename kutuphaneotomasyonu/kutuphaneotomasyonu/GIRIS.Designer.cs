namespace kutuphaneotomasyonu
{
    partial class GIRISFORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIRISFORM));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.btnGIRIS = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullanıcı = new DevExpress.XtraEditors.TextEdit();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGIRIS
            // 
            this.btnGIRIS.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("btnGIRIS.Appearance.Font")));
            this.btnGIRIS.Appearance.Options.UseFont = true;
            resources.ApplyResources(this.btnGIRIS, "btnGIRIS");
            this.btnGIRIS.Name = "btnGIRIS";
            this.btnGIRIS.Click += new System.EventHandler(this.btnGIRIS_Click_1);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("labelControl1.Appearance.BackColor")));
            this.labelControl1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl1.Appearance.Font")));
            resources.ApplyResources(this.labelControl1, "labelControl1");
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.UseMnemonic = false;
            // 
            // txtSifre
            // 
            resources.ApplyResources(this.txtSifre, "txtSifre");
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtSifre.Properties.Appearance.Font")));
            this.txtSifre.Properties.Appearance.Options.UseFont = true;
            this.txtSifre.Properties.PasswordChar = '*';
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("labelControl2.Appearance.BackColor")));
            this.labelControl2.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("labelControl2.Appearance.Font")));
            resources.ApplyResources(this.labelControl2, "labelControl2");
            this.labelControl2.Name = "labelControl2";
            // 
            // txtKullanıcı
            // 
            resources.ApplyResources(this.txtKullanıcı, "txtKullanıcı");
            this.txtKullanıcı.Name = "txtKullanıcı";
            this.txtKullanıcı.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("txtKullanıcı.Properties.Appearance.Font")));
            this.txtKullanıcı.Properties.Appearance.Options.UseFont = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // GIRISFORM
            // 
            this.AcceptButton = this.btnGIRIS;
            this.ActiveGlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Appearance.BackColor = ((System.Drawing.Color)(resources.GetObject("GIRISFORM.Appearance.BackColor")));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.btnGIRIS);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtKullanıcı);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.InactiveGlowColor = System.Drawing.Color.Silver;
            this.Name = "GIRISFORM";
            this.Load += new System.EventHandler(this.GIRISFORM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullanıcı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.SimpleButton btnGIRIS;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtKullanıcı;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;

    }
}