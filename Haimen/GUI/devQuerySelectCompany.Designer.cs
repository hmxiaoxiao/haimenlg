namespace Haimen.GUI
{
    partial class DevQuerySelectCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevQuerySelectCompany));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.tsbReSelect = new DevExpress.XtraBars.BarButtonItem();
            this.tsbUnSelected = new DevExpress.XtraBars.BarButtonItem();
            this.tsbConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.tsbClose = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_selected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelected)).BeginInit();
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
            this.tsbSelectAll,
            this.tsbReSelect,
            this.tsbUnSelected,
            this.tsbConfirm,
            this.tsbClose});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSelectAll, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbReSelect, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbUnSelected, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbConfirm, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbClose, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbSelectAll
            // 
            this.tsbSelectAll.Caption = "全选";
            this.tsbSelectAll.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbSelectAll.Glyph")));
            this.tsbSelectAll.Id = 0;
            this.tsbSelectAll.Name = "tsbSelectAll";
            this.tsbSelectAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSelectAll_ItemClick);
            // 
            // tsbReSelect
            // 
            this.tsbReSelect.Caption = "反选";
            this.tsbReSelect.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbReSelect.Glyph")));
            this.tsbReSelect.Id = 1;
            this.tsbReSelect.Name = "tsbReSelect";
            this.tsbReSelect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbReSelect_ItemClick);
            // 
            // tsbUnSelected
            // 
            this.tsbUnSelected.Caption = "不选";
            this.tsbUnSelected.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbUnSelected.Glyph")));
            this.tsbUnSelected.Id = 2;
            this.tsbUnSelected.Name = "tsbUnSelected";
            this.tsbUnSelected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbUnSelected_ItemClick);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Caption = "确认选择";
            this.tsbConfirm.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Glyph")));
            this.tsbConfirm.Id = 3;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbConfirm_ItemClick);
            // 
            // tsbClose
            // 
            this.tsbClose.Caption = "取消退出";
            this.tsbClose.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbClose.Glyph")));
            this.tsbClose.Id = 4;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbClose_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(616, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 401);
            this.barDockControlBottom.Size = new System.Drawing.Size(616, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 354);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(616, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 354);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkSelected});
            this.gridControl1.Size = new System.Drawing.Size(616, 354);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_selected,
            this.col_id,
            this.col_code,
            this.col_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_selected
            // 
            this.col_selected.Caption = "选择";
            this.col_selected.ColumnEdit = this.chkSelected;
            this.col_selected.FieldName = "sel";
            this.col_selected.Name = "col_selected";
            this.col_selected.Visible = true;
            this.col_selected.VisibleIndex = 0;
            // 
            // chkSelected
            // 
            this.chkSelected.AutoHeight = false;
            this.chkSelected.Caption = "Check";
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.ValueChecked = "Y";
            this.chkSelected.ValueUnchecked = "N";
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "id";
            this.col_id.Name = "col_id";
            // 
            // col_code
            // 
            this.col_code.Caption = "代码";
            this.col_code.FieldName = "code";
            this.col_code.Name = "col_code";
            this.col_code.OptionsColumn.AllowEdit = false;
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 1;
            // 
            // col_name
            // 
            this.col_name.Caption = "名称";
            this.col_name.FieldName = "name";
            this.col_name.Name = "col_name";
            this.col_name.OptionsColumn.AllowEdit = false;
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 2;
            // 
            // DevQuerySelectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 401);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevQuerySelectCompany";
            this.Text = "选择单位";
            this.Load += new System.EventHandler(this.devQuerySelectCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsbSelectAll;
        private DevExpress.XtraBars.BarButtonItem tsbReSelect;
        private DevExpress.XtraBars.BarButtonItem tsbUnSelected;
        private DevExpress.XtraBars.BarButtonItem tsbConfirm;
        private DevExpress.XtraBars.BarButtonItem tsbClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_selected;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSelected;
    }
}