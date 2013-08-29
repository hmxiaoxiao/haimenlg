namespace Haimen.NewGUI
{
    partial class DevContractQuery
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lueCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.txtCode = new C1.Win.C1Input.C1TextBox();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExit = new C1.Win.C1Input.C1Button();
            this.btnQuery = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lueCompany);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(430, 105);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lueCompany
            // 
            this.lueCompany.Location = new System.Drawing.Point(82, 60);
            this.lueCompany.Name = "lueCompany";
            this.lueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueCompany.Properties.NullText = "";
            this.lueCompany.Size = new System.Drawing.Size(328, 20);
            this.lueCompany.StyleController = this.layoutControl1;
            this.lueCompany.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(82, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(328, 22);
            this.txtCode.TabIndex = 4;
            this.txtCode.Tag = null;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(430, 105);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "代码：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(410, 40);
            this.layoutControlItem1.Text = "单据字";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueCompany;
            this.layoutControlItem5.CustomizationFormText = "单位：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(410, 45);
            this.layoutControlItem5.Text = "支出单位：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(336, 111);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnQuery.Location = new System.Drawing.Point(207, 111);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DevContractQuery
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(430, 145);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Name = "DevContractQuery";
            this.Text = "合同查询";
            this.Load += new System.EventHandler(this.DevContractQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lueCompany;
        private C1.Win.C1Input.C1TextBox txtCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private C1.Win.C1Input.C1Button btnExit;
        private C1.Win.C1Input.C1Button btnQuery;
    }
}