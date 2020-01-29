namespace kutuphaneotomasyonu
{
    partial class FRM_ODUNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_ODUNC));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.lblAD = new DevExpress.XtraEditors.LabelControl();
            this.mskTESLIM = new System.Windows.Forms.MaskedTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.mskALIS = new System.Windows.Forms.MaskedTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbKITAP = new System.Windows.Forms.ComboBox();
            this.cmbALAN = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1500, 950);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(113, 297);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(157, 44);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "KAYDET";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // lblAD
            // 
            this.lblAD.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAD.Location = new System.Drawing.Point(24, 74);
            this.lblAD.Name = "lblAD";
            this.lblAD.Size = new System.Drawing.Size(95, 22);
            this.lblAD.TabIndex = 0;
            this.lblAD.Text = "Ödünç alan:";
            this.lblAD.Click += new System.EventHandler(this.lblAD_Click);
            // 
            // mskTESLIM
            // 
            this.mskTESLIM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTESLIM.Location = new System.Drawing.Point(125, 221);
            this.mskTESLIM.Mask = "00/00/0000";
            this.mskTESLIM.Name = "mskTESLIM";
            this.mskTESLIM.Size = new System.Drawing.Size(145, 28);
            this.mskTESLIM.TabIndex = 7;
            this.mskTESLIM.ValidatingType = typeof(System.DateTime);
            this.mskTESLIM.Leave += new System.EventHandler(this.mskTESLIM_Leave);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Location = new System.Drawing.Point(36, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(83, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Alış Tarihi:";
            // 
            // mskALIS
            // 
            this.mskALIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskALIS.Location = new System.Drawing.Point(125, 187);
            this.mskALIS.Mask = "00/00/0000";
            this.mskALIS.Name = "mskALIS";
            this.mskALIS.Size = new System.Drawing.Size(145, 28);
            this.mskALIS.TabIndex = 6;
            this.mskALIS.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mskALIS.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Location = new System.Drawing.Point(27, 120);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(92, 22);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "KİTAP ADI:";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Location = new System.Drawing.Point(12, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(107, 22);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Teslim Tarihi:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbKITAP);
            this.groupControl1.Controls.Add(this.cmbALAN);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.btnGUNCELLE);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.lblAD);
            this.groupControl1.Controls.Add(this.mskTESLIM);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.mskALIS);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Location = new System.Drawing.Point(1497, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(550, 950);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // cmbKITAP
            // 
            this.cmbKITAP.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKITAP.FormattingEnabled = true;
            this.cmbKITAP.Location = new System.Drawing.Point(125, 117);
            this.cmbKITAP.Name = "cmbKITAP";
            this.cmbKITAP.Size = new System.Drawing.Size(145, 30);
            this.cmbKITAP.TabIndex = 14;
            this.cmbKITAP.SelectedIndexChanged += new System.EventHandler(this.cmbKITAP_SelectedIndexChanged);
            // 
            // cmbALAN
            // 
            this.cmbALAN.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbALAN.FormattingEnabled = true;
            this.cmbALAN.Location = new System.Drawing.Point(125, 71);
            this.cmbALAN.Name = "cmbALAN";
            this.cmbALAN.Size = new System.Drawing.Size(145, 30);
            this.cmbALAN.TabIndex = 13;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Location = new System.Drawing.Point(94, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 22);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtID.Location = new System.Drawing.Point(125, 27);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(145, 28);
            this.txtID.TabIndex = 12;
            // 
            // btnGUNCELLE
            // 
            this.btnGUNCELLE.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGUNCELLE.Appearance.Options.UseFont = true;
            this.btnGUNCELLE.Image = ((System.Drawing.Image)(resources.GetObject("btnGUNCELLE.Image")));
            this.btnGUNCELLE.Location = new System.Drawing.Point(113, 397);
            this.btnGUNCELLE.Name = "btnGUNCELLE";
            this.btnGUNCELLE.Size = new System.Drawing.Size(157, 44);
            this.btnGUNCELLE.TabIndex = 10;
            this.btnGUNCELLE.Text = "GÜNCELLE";
            this.btnGUNCELLE.Click += new System.EventHandler(this.btnGUNCELLE_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(113, 347);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(157, 44);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "SİL";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.Name = "sqlDataSource1";
            // 
            // FRM_ODUNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 903);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "FRM_ODUNC";
            this.Text = "Ödünç Servisi";
            this.Load += new System.EventHandler(this.FRM_ODUNC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl lblAD;
        private System.Windows.Forms.MaskedTextBox mskTESLIM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.MaskedTextBox mskALIS;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtID;
        private DevExpress.XtraEditors.SimpleButton btnGUNCELLE;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.ComboBox cmbKITAP;
        private System.Windows.Forms.ComboBox cmbALAN;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}