namespace Haimen.GUI
{
    partial class DevContractAcceptList
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
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tsbGene = new DevExpress.XtraBars.BarButtonItem();
            this.tsbRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.tsbExit = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_contract_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_contract_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_accept_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_accept_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_memo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lueStatus = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).BeginInit();
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
            this.tsbGene,
            this.tsbRefresh,
            this.tsbExit});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(509, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Size = new System.Drawing.Size(509, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 349);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(509, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 349);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbGene, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbRefresh, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tsbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tsbGene
            // 
            this.tsbGene.Caption = "生成凭证";
            this.tsbGene.Glyph = global::Haimen.Properties.Resources.Card_Add;
            this.tsbGene.Id = 0;
            this.tsbGene.Name = "tsbGene";
            this.tsbGene.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbGene_ItemClick);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Caption = "刷新";
            this.tsbRefresh.Glyph = global::Haimen.Properties.Resources.Refresh_hot;
            this.tsbRefresh.Id = 1;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbRefresh_ItemClick);
            // 
            // tsbExit
            // 
            this.tsbExit.Caption = "退出";
            this.tsbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tsbExit.Id = 2;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tsbExit_ItemClick);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 39);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lueStatus});
            this.gridControl1.Size = new System.Drawing.Size(509, 349);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_contract_code,
            this.col_contract_name,
            this.col_accept_unit,
            this.col_accept_date,
            this.col_pass,
            this.col_money,
            this.col_memo,
            this.col_status});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_contract_code
            // 
            this.col_contract_code.Caption = "合同号";
            this.col_contract_code.FieldName = "Contract.Code";
            this.col_contract_code.Name = "col_contract_code";
            this.col_contract_code.Visible = true;
            this.col_contract_code.VisibleIndex = 0;
            // 
            // col_contract_name
            // 
            this.col_contract_name.Caption = "合同名";
            this.col_contract_name.FieldName = "Contract.Name";
            this.col_contract_name.Name = "col_contract_name";
            this.col_contract_name.Visible = true;
            this.col_contract_name.VisibleIndex = 1;
            // 
            // col_accept_unit
            // 
            this.col_accept_unit.Caption = "验收单位";
            this.col_accept_unit.FieldName = "AcceptUnit";
            this.col_accept_unit.Name = "col_accept_unit";
            this.col_accept_unit.Visible = true;
            this.col_accept_unit.VisibleIndex = 2;
            // 
            // col_accept_date
            // 
            this.col_accept_date.Caption = "验收日期";
            this.col_accept_date.FieldName = "AcceptDate";
            this.col_accept_date.Name = "col_accept_date";
            this.col_accept_date.Visible = true;
            this.col_accept_date.VisibleIndex = 3;
            // 
            // col_pass
            // 
            this.col_pass.Caption = "验收结果";
            this.col_pass.FieldName = "Pass";
            this.col_pass.Name = "col_pass";
            this.col_pass.Visible = true;
            this.col_pass.VisibleIndex = 4;
            // 
            // col_money
            // 
            this.col_money.Caption = "结算金额";
            this.col_money.FieldName = "Money";
            this.col_money.Name = "col_money";
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 5;
            // 
            // col_memo
            // 
            this.col_memo.Caption = "验收说明";
            this.col_memo.FieldName = "Memo";
            this.col_memo.Name = "col_memo";
            this.col_memo.Visible = true;
            this.col_memo.VisibleIndex = 6;
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.ColumnEdit = this.lueStatus;
            this.col_status.FieldName = "Status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 7;
            // 
            // lueStatus
            // 
            this.lueStatus.AutoHeight = false;
            this.lueStatus.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueStatus.Name = "lueStatus";
            // 
            // DevContractAcceptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 388);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevContractAcceptList";
            this.Text = "合同验收列表";
            this.Load += new System.EventHandler(this.DevContractAcceptList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem tsbGene;
        private DevExpress.XtraBars.BarButtonItem tsbRefresh;
        private DevExpress.XtraBars.BarButtonItem tsbExit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_contract_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_contract_name;
        private DevExpress.XtraGrid.Columns.GridColumn col_accept_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_accept_date;
        private DevExpress.XtraGrid.Columns.GridColumn col_pass;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraGrid.Columns.GridColumn col_memo;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lueStatus;
    }
}