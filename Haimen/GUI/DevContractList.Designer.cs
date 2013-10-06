namespace Haimen.GUI
{
    partial class DevContractList
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
            this.col_payment_ration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_end_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_begin_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_signed_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_partya = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_partyb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_securigy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbGen = new DevExpress.XtraBars.BarButtonItem();
            this.tsbPay = new DevExpress.XtraBars.BarButtonItem();
            this.tsbAccept = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbCostMoney = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCheckMoney = new DevExpress.XtraBars.BarButtonItem();
            this.col_cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_checkmoney = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // col_payment_ration
            // 
            this.col_payment_ration.Caption = "支付比例";
            this.col_payment_ration.FieldName = "PaymentRatio";
            this.col_payment_ration.Name = "col_payment_ration";
            this.col_payment_ration.Visible = true;
            this.col_payment_ration.VisibleIndex = 14;
            // 
            // col_money
            // 
            this.col_money.Caption = "合同价";
            this.col_money.DisplayFormat.FormatString = "c";
            this.col_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_money.FieldName = "Money";
            this.col_money.Name = "col_money";
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 9;
            // 
            // col_name
            // 
            this.col_name.Caption = "合同名称";
            this.col_name.FieldName = "Name";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 1;
            // 
            // col_end_date
            // 
            this.col_end_date.Caption = "结束日期";
            this.col_end_date.FieldName = "EndDate";
            this.col_end_date.Name = "col_end_date";
            this.col_end_date.Visible = true;
            this.col_end_date.VisibleIndex = 8;
            // 
            // col_begin_date
            // 
            this.col_begin_date.Caption = "开始日期";
            this.col_begin_date.FieldName = "BeginDate";
            this.col_begin_date.Name = "col_begin_date";
            this.col_begin_date.Visible = true;
            this.col_begin_date.VisibleIndex = 7;
            // 
            // col_signed_date
            // 
            this.col_signed_date.Caption = "签订日期";
            this.col_signed_date.FieldName = "SignedDate";
            this.col_signed_date.Name = "col_signed_date";
            this.col_signed_date.Visible = true;
            this.col_signed_date.VisibleIndex = 6;
            // 
            // col_outcompany
            // 
            this.col_outcompany.Caption = "付款单位";
            this.col_outcompany.FieldName = "OutCompany.Name";
            this.col_outcompany.Name = "col_outcompany";
            this.col_outcompany.Visible = true;
            this.col_outcompany.VisibleIndex = 4;
            // 
            // col_code
            // 
            this.col_code.Caption = "合同编号";
            this.col_code.FieldName = "Code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_status,
            this.col_code,
            this.col_name,
            this.col_partya,
            this.col_partyb,
            this.col_outcompany,
            this.col_incompany,
            this.col_signed_date,
            this.col_begin_date,
            this.col_end_date,
            this.col_money,
            this.col_cost,
            this.col_checkmoney,
            this.col_pay,
            this.col_securigy,
            this.col_payment_ration});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "Name";
            this.col_id.Name = "col_id";
            // 
            // col_partya
            // 
            this.col_partya.Caption = "甲方";
            this.col_partya.FieldName = "PartyA.Name";
            this.col_partya.Name = "col_partya";
            this.col_partya.Visible = true;
            this.col_partya.VisibleIndex = 2;
            // 
            // col_partyb
            // 
            this.col_partyb.Caption = "乙方";
            this.col_partyb.FieldName = "PartyB.Name";
            this.col_partyb.Name = "col_partyb";
            this.col_partyb.Visible = true;
            this.col_partyb.VisibleIndex = 3;
            // 
            // col_incompany
            // 
            this.col_incompany.Caption = "收款单位";
            this.col_incompany.FieldName = "InCompany.Name";
            this.col_incompany.Name = "col_incompany";
            this.col_incompany.Visible = true;
            this.col_incompany.VisibleIndex = 5;
            // 
            // col_pay
            // 
            this.col_pay.Caption = "已付金额";
            this.col_pay.DisplayFormat.FormatString = "c";
            this.col_pay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_pay.FieldName = "Pay";
            this.col_pay.Name = "col_pay";
            this.col_pay.Visible = true;
            this.col_pay.VisibleIndex = 12;
            // 
            // col_securigy
            // 
            this.col_securigy.Caption = "保证金";
            this.col_securigy.DisplayFormat.FormatString = "c";
            this.col_securigy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_securigy.FieldName = "Security";
            this.col_securigy.Name = "col_securigy";
            this.col_securigy.Visible = true;
            this.col_securigy.VisibleIndex = 13;
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
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name")});
            this.lueStatus.Name = "lueStatus";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueStatus});
            this.gridControl1.Size = new System.Drawing.Size(1075, 522);
            this.gridControl1.TabIndex = 27;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.tsbCheck,
            this.tsbQuery,
            this.tsbGen,
            this.tsbExit,
            this.tsbRefresh,
            this.tsbAccept,
            this.tsbPay,
            this.tsbCostMoney,
            this.tsbCheckMoney});
            this.barManager1.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbGen, "", true, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbPay, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbAccept, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCostMoney, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCheckMoney, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // tsbCheck
            // 
            this.tsbCheck.Caption = "审核";
            this.tsbCheck.Glyph = global::Haimen.Properties.Resources.Close;
            this.tsbCheck.Id = 3;
            this.tsbCheck.Name = "tsbCheck";
            this.tsbCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCheck_ItemClick);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = global::Haimen.Properties.Resources.Search_hot;
            this.tsbQuery.Id = 4;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.tsbRefresh.Id = 7;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbGen
            // 
            this.tsbGen.Caption = "生成支付凭证";
            this.tsbGen.Glyph = global::Haimen.Properties.Resources.Notepad;
            this.tsbGen.Id = 5;
            this.tsbGen.Name = "tsbGen";
            this.tsbGen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbGen_ItemClick);
            // 
            // tsbPay
            // 
            this.tsbPay.Caption = "付款申请";
            this.tsbPay.Glyph = global::Haimen.Properties.Resources.Note_New_hot;
            this.tsbPay.Id = 9;
            this.tsbPay.Name = "tsbPay";
            this.tsbPay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbPay_ItemClick);
            // 
            // tsbAccept
            // 
            this.tsbAccept.Caption = "验收";
            this.tsbAccept.Glyph = global::Haimen.Properties.Resources.Slide_Show_hot;
            this.tsbAccept.Id = 8;
            this.tsbAccept.Name = "tsbAccept";
            this.tsbAccept.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbAccept_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1075, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Size = new System.Drawing.Size(1075, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 522);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1075, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 522);
            // 
            // tsbCostMoney
            // 
            this.tsbCostMoney.Caption = "决算价";
            this.tsbCostMoney.Glyph = global::Haimen.Properties.Resources.Parcel_hot;
            this.tsbCostMoney.Id = 10;
            this.tsbCostMoney.Name = "tsbCostMoney";
            this.tsbCostMoney.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCostMoney_ItemClick);
            // 
            // tsbCheckMoney
            // 
            this.tsbCheckMoney.Caption = "审计价";
            this.tsbCheckMoney.Glyph = global::Haimen.Properties.Resources.Page_Number_hot;
            this.tsbCheckMoney.Id = 11;
            this.tsbCheckMoney.Name = "tsbCheckMoney";
            this.tsbCheckMoney.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCheckMoney_ItemClick);
            // 
            // col_cost
            // 
            this.col_cost.Caption = "决算价";
            this.col_cost.DisplayFormat.FormatString = "c";
            this.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_cost.FieldName = "Cost";
            this.col_cost.Name = "col_cost";
            this.col_cost.Visible = true;
            this.col_cost.VisibleIndex = 10;
            // 
            // col_checkmoney
            // 
            this.col_checkmoney.Caption = "审计价";
            this.col_checkmoney.DisplayFormat.FormatString = "c";
            this.col_checkmoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_checkmoney.FieldName = "CheckMoney";
            this.col_checkmoney.Name = "col_checkmoney";
            this.col_checkmoney.Visible = true;
            this.col_checkmoney.VisibleIndex = 11;
            // 
            // DevContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 561);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevContractList";
            this.Text = "合同列表";
            this.Load += new System.EventHandler(this.DevContractList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn col_payment_ration;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_end_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_begin_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_signed_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_securigy;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraBars.BarButtonItem tsbCheck;
        private DevExpress.XtraBars.BarButtonItem tsbQuery;
        private DevExpress.XtraBars.BarButtonItem tsbGen;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueStatus;
        private DevExpress.XtraGrid.Columns.GridColumn col_partya;
        private DevExpress.XtraGrid.Columns.GridColumn col_partyb;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_pay;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
        private DevExpress.XtraBars.BarButtonItem tsbAccept;
        private DevExpress.XtraBars.BarButtonItem tsbPay;
        private DevExpress.XtraBars.BarButtonItem tsbCostMoney;
        private DevExpress.XtraBars.BarButtonItem tsbCheckMoney;
        private DevExpress.XtraGrid.Columns.GridColumn col_cost;
        private DevExpress.XtraGrid.Columns.GridColumn col_checkmoney;
    }
}