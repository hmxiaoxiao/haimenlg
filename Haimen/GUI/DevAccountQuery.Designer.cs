namespace Haimen.GUI
{
    partial class DevAccountQuery
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
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.lueOutCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lueInCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.lookUpEdit1);
            this.layoutControl1.Controls.Add(this.lueOutCompany);
            this.layoutControl1.Controls.Add(this.lueInCompany);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(391, 186);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(84, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(285, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 1;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.EnterMoveNextControl = true;
            this.lookUpEdit1.Location = new System.Drawing.Point(82, 144);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Size = new System.Drawing.Size(289, 20);
            this.lookUpEdit1.StyleController = this.layoutControl1;
            this.lookUpEdit1.TabIndex = 4;
            // 
            // lueOutCompany
            // 
            this.lueOutCompany.EnterMoveNextControl = true;
            this.lueOutCompany.Location = new System.Drawing.Point(82, 64);
            this.lueOutCompany.Name = "lueOutCompany";
            this.lueOutCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueOutCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOutCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueOutCompany.Properties.NullText = "";
            this.lueOutCompany.Size = new System.Drawing.Size(289, 20);
            this.lueOutCompany.StyleController = this.layoutControl1;
            this.lueOutCompany.TabIndex = 2;
            // 
            // lueInCompany
            // 
            this.lueInCompany.EnterMoveNextControl = true;
            this.lueInCompany.Location = new System.Drawing.Point(82, 104);
            this.lueInCompany.Name = "lueInCompany";
            this.lueInCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueInCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueInCompany.Properties.NullText = "";
            this.lueInCompany.Size = new System.Drawing.Size(289, 20);
            this.lueInCompany.StyleController = this.layoutControl1;
            this.lueInCompany.TabIndex = 3;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(391, 186);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lueInCompany;
            this.layoutControlItem4.CustomizationFormText = "开户行：";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(371, 40);
            this.layoutControlItem4.Text = "收入单位：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueOutCompany;
            this.layoutControlItem5.CustomizationFormText = "支出单位：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(371, 40);
            this.layoutControlItem5.Text = "支出单位：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lookUpEdit1;
            this.layoutControlItem2.CustomizationFormText = "审批进度";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(371, 42);
            this.layoutControlItem2.Text = "审批进度";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCode;
            this.layoutControlItem3.CustomizationFormText = "单据字";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(371, 44);
            this.layoutControlItem3.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Text = "单据字";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(60, 14);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(287, 192);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnQuery.Location = new System.Drawing.Point(158, 192);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // DevAccountQuery
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(391, 246);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnQuery);
            this.Name = "DevAccountQuery";
            this.Text = "资金往来查询";
            this.Load += new System.EventHandler(this.DevAccountQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lueInCompany;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.LookUpEdit lueOutCompany;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}