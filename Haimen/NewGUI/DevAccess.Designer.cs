namespace Haimen.NewGUI
{
    partial class DevAccess
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
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cboUType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_function = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtFunction = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_view = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkView = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_new = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkNew = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lueList = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboUType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueList.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
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
            this.btnSave,
            this.btnExit});
            this.barManager1.MaxItemId = 2;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "保存";
            this.btnSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.btnSave.Id = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "退出";
            this.btnExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.btnExit.Id = 1;
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(567, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 479);
            this.barDockControlBottom.Size = new System.Drawing.Size(567, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 440);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(567, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 440);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cboUType);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.lueList);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(567, 440);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cboUType
            // 
            this.cboUType.Location = new System.Drawing.Point(12, 12);
            this.cboUType.MenuManager = this.barManager1;
            this.cboUType.Name = "cboUType";
            this.cboUType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.cboUType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboUType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboUType.Size = new System.Drawing.Size(158, 20);
            this.cboUType.StyleController = this.layoutControl1;
            this.cboUType.TabIndex = 7;
            this.cboUType.EditValueChanged += new System.EventHandler(this.cboUType_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.chkView,
            this.chkNew,
            this.chkEdit,
            this.chkDelete,
            this.chkCheck,
            this.txtFunction});
            this.gridControl1.Size = new System.Drawing.Size(543, 392);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_function,
            this.col_view,
            this.col_new,
            this.col_edit,
            this.col_delete,
            this.col_check});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_function
            // 
            this.col_function.Caption = "业务";
            this.col_function.ColumnEdit = this.txtFunction;
            this.col_function.FieldName = "Name";
            this.col_function.Name = "col_function";
            this.col_function.Visible = true;
            this.col_function.VisibleIndex = 0;
            // 
            // txtFunction
            // 
            this.txtFunction.AutoHeight = false;
            this.txtFunction.Name = "txtFunction";
            // 
            // col_view
            // 
            this.col_view.Caption = "查看";
            this.col_view.ColumnEdit = this.chkView;
            this.col_view.FieldName = "View";
            this.col_view.Name = "col_view";
            this.col_view.Visible = true;
            this.col_view.VisibleIndex = 1;
            // 
            // chkView
            // 
            this.chkView.AutoHeight = false;
            this.chkView.Caption = "Check";
            this.chkView.Name = "chkView";
            // 
            // col_new
            // 
            this.col_new.Caption = "新增";
            this.col_new.ColumnEdit = this.chkNew;
            this.col_new.FieldName = "New";
            this.col_new.Name = "col_new";
            this.col_new.Visible = true;
            this.col_new.VisibleIndex = 2;
            // 
            // chkNew
            // 
            this.chkNew.AutoHeight = false;
            this.chkNew.Caption = "Check";
            this.chkNew.Name = "chkNew";
            // 
            // col_edit
            // 
            this.col_edit.Caption = "编辑";
            this.col_edit.ColumnEdit = this.chkEdit;
            this.col_edit.FieldName = "Edit";
            this.col_edit.Name = "col_edit";
            this.col_edit.Visible = true;
            this.col_edit.VisibleIndex = 3;
            // 
            // chkEdit
            // 
            this.chkEdit.AutoHeight = false;
            this.chkEdit.Caption = "Check";
            this.chkEdit.Name = "chkEdit";
            // 
            // col_delete
            // 
            this.col_delete.Caption = "删除";
            this.col_delete.ColumnEdit = this.chkDelete;
            this.col_delete.FieldName = "Delete";
            this.col_delete.Name = "col_delete";
            this.col_delete.Visible = true;
            this.col_delete.VisibleIndex = 4;
            // 
            // chkDelete
            // 
            this.chkDelete.AutoHeight = false;
            this.chkDelete.Caption = "Check";
            this.chkDelete.Name = "chkDelete";
            // 
            // col_check
            // 
            this.col_check.Caption = "审核";
            this.col_check.ColumnEdit = this.chkCheck;
            this.col_check.FieldName = "Check";
            this.col_check.Name = "col_check";
            this.col_check.Visible = true;
            this.col_check.VisibleIndex = 5;
            // 
            // chkCheck
            // 
            this.chkCheck.AutoHeight = false;
            this.chkCheck.Caption = "Check";
            this.chkCheck.Name = "chkCheck";
            // 
            // lueList
            // 
            this.lueList.Location = new System.Drawing.Point(174, 12);
            this.lueList.MenuManager = this.barManager1;
            this.lueList.Name = "lueList";
            this.lueList.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueList.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueList.Properties.NullText = "";
            this.lueList.Size = new System.Drawing.Size(381, 20);
            this.lueList.StyleController = this.layoutControl1;
            this.lueList.TabIndex = 5;
            this.lueList.EditValueChanged += new System.EventHandler(this.lueList_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(567, 440);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lueList;
            this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem2.Location = new System.Drawing.Point(162, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(385, 24);
            this.layoutControlItem2.Text = "layoutControlItem2";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(547, 396);
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextToControlDistance = 0;
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cboUType;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(162, 24);
            this.layoutControlItem4.Text = "layoutControlItem4";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // DevAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 479);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "DevAccess";
            this.Text = "权限设置";
            this.Load += new System.EventHandler(this.DevAccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboUType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueList.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lueList;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ComboBoxEdit cboUType;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn col_function;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtFunction;
        private DevExpress.XtraGrid.Columns.GridColumn col_view;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkView;
        private DevExpress.XtraGrid.Columns.GridColumn col_new;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkNew;
        private DevExpress.XtraGrid.Columns.GridColumn col_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEdit;
        private DevExpress.XtraGrid.Columns.GridColumn col_delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDelete;
        private DevExpress.XtraGrid.Columns.GridColumn col_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkCheck;
    }
}