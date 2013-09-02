namespace Haimen.NewGUI
{
    partial class DevAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevAccount));
            this.lueInCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit6 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            this.lueOutCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_funds_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.luefunds = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_usage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.dtSigned = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInCompanyBank = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtInCompanyAccount = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOutCompanyBank = new System.Windows.Forms.TextBox();
            this.txtOutComapnyAccount = new System.Windows.Forms.TextBox();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tbSave = new DevExpress.XtraBars.BarButtonItem();
            this.tbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.lstFiles = new DevExpress.XtraEditors.ImageListBoxControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbAttachNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAttachDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefunds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.c1SplitterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiles)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lueInCompany
            // 
            this.lueInCompany.Location = new System.Drawing.Point(356, 73);
            this.lueInCompany.Name = "lueInCompany";
            this.lueInCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueInCompany.Properties.NullText = "请选择收款单位";
            this.lueInCompany.Size = new System.Drawing.Size(207, 20);
            this.lueInCompany.TabIndex = 34;
            this.lueInCompany.EditValueChanged += new System.EventHandler(this.lueInCompany_EditValueChanged);
            // 
            // lookUpEdit6
            // 
            this.lookUpEdit6.Location = new System.Drawing.Point(356, 186);
            this.lookUpEdit6.Name = "lookUpEdit6";
            this.lookUpEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit6.Properties.NullText = "请选择合同号";
            this.lookUpEdit6.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit6.TabIndex = 39;
            // 
            // lookUpEdit5
            // 
            this.lookUpEdit5.Location = new System.Drawing.Point(80, 186);
            this.lookUpEdit5.Name = "lookUpEdit5";
            this.lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit5.Properties.NullText = "请选择代码编号";
            this.lookUpEdit5.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit5.TabIndex = 38;
            // 
            // lueOutCompany
            // 
            this.lueOutCompany.Location = new System.Drawing.Point(80, 73);
            this.lueOutCompany.Name = "lueOutCompany";
            this.lueOutCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOutCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueOutCompany.Properties.NullText = "请选择付款单位";
            this.lueOutCompany.Size = new System.Drawing.Size(207, 20);
            this.lueOutCompany.TabIndex = 30;
            this.lueOutCompany.EditValueChanged += new System.EventHandler(this.lueOutCompany_EditValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 14);
            this.label11.TabIndex = 52;
            this.label11.Text = "贷款编号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 53;
            this.label8.Text = "帐户";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 51;
            this.label9.Text = "合同编号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 50;
            this.label7.Text = "帐户";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.luefunds});
            this.gridControl1.Size = new System.Drawing.Size(534, 259);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_funds_id,
            this.col_money,
            this.col_usage});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "ID";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            // 
            // col_funds_id
            // 
            this.col_funds_id.Caption = "资金性质";
            this.col_funds_id.ColumnEdit = this.luefunds;
            this.col_funds_id.FieldName = "Funds_ID";
            this.col_funds_id.Name = "col_funds_id";
            this.col_funds_id.Visible = true;
            this.col_funds_id.VisibleIndex = 0;
            // 
            // luefunds
            // 
            this.luefunds.AutoHeight = false;
            this.luefunds.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luefunds.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.luefunds.Name = "luefunds";
            this.luefunds.NullText = "请选择资金性质";
            // 
            // col_money
            // 
            this.col_money.Caption = "金额";
            this.col_money.FieldName = "Money";
            this.col_money.Name = "col_money";
            this.col_money.Visible = true;
            this.col_money.VisibleIndex = 1;
            // 
            // col_usage
            // 
            this.col_usage.Caption = "用途";
            this.col_usage.FieldName = "Usage";
            this.col_usage.Name = "col_usage";
            this.col_usage.Visible = true;
            this.col_usage.VisibleIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 49;
            this.label10.Text = "备注";
            // 
            // dtSigned
            // 
            this.dtSigned.Location = new System.Drawing.Point(80, 44);
            this.dtSigned.Name = "dtSigned";
            this.dtSigned.Size = new System.Drawing.Size(207, 22);
            this.dtSigned.TabIndex = 28;
            this.dtSigned.ValueChanged += new System.EventHandler(this.dtSigned_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 14);
            this.label6.TabIndex = 46;
            this.label6.Text = "开户行";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 47;
            this.label5.Text = "付款单位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 45;
            this.label3.Text = "开户行";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(297, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 48;
            this.label2.Text = "收款单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "签订日期";
            // 
            // txtInCompanyBank
            // 
            this.txtInCompanyBank.Location = new System.Drawing.Point(356, 100);
            this.txtInCompanyBank.Name = "txtInCompanyBank";
            this.txtInCompanyBank.ReadOnly = true;
            this.txtInCompanyBank.Size = new System.Drawing.Size(207, 22);
            this.txtInCompanyBank.TabIndex = 32;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(80, 154);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(483, 24);
            this.txtMemo.TabIndex = 37;
            this.txtMemo.TextChanged += new System.EventHandler(this.txtMemo_TextChanged);
            // 
            // txtInCompanyAccount
            // 
            this.txtInCompanyAccount.Location = new System.Drawing.Point(356, 126);
            this.txtInCompanyAccount.Name = "txtInCompanyAccount";
            this.txtInCompanyAccount.ReadOnly = true;
            this.txtInCompanyAccount.Size = new System.Drawing.Size(207, 22);
            this.txtInCompanyAccount.TabIndex = 35;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(356, 44);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 22);
            this.txtCode.TabIndex = 29;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "单据字";
            // 
            // txtOutCompanyBank
            // 
            this.txtOutCompanyBank.Location = new System.Drawing.Point(80, 100);
            this.txtOutCompanyBank.Name = "txtOutCompanyBank";
            this.txtOutCompanyBank.ReadOnly = true;
            this.txtOutCompanyBank.Size = new System.Drawing.Size(207, 22);
            this.txtOutCompanyBank.TabIndex = 33;
            // 
            // txtOutComapnyAccount
            // 
            this.txtOutComapnyAccount.Location = new System.Drawing.Point(80, 126);
            this.txtOutComapnyAccount.Name = "txtOutComapnyAccount";
            this.txtOutComapnyAccount.ReadOnly = true;
            this.txtOutComapnyAccount.Size = new System.Drawing.Size(207, 22);
            this.txtOutComapnyAccount.TabIndex = 31;
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
            this.tbSave,
            this.tbExit,
            this.tbNew,
            this.tbEdit,
            this.tbDelete});
            this.barManager1.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbEdit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbDelete, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbSave, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tbNew
            // 
            this.tbNew.Caption = "新增";
            this.tbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tbNew.Id = 2;
            this.tbNew.Name = "tbNew";
            this.tbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbNew_ItemClick);
            // 
            // tbEdit
            // 
            this.tbEdit.Caption = "编辑";
            this.tbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tbEdit.Id = 3;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbEdit_ItemClick);
            // 
            // tbDelete
            // 
            this.tbDelete.Caption = "删除";
            this.tbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tbDelete.Id = 4;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbDelete_ItemClick);
            // 
            // tbSave
            // 
            this.tbSave.Caption = "保存";
            this.tbSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.tbSave.Id = 0;
            this.tbSave.Name = "tbSave";
            this.tbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbSave_ItemClick);
            // 
            // tbExit
            // 
            this.tbExit.Caption = "退出";
            this.tbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tbExit.Id = 1;
            this.tbExit.Name = "tbExit";
            this.tbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(723, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Size = new System.Drawing.Size(723, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(723, 39);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(12, 212);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(699, 305);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.Transparent;
            this.c1SplitContainer1.TabIndex = 58;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.gridControl1);
            this.c1SplitterPanel1.Controls.Add(this.toolStrip3);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(534, 284);
            this.c1SplitterPanel1.SizeRatio = 76.835D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "明细";
            this.c1SplitterPanel1.Width = 534;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator3,
            this.tsbDelete});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(534, 25);
            this.toolStrip3.TabIndex = 42;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::Haimen.Properties.Resources.New_hot;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(52, 22);
            this.tsbNew.Text = "新增";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.c1SplitterPanel2.Controls.Add(this.lstFiles);
            this.c1SplitterPanel2.Controls.Add(this.toolStrip2);
            this.c1SplitterPanel2.Height = 100;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(538, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(161, 284);
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Text = "附件";
            // 
            // lstFiles
            // 
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.ImageList = this.imageList1;
            this.lstFiles.ItemHeight = 32;
            this.lstFiles.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageListBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageListBoxItem("asdfasdf", 1)});
            this.lstFiles.Location = new System.Drawing.Point(0, 25);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(161, 259);
            this.lstFiles.TabIndex = 63;
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ADOBE PSD.ico");
            this.imageList1.Images.SetKeyName(1, "AIF.ico");
            this.imageList1.Images.SetKeyName(2, "APF.ico");
            this.imageList1.Images.SetKeyName(3, "AU.ico");
            this.imageList1.Images.SetKeyName(4, "AVI.ico");
            this.imageList1.Images.SetKeyName(5, "AVIJ.ico");
            this.imageList1.Images.SetKeyName(6, "BINDER 002.ico");
            this.imageList1.Images.SetKeyName(7, "BLANK WORD DOC.ico");
            this.imageList1.Images.SetKeyName(8, "BMP.ico");
            this.imageList1.Images.SetKeyName(9, "BMP2.ico");
            this.imageList1.Images.SetKeyName(10, "BUDDY LIST FILE.ico");
            this.imageList1.Images.SetKeyName(11, "CDAJ.ico");
            this.imageList1.Images.SetKeyName(12, "CLASS.ico");
            this.imageList1.Images.SetKeyName(13, "CONFIGURATION .ico");
            this.imageList1.Images.SetKeyName(14, "CSS.ico");
            this.imageList1.Images.SetKeyName(15, "DEFAULT ICON.ico");
            this.imageList1.Images.SetKeyName(16, "DIVX.ico");
            this.imageList1.Images.SetKeyName(17, "DIVXJ.ico");
            this.imageList1.Images.SetKeyName(18, "DREAMWEAVER XP.ico");
            this.imageList1.Images.SetKeyName(19, "ERASER.ico");
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAttachNew,
            this.toolStripSeparator1,
            this.tsbAttachDelete});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(161, 25);
            this.toolStrip2.TabIndex = 43;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbAttachNew
            // 
            this.tsbAttachNew.Image = global::Haimen.Properties.Resources.New_hot;
            this.tsbAttachNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttachNew.Name = "tsbAttachNew";
            this.tsbAttachNew.Size = new System.Drawing.Size(52, 22);
            this.tsbAttachNew.Text = "新增";
            this.tsbAttachNew.Click += new System.EventHandler(this.tsbAttachNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAttachDelete
            // 
            this.tsbAttachDelete.Image = global::Haimen.Properties.Resources.Delete_hot;
            this.tsbAttachDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttachDelete.Name = "tsbAttachDelete";
            this.tsbAttachDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbAttachDelete.Text = "删除";
            this.tsbAttachDelete.Click += new System.EventHandler(this.tsbAttachDelete_Click);
            // 
            // DevAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 529);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.lueInCompany);
            this.Controls.Add(this.lookUpEdit6);
            this.Controls.Add(this.lookUpEdit5);
            this.Controls.Add(this.lueOutCompany);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtSigned);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInCompanyBank);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtInCompanyAccount);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutCompanyBank);
            this.Controls.Add(this.txtOutComapnyAccount);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevAccount";
            this.Text = "资金往来";
            this.Load += new System.EventHandler(this.DevAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luefunds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            this.c1SplitterPanel1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.c1SplitterPanel2.ResumeLayout(false);
            this.c1SplitterPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiles)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueInCompany;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit5;
        private DevExpress.XtraEditors.LookUpEdit lueOutCompany;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_funds_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit luefunds;
        private DevExpress.XtraGrid.Columns.GridColumn col_money;
        private DevExpress.XtraGrid.Columns.GridColumn col_usage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtSigned;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInCompanyBank;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtInCompanyAccount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOutCompanyBank;
        private System.Windows.Forms.TextBox txtOutComapnyAccount;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tbNew;
        private DevExpress.XtraBars.BarButtonItem tbEdit;
        private DevExpress.XtraBars.BarButtonItem tbDelete;
        private DevExpress.XtraBars.BarButtonItem tbSave;
        private DevExpress.XtraBars.BarButtonItem tbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbAttachNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbAttachDelete;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraEditors.ImageListBoxControl lstFiles;
        private System.Windows.Forms.ImageList imageList1;
    }
}