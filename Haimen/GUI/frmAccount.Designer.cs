namespace Haimen.GUI
{
    partial class frmAccount
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAttachNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAttachDelete = new System.Windows.Forms.ToolStripButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inplace_funds = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.label10 = new System.Windows.Forms.Label();
            this.dtSigned = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtInCompanyAccount = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOutComapnyAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lueOutCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lueInCompany = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit5 = new DevExpress.XtraEditors.LookUpEdit();
            this.lookUpEdit6 = new DevExpress.XtraEditors.LookUpEdit();
            this.txtOutCompanyBank = new System.Windows.Forms.TextBox();
            this.txtInCompanyBank = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inplace_funds)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAttachNew,
            this.toolStripSeparator2,
            this.tsbAttachDelete});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(184, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAttachNew
            // 
            this.tsbAttachNew.Image = global::Haimen.Properties.Resources.New;
            this.tsbAttachNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttachNew.Name = "tsbAttachNew";
            this.tsbAttachNew.Size = new System.Drawing.Size(52, 22);
            this.tsbAttachNew.Text = "新增";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbAttachDelete
            // 
            this.tsbAttachDelete.Image = global::Haimen.Properties.Resources.Delete;
            this.tsbAttachDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAttachDelete.Name = "tsbAttachDelete";
            this.tsbAttachDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbAttachDelete.Text = "删除";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(588, 37);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 23);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.treeView1);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Location = new System.Drawing.Point(506, 183);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 307);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "附件";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 42);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(184, 262);
            this.treeView1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 27;
            this.label7.Text = "帐户";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(588, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Location = new System.Drawing.Point(8, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 307);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "明细";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 42);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inplace_funds});
            this.gridControl1.Size = new System.Drawing.Size(486, 262);
            this.gridControl1.TabIndex = 13;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "资金性质";
            this.gridColumn1.ColumnEdit = this.inplace_funds;
            this.gridColumn1.FieldName = "Funds_ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // inplace_funds
            // 
            this.inplace_funds.AutoHeight = false;
            this.inplace_funds.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inplace_funds.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.inplace_funds.Name = "inplace_funds";
            this.inplace_funds.NullText = "请选择资金性质";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "金额";
            this.gridColumn2.FieldName = "Money";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用途";
            this.gridColumn3.FieldName = "Usage";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbDelete});
            this.toolStrip2.Location = new System.Drawing.Point(3, 17);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(486, 25);
            this.toolStrip2.TabIndex = 15;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tsbNew
            // 
            this.tsbNew.Image = global::Haimen.Properties.Resources.New;
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
            this.tsbDelete.Image = global::Haimen.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "备注";
            // 
            // dtSigned
            // 
            this.dtSigned.Location = new System.Drawing.Point(85, 15);
            this.dtSigned.Name = "dtSigned";
            this.dtSigned.Size = new System.Drawing.Size(207, 21);
            this.dtSigned.TabIndex = 1;
            this.dtSigned.ValueChanged += new System.EventHandler(this.dtSigned_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "收款单位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "签订日期";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(85, 125);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(483, 24);
            this.txtMemo.TabIndex = 9;
            this.txtMemo.TextChanged += new System.EventHandler(this.txtMemo_TextChanged);
            // 
            // txtInCompanyAccount
            // 
            this.txtInCompanyAccount.Location = new System.Drawing.Point(361, 97);
            this.txtInCompanyAccount.Name = "txtInCompanyAccount";
            this.txtInCompanyAccount.ReadOnly = true;
            this.txtInCompanyAccount.Size = new System.Drawing.Size(207, 21);
            this.txtInCompanyAccount.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(361, 15);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 21);
            this.txtCode.TabIndex = 2;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "单据字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 20;
            this.label3.Text = "开户行";
            // 
            // txtOutComapnyAccount
            // 
            this.txtOutComapnyAccount.Location = new System.Drawing.Point(85, 97);
            this.txtOutComapnyAccount.Name = "txtOutComapnyAccount";
            this.txtOutComapnyAccount.ReadOnly = true;
            this.txtOutComapnyAccount.Size = new System.Drawing.Size(207, 21);
            this.txtOutComapnyAccount.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "付款单位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "开户行";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 27;
            this.label8.Text = "帐户";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(302, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "合同编号";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 27;
            this.label11.Text = "贷款编号";
            // 
            // lueOutCompany
            // 
            this.lueOutCompany.Location = new System.Drawing.Point(85, 44);
            this.lueOutCompany.Name = "lueOutCompany";
            this.lueOutCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueOutCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueOutCompany.Properties.NullText = "请选择付款单位";
            this.lueOutCompany.Size = new System.Drawing.Size(207, 20);
            this.lueOutCompany.TabIndex = 3;
            this.lueOutCompany.EditValueChanged += new System.EventHandler(this.lueOutCompany_EditValueChanged);
            // 
            // lueInCompany
            // 
            this.lueInCompany.Location = new System.Drawing.Point(361, 44);
            this.lueInCompany.Name = "lueInCompany";
            this.lueInCompany.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueInCompany.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.lueInCompany.Properties.NullText = "请选择收款单位";
            this.lueInCompany.Size = new System.Drawing.Size(207, 20);
            this.lueInCompany.TabIndex = 6;
            this.lueInCompany.EditValueChanged += new System.EventHandler(this.lueInCompany_EditValueChanged);
            // 
            // lookUpEdit5
            // 
            this.lookUpEdit5.Location = new System.Drawing.Point(85, 157);
            this.lookUpEdit5.Name = "lookUpEdit5";
            this.lookUpEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit5.Properties.NullText = "请选择代码编号";
            this.lookUpEdit5.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit5.TabIndex = 10;
            // 
            // lookUpEdit6
            // 
            this.lookUpEdit6.Location = new System.Drawing.Point(361, 157);
            this.lookUpEdit6.Name = "lookUpEdit6";
            this.lookUpEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit6.Properties.NullText = "请选择合同号";
            this.lookUpEdit6.Size = new System.Drawing.Size(207, 20);
            this.lookUpEdit6.TabIndex = 11;
            // 
            // txtOutCompanyBank
            // 
            this.txtOutCompanyBank.Location = new System.Drawing.Point(85, 71);
            this.txtOutCompanyBank.Name = "txtOutCompanyBank";
            this.txtOutCompanyBank.ReadOnly = true;
            this.txtOutCompanyBank.Size = new System.Drawing.Size(207, 21);
            this.txtOutCompanyBank.TabIndex = 5;
            // 
            // txtInCompanyBank
            // 
            this.txtInCompanyBank.Location = new System.Drawing.Point(361, 71);
            this.txtInCompanyBank.Name = "txtInCompanyBank";
            this.txtInCompanyBank.ReadOnly = true;
            this.txtInCompanyBank.Size = new System.Drawing.Size(207, 21);
            this.txtInCompanyBank.TabIndex = 5;
            // 
            // frmAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(708, 502);
            this.Controls.Add(this.lueInCompany);
            this.Controls.Add(this.lookUpEdit6);
            this.Controls.Add(this.lookUpEdit5);
            this.Controls.Add(this.lueOutCompany);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtSigned);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtInCompanyBank);
            this.Controls.Add(this.txtOutCompanyBank);
            this.Controls.Add(this.txtOutComapnyAccount);
            this.Controls.Add(this.txtMemo);
            this.Controls.Add(this.txtInCompanyAccount);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "frmAccount";
            this.Text = "资金支付";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inplace_funds)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueOutCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueInCompany.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAttachNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbAttachDelete;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtSigned;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtInCompanyAccount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOutComapnyAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TreeView treeView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lueOutCompany;
        private DevExpress.XtraEditors.LookUpEdit lueInCompany;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit5;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit inplace_funds;
        private System.Windows.Forms.TextBox txtOutCompanyBank;
        private System.Windows.Forms.TextBox txtInCompanyBank;
    }
}