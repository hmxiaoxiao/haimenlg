namespace Haimen.GUI
{
    partial class DevCompany
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
            this.cbOutput = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDoc = new DevExpress.XtraEditors.TextEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbSave = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.cbInput = new DevExpress.XtraEditors.CheckEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.sueCompany = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbOutput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInput.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cbOutput
            // 
            this.cbOutput.EnterMoveNextControl = true;
            this.cbOutput.Location = new System.Drawing.Point(82, 219);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Properties.Caption = "支出单位";
            this.cbOutput.Size = new System.Drawing.Size(355, 19);
            this.cbOutput.StyleController = this.layoutControl1;
            this.cbOutput.TabIndex = 6;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sueCompany);
            this.layoutControl1.Controls.Add(this.txtDoc);
            this.layoutControl1.Controls.Add(this.txtName);
            this.layoutControl1.Controls.Add(this.txtCode);
            this.layoutControl1.Controls.Add(this.cbOutput);
            this.layoutControl1.Controls.Add(this.cbInput);
            this.layoutControl1.Location = new System.Drawing.Point(0, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsFocus.EnableAutoTabOrder = false;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(457, 367);
            this.layoutControl1.TabIndex = 14;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDoc
            // 
            this.txtDoc.EnterMoveNextControl = true;
            this.txtDoc.Location = new System.Drawing.Point(82, 100);
            this.txtDoc.MenuManager = this.barManager1;
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(355, 20);
            this.txtDoc.StyleController = this.layoutControl1;
            this.txtDoc.TabIndex = 3;
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
            this.barButtonItem1,
            this.tsbSave,
            this.tsbExit,
            this.tsbNew,
            this.tsbEdit,
            this.tsbDelete});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbNew
            // 
            this.tsbNew.Caption = "新增";
            this.tsbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.Id = 3;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbNew_ItemClick);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Caption = "编辑";
            this.tsbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tsbEdit.Id = 4;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbEdit_ItemClick);
            // 
            // tsbSave
            // 
            this.tsbSave.Caption = "保存";
            this.tsbSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.tsbSave.Id = 1;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbSave_ItemClick);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Caption = "删除";
            this.tsbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbDelete.Id = 5;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbDelete_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 2;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(532, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 406);
            this.barDockControlBottom.Size = new System.Drawing.Size(532, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 367);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(532, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 367);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // txtName
            // 
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Location = new System.Drawing.Point(82, 60);
            this.txtName.MenuManager = this.barManager1;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(355, 20);
            this.txtName.StyleController = this.layoutControl1;
            this.txtName.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(82, 20);
            this.txtCode.MenuManager = this.barManager1;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(355, 20);
            this.txtCode.StyleController = this.layoutControl1;
            this.txtCode.TabIndex = 1;
            // 
            // cbInput
            // 
            this.cbInput.EnterMoveNextControl = true;
            this.cbInput.Location = new System.Drawing.Point(82, 180);
            this.cbInput.Name = "cbInput";
            this.cbInput.Properties.Caption = "收入单位";
            this.cbInput.Size = new System.Drawing.Size(355, 19);
            this.cbInput.StyleController = this.layoutControl1;
            this.cbInput.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(457, 367);
            this.layoutControlGroup1.Text = "Root";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cbInput;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem6.Size = new System.Drawing.Size(437, 39);
            this.layoutControlItem6.Text = "   ";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.cbOutput;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem7";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 199);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem7.Size = new System.Drawing.Size(437, 148);
            this.layoutControlItem7.Text = "   ";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtCode;
            this.layoutControlItem8.CustomizationFormText = "编号：";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem8.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem8.Text = "编号：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtName;
            this.layoutControlItem9.CustomizationFormText = "名称：";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem9.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem9.Text = "名称：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(60, 14);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtDoc;
            this.layoutControlItem11.CustomizationFormText = "单据字：";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem11.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem11.Text = "单据字：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(60, 14);
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // sueCompany
            // 
            this.sueCompany.EditValue = "请选择...";
            this.sueCompany.Location = new System.Drawing.Point(82, 140);
            this.sueCompany.MenuManager = this.barManager1;
            this.sueCompany.Name = "sueCompany";
            this.sueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sueCompany.Properties.View = this.searchLookUpEdit1View;
            this.sueCompany.Size = new System.Drawing.Size(355, 20);
            this.sueCompany.StyleController = this.layoutControl1;
            this.sueCompany.TabIndex = 7;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sueCompany;
            this.layoutControlItem1.CustomizationFormText = "所属单位：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(437, 40);
            this.layoutControlItem1.Text = "所属单位：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 14);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_code,
            this.col_name});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_code
            // 
            this.col_code.Caption = "代码";
            this.col_code.FieldName = "Code";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 0;
            // 
            // col_name
            // 
            this.col_name.Caption = "名称";
            this.col_name.FieldName = "Name";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 1;
            // 
            // DevCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 406);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevCompany";
            this.Text = "单位管理";
            this.Load += new System.EventHandler(this.DevCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbOutput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbInput.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sueCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit cbOutput;
        private DevExpress.XtraEditors.CheckEdit cbInput;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tsbNew;
        private DevExpress.XtraBars.BarButtonItem tsbEdit;
        private DevExpress.XtraBars.BarButtonItem tsbSave;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraBars.BarButtonItem tsbDelete;
        private DevExpress.XtraEditors.TextEdit txtDoc;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.XtraEditors.SearchLookUpEdit sueCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
    }
}