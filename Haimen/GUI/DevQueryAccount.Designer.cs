namespace Haimen.GUI
{
    partial class DevQueryAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevQueryAccount));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.d_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_parent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.d_usage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.m_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_outcompanyname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_outbankname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_outaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_incompanyname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inbankname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inaccount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_signeddate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.m_project_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_invoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.m_memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barRefresh = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.d_id,
            this.d_parent_id,
            this.d_name,
            this.d_money,
            this.d_usage});
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.EnableAppearanceEvenRow = true;
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
            // d_name
            // 
            this.d_name.Caption = "性质";
            this.d_name.FieldName = "name";
            this.d_name.Name = "d_name";
            this.d_name.Visible = true;
            this.d_name.VisibleIndex = 0;
            // 
            // d_money
            // 
            this.d_money.Caption = "金额";
            this.d_money.FieldName = "money";
            this.d_money.Name = "d_money";
            this.d_money.Visible = true;
            this.d_money.VisibleIndex = 1;
            // 
            // d_usage
            // 
            this.d_usage.Caption = "用途";
            this.d_usage.FieldName = "usage";
            this.d_usage.Name = "d_usage";
            this.d_usage.Visible = true;
            this.d_usage.VisibleIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridView2;
            gridLevelNode1.RelationName = "明细";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 31);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueInvoice,
            this.lueStatus});
            this.gridControl1.Size = new System.Drawing.Size(797, 514);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.m_id,
            this.m_outcompanyname,
            this.m_outbankname,
            this.m_outaccount,
            this.m_incompanyname,
            this.inbankname,
            this.inaccount,
            this.m_code,
            this.m_signeddate,
            this.m_money,
            this.m_status,
            this.m_project_id,
            this.m_invoice,
            this.m_memo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.m_outcompanyname, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.m_outbankname, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            this.gridView1.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gridView1_CustomColumnDisplayText);
            // 
            // m_id
            // 
            this.m_id.Caption = "ID";
            this.m_id.FieldName = "id";
            this.m_id.Name = "m_id";
            // 
            // m_outcompanyname
            // 
            this.m_outcompanyname.Caption = "本单位";
            this.m_outcompanyname.FieldName = "outcompanyname";
            this.m_outcompanyname.Name = "m_outcompanyname";
            this.m_outcompanyname.Visible = true;
            this.m_outcompanyname.VisibleIndex = 0;
            // 
            // m_outbankname
            // 
            this.m_outbankname.Caption = "本单位银行";
            this.m_outbankname.FieldName = "outbankname";
            this.m_outbankname.Name = "m_outbankname";
            this.m_outbankname.Visible = true;
            this.m_outbankname.VisibleIndex = 1;
            // 
            // m_outaccount
            // 
            this.m_outaccount.Caption = "本单位帐号";
            this.m_outaccount.FieldName = "outaccount";
            this.m_outaccount.Name = "m_outaccount";
            this.m_outaccount.Visible = true;
            this.m_outaccount.VisibleIndex = 2;
            // 
            // m_incompanyname
            // 
            this.m_incompanyname.Caption = "外单位";
            this.m_incompanyname.FieldName = "incompanyname";
            this.m_incompanyname.Name = "m_incompanyname";
            this.m_incompanyname.Visible = true;
            this.m_incompanyname.VisibleIndex = 3;
            // 
            // inbankname
            // 
            this.inbankname.Caption = "外单位银行";
            this.inbankname.FieldName = "inbankname";
            this.inbankname.Name = "inbankname";
            this.inbankname.Visible = true;
            this.inbankname.VisibleIndex = 4;
            // 
            // inaccount
            // 
            this.inaccount.Caption = "外单位帐号";
            this.inaccount.FieldName = "inaccount";
            this.inaccount.Name = "inaccount";
            this.inaccount.Visible = true;
            this.inaccount.VisibleIndex = 5;
            // 
            // m_code
            // 
            this.m_code.Caption = "凭证号";
            this.m_code.FieldName = "code";
            this.m_code.Name = "m_code";
            this.m_code.Visible = true;
            this.m_code.VisibleIndex = 6;
            // 
            // m_signeddate
            // 
            this.m_signeddate.Caption = "日期";
            this.m_signeddate.FieldName = "signeddate";
            this.m_signeddate.Name = "m_signeddate";
            this.m_signeddate.Visible = true;
            this.m_signeddate.VisibleIndex = 7;
            // 
            // m_money
            // 
            this.m_money.Caption = "总金额";
            this.m_money.FieldName = "money";
            this.m_money.Name = "m_money";
            this.m_money.Visible = true;
            this.m_money.VisibleIndex = 8;
            // 
            // m_status
            // 
            this.m_status.Caption = "状态";
            this.m_status.ColumnEdit = this.lueStatus;
            this.m_status.FieldName = "status";
            this.m_status.Name = "m_status";
            this.m_status.Visible = true;
            this.m_status.VisibleIndex = 9;
            // 
            // lueStatus
            // 
            this.lueStatus.AutoHeight = false;
            this.lueStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Name = "lueStatus";
            // 
            // m_project_id
            // 
            this.m_project_id.Caption = "所属项目";
            this.m_project_id.FieldName = "project_id";
            this.m_project_id.Name = "m_project_id";
            this.m_project_id.Visible = true;
            this.m_project_id.VisibleIndex = 10;
            // 
            // m_invoice
            // 
            this.m_invoice.Caption = "发票";
            this.m_invoice.ColumnEdit = this.lueInvoice;
            this.m_invoice.FieldName = "invoice";
            this.m_invoice.Name = "m_invoice";
            this.m_invoice.Visible = true;
            this.m_invoice.VisibleIndex = 11;
            // 
            // lueInvoice
            // 
            this.lueInvoice.AutoHeight = false;
            this.lueInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInvoice.Name = "lueInvoice";
            // 
            // m_memo
            // 
            this.m_memo.Caption = "备注";
            this.m_memo.FieldName = "memo";
            this.m_memo.Name = "m_memo";
            this.m_memo.Visible = true;
            this.m_memo.VisibleIndex = 12;
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
            this.barRefresh});
            this.barManager1.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(797, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 545);
            this.barDockControlBottom.Size = new System.Drawing.Size(797, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 514);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(797, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 514);
            // 
            // barRefresh
            // 
            this.barRefresh.Caption = "刷新";
            this.barRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("barRefresh.Glyph")));
            this.barRefresh.Id = 0;
            this.barRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barRefresh.LargeGlyph")));
            this.barRefresh.Name = "barRefresh";
            this.barRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefresh_ItemClick);
            // 
            // DevQueryAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 545);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevQueryAccount";
            this.Text = "资金查询";
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn d_id;
        private DevExpress.XtraGrid.Columns.GridColumn d_parent_id;
        private DevExpress.XtraGrid.Columns.GridColumn d_name;
        private DevExpress.XtraGrid.Columns.GridColumn d_money;
        private DevExpress.XtraGrid.Columns.GridColumn d_usage;
        private DevExpress.XtraGrid.Columns.GridColumn m_id;
        private DevExpress.XtraGrid.Columns.GridColumn m_status;
        private DevExpress.XtraGrid.Columns.GridColumn m_signeddate;
        private DevExpress.XtraGrid.Columns.GridColumn m_money;
        private DevExpress.XtraGrid.Columns.GridColumn m_project_id;
        private DevExpress.XtraGrid.Columns.GridColumn m_invoice;
        private DevExpress.XtraGrid.Columns.GridColumn m_code;
        private DevExpress.XtraGrid.Columns.GridColumn m_outcompanyname;
        private DevExpress.XtraGrid.Columns.GridColumn m_outbankname;
        private DevExpress.XtraGrid.Columns.GridColumn m_outaccount;
        private DevExpress.XtraGrid.Columns.GridColumn m_incompanyname;
        private DevExpress.XtraGrid.Columns.GridColumn inbankname;
        private DevExpress.XtraGrid.Columns.GridColumn inaccount;
        private DevExpress.XtraGrid.Columns.GridColumn m_memo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueInvoice;
        private DevExpress.XtraBars.BarButtonItem barRefresh;
    }
}