namespace Haimen.NewGUI
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
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tsbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tsbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tsbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tsbQuery = new DevExpress.XtraBars.BarButtonItem();
            this.tsbGen = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "支付比例";
            this.gridColumn9.FieldName = "PaymentRatio";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "金额";
            this.gridColumn7.FieldName = "Money";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "合同名称";
            this.gridColumn6.FieldName = "Name";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "结束日期";
            this.gridColumn5.FieldName = "EndDate";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "开始日期";
            this.gridColumn4.FieldName = "BeginDate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "签订日期";
            this.gridColumn3.FieldName = "SignedDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "单位";
            this.gridColumn2.FieldName = "Company.Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "合同编号";
            this.gridColumn1.FieldName = "Code";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "保证金";
            this.gridColumn8.FieldName = "Security";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(744, 522);
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
            this.tsbExit});
            this.barManager1.MaxItemId = 7;
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
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Size = new System.Drawing.Size(744, 0);
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
            this.barDockControlRight.Location = new System.Drawing.Point(744, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 522);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbCheck, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbQuery, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbGen, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            // tsbGen
            // 
            this.tsbGen.Caption = "生成支付凭证";
            this.tsbGen.Glyph = global::Haimen.Properties.Resources.Notepad;
            this.tsbGen.Id = 5;
            this.tsbGen.Name = "tsbGen";
            this.tsbGen.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbGen_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 6;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // DevContractList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 561);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevContractList";
            this.Text = "合同列表";
            this.Load += new System.EventHandler(this.DevContractList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
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
    }
}