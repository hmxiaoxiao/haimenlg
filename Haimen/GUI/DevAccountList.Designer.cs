namespace Haimen.NewGUI
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
            this.col_detail_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_funds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usage = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tsbPay = new DevExpress.XtraBars.BarButtonItem();
            this.tsb2Invoice = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbNewInput = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // col_detail_money
            // 
            this.col_detail_money.Caption = "金额";
            this.col_detail_money.DisplayFormat.FormatString = "C";
            this.col_detail_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_detail_money.FieldName = "Money";
            this.col_detail_money.Name = "col_detail_money";
            this.col_detail_money.Visible = true;
            this.col_detail_money.VisibleIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView3;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(217, 519);
            this.gridControl2.TabIndex = 25;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_funds,
            this.col_detail_money,
            this.col_usage});
            this.gridView3.GridControl = this.gridControl2;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // col_funds
            // 
            this.col_funds.Caption = "资金性质";
            this.col_funds.FieldName = "Funds.Name";
            this.col_funds.Name = "col_funds";
            this.col_funds.Visible = true;
            this.col_funds.VisibleIndex = 0;
            // 
            // col_usage
            // 
            this.col_usage.Caption = "用途";
            this.col_usage.FieldName = "Usage";
            this.col_usage.Name = "col_usage";
            this.col_usage.Visible = true;
            this.col_usage.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueStatus,
            this.lueInvoiceList});
            this.gridControl1.Size = new System.Drawing.Size(522, 519);
            this.gridControl1.TabIndex = 23;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.ColumnEdit = this.lueStatus;
            this.col_status.FieldName = "Status";
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
            this.col_signed.FieldName = "SignedDate";
            this.col_signed.Name = "col_signed";
            this.col_signed.Visible = true;
            this.col_signed.VisibleIndex = 1;
            // 
            // col_money
            // 
            this.col_money.Caption = "总金额";
            this.col_money.DisplayFormat.FormatString = "C";
            this.col_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_money.FieldName = "Money";
            this.col_money.Name = "col_money";
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 2;
            // 
            // col_project
            // 
            this.col_project.Caption = "所属项目";
            this.col_project.FieldName = "Project.Name";
            this.col_project.Name = "col_project";
            this.col_project.Visible = true;
            this.col_project.VisibleIndex = 3;
            // 
            // col_invoice
            // 
            this.col_invoice.Caption = "发票";
            this.col_invoice.ColumnEdit = this.lueInvoiceList;
            this.col_invoice.FieldName = "Invoice";
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
            this.col_code.Caption = "单据字";
            this.col_code.FieldName = "Code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 5;
            // 
            // col_outcompany
            // 
            this.col_outcompany.Caption = "付款单位";
            this.col_outcompany.FieldName = "OutCompanyDetail.Parent.Name";
            this.col_outcompany.Name = "col_outcompany";
            this.col_outcompany.Visible = true;
            this.col_outcompany.VisibleIndex = 6;
            // 
            // col_outcompany_bank
            // 
            this.col_outcompany_bank.Caption = "付款银行";
            this.col_outcompany_bank.FieldName = "OutCompanyDetail.Bank.Name";
            this.col_outcompany_bank.Name = "col_outcompany_bank";
            this.col_outcompany_bank.Visible = true;
            this.col_outcompany_bank.VisibleIndex = 7;
            // 
            // col_outcompany_account
            // 
            this.col_outcompany_account.Caption = "付款帐号";
            this.col_outcompany_account.FieldName = "OutCompanyDetail.Account";
            this.col_outcompany_account.Name = "col_outcompany_account";
            this.col_outcompany_account.Visible = true;
            this.col_outcompany_account.VisibleIndex = 8;
            // 
            // col_incompany
            // 
            this.col_incompany.Caption = "收款单位";
            this.col_incompany.FieldName = "InCompanyDetail.Parent.Name";
            this.col_incompany.Name = "col_incompany";
            this.col_incompany.Visible = true;
            this.col_incompany.VisibleIndex = 9;
            // 
            // col_incompany_bank
            // 
            this.col_incompany_bank.Caption = "收款银行";
            this.col_incompany_bank.FieldName = "InCompanyDetail.Bank.Name";
            this.col_incompany_bank.Name = "col_incompany_bank";
            this.col_incompany_bank.Visible = true;
            this.col_incompany_bank.VisibleIndex = 10;
            // 
            // col_incompany_account
            // 
            this.col_incompany_account.Caption = "收款帐号";
            this.col_incompany_account.FieldName = "InCompanyDetail.Account";
            this.col_incompany_account.Name = "col_incompany_account";
            this.col_incompany_account.Visible = true;
            this.col_incompany_account.VisibleIndex = 11;
            // 
            // col_memo
            // 
            this.col_memo.Caption = "备注";
            this.col_memo.FieldName = "Memo";
            this.col_memo.Name = "col_memo";
            this.col_memo.Visible = true;
            this.col_memo.VisibleIndex = 12;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "资金性质";
            this.gridColumn11.FieldName = "Funds.Name";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "金额";
            this.gridColumn12.FieldName = "Money";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
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
            this.tsb2Invoice});
            this.barManager1.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCheck, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbPay, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsb2Invoice, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.Id = 0;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tsbEdit.Id = 2;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbDelete.Id = 3;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // tsbCheck
            // 
            this.tsbCheck.Caption = "审核";
            this.tsbCheck.Glyph = global::Haimen.Properties.Resources.Close_hot;
            this.tsbCheck.Id = 4;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCheck_ItemClick);
            // 
            // tsbPay
            // 
            this.tsbPay.Caption = "支付";
            this.tsbPay.Glyph = global::Haimen.Properties.Resources.Insert_hot;
            this.tsbPay.Id = 9;
            this.tsbPay.Name = "tsbPay";
            this.tsbPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // tsb2Invoice
            // 
            this.tsb2Invoice.Caption = " 转正式发票";
            this.tsb2Invoice.Glyph = global::Haimen.Properties.Resources.Card_File_hot;
            this.tsb2Invoice.Id = 10;
            this.tsb2Invoice.Name = "tsb2Invoice";
            this.tsb2Invoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsb2Invoice_ItemClick);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = global::Haimen.Properties.Resources.Search_hot;
            this.tsbQuery.Id = 5;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.tsbRefresh.Id = 8;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 6;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(744, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 558);
            this.barDockControlBottom.Size = new System.Drawing.Size(744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 519);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(744, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 519);
            // 
            // tsbNewInput
            // 
            this.tsbNewInput.Id = 7;
            this.tsbNewInput.Name = "tsbNewInput";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 39);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(744, 519);
            this.splitContainerControl1.SplitterPosition = 217;
            this.splitContainerControl1.TabIndex = 38;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // DevAccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 558);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevAccountList";
            this.Text = "资金往来列表";
            this.Load += new System.EventHandler(this.DevAccountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoiceList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn col_detail_money;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn col_funds;
        private DevExpress.XtraGrid.Columns.GridColumn col_usage;
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
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
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
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraBars.BarButtonItem tsbPay;
        private DevExpress.XtraGrid.Columns.GridColumn col_project;
        private DevExpress.XtraGrid.Columns.GridColumn col_invoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueInvoiceList;
        private DevExpress.XtraBars.BarButtonItem tsb2Invoice;
    }
}