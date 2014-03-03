namespace Haimen.GUI
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
            this.col_userid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usergroupid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_functiontype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_functionid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_functionname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_actionid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_actionname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_access = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chkAccess = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkView = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkNew = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkDelete = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.chkCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.txtFunction = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkAccess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunction)).BeginInit();
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
            this.txtFunction,
            this.chkAccess});
            this.gridControl1.Size = new System.Drawing.Size(543, 392);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_userid,
            this.col_usergroupid,
            this.col_functiontype,
            this.col_functionid,
            this.col_functionname,
            this.col_actionid,
            this.col_actionname,
            this.col_access});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.IndicatorWidth = 40;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsCustomization.AllowColumnMoving = false;
            this.gridView1.OptionsCustomization.AllowFilter = false;
            this.gridView1.OptionsCustomization.AllowGroup = false;
            this.gridView1.OptionsCustomization.AllowSort = false;
            this.gridView1.OptionsView.AllowCellMerge = true;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.EnableAppearanceEvenRow = true;
            this.gridView1.OptionsView.EnableAppearanceOddRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CellMerge += new DevExpress.XtraGrid.Views.Grid.CellMergeEventHandler(this.gridView1_CellMerge);
            this.gridView1.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridView1_CustomDrawRowIndicator);
            // 
            // col_userid
            // 
            this.col_userid.Caption = "用户ID";
            this.col_userid.FieldName = "UserID";
            this.col_userid.Name = "col_userid";
            this.col_userid.OptionsColumn.AllowEdit = false;
            // 
            // col_usergroupid
            // 
            this.col_usergroupid.Caption = "用户组ID";
            this.col_usergroupid.FieldName = "UserGroupID";
            this.col_usergroupid.Name = "col_usergroupid";
            this.col_usergroupid.OptionsColumn.AllowEdit = false;
            // 
            // col_functiontype
            // 
            this.col_functiontype.Caption = "类别";
            this.col_functiontype.FieldName = "FunctionType";
            this.col_functiontype.Name = "col_functiontype";
            this.col_functiontype.OptionsColumn.AllowEdit = false;
            this.col_functiontype.Visible = true;
            this.col_functiontype.VisibleIndex = 0;
            // 
            // col_functionid
            // 
            this.col_functionid.Caption = "功能ID";
            this.col_functionid.FieldName = "FunctionID";
            this.col_functionid.Name = "col_functionid";
            this.col_functionid.OptionsColumn.AllowEdit = false;
            // 
            // col_functionname
            // 
            this.col_functionname.Caption = "功能";
            this.col_functionname.FieldName = "FunctionName";
            this.col_functionname.Name = "col_functionname";
            this.col_functionname.OptionsColumn.AllowEdit = false;
            this.col_functionname.Visible = true;
            this.col_functionname.VisibleIndex = 1;
            // 
            // col_actionid
            // 
            this.col_actionid.Caption = "操作ID";
            this.col_actionid.FieldName = "ActionID";
            this.col_actionid.Name = "col_actionid";
            this.col_actionid.OptionsColumn.AllowEdit = false;
            // 
            // col_actionname
            // 
            this.col_actionname.Caption = "操作";
            this.col_actionname.FieldName = "ActionName";
            this.col_actionname.Name = "col_actionname";
            this.col_actionname.OptionsColumn.AllowEdit = false;
            this.col_actionname.Visible = true;
            this.col_actionname.VisibleIndex = 2;
            // 
            // col_access
            // 
            this.col_access.Caption = "权限";
            this.col_access.ColumnEdit = this.chkAccess;
            this.col_access.FieldName = "CanAccess";
            this.col_access.Name = "col_access";
            this.col_access.Visible = true;
            this.col_access.VisibleIndex = 3;
            // 
            // chkAccess
            // 
            this.chkAccess.AutoHeight = false;
            this.chkAccess.Caption = "Check";
            this.chkAccess.Name = "chkAccess";
            this.chkAccess.ValueChecked = ((byte)(1));
            this.chkAccess.ValueUnchecked = ((byte)(0));
            // 
            // chkView
            // 
            this.chkView.AutoHeight = false;
            this.chkView.Caption = "Check";
            this.chkView.Name = "chkView";
            // 
            // chkNew
            // 
            this.chkNew.AutoHeight = false;
            this.chkNew.Caption = "Check";
            this.chkNew.Name = "chkNew";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoHeight = false;
            this.chkEdit.Caption = "Check";
            this.chkEdit.Name = "chkEdit";
            // 
            // chkDelete
            // 
            this.chkDelete.AutoHeight = false;
            this.chkDelete.Caption = "Check";
            this.chkDelete.Name = "chkDelete";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoHeight = false;
            this.chkCheck.Caption = "Check";
            this.chkCheck.Name = "chkCheck";
            // 
            // txtFunction
            // 
            this.txtFunction.AutoHeight = false;
            this.txtFunction.Name = "txtFunction";
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
            ((System.ComponentModel.ISupportInitialize)(this.chkAccess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFunction)).EndInit();
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtFunction;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkNew;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkDelete;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkCheck;
        private DevExpress.XtraGrid.Columns.GridColumn col_userid;
        private DevExpress.XtraGrid.Columns.GridColumn col_usergroupid;
        private DevExpress.XtraGrid.Columns.GridColumn col_functiontype;
        private DevExpress.XtraGrid.Columns.GridColumn col_functionid;
        private DevExpress.XtraGrid.Columns.GridColumn col_functionname;
        private DevExpress.XtraGrid.Columns.GridColumn col_actionid;
        private DevExpress.XtraGrid.Columns.GridColumn col_actionname;
        private DevExpress.XtraGrid.Columns.GridColumn col_access;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit chkAccess;
    }
}