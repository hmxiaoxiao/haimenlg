namespace Haimen.GUI
{
    partial class DevUnAuth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevUnAuth));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbSave = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtBank = new DevExpress.XtraEditors.TextEdit();
            this.txtMoney = new DevExpress.XtraEditors.CalcEdit();
            this.chkOutput = new DevExpress.XtraEditors.CheckEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.txtMemo = new DevExpress.XtraEditors.MemoEdit();
            this.lueCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.a_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueAccount = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.b_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b_bankname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b_balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.b_credit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.dtSignedDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAccount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSignedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSignedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
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
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbExit});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbNew.Glyph")));
            this.tsbNew.Id = 0;
            this.tsbNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbNew.LargeGlyph")));
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Glyph")));
            this.tsbEdit.Id = 1;
            this.tsbEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbEdit.LargeGlyph")));
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Glyph")));
            this.tsbDelete.Id = 2;
            this.tsbDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbDelete.LargeGlyph")));
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // tsbSave
            // 
            this.tsbSave.Caption = "保存";
            this.tsbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbSave.Glyph")));
            this.tsbSave.Id = 3;
            this.tsbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbSave.LargeGlyph")));
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSave_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbExit.Glyph")));
            this.tsbExit.Id = 4;
            this.tsbExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbExit.LargeGlyph")));
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(728, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 531);
            this.barDockControlBottom.Size = new System.Drawing.Size(728, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 500);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(728, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 500);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dtSignedDate);
            this.layoutControl1.Controls.Add(this.txtBank);
            this.layoutControl1.Controls.Add(this.txtMoney);
            this.layoutControl1.Controls.Add(this.chkOutput);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.txtMemo);
            this.layoutControl1.Controls.Add(this.lueCompany);
            this.layoutControl1.Controls.Add(this.lueAccount);
            this.layoutControl1.Location = new System.Drawing.Point(0, 31);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(491, 323);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtBank
            // 
            this.txtBank.Enabled = false;
            this.txtBank.Location = new System.Drawing.Point(67, 144);
            this.txtBank.MenuManager = this.barManager1;
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(408, 20);
            this.txtBank.StyleController = this.layoutControl1;
            this.txtBank.TabIndex = 50;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(67, 176);
            this.txtMoney.MenuManager = this.barManager1;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMoney.Properties.DisplayFormat.FormatString = "{0:N}";
            this.txtMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMoney.Properties.EditFormat.FormatString = "{0:N}";
            this.txtMoney.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMoney.Properties.Mask.EditMask = "c";
            this.txtMoney.Size = new System.Drawing.Size(408, 20);
            this.txtMoney.StyleController = this.layoutControl1;
            this.txtMoney.TabIndex = 60;
            this.txtMoney.Click += new System.EventHandler(this.txtMoney_Click);
            this.txtMoney.Enter += new System.EventHandler(this.txtMoney_Enter);
            // 
            // chkOutput
            // 
            this.chkOutput.Location = new System.Drawing.Point(16, 208);
            this.chkOutput.MenuManager = this.barManager1;
            this.chkOutput.Name = "chkOutput";
            this.chkOutput.Properties.Caption = "支出";
            this.chkOutput.Size = new System.Drawing.Size(459, 19);
            this.chkOutput.StyleController = this.layoutControl1;
            this.chkOutput.TabIndex = 7;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(67, 48);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(408, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 20;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(67, 239);
            this.txtMemo.MenuManager = this.barManager1;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(408, 68);
            this.txtMemo.StyleController = this.layoutControl1;
            this.txtMemo.TabIndex = 70;
            // 
            // lueCompany
            // 
            this.lueCompany.EditValue = "请选择单位";
            this.lueCompany.Location = new System.Drawing.Point(67, 80);
            this.lueCompany.MenuManager = this.barManager1;
            this.lueCompany.Name = "lueCompany";
            this.lueCompany.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompany.Properties.DisplayMember = "Name";
            this.lueCompany.Properties.NullText = "请选择单位";
            this.lueCompany.Properties.ValueMember = "ID";
            this.lueCompany.Properties.View = this.searchLookUpEdit1View;
            this.lueCompany.Size = new System.Drawing.Size(408, 20);
            this.lueCompany.StyleController = this.layoutControl1;
            this.lueCompany.TabIndex = 30;
            this.lueCompany.EditValueChanged += new System.EventHandler(this.lueCompany_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.a_code,
            this.a_name,
            this.a_id});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ColumnAutoWidth = false;
            this.searchLookUpEdit1View.OptionsView.EnableAppearanceEvenRow = true;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // a_code
            // 
            this.a_code.Caption = "代码";
            this.a_code.FieldName = "Code";
            this.a_code.Name = "a_code";
            this.a_code.Visible = true;
            this.a_code.VisibleIndex = 0;
            // 
            // a_name
            // 
            this.a_name.Caption = "名称";
            this.a_name.FieldName = "Name";
            this.a_name.Name = "a_name";
            this.a_name.Visible = true;
            this.a_name.VisibleIndex = 1;
            // 
            // a_id
            // 
            this.a_id.Caption = "ID";
            this.a_id.FieldName = "ID";
            this.a_id.Name = "a_id";
            // 
            // lueAccount
            // 
            this.lueAccount.Location = new System.Drawing.Point(67, 112);
            this.lueAccount.MenuManager = this.barManager1;
            this.lueAccount.Name = "lueAccount";
            this.lueAccount.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lueAccount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueAccount.Properties.DisplayMember = "Account";
            this.lueAccount.Properties.NullText = "请选择帐号";
            this.lueAccount.Properties.ValueMember = "ID";
            this.lueAccount.Properties.View = this.gridView1;
            this.lueAccount.Size = new System.Drawing.Size(408, 20);
            this.lueAccount.StyleController = this.layoutControl1;
            this.lueAccount.TabIndex = 40;
            this.lueAccount.EditValueChanged += new System.EventHandler(this.lueAccount_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.b_id,
            this.b_bankname,
            this.b_account,
            this.b_type,
            this.b_balance,
            this.b_credit});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // b_id
            // 
            this.b_id.Caption = "ID";
            this.b_id.FieldName = "ID";
            this.b_id.Name = "b_id";
            // 
            // b_bankname
            // 
            this.b_bankname.Caption = "银行";
            this.b_bankname.FieldName = "BankName";
            this.b_bankname.Name = "b_bankname";
            this.b_bankname.Visible = true;
            this.b_bankname.VisibleIndex = 0;
            // 
            // b_account
            // 
            this.b_account.Caption = "帐号";
            this.b_account.FieldName = "Account";
            this.b_account.Name = "b_account";
            this.b_account.Visible = true;
            this.b_account.VisibleIndex = 1;
            // 
            // b_type
            // 
            this.b_type.Caption = "类别";
            this.b_type.FieldName = "AccountType";
            this.b_type.Name = "b_type";
            this.b_type.Visible = true;
            this.b_type.VisibleIndex = 2;
            // 
            // b_balance
            // 
            this.b_balance.Caption = "余额";
            this.b_balance.FieldName = "Balance";
            this.b_balance.Name = "b_balance";
            this.b_balance.Visible = true;
            this.b_balance.VisibleIndex = 3;
            // 
            // b_credit
            // 
            this.b_credit.Caption = "贷款";
            this.b_credit.FieldName = "Credit";
            this.b_credit.Name = "b_credit";
            this.b_credit.Visible = true;
            this.b_credit.VisibleIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(491, 323);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "凭证号：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem1.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem1.Text = "凭证号：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueCompany;
            this.layoutControlItem2.CustomizationFormText = "本单位：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 64);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem2.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem2.Text = "本单位：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lueAccount;
            this.layoutControlItem3.CustomizationFormText = "帐号：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem3.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem3.Text = "帐号：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chkOutput;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem4.Size = new System.Drawing.Size(471, 31);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtMemo;
            this.layoutControlItem5.CustomizationFormText = "备注：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 223);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(50, 25);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem5.Size = new System.Drawing.Size(471, 80);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.Text = "备注：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtMoney;
            this.layoutControlItem6.CustomizationFormText = "金额:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem6.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem6.Text = "金额:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtBank;
            this.layoutControlItem7.CustomizationFormText = "银行：";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 128);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem7.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem7.Text = "银行：";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 14);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // dtSignedDate
            // 
            this.dtSignedDate.EditValue = null;
            this.dtSignedDate.Location = new System.Drawing.Point(67, 16);
            this.dtSignedDate.MenuManager = this.barManager1;
            this.dtSignedDate.Name = "dtSignedDate";
            this.dtSignedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSignedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtSignedDate.Properties.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.dtSignedDate.Properties.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.dtSignedDate.Size = new System.Drawing.Size(408, 20);
            this.dtSignedDate.StyleController = this.layoutControl1;
            this.dtSignedDate.TabIndex = 10;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.dtSignedDate;
            this.layoutControlItem8.CustomizationFormText = "日期：";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlItem8.Size = new System.Drawing.Size(471, 32);
            this.layoutControlItem8.Text = "日期：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 14);
            // 
            // DevUnAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 531);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevUnAuth";
            this.Text = "非授权收支";
            this.Load += new System.EventHandler(this.DevUnAuth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtBank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueAccount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSignedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtSignedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraBars.BarButtonItem tsbSave;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.CheckEdit chkOutput;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.MemoEdit txtMemo;
        private DevExpress.XtraEditors.SearchLookUpEdit lueCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit lueAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn a_code;
        private DevExpress.XtraGrid.Columns.GridColumn a_name;
        private DevExpress.XtraGrid.Columns.GridColumn a_id;
        private DevExpress.XtraGrid.Columns.GridColumn b_id;
        private DevExpress.XtraGrid.Columns.GridColumn b_bankname;
        private DevExpress.XtraGrid.Columns.GridColumn b_account;
        private DevExpress.XtraGrid.Columns.GridColumn b_type;
        private DevExpress.XtraGrid.Columns.GridColumn b_balance;
        private DevExpress.XtraGrid.Columns.GridColumn b_credit;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.CalcEdit txtMoney;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit txtBank;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit dtSignedDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}