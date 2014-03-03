namespace Haimen.GUI
{
    partial class DevQuerySelectBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevQuerySelectBank));
            this.chkSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_selected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.tsbReselect = new DevExpress.XtraBars.BarButtonItem();
            this.tsbUnselected = new DevExpress.XtraBars.BarButtonItem();
            this.tsbConfirm = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCancel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSelected
            // 
            this.chkSelected.AutoHeight = false;
            this.chkSelected.Caption = "Check";
            this.chkSelected.Name = "chkSelected";
            this.chkSelected.ValueChecked = "Y";
            this.chkSelected.ValueUnchecked = "N";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(616, 385);
            this.gridControl1.TabIndex = 0;
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
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
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
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 1;
            // 
            // col_name
            // 
            this.col_name.Caption = "名称";
            this.col_name.FieldName = "name";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 2;
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
            this.tsbReselect,
            this.tsbUnselected,
            this.tsbConfirm,
            this.tsbCancel});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbReselect, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbUnselected, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbConfirm, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCancel, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // tsbReselect
            // 
            this.tsbReselect.Caption = "反选";
            this.tsbReselect.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbReselect.Glyph")));
            this.tsbReselect.Id = 1;
            this.tsbReselect.Name = "tsbReselect";
            this.tsbReselect.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbReselect_ItemClick);
            // 
            // tsbUnselected
            // 
            this.tsbUnselected.Caption = "不选";
            this.tsbUnselected.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbUnselected.Glyph")));
            this.tsbUnselected.Id = 2;
            this.tsbUnselected.Name = "tsbUnselected";
            this.tsbUnselected.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbUnselected_ItemClick);
            // 
            // tsbConfirm
            // 
            this.tsbConfirm.Caption = "确认选择";
            this.tsbConfirm.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbConfirm.Glyph")));
            this.tsbConfirm.Id = 3;
            this.tsbConfirm.Name = "tsbConfirm";
            this.tsbConfirm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbConfirm_ItemClick);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Caption = "取消退出";
            this.tsbCancel.Glyph = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Glyph")));
            this.tsbCancel.Id = 4;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbCancel_ItemClick);
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 432);
            this.barDockControlBottom.Size = new System.Drawing.Size(616, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 385);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(616, 47);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 385);
            // 
            // DevQuerySelectBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 432);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevQuerySelectBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "银行选择";
            this.Load += new System.EventHandler(this.devQuerySelectBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chkSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_selected;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkSelected;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbSelectAll;
        private DevExpress.XtraBars.BarButtonItem tsbReselect;
        private DevExpress.XtraBars.BarButtonItem tsbUnselected;
        private DevExpress.XtraBars.BarButtonItem tsbConfirm;
        private DevExpress.XtraBars.BarButtonItem tsbCancel;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;

    }
}