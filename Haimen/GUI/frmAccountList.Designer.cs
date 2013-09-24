//namespace Haimen.GUI
//{
//    partial class frmAccountList
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
//            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
//            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_outcompany = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_outcompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_outcompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_incompany = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_incompany_bank = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_incompany_account = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_memo = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.col_signed = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.button1 = new System.Windows.Forms.Button();
//            this.checkBox3 = new System.Windows.Forms.CheckBox();
//            this.checkBox2 = new System.Windows.Forms.CheckBox();
//            this.checkBox1 = new System.Windows.Forms.CheckBox();
//            this.textBox1 = new System.Windows.Forms.TextBox();
//            this.textBox3 = new System.Windows.Forms.TextBox();
//            this.textBox2 = new System.Windows.Forms.TextBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.tsbExit = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
//            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbNewIn = new System.Windows.Forms.ToolStripButton();
//            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
//            this.tsbNewOut = new System.Windows.Forms.ToolStripButton();
//            this.tsbVerify = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
//            this.groupBox2 = new System.Windows.Forms.GroupBox();
//            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
//            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.gridColumn15 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
//            this.groupBox1.SuspendLayout();
//            this.toolStrip2.SuspendLayout();
//            this.groupBox2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // gridView2
//            // 
//            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.gridColumn11,
//            this.gridColumn12});
//            this.gridView2.GridControl = this.gridControl1;
//            this.gridView2.Name = "gridView2";
//            // 
//            // gridColumn11
//            // 
//            this.gridColumn11.Caption = "资金性质";
//            this.gridColumn11.FieldName = "Funds.Name";
//            this.gridColumn11.Name = "gridColumn11";
//            this.gridColumn11.Visible = true;
//            this.gridColumn11.VisibleIndex = 0;
//            // 
//            // gridColumn12
//            // 
//            this.gridColumn12.Caption = "金额";
//            this.gridColumn12.FieldName = "Money";
//            this.gridColumn12.Name = "gridColumn12";
//            this.gridColumn12.Visible = true;
//            this.gridColumn12.VisibleIndex = 1;
//            // 
//            // gridControl1
//            // 
//            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.gridControl1.DataSource = this.accountBindingSource;
//            this.gridControl1.Location = new System.Drawing.Point(3, 17);
//            this.gridControl1.MainView = this.gridView1;
//            this.gridControl1.Name = "gridControl1";
//            this.gridControl1.Size = new System.Drawing.Size(542, 371);
//            this.gridControl1.TabIndex = 23;
//            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView1,
//            this.gridView2});
//            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
//            // 
//            // accountBindingSource
//            // 
//            this.accountBindingSource.DataSource = typeof(Haimen.Entity.Account);
//            // 
//            // gridView1
//            // 
//            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.col_id,
//            this.col_code,
//            this.col_outcompany,
//            this.col_outcompany_bank,
//            this.col_outcompany_account,
//            this.col_incompany,
//            this.col_incompany_bank,
//            this.col_incompany_account,
//            this.col_memo,
//            this.col_signed});
//            this.gridView1.GridControl = this.gridControl1;
//            this.gridView1.Name = "gridView1";
//            this.gridView1.OptionsBehavior.Editable = false;
//            this.gridView1.OptionsView.ShowGroupPanel = false;
//            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
//            // 
//            // col_id
//            // 
//            this.col_id.Caption = "ID";
//            this.col_id.FieldName = "ID";
//            this.col_id.Name = "col_id";
//            this.col_id.Visible = true;
//            this.col_id.VisibleIndex = 0;
//            // 
//            // col_code
//            // 
//            this.col_code.Caption = "单据字";
//            this.col_code.FieldName = "Code";
//            this.col_code.Name = "col_code";
//            this.col_code.Visible = true;
//            this.col_code.VisibleIndex = 1;
//            // 
//            // col_outcompany
//            // 
//            this.col_outcompany.Caption = "付款单位";
//            this.col_outcompany.FieldName = "OutCompany.Name";
//            this.col_outcompany.Name = "col_outcompany";
//            this.col_outcompany.Visible = true;
//            this.col_outcompany.VisibleIndex = 2;
//            // 
//            // col_outcompany_bank
//            // 
//            this.col_outcompany_bank.Caption = "开户行";
//            this.col_outcompany_bank.FieldName = "OutCompany.Bank.Name";
//            this.col_outcompany_bank.Name = "col_outcompany_bank";
//            this.col_outcompany_bank.Visible = true;
//            this.col_outcompany_bank.VisibleIndex = 3;
//            // 
//            // col_outcompany_account
//            // 
//            this.col_outcompany_account.Caption = "帐号";
//            this.col_outcompany_account.FieldName = "OutCompany.Account";
//            this.col_outcompany_account.Name = "col_outcompany_account";
//            this.col_outcompany_account.Visible = true;
//            this.col_outcompany_account.VisibleIndex = 4;
//            // 
//            // col_incompany
//            // 
//            this.col_incompany.Caption = "收款单位";
//            this.col_incompany.FieldName = "InCompany.Name";
//            this.col_incompany.Name = "col_incompany";
//            this.col_incompany.Visible = true;
//            this.col_incompany.VisibleIndex = 5;
//            // 
//            // col_incompany_bank
//            // 
//            this.col_incompany_bank.Caption = "开户行";
//            this.col_incompany_bank.FieldName = "InCompnay.Bank.Name";
//            this.col_incompany_bank.Name = "col_incompany_bank";
//            this.col_incompany_bank.Visible = true;
//            this.col_incompany_bank.VisibleIndex = 6;
//            // 
//            // col_incompany_account
//            // 
//            this.col_incompany_account.Caption = "帐号";
//            this.col_incompany_account.FieldName = "InCompany.Account";
//            this.col_incompany_account.Name = "col_incompany_account";
//            this.col_incompany_account.Visible = true;
//            this.col_incompany_account.VisibleIndex = 7;
//            // 
//            // col_memo
//            // 
//            this.col_memo.Caption = "备注";
//            this.col_memo.FieldName = "Memo";
//            this.col_memo.Name = "col_memo";
//            this.col_memo.Visible = true;
//            this.col_memo.VisibleIndex = 8;
//            // 
//            // col_signed
//            // 
//            this.col_signed.Caption = "签订日期";
//            this.col_signed.FieldName = "SignedDate";
//            this.col_signed.Name = "col_signed";
//            this.col_signed.Visible = true;
//            this.col_signed.VisibleIndex = 9;
//            // 
//            // button1
//            // 
//            this.button1.Location = new System.Drawing.Point(646, 38);
//            this.button1.Name = "button1";
//            this.button1.Size = new System.Drawing.Size(75, 23);
//            this.button1.TabIndex = 22;
//            this.button1.Text = "查询";
//            this.button1.UseVisualStyleBackColor = true;
//            // 
//            // checkBox3
//            // 
//            this.checkBox3.AutoSize = true;
//            this.checkBox3.Location = new System.Drawing.Point(467, 58);
//            this.checkBox3.Name = "checkBox3";
//            this.checkBox3.Size = new System.Drawing.Size(60, 16);
//            this.checkBox3.TabIndex = 6;
//            this.checkBox3.Text = "已结清";
//            this.checkBox3.UseVisualStyleBackColor = true;
//            // 
//            // checkBox2
//            // 
//            this.checkBox2.AutoSize = true;
//            this.checkBox2.Checked = true;
//            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
//            this.checkBox2.Location = new System.Drawing.Point(467, 36);
//            this.checkBox2.Name = "checkBox2";
//            this.checkBox2.Size = new System.Drawing.Size(60, 16);
//            this.checkBox2.TabIndex = 6;
//            this.checkBox2.Text = "还贷中";
//            this.checkBox2.UseVisualStyleBackColor = true;
//            // 
//            // checkBox1
//            // 
//            this.checkBox1.AutoSize = true;
//            this.checkBox1.Checked = true;
//            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
//            this.checkBox1.Location = new System.Drawing.Point(467, 14);
//            this.checkBox1.Name = "checkBox1";
//            this.checkBox1.Size = new System.Drawing.Size(60, 16);
//            this.checkBox1.TabIndex = 6;
//            this.checkBox1.Text = "未审核";
//            this.checkBox1.UseVisualStyleBackColor = true;
//            // 
//            // textBox1
//            // 
//            this.textBox1.Location = new System.Drawing.Point(49, 20);
//            this.textBox1.Name = "textBox1";
//            this.textBox1.Size = new System.Drawing.Size(151, 21);
//            this.textBox1.TabIndex = 3;
//            // 
//            // textBox3
//            // 
//            this.textBox3.Location = new System.Drawing.Point(49, 48);
//            this.textBox3.Name = "textBox3";
//            this.textBox3.Size = new System.Drawing.Size(151, 21);
//            this.textBox3.TabIndex = 5;
//            // 
//            // textBox2
//            // 
//            this.textBox2.Location = new System.Drawing.Point(253, 20);
//            this.textBox2.Name = "textBox2";
//            this.textBox2.Size = new System.Drawing.Size(151, 21);
//            this.textBox2.TabIndex = 5;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(19, 51);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(29, 12);
//            this.label3.TabIndex = 4;
//            this.label3.Text = "单位";
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(14, 23);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(29, 12);
//            this.label1.TabIndex = 2;
//            this.label1.Text = "编号";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(218, 23);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(29, 12);
//            this.label2.TabIndex = 4;
//            this.label2.Text = "银行";
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.checkBox3);
//            this.groupBox1.Controls.Add(this.checkBox2);
//            this.groupBox1.Controls.Add(this.checkBox1);
//            this.groupBox1.Controls.Add(this.textBox1);
//            this.groupBox1.Controls.Add(this.textBox3);
//            this.groupBox1.Controls.Add(this.textBox2);
//            this.groupBox1.Controls.Add(this.label3);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Location = new System.Drawing.Point(12, 28);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(596, 86);
//            this.groupBox1.TabIndex = 21;
//            this.groupBox1.TabStop = false;
//            // 
//            // tsbExit
//            // 
//            this.tsbExit.Image = global::Haimen.Properties.Resources.Exit;
//            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbExit.Name = "tsbExit";
//            this.tsbExit.Size = new System.Drawing.Size(52, 22);
//            this.tsbExit.Text = "退出";
//            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
//            // 
//            // toolStripSeparator2
//            // 
//            this.toolStripSeparator2.Name = "toolStripSeparator2";
//            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
//            // 
//            // tsbDelete
//            // 
//            this.tsbDelete.Image = global::Haimen.Properties.Resources.Delete;
//            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbDelete.Name = "tsbDelete";
//            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
//            this.tsbDelete.Text = "删除";
//            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
//            // 
//            // tsbEdit
//            // 
//            this.tsbEdit.Image = global::Haimen.Properties.Resources.Edit;
//            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbEdit.Name = "tsbEdit";
//            this.tsbEdit.Size = new System.Drawing.Size(52, 22);
//            this.tsbEdit.Text = "修改";
//            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
//            // 
//            // toolStripSeparator1
//            // 
//            this.toolStripSeparator1.Name = "toolStripSeparator1";
//            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
//            // 
//            // tsbNewIn
//            // 
//            this.tsbNewIn.Image = global::Haimen.Properties.Resources.New;
//            this.tsbNewIn.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbNewIn.Name = "tsbNewIn";
//            this.tsbNewIn.Size = new System.Drawing.Size(100, 22);
//            this.tsbNewIn.Text = "新增资金收入";
//            this.tsbNewIn.Click += new System.EventHandler(this.tsbNewIn_Click);
//            // 
//            // toolStrip2
//            // 
//            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsbNewOut,
//            this.tsbNewIn,
//            this.toolStripSeparator1,
//            this.tsbEdit,
//            this.tsbDelete,
//            this.toolStripSeparator2,
//            this.tsbVerify,
//            this.toolStripSeparator3,
//            this.tsbExit});
//            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
//            this.toolStrip2.Name = "toolStrip2";
//            this.toolStrip2.Size = new System.Drawing.Size(848, 25);
//            this.toolStrip2.TabIndex = 20;
//            this.toolStrip2.Text = "toolStrip2";
//            // 
//            // tsbNewOut
//            // 
//            this.tsbNewOut.Image = global::Haimen.Properties.Resources.Work_Sheet;
//            this.tsbNewOut.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbNewOut.Name = "tsbNewOut";
//            this.tsbNewOut.Size = new System.Drawing.Size(100, 22);
//            this.tsbNewOut.Text = "新增资金支付";
//            this.tsbNewOut.Click += new System.EventHandler(this.tsbNewOut_Click);
//            // 
//            // tsbVerify
//            // 
//            this.tsbVerify.Image = global::Haimen.Properties.Resources.Zoom_In;
//            this.tsbVerify.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbVerify.Name = "tsbVerify";
//            this.tsbVerify.Size = new System.Drawing.Size(52, 22);
//            this.tsbVerify.Text = "审核";
//            this.tsbVerify.Click += new System.EventHandler(this.tsbVerify_Click);
//            // 
//            // toolStripSeparator3
//            // 
//            this.toolStripSeparator3.Name = "toolStripSeparator3";
//            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
//            // 
//            // groupBox2
//            // 
//            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.groupBox2.Controls.Add(this.gridControl2);
//            this.groupBox2.Controls.Add(this.gridControl1);
//            this.groupBox2.Location = new System.Drawing.Point(12, 120);
//            this.groupBox2.Name = "groupBox2";
//            this.groupBox2.Size = new System.Drawing.Size(824, 391);
//            this.groupBox2.TabIndex = 24;
//            this.groupBox2.TabStop = false;
//            // 
//            // gridControl2
//            // 
//            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            gridLevelNode2.RelationName = "Level1";
//            this.gridControl2.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
//            gridLevelNode2});
//            this.gridControl2.Location = new System.Drawing.Point(551, 17);
//            this.gridControl2.MainView = this.gridView3;
//            this.gridControl2.Name = "gridControl2";
//            this.gridControl2.Size = new System.Drawing.Size(273, 371);
//            this.gridControl2.TabIndex = 25;
//            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView3});
//            // 
//            // gridView3
//            // 
//            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.gridColumn15,
//            this.gridColumn13,
//            this.gridColumn14});
//            this.gridView3.GridControl = this.gridControl2;
//            this.gridView3.Name = "gridView3";
//            this.gridView3.OptionsBehavior.Editable = false;
//            this.gridView3.OptionsView.ShowGroupPanel = false;
//            // 
//            // gridColumn15
//            // 
//            this.gridColumn15.Caption = "资金性质";
//            this.gridColumn15.FieldName = "Funds.Name";
//            this.gridColumn15.Name = "gridColumn15";
//            this.gridColumn15.Visible = true;
//            this.gridColumn15.VisibleIndex = 2;
//            // 
//            // gridColumn13
//            // 
//            this.gridColumn13.Caption = "金额";
//            this.gridColumn13.FieldName = "Money";
//            this.gridColumn13.Name = "gridColumn13";
//            this.gridColumn13.Visible = true;
//            this.gridColumn13.VisibleIndex = 0;
//            // 
//            // gridColumn14
//            // 
//            this.gridColumn14.Caption = "用途";
//            this.gridColumn14.FieldName = "Usage";
//            this.gridColumn14.Name = "gridColumn14";
//            this.gridColumn14.Visible = true;
//            this.gridColumn14.VisibleIndex = 1;
//            // 
//            // frmAccountList
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(848, 523);
//            this.Controls.Add(this.groupBox2);
//            this.Controls.Add(this.button1);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.toolStrip2);
//            this.Name = "frmAccountList";
//            this.Text = "资金查询";
//            this.Load += new System.EventHandler(this.frmAccountList_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            this.toolStrip2.ResumeLayout(false);
//            this.toolStrip2.PerformLayout();
//            this.groupBox2.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Button button1;
//        private System.Windows.Forms.CheckBox checkBox3;
//        private System.Windows.Forms.CheckBox checkBox2;
//        private System.Windows.Forms.CheckBox checkBox1;
//        private System.Windows.Forms.TextBox textBox1;
//        private System.Windows.Forms.TextBox textBox3;
//        private System.Windows.Forms.TextBox textBox2;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.ToolStripButton tsbExit;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
//        private System.Windows.Forms.ToolStripButton tsbDelete;
//        private System.Windows.Forms.ToolStripButton tsbEdit;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripButton tsbNewIn;
//        private System.Windows.Forms.ToolStrip toolStrip2;
//        private System.Windows.Forms.ToolStripButton tsbNewOut;
//        private System.Windows.Forms.ToolStripButton tsbVerify;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
//        private DevExpress.XtraGrid.GridControl gridControl1;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
//        private System.Windows.Forms.GroupBox groupBox2;
//        private DevExpress.XtraGrid.Columns.GridColumn col_id;
//        private DevExpress.XtraGrid.Columns.GridColumn col_code;
//        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany;
//        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_bank;
//        private DevExpress.XtraGrid.Columns.GridColumn col_outcompany_account;
//        private DevExpress.XtraGrid.Columns.GridColumn col_incompany;
//        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_bank;
//        private DevExpress.XtraGrid.Columns.GridColumn col_incompany_account;
//        private DevExpress.XtraGrid.Columns.GridColumn col_memo;
//        private DevExpress.XtraGrid.Columns.GridColumn col_signed;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
//        private System.Windows.Forms.BindingSource accountBindingSource;
//        private DevExpress.XtraGrid.GridControl gridControl2;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn15;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;

//    }
//}