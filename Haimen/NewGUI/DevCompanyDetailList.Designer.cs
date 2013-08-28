namespace Haimen.NewGUI
{
    partial class DevCompanyDetailList
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
            this.lueBanks = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.c_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_credit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tree = new DevExpress.XtraTreeList.TreeList();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel3 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtCode = new C1.Win.C1Input.C1TextBox();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtDoc = new C1.Win.C1Input.C1TextBox();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtName = new C1.Win.C1Input.C1TextBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtAccount = new C1.Win.C1Input.C1TextBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBank = new C1.Win.C1Input.C1TextBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.node_name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.node_id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tsbSave = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.lueBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.c1SplitterPanel2.SuspendLayout();
            this.c1SplitterPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // lueBanks
            // 
            this.lueBanks.AutoHeight = false;
            this.lueBanks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueBanks.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueBanks.LookAndFeel.SkinName = "Seven Classic";
            this.lueBanks.Name = "lueBanks";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_id,
            this.c_bank,
            this.c_account,
            this.c_balance,
            this.c_credit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.BeforeLeaveRow += new DevExpress.XtraGrid.Views.Base.RowAllowEventHandler(this.gridView1_BeforeLeaveRow);
            // 
            // c_id
            // 
            this.c_id.Caption = "ID";
            this.c_id.ColumnEdit = this.lueBanks;
            this.c_id.FieldName = "ID";
            this.c_id.Name = "c_id";
            this.c_id.Width = 20;
            // 
            // c_bank
            // 
            this.c_bank.Caption = "银行";
            this.c_bank.ColumnEdit = this.lueBanks;
            this.c_bank.FieldName = "Bank_ID";
            this.c_bank.Name = "c_bank";
            this.c_bank.Visible = true;
            this.c_bank.VisibleIndex = 0;
            // 
            // c_account
            // 
            this.c_account.Caption = "帐号";
            this.c_account.FieldName = "Account";
            this.c_account.Name = "c_account";
            this.c_account.Visible = true;
            this.c_account.VisibleIndex = 1;
            // 
            // c_balance
            // 
            this.c_balance.Caption = "余额";
            this.c_balance.DisplayFormat.FormatString = "N";
            this.c_balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_balance.FieldName = "Balance";
            this.c_balance.Name = "c_balance";
            this.c_balance.Visible = true;
            this.c_balance.VisibleIndex = 2;
            // 
            // c_credit
            // 
            this.c_credit.Caption = "贷款";
            this.c_credit.DisplayFormat.FormatString = "N";
            this.c_credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_credit.FieldName = "Credit";
            this.c_credit.Name = "c_credit";
            this.c_credit.Visible = true;
            this.c_credit.VisibleIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueBanks});
            this.gridControl1.Size = new System.Drawing.Size(651, 325);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tree
            // 
            this.tree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.node_name,
            this.node_id});
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.OptionsBehavior.Editable = false;
            this.tree.OptionsView.ShowColumns = false;
            this.tree.OptionsView.ShowIndentAsRowStyle = true;
            this.tree.OptionsView.ShowIndicator = false;
            this.tree.Size = new System.Drawing.Size(163, 491);
            this.tree.TabIndex = 26;
            this.tree.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.tree_FocusedNodeChanged);
            this.tree.Click += new System.EventHandler(this.treeList1_Click);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(0, 39);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel3);
            this.c1SplitContainer1.Size = new System.Drawing.Size(818, 512);
            this.c1SplitContainer1.TabIndex = 27;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.tree);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(163, 491);
            this.c1SplitterPanel1.SizeRatio = 20D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "单位列表";
            this.c1SplitterPanel1.Width = 163;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Controls.Add(this.layoutControl1);
            this.c1SplitterPanel2.Height = 165;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(167, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Resizable = false;
            this.c1SplitterPanel2.Size = new System.Drawing.Size(651, 144);
            this.c1SplitterPanel2.SizeRatio = 32.283D;
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Text = "单位详情";
            // 
            // c1SplitterPanel3
            // 
            this.c1SplitterPanel3.Controls.Add(this.gridControl1);
            this.c1SplitterPanel3.Height = 100;
            this.c1SplitterPanel3.Location = new System.Drawing.Point(167, 187);
            this.c1SplitterPanel3.Name = "c1SplitterPanel3";
            this.c1SplitterPanel3.Size = new System.Drawing.Size(651, 325);
            this.c1SplitterPanel3.TabIndex = 2;
            this.c1SplitterPanel3.Text = "明细帐";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtBank);
            this.layoutControl1.Controls.Add(this.txtAccount);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtDoc);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(651, 144);
            this.layoutControl1.TabIndex = 28;
            this.layoutControl1.Text = "layoutControl1";
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
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(651, 144);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(67, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(252, 22);
            this.txtCode.TabIndex = 4;
            this.txtCode.Tag = null;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.CustomizationFormText = "代码：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem1.Size = new System.Drawing.Size(314, 30);
            this.layoutControlItem1.Text = "代码：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(381, 15);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(255, 22);
            this.txtDoc.TabIndex = 5;
            this.txtDoc.Tag = null;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtDoc;
            this.layoutControlItem2.CustomizationFormText = "单据字：";
            this.layoutControlItem2.Location = new System.Drawing.Point(314, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem2.Size = new System.Drawing.Size(317, 30);
            this.layoutControlItem2.Text = "单据字：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(67, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(569, 22);
            this.txtName.TabIndex = 6;
            this.txtName.Tag = null;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtName;
            this.layoutControlItem3.CustomizationFormText = "名称：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 30);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem3.Size = new System.Drawing.Size(631, 30);
            this.layoutControlItem3.Text = "名称：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(67, 105);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(569, 22);
            this.txtAccount.TabIndex = 8;
            this.txtAccount.Tag = null;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtAccount;
            this.layoutControlItem5.CustomizationFormText = "帐号：";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem5.Size = new System.Drawing.Size(631, 34);
            this.layoutControlItem5.Text = "帐号：";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(67, 75);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(569, 22);
            this.txtBank.TabIndex = 9;
            this.txtBank.Tag = null;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtBank;
            this.layoutControlItem6.CustomizationFormText = "开户行：";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 60);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlItem6.Size = new System.Drawing.Size(631, 30);
            this.layoutControlItem6.Text = "开户行：";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 14);
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
            this.tsbRefresh,
            this.tsbExit,
            this.tsbSave});
            this.barManager1.MaxItemId = 6;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(818, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 551);
            this.barDockControlBottom.Size = new System.Drawing.Size(818, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 512);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(818, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 512);
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "增加";
            this.tsbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.Id = 0;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tsbEdit.Id = 1;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbDelete.Id = 2;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.tsbRefresh.Id = 3;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 4;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // node_name
            // 
            this.node_name.Caption = "名称";
            this.node_name.FieldName = "Name";
            this.node_name.Name = "node_name";
            this.node_name.Visible = true;
            this.node_name.VisibleIndex = 0;
            // 
            // node_id
            // 
            this.node_id.Caption = "ID";
            this.node_id.FieldName = "ID";
            this.node_id.Name = "node_id";
            // 
            // tsbSave
            // 
            this.tsbSave.Caption = "保存";
            this.tsbSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.tsbSave.Id = 5;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSave_ItemClick);
            // 
            // DevCompanyDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 551);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevCompanyDetailList";
            this.Text = "DevCompanyDetailList";
            this.Load += new System.EventHandler(this.DevCompanyDetailList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.c1SplitterPanel2.ResumeLayout(false);
            this.c1SplitterPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn c_credit;
        private DevExpress.XtraGrid.Columns.GridColumn c_balance;
        private DevExpress.XtraGrid.Columns.GridColumn c_account;
        private DevExpress.XtraGrid.Columns.GridColumn c_bank;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueBanks;
        private DevExpress.XtraGrid.Columns.GridColumn c_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraTreeList.TreeList tree;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private C1.Win.C1Input.C1TextBox txtBank;
        private C1.Win.C1Input.C1TextBox txtAccount;
        private C1.Win.C1Input.C1TextBox txtName;
        private C1.Win.C1Input.C1TextBox txtDoc;
        private C1.Win.C1Input.C1TextBox txtCode;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraTreeList.Columns.TreeListColumn node_name;
        private DevExpress.XtraTreeList.Columns.TreeListColumn node_id;
        private DevExpress.XtraBars.BarButtonItem tsbSave;
    }
}