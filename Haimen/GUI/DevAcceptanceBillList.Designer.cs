namespace Haimen.GUI
{
    partial class DevAcceptanceBillList
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tsbFinish = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_drawdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_outcompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_incompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_enddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_tradecode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_movecompany = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tsbQuery,
            this.tsbExit,
            this.tsbFinish,
            this.barButtonItem1});
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", true, true, false, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // tsbQuery
            // 
            this.tsbQuery.Caption = "查询";
            this.tsbQuery.Glyph = global::Haimen.Properties.Resources.Search_hot;
            this.tsbQuery.Id = 3;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbQuery_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "刷新";
            this.barButtonItem1.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 4;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(628, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 460);
            this.barDockControlBottom.Size = new System.Drawing.Size(628, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(628, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // tsbFinish
            // 
            this.tsbFinish.Caption = "完结";
            this.tsbFinish.Glyph = global::Haimen.Properties.Resources.Fill_Up_hot;
            this.tsbFinish.Id = 5;
            this.tsbFinish.Name = "tsbFinish";
            this.tsbFinish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbFinish_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(628, 421);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_drawdate,
            this.col_code,
            this.col_outcompany,
            this.col_outcompany_bank,
            this.col_outcompany_account,
            this.col_incompany,
            this.col_incompany_bank,
            this.col_incompany_account,
            this.col_money,
            this.col_enddate,
            this.col_tradecode,
            this.col_status,
            this.col_movecompany});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_drawdate
            // 
            this.col_drawdate.Caption = "出票日期";
            this.col_drawdate.FieldName = "DrawDate";
            this.col_drawdate.Name = "col_drawdate";
            this.col_drawdate.Visible = true;
            this.col_drawdate.VisibleIndex = 0;
            // 
            // col_code
            // 
            this.col_code.Caption = "单据号";
            this.col_code.FieldName = "Code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 1;
            // 
            // col_outcompany
            // 
            this.col_outcompany.Caption = "付款单位";
            this.col_outcompany.FieldName = "OutCompanyDetail.Parent.Name";
            this.col_outcompany.Name = "col_outcompany";
            this.col_outcompany.Visible = true;
            this.col_outcompany.VisibleIndex = 2;
            // 
            // col_outcompany_bank
            // 
            this.col_outcompany_bank.Caption = "付款银行";
            this.col_outcompany_bank.FieldName = "OutCompanyDetail.Bank.Name";
            this.col_outcompany_bank.Name = "col_outcompany_bank";
            this.col_outcompany_bank.Visible = true;
            this.col_outcompany_bank.VisibleIndex = 3;
            // 
            // col_outcompany_account
            // 
            this.col_outcompany_account.Caption = "付款帐号";
            this.col_outcompany_account.FieldName = "OutCompanyDetail.Account";
            this.col_outcompany_account.Name = "col_outcompany_account";
            this.col_outcompany_account.Visible = true;
            this.col_outcompany_account.VisibleIndex = 4;
            // 
            // col_incompany
            // 
            this.col_incompany.Caption = "收款单位";
            this.col_incompany.FieldName = "InCompanyDetail.Parent.Name";
            this.col_incompany.Name = "col_incompany";
            this.col_incompany.Visible = true;
            this.col_incompany.VisibleIndex = 5;
            // 
            // col_incompany_bank
            // 
            this.col_incompany_bank.Caption = "收款银行";
            this.col_incompany_bank.FieldName = "InCompanyDetail.Bank.Name";
            this.col_incompany_bank.Name = "col_incompany_bank";
            this.col_incompany_bank.Visible = true;
            this.col_incompany_bank.VisibleIndex = 6;
            // 
            // col_incompany_account
            // 
            this.col_incompany_account.Caption = "收款帐号";
            this.col_incompany_account.FieldName = "InCompanyDetail.Account";
            this.col_incompany_account.Name = "col_incompany_account";
            this.col_incompany_account.Visible = true;
            this.col_incompany_account.VisibleIndex = 7;
            // 
            // col_money
            // 
            this.col_money.Caption = "出票金额";
            this.col_money.DisplayFormat.FormatString = "c";
            this.col_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_money.FieldName = "Money";
            this.col_money.Name = "col_money";
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 8;
            // 
            // col_enddate
            // 
            this.col_enddate.Caption = "到期日";
            this.col_enddate.FieldName = "EndDate";
            this.col_enddate.Name = "col_enddate";
            this.col_enddate.Visible = true;
            this.col_enddate.VisibleIndex = 9;
            // 
            // col_tradecode
            // 
            this.col_tradecode.Caption = "交易合同号";
            this.col_tradecode.FieldName = "TradeCode";
            this.col_tradecode.Name = "col_tradecode";
            this.col_tradecode.Visible = true;
            this.col_tradecode.VisibleIndex = 10;
            // 
            // col_status
            // 
            this.col_status.Caption = "完结状态";
            this.col_status.FieldName = "Status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 11;
            // 
            // col_movecompany
            // 
            this.col_movecompany.Caption = "背书单位";
            this.col_movecompany.FieldName = "MoveCompanyDetail.Parent.Name";
            this.col_movecompany.Name = "col_movecompany";
            this.col_movecompany.Visible = true;
            this.col_movecompany.VisibleIndex = 12;
            // 
            // DevAcceptanceBillList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 460);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevAcceptanceBillList";
            this.Text = "承兑汇票列表";
            this.Activated += new System.EventHandler(this.DevAcceptanceBillList_Activated);
            this.Load += new System.EventHandler(this.DevAcceptanceBillList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem tsbQuery;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarButtonItem tsbFinish;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_drawdate;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_bank;
        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_account;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraGrid.Columns.GridColumn col_enddate;
        private DevExpress.XtraGrid.Columns.GridColumn col_tradecode;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_movecompany;
    }
}