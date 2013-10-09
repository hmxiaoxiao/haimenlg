namespace Haimen.GUI
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
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.lueCheck = new DevExpress.XtraEditors.LookUpEdit();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.lueCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.lueCheck);
            this.layoutControl1.Controls.Add(this.btnQuery);
            this.layoutControl1.Controls.Add(this.btnExit);
            this.layoutControl1.Controls.Add(this.lueCompany);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(388, 188);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(84, 22);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(282, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 1;
            // 
            // lueCheck
            // 
            this.lueCheck.EnterMoveNextControl = true;
            this.lueCheck.Location = new System.Drawing.Point(82, 104);
            this.lueCheck.Name = "lueCheck";
            this.lueCheck.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueCheck.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCheck.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "进度")});
            this.lueCheck.Properties.NullText = "";
            this.lueCheck.Size = new System.Drawing.Size(286, 20);
            this.lueCheck.StyleController = this.layoutControl1;
            this.lueCheck.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnQuery.Location = new System.Drawing.Point(147, 144);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 22);
            this.btnQuery.StyleController = this.layoutControl1;
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(267, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 22);
            this.btnExit.StyleController = this.layoutControl1;
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lueCompany
            // 
            this.lueCompany.EnterMoveNextControl = true;
            this.lueCompany.Location = new System.Drawing.Point(82, 64);
            this.lueCompany.Name = "lueCompany";
            this.lueCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "编码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueCompany.Properties.NullText = "";
            this.lueCompany.Size = new System.Drawing.Size(286, 20);
            this.lueCompany.StyleController = this.layoutControl1;
            this.lueCompany.TabIndex = 2;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(388, 188);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lueCompany;
            this.layoutControlItem5.CustomizationFormText = "单位：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 44);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(368, 40);
            this.layoutControlItem5.Text = "支出单位：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(60, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 124);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(127, 44);
            this.emptySpaceItem1.Text = "emptySpaceItem1";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExit;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(247, 124);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(121, 44);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnQuery;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(127, 124);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(120, 44);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lueCheck;
            this.layoutControlItem6.CustomizationFormText = "审核进度：";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(368, 40);
            this.layoutControlItem6.Text = "审核进度：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtCode;
            this.layoutControlItem2.CustomizationFormText = "单据字：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(368, 44);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Text = "单据字：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 14);
            // 
            // DevContractQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 198);
            this.Controls.Add(this.layoutControl1);
            this.Name = "DevContractQuery";
            this.Text = "合同查询";
            this.Load += new System.EventHandler(this.DevContractQuery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LookUpEdit lueCompany;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lueCheck;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}