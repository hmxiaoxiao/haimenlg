namespace Haimen.NewGUI
{
    partial class DevContract
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevContract));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.lueCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtSignedDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtPayment_ratio = new System.Windows.Forms.TextBox();
            this.txtSecurity = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.tbNew = new DevExpress.XtraBars.BarButtonItem();
            this.tbEdit = new DevExpress.XtraBars.BarButtonItem();
            this.tbDelete = new DevExpress.XtraBars.BarButtonItem();
            this.tbSave = new DevExpress.XtraBars.BarButtonItem();
            this.tbCheck = new DevExpress.XtraBars.BarButtonItem();
            this.tbExit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.lstFiles = new DevExpress.XtraEditors.ImageListBoxControl();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.tsbAttachNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAttachDelete = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.c1SplitterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstFiles)).BeginInit();
            this.toolStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "日期";
            this.gridColumn1.ColumnEdit = this.repositoryItemDateEdit1;
            this.gridColumn1.DisplayFormat.FormatString = "d";
            this.gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn1.FieldName = "PayDate";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F4);
            this.repositoryItemDateEdit1.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Default;
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "付款金额";
            this.gridColumn2.DisplayFormat.FormatString = "N";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "Money";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1});
            this.gridControl1.Size = new System.Drawing.Size(625, 208);
            this.gridControl1.TabIndex = 16;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // lueCompany
            // 
            this.lueCompany.Location = new System.Drawing.Point(345, 44);
            this.lueCompany.Name = "lueCompany";
            this.lueCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueCompany.Properties.NullText = "请选择单位";
            this.lueCompany.Size = new System.Drawing.Size(207, 20);
            this.lueCompany.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "支付比例";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(297, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "保证金";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(33, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "备注";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 14);
            this.label7.TabIndex = 25;
            this.label7.Text = "金额";
            // 
            // dtEndDate
            // 
            this.dtEndDate.Location = new System.Drawing.Point(68, 155);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(158, 22);
            this.dtEndDate.TabIndex = 23;
            // 
            // dtBeginDate
            // 
            this.dtBeginDate.Location = new System.Drawing.Point(68, 127);
            this.dtBeginDate.Name = "dtBeginDate";
            this.dtBeginDate.Size = new System.Drawing.Size(158, 22);
            this.dtBeginDate.TabIndex = 24;
            // 
            // dtSignedDate
            // 
            this.dtSignedDate.Location = new System.Drawing.Point(68, 99);
            this.dtSignedDate.Name = "dtSignedDate";
            this.dtSignedDate.Size = new System.Drawing.Size(158, 22);
            this.dtSignedDate.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "结束日期";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "开始日期";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(68, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 22);
            this.txtName.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "签订日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "合同名称";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(68, 183);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(483, 100);
            this.txtMemo.TabIndex = 18;
            // 
            // txtPayment_ratio
            // 
            this.txtPayment_ratio.Location = new System.Drawing.Point(344, 155);
            this.txtPayment_ratio.Name = "txtPayment_ratio";
            this.txtPayment_ratio.Size = new System.Drawing.Size(207, 22);
            this.txtPayment_ratio.TabIndex = 17;
            // 
            // txtSecurity
            // 
            this.txtSecurity.Location = new System.Drawing.Point(344, 127);
            this.txtSecurity.Name = "txtSecurity";
            this.txtSecurity.Size = new System.Drawing.Size(207, 22);
            this.txtSecurity.TabIndex = 16;
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(344, 99);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(207, 22);
            this.txtMoney.TabIndex = 15;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(68, 44);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(158, 22);
            this.txtCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "合同编号";
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
            this.tbNew,
            this.tbEdit,
            this.tbDelete,
            this.tbCheck,
            this.tbSave,
            this.tbExit});
            this.barManager1.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbCheck, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // tbNew
            // 
            this.tbNew.Caption = "新增";
            this.tbNew.Glyph = global::Haimen.Properties.Resources.New_hot;
            this.tbNew.Id = 0;
            this.tbNew.Name = "tbNew";
            this.tbNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbNew_ItemClick);
            // 
            // tbEdit
            // 
            this.tbEdit.Caption = "编辑";
            this.tbEdit.Glyph = global::Haimen.Properties.Resources.Edit_hot;
            this.tbEdit.Id = 1;
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbEdit_ItemClick);
            // 
            // tbDelete
            // 
            this.tbDelete.Caption = "删除";
            this.tbDelete.Glyph = global::Haimen.Properties.Resources.Delete_hot;
            this.tbDelete.Id = 2;
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbDelete_ItemClick);
            // 
            // tbSave
            // 
            this.tbSave.Caption = "保存";
            this.tbSave.Glyph = global::Haimen.Properties.Resources.Save_hot;
            this.tbSave.Id = 4;
            this.tbSave.Name = "tbSave";
            this.tbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbSave_ItemClick);
            // 
            // tbCheck
            // 
            this.tbCheck.Caption = "审核";
            this.tbCheck.Glyph = global::Haimen.Properties.Resources.Certificate_hot;
            this.tbCheck.Id = 3;
            this.tbCheck.Name = "tbCheck";
            this.tbCheck.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbCheck_ItemClick);
            // 
            // tbExit
            // 
            this.tbExit.Caption = "退出";
            this.tbExit.Glyph = global::Haimen.Properties.Resources.Exit_hot;
            this.tbExit.Id = 5;
            this.tbExit.Name = "tbExit";
            this.tbExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbExit_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(832, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 555);
            this.barDockControlBottom.Size = new System.Drawing.Size(832, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 518);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(832, 37);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 518);
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1SplitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(150)))));
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.c1SplitContainer1.Location = new System.Drawing.Point(12, 289);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(808, 254);
            this.c1SplitContainer1.TabIndex = 38;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.gridControl1);
            this.c1SplitterPanel1.Controls.Add(this.toolStrip3);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 21);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(625, 233);
            this.c1SplitterPanel1.SizeRatio = 77.718D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Text = "明细";
            this.c1SplitterPanel1.Width = 625;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbDelete});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(625, 25);
            this.toolStrip3.TabIndex = 0;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.c1SplitterPanel2.Controls.Add(this.lstFiles);
            this.c1SplitterPanel2.Controls.Add(this.toolStrip4);
            this.c1SplitterPanel2.Height = 100;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(629, 21);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(179, 233);
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Text = "附件";
            // 
            // lstFiles
            // 
            this.lstFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstFiles.Location = new System.Drawing.Point(0, 25);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(179, 208);
            this.lstFiles.TabIndex = 1;
            this.lstFiles.DoubleClick += new System.EventHandler(this.lstFiles_DoubleClick);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAttachNew,
            this.toolStripSeparator2,
            this.tsbAttachDelete});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(179, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // DevContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 555);
            this.Controls.Add(this.c1SplitContainer1);
            this.Controls.Add(this.lueCompany);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtEndDate);
            this.Controls.Add(this.dtBeginDate);
            this.Controls.Add(this.dtSignedDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtPayment_ratio);
            this.Controls.Add(this.txtSecurity);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DevContract";
            this.Text = "合同编辑";
            this.Load += new System.EventHandler(this.DevContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCompany.Properties)).EndInit();
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
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.LookUpEdit lueCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.DateTimePicker dtBeginDate;
        private System.Windows.Forms.DateTimePicker dtSignedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtPayment_ratio;
        private System.Windows.Forms.TextBox txtSecurity;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem tbNew;
        private DevExpress.XtraBars.BarButtonItem tbEdit;
        private DevExpress.XtraBars.BarButtonItem tbDelete;
        private DevExpress.XtraBars.BarButtonItem tbSave;
        private DevExpress.XtraBars.BarButtonItem tbCheck;
        private DevExpress.XtraBars.BarButtonItem tbExit;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbAttachNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAttachDelete;
        private DevExpress.XtraEditors.ImageListBoxControl lstFiles;
        private System.Windows.Forms.ImageList imageList1;
    }
}