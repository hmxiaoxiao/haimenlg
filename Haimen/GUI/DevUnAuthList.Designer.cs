namespace Haimen.GUI
{
    partial class DevUnAuthList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevUnAuthList));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbView = new DevExpress.XtraBars.BarButtonItem();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.txtDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.a_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_bankname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_output = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_input = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.a_memo = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.tsbView,
            this.tsbNew,
            this.tsbEdit,
            this.txtDelete,
            this.tsbExit,
            this.tsbRefresh});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbView, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.txtDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbView
            // 
            this.tsbView.Caption = "查看";
            this.tsbView.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbView.Glyph")));
            this.tsbView.Id = 0;
            this.tsbView.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbView.LargeGlyph")));
            this.tsbView.Name = "tsbView";
            this.tsbView.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbView_ItemClick);
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbNew.Glyph")));
            this.tsbNew.Id = 1;
            this.tsbNew.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbNew.LargeGlyph")));
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Glyph")));
            this.tsbEdit.Id = 2;
            this.tsbEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbEdit.LargeGlyph")));
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // txtDelete
            // 
            this.txtDelete.Caption = "删除";
            this.txtDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("txtDelete.Glyph")));
            this.txtDelete.Id = 3;
            this.txtDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("txtDelete.LargeGlyph")));
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.txtDelete_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Glyph")));
            this.tsbRefresh.Id = 5;
            this.tsbRefresh.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.LargeGlyph")));
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(787, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 528);
            this.barDockControlBottom.Size = new System.Drawing.Size(787, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(787, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(787, 481);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.a_id,
            this.a_date,
            this.a_code,
            this.a_company,
            this.a_bankname,
            this.a_account,
            this.a_output,
            this.a_input,
            this.a_money,
            this.a_memo});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // a_id
            // 
            this.a_id.Caption = "ID";
            this.a_id.FieldName = "id";
            this.a_id.Name = "a_id";
            // 
            // a_date
            // 
            this.a_date.Caption = "日期";
            this.a_date.FieldName = "signed_date";
            this.a_date.Name = "a_date";
            this.a_date.Visible = true;
            this.a_date.VisibleIndex = 0;
            // 
            // a_code
            // 
            this.a_code.Caption = "凭证号";
            this.a_code.FieldName = "code";
            this.a_code.Name = "a_code";
            this.a_code.Visible = true;
            this.a_code.VisibleIndex = 1;
            // 
            // a_company
            // 
            this.a_company.Caption = "本单位";
            this.a_company.FieldName = "companyname";
            this.a_company.Name = "a_company";
            this.a_company.Visible = true;
            this.a_company.VisibleIndex = 2;
            // 
            // a_bankname
            // 
            this.a_bankname.Caption = "银行";
            this.a_bankname.FieldName = "bankname";
            this.a_bankname.Name = "a_bankname";
            this.a_bankname.Visible = true;
            this.a_bankname.VisibleIndex = 3;
            // 
            // a_account
            // 
            this.a_account.Caption = "帐号";
            this.a_account.FieldName = "account";
            this.a_account.Name = "a_account";
            this.a_account.Visible = true;
            this.a_account.VisibleIndex = 4;
            // 
            // a_output
            // 
            this.a_output.Caption = "支出";
            this.a_output.FieldName = "output";
            this.a_output.Name = "a_output";
            this.a_output.Visible = true;
            this.a_output.VisibleIndex = 5;
            // 
            // a_input
            // 
            this.a_input.Caption = "收入";
            this.a_input.FieldName = "input";
            this.a_input.Name = "a_input";
            this.a_input.Visible = true;
            this.a_input.VisibleIndex = 6;
            // 
            // a_money
            // 
            this.a_money.Caption = "金额";
            this.a_money.DisplayFormat.FormatString = "C";
            this.a_money.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.a_money.FieldName = "money";
            this.a_money.Name = "a_money";
            this.a_money.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum)});
            this.a_money.Visible = true;
            this.a_money.VisibleIndex = 7;
            // 
            // a_memo
            // 
            this.a_memo.Caption = "备注";
            this.a_memo.FieldName = "memo";
            this.a_memo.Name = "a_memo";
            this.a_memo.Visible = true;
            this.a_memo.VisibleIndex = 8;
            // 
            // DevUnAuthList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 528);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevUnAuthList";
            this.Text = "非授权收支列表";
            this.Activated += new System.EventHandler(this.DevUnAuthList_Activated);
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem tsbView;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem txtDelete;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraGrid.Columns.GridColumn a_company;
        private DevExpress.XtraGrid.Columns.GridColumn a_bankname;
        private DevExpress.XtraGrid.Columns.GridColumn a_account;
        private DevExpress.XtraGrid.Columns.GridColumn a_output;
        private DevExpress.XtraGrid.Columns.GridColumn a_input;
        private DevExpress.XtraGrid.Columns.GridColumn a_money;
        private DevExpress.XtraGrid.Columns.GridColumn a_memo;
        private DevExpress.XtraGrid.Columns.GridColumn a_code;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn a_id;
        private DevExpress.XtraGrid.Columns.GridColumn a_date;
    }
}