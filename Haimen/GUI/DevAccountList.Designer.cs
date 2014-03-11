namespace Haimen.GUI
{
    partial class DevAccountList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevAccountList));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.d_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_parent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_fundsname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_usage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_signed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_project = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_invoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueInvoiceList = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            this.tsbView = new DevExpress.XtraBars.BarButtonItem();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.tsbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tsbUnCheck = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.tsbPay = new DevExpress.XtraBars.BarButtonItem();
            this.tsbUnPay = new DevExpress.XtraBars.BarButtonItem();
            this.tsb2Invoice = new DevExpress.XtraBars.BarButtonItem();
            this.tsbPrint = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbNewInput = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.d_id,
            this.d_parent_id,
            this.d_fundsname,
            this.d_money,
            this.d_usage});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsCustomization.AllowSort = false;
            this.gridView2.OptionsView.ColumnAutoWidth = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // d_id
            // 
            this.d_id.Caption = "ID";
            this.d_id.FieldName = "id";
            this.d_id.Name = "d_id";
            // 
            // d_parent_id
            // 
            this.d_parent_id.Caption = "父结点";
            this.d_parent_id.FieldName = "parent_id";
            this.d_parent_id.Name = "d_parent_id";
            // 
            // d_fundsname
            // 
            this.d_fundsname.Caption = "性质";
            this.d_fundsname.FieldName = "name";
            this.d_fundsname.MinWidth = 200;
            this.d_fundsname.Name = "d_fundsname";
            this.d_fundsname.Visible = true;
            this.d_fundsname.VisibleIndex = 0;
            this.d_fundsname.Width = 200;
            // 
            // d_money
            // 
            this.d_money.Caption = "金额";
            this.d_money.DisplayFormat.FormatString = "c";
            this.d_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.d_money.FieldName = "money";
            this.d_money.MinWidth = 200;
            this.d_money.Name = "d_money";
            this.d_money.Visible = true;
            this.d_money.VisibleIndex = 1;
            this.d_money.Width = 200;
            // 
            // d_usage
            // 
            this.d_usage.Caption = "用途";
            this.d_usage.FieldName = "usage";
            this.d_usage.MinWidth = 200;
            this.d_usage.Name = "d_usage";
            this.d_usage.Visible = true;
            this.d_usage.VisibleIndex = 2;
            this.d_usage.Width = 200;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "明细";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueStatus,
            this.lueInvoiceList});
            this.gridControl1.Size = new System.Drawing.Size(733, 439);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_status,
            this.col_signed,
            this.col_money,
            this.col_project,
            this.col_invoice,
            this.col_code,
            this.col_outcompany,
            this.col_outcompany_bank,
            this.col_outcompany_account,
            this.col_incompany,
            this.col_incompany_bank,
            this.col_incompany_account,
            this.col_memo});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.ColumnEdit = this.lueStatus;
            this.col_status.FieldName = "status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 0;
            // 
            // lueStatus
            // 
            this.lueStatus.AutoHeight = false;
            this.lueStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueStatus.Name = "lueStatus";
            // 
            // col_signed
            // 
            this.col_signed.Caption = "日期";
            this.col_signed.FieldName = "signeddate";
            this.col_signed.Name = "col_signed";
            this.col_signed.Visible = true;
            this.col_signed.VisibleIndex = 1;
            // 
            // col_money
            // 
            this.col_money.Caption = "总金额";
            this.col_money.DisplayFormat.FormatString = "C";
            this.col_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_money.FieldName = "money";
            this.col_money.Name = "col_money";
            this.col_money.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "money", "小计：{0:C2}")});
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 2;
            // 
            // col_project
            // 
            this.col_project.Caption = "所属项目";
            this.col_project.FieldName = "project_id";
            this.col_project.Name = "col_project";
            this.col_project.Visible = true;
            this.col_project.VisibleIndex = 3;
            // 
            // col_invoice
            // 
            this.col_invoice.Caption = "发票";
            this.col_invoice.ColumnEdit = this.lueInvoiceList;
            this.col_invoice.FieldName = "invoice";
            this.col_invoice.Name = "col_invoice";
            this.col_invoice.Visible = true;
            this.col_invoice.VisibleIndex = 4;
            // 
            // lueInvoiceList
            // 
            this.lueInvoiceList.AutoHeight = false;
            this.lueInvoiceList.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInvoiceList.Name = "lueInvoiceList";
            // 
            // col_code
            // 
            this.col_code.Caption = "凭证号";
            this.col_code.FieldName = "code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 5;
            // 
            // col_outcompany
            // 
            this.col_outcompany.Caption = "本单位";
            this.col_outcompany.FieldName = "outcompanyname";
            this.col_outcompany.Name = "col_outcompany";
            this.col_outcompany.Visible = true;
            this.col_outcompany.VisibleIndex = 6;
            // 
            // col_outcompany_bank
            // 
            this.col_outcompany_bank.Caption = "本单位银行";
            this.col_outcompany_bank.FieldName = "outbankname";
            this.col_outcompany_bank.Name = "col_outcompany_bank";
            this.col_outcompany_bank.Visible = true;
            this.col_outcompany_bank.VisibleIndex = 7;
            // 
            // col_outcompany_account
            // 
            this.col_outcompany_account.Caption = "本单位帐号";
            this.col_outcompany_account.FieldName = "outaccount";
            this.col_outcompany_account.Name = "col_outcompany_account";
            this.col_outcompany_account.Visible = true;
            this.col_outcompany_account.VisibleIndex = 8;
            // 
            // col_incompany
            // 
            this.col_incompany.Caption = "外单位";
            this.col_incompany.FieldName = "incompanyname";
            this.col_incompany.Name = "col_incompany";
            this.col_incompany.Visible = true;
            this.col_incompany.VisibleIndex = 9;
            // 
            // col_incompany_bank
            // 
            this.col_incompany_bank.Caption = "外单位银行";
            this.col_incompany_bank.FieldName = "inbankname";
            this.col_incompany_bank.Name = "col_incompany_bank";
            this.col_incompany_bank.Visible = true;
            this.col_incompany_bank.VisibleIndex = 10;
            // 
            // col_incompany_account
            // 
            this.col_incompany_account.Caption = "外单位帐号";
            this.col_incompany_account.FieldName = "inaccount";
            this.col_incompany_account.Name = "col_incompany_account";
            this.col_incompany_account.Visible = true;
            this.col_incompany_account.VisibleIndex = 11;
            // 
            // col_memo
            // 
            this.col_memo.Caption = "备注";
            this.col_memo.FieldName = "memo";
            this.col_memo.Name = "col_memo";
            this.col_memo.Visible = true;
            this.col_memo.VisibleIndex = 12;
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
            this.tsbNewInput,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbCheck,
            this.tsbQuery,
            this.tsbExit,
            this.tsbRefresh,
            this.tsbPay,
            this.tsb2Invoice,
            this.tsbPrint,
            this.tsbView,
            this.tsbUnCheck,
            this.tsbUnPay,
            this.barSubItem1,
            this.barSubItem2,
            this.barSubItem3,
            this.barButtonItem1,
            this.barSubItem4,
            this.barButtonItem3,
            this.barButtonItem2});
            this.barManager1.MaxItemId = 27;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem2, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsb2Invoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbPrint, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem4, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", false, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barSubItem3
            // 
            this.barSubItem3.Caption = "编辑";
            this.barSubItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem3.Glyph")));
            this.barSubItem3.Id = 19;
            this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbView, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem3.Name = "barSubItem3";
            // 
            // tsbView
            // 
            this.tsbView.Caption = "查看";
            this.tsbView.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbView.Glyph")));
            this.tsbView.Id = 12;
            this.tsbView.Name = "tsbView";
            this.tsbView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbView_ItemClick_1);
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbNew.Glyph")));
            this.tsbNew.Id = 0;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Glyph")));
            this.tsbEdit.Id = 2;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Glyph")));
            this.tsbDelete.Id = 3;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "复核";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 17;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCheck, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbUnCheck, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // tsbCheck
            // 
            this.tsbCheck.Caption = "复核";
            this.tsbCheck.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbCheck.Glyph")));
            this.tsbCheck.Id = 4;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCheck_ItemClick);
            // 
            // tsbUnCheck
            // 
            this.tsbUnCheck.Caption = "撤消";
            this.tsbUnCheck.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbUnCheck.Glyph")));
            this.tsbUnCheck.Id = 13;
            this.tsbUnCheck.Name = "tsbUnCheck";
            this.tsbUnCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbUnCheck_ItemClick);
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "审核";
            this.barSubItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem2.Glyph")));
            this.barSubItem2.Id = 18;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbPay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbUnPay, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // tsbPay
            // 
            this.tsbPay.Caption = "审核";
            this.tsbPay.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbPay.Glyph")));
            this.tsbPay.Id = 9;
            this.tsbPay.Name = "tsbPay";
            this.tsbPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // tsbUnPay
            // 
            this.tsbUnPay.Caption = "撤审";
            this.tsbUnPay.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbUnPay.Glyph")));
            this.tsbUnPay.Id = 14;
            this.tsbUnPay.Name = "tsbUnPay";
            this.tsbUnPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbUnPay_ItemClick);
            // 
            // tsb2Invoice
            // 
            this.tsb2Invoice.Caption = " 转正式发票";
            this.tsb2Invoice.Glyph = ((System.Drawing.Image)(resources.GetObject("tsb2Invoice.Glyph")));
            this.tsb2Invoice.Id = 10;
            this.tsb2Invoice.Name = "tsb2Invoice";
            this.tsb2Invoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsb2Invoice_ItemClick);
            // 
            // tsbPrint
            // 
            this.tsbPrint.Caption = "打印";
            this.tsbPrint.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Glyph")));
            this.tsbPrint.Id = 11;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbPrint_ItemClick);
            // 
            // barSubItem4
            // 
            this.barSubItem4.Caption = "刷新";
            this.barSubItem4.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem4.Glyph")));
            this.barSubItem4.Id = 23;
            this.barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem4.Name = "barSubItem4";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "最近100条记录";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 26;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "最近500条记录";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 25;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "全部";
            this.tsbRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Glyph")));
            this.tsbRefresh.Id = 8;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Glyph")));
            this.tsbQuery.Id = 5;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbExit.Glyph")));
            this.tsbExit.Id = 6;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(733, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 486);
            this.barDockControlBottom.Size = new System.Drawing.Size(733, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 439);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(733, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 439);
            // 
            // tsbNewInput
            // 
            this.tsbNewInput.Id = 7;
            this.tsbNewInput.Name = "tsbNewInput";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "本日";
            this.barButtonItem1.Id = 21;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // DevAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 486);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevAccountList";
            this.Text = "授权资金往来列表";
            this.Activated += new System.EventHandler(this.DevAccountList_Activated);
            this.Load += new System.EventHandler(this.DevAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_memo;
        private DevExpress.XtraGrid.Columns.GridColumn col_signed;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbNewInput;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraBars.BarButtonItem tsbCheck;
        private DevExpress.XtraBars.BarButtonItem tsbQuery;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueStatus;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraBars.BarButtonItem tsbPay;
        private DevExpress.XtraGrid.Columns.GridColumn col_project;
        private DevExpress.XtraGrid.Columns.GridColumn col_invoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueInvoiceList;
        private DevExpress.XtraBars.BarButtonItem tsb2Invoice;
        private DevExpress.XtraBars.BarButtonItem tsbPrint;
        private DevExpress.XtraBars.BarButtonItem tsbView;
        private DevExpress.XtraBars.BarButtonItem tsbUnCheck;
        private DevExpress.XtraBars.BarButtonItem tsbUnPay;
        private DevExpress.XtraGrid.Columns.GridColumn d_id;
        private DevExpress.XtraGrid.Columns.GridColumn d_parent_id;
        private DevExpress.XtraGrid.Columns.GridColumn d_fundsname;
        private DevExpress.XtraGrid.Columns.GridColumn d_money;
        private DevExpress.XtraGrid.Columns.GridColumn d_usage;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}