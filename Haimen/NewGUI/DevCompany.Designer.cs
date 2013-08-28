namespace Haimen.NewGUI
{
    partial class DevCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevCompany));
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.cbOutput = new C1.Win.C1Input.C1CheckBox();
            this.cbInput = new C1.Win.C1Input.C1CheckBox();
            this.cboBankList = new C1.Win.C1List.C1Combo();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbSave = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.cboBankList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(70, 180);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(360, 20);
            this.txtDoc.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(70, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 20);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(70, 140);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(360, 20);
            this.txtAccount.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(70, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(360, 20);
            this.txtCode.TabIndex = 0;
            this.txtCode.TabStop = false;
            // 
            // cbOutput
            // 
            this.cbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbOutput.Location = new System.Drawing.Point(20, 260);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(417, 20);
            this.cbOutput.TabIndex = 6;
            this.cbOutput.Text = "支出单位";
            this.cbOutput.Value = null;
            // 
            // cbInput
            // 
            this.cbInput.BorderColor = System.Drawing.Color.Transparent;
            this.cbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbInput.Location = new System.Drawing.Point(20, 220);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(417, 20);
            this.cbInput.TabIndex = 5;
            this.cbInput.Text = "收入单位";
            this.cbInput.Value = null;
            // 
            // cboBankList
            // 
            this.cboBankList.AddItemSeparator = ';';
            this.cboBankList.AlternatingRows = true;
            this.cboBankList.AutoSize = false;
            this.cboBankList.Caption = "";
            this.cboBankList.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboBankList.ContentHeight = 14;
            this.cboBankList.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cboBankList.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cboBankList.EditorFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBankList.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBankList.Images.Add(((System.Drawing.Image)(resources.GetObject("cboBankList.Images"))));
            this.cboBankList.Location = new System.Drawing.Point(70, 100);
            this.cboBankList.MatchEntryTimeout = ((long)(2000));
            this.cboBankList.MaxDropDownItems = ((short)(5));
            this.cboBankList.MaxLength = 32767;
            this.cboBankList.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cboBankList.Name = "cboBankList";
            this.cboBankList.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cboBankList.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cboBankList.Size = new System.Drawing.Size(360, 20);
            this.cboBankList.TabIndex = 2;
            this.cboBankList.PropBag = resources.GetString("cboBankList.PropBag");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.tsbSave,
            this.tsbExit,
            this.tsbNew,
            this.tsbEdit});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.Id = 3;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tsbEdit.Id = 4;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbSave
            // 
            this.tsbSave.Caption = "保存";
            this.tsbSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.tsbSave.Id = 1;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSave_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 2;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(457, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Size = new System.Drawing.Size(457, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 367);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(457, 37);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 367);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cbOutput);
            this.layoutControl1.Controls.Add(this.cbInput);
            this.layoutControl1.Controls.Add(this.cboBankList);
            this.layoutControl1.Controls.Add(this.txtAccount);
            this.layoutControl1.Controls.Add(this.txtDoc);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(457, 367);
            this.layoutControl1.TabIndex = 14;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(457, 367);
            this.layoutControlGroup1.Text = "Root";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "编号：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "编号：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtName;
            this.layoutControlItem3.CustomizationFormText = "名称：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "名称：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAccount;
            this.layoutControlItem5.CustomizationFormText = "帐号：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem5.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "帐号：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbInput;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 200);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem6.Text = "layoutControlItem6";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextToControlDistance = 0;
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbOutput;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem7.Size = new System.Drawing.Size(437, 107);
            this.layoutControlItem7.Text = "layoutControlItem7";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextToControlDistance = 0;
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboBankList;
            this.layoutControlItem4.CustomizationFormText = "开户行：";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem4.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "开户行：";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDoc;
            this.layoutControlItem2.CustomizationFormText = "单据字：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(430, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "单据字：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // DevCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 404);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevCompany";
            this.Text = "单位管理";
            this.Load += new System.EventHandler(this.DevCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboBankList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtCode;
        private C1.Win.C1Input.C1CheckBox cbOutput;
        private C1.Win.C1Input.C1CheckBox cbInput;
        private C1.Win.C1List.C1Combo cboBankList;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbSave;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}