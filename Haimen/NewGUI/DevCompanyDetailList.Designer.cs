namespace Haimen.NewGUI
{
    partial class DevCompanyDetailList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("海门市兴临市政工程有限公司");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("海门市时运建筑工程有限公司");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("海门市兴临市政工程有限公司");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("海门江涌投资开发有限公司");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("海门市通江水业有限公司");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("海门临江生物医药科技创业园有限公司");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("南通临江新区滨江水务有限公司");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("海门沿江投资开发有限公司");
            DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tree = new System.Windows.Forms.TreeView();
            this.c_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_bank = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_balance = new DevExpress.XtraGrid.Columns.GridColumn();
            this.c_credit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.inplace_banks = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inplace_banks)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.c_id,
            this.c_bank,
            this.c_account,
            this.c_balance,
            this.c_credit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.inplace_banks});
            this.gridControl1.Size = new System.Drawing.Size(551, 375);
            this.gridControl1.TabIndex = 12;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(77, 74);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(447, 22);
            this.txtBank.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 48);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(447, 22);
            this.txtName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "名称";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(77, 101);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(447, 22);
            this.txtAccount.TabIndex = 6;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(167, 22);
            this.txtCode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "帐号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 10;
            this.label4.Text = "开户行";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "编号";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbDelete,
            this.tsbSave,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(551, 25);
            this.toolStrip2.TabIndex = 11;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(361, 22);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(163, 22);
            this.txtDoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "单据字";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.gridControl1);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(249, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 400);
            this.panel1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDoc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBank);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(248, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 128);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // tree
            // 
            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tree.Location = new System.Drawing.Point(11, 24);
            this.tree.Name = "tree";
            treeNode1.Name = "节点0";
            treeNode1.Text = "海门市兴临市政工程有限公司";
            treeNode2.Name = "节点1";
            treeNode2.Text = "海门市时运建筑工程有限公司";
            treeNode3.Name = "节点2";
            treeNode3.Text = "海门市兴临市政工程有限公司";
            treeNode4.Name = "节点3";
            treeNode4.Text = "海门江涌投资开发有限公司";
            treeNode5.Name = "节点4";
            treeNode5.Text = "海门市通江水业有限公司";
            treeNode6.Name = "节点5";
            treeNode6.Text = "海门临江生物医药科技创业园有限公司";
            treeNode7.Name = "节点6";
            treeNode7.Text = "南通临江新区滨江水务有限公司";
            treeNode8.Name = "节点7";
            treeNode8.Text = "海门沿江投资开发有限公司";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8});
            this.tree.Size = new System.Drawing.Size(231, 534);
            this.tree.TabIndex = 23;
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            // 
            // c_id
            // 
            this.c_id.Caption = "ID";
            repositoryItemLookUpEdit1.AutoHeight = false;
            repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            repositoryItemLookUpEdit1.LookAndFeel.SkinName = "Seven Classic";
            repositoryItemLookUpEdit1.Name = "inplace_banks";
            this.c_id.ColumnEdit = repositoryItemLookUpEdit1;
            this.c_id.FieldName = "ID";
            this.c_id.Name = "c_id";
            this.c_id.Width = 20;
            // 
            // c_bank
            // 
            this.c_bank.Caption = "银行";
            this.c_bank.ColumnEdit = repositoryItemLookUpEdit1;
            this.c_bank.FieldName = "Bank_ID";
            this.c_bank.Name = "c_bank";
            this.c_bank.Visible = true;
            this.c_bank.VisibleIndex = 0;
            // 
            // c_account
            // 
            this.c_account.Caption = "帐号";
            this.c_account.FieldName = "Account";
            this.c_account.Name = "c_account";
            this.c_account.Visible = true;
            this.c_account.VisibleIndex = 1;
            // 
            // c_balance
            // 
            this.c_balance.Caption = "余额";
            this.c_balance.DisplayFormat.FormatString = "N";
            this.c_balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_balance.FieldName = "Balance";
            this.c_balance.Name = "c_balance";
            this.c_balance.Visible = true;
            this.c_balance.VisibleIndex = 2;
            // 
            // c_credit
            // 
            this.c_credit.Caption = "贷款";
            this.c_credit.DisplayFormat.FormatString = "N";
            this.c_credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.c_credit.FieldName = "Credit";
            this.c_credit.Name = "c_credit";
            this.c_credit.Visible = true;
            this.c_credit.VisibleIndex = 3;
            // 
            // inplace_banks
            // 
            this.inplace_banks.AutoHeight = false;
            this.inplace_banks.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.inplace_banks.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "名称")});
            this.inplace_banks.Name = "inplace_banks";
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
            // tsbDelete
            // 
            this.tsbDelete.Image = global::Haimen.Properties.Resources.Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = global::Haimen.Properties.Resources.Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // DevCompanyDetailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tree);
            this.Name = "DevCompanyDetailList";
            this.Text = "DevCompanyDetailList";
            this.Load += new System.EventHandler(this.DevCompanyDetailList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inplace_banks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private DevExpress.XtraGrid.Columns.GridColumn c_credit;
        private DevExpress.XtraGrid.Columns.GridColumn c_balance;
        private DevExpress.XtraGrid.Columns.GridColumn c_account;
        private DevExpress.XtraGrid.Columns.GridColumn c_bank;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit inplace_banks;
        private DevExpress.XtraGrid.Columns.GridColumn c_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tree;
    }
}