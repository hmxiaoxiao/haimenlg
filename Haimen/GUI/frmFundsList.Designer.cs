//namespace Haimen.GUI
//{
//    partial class frmFundsList
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
//            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("管理费用");
//            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("主营业成本 ");
//            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("支出", new System.Windows.Forms.TreeNode[] {
//            treeNode29,
//            treeNode30});
//            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("往来款");
//            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("贷款流程");
//            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("内部资金调动");
//            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("全部资料 ", new System.Windows.Forms.TreeNode[] {
//            treeNode31,
//            treeNode32,
//            treeNode33,
//            treeNode34});
//            this.tree = new System.Windows.Forms.TreeView();
//            this.txtQName = new System.Windows.Forms.TextBox();
//            this.tsbExit = new System.Windows.Forms.ToolStripButton();
//            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
//            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
//            this.tsbNew = new System.Windows.Forms.ToolStripButton();
//            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
//            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
//            this.label2 = new System.Windows.Forms.Label();
//            this.btnQuery = new System.Windows.Forms.Button();
//            this.grid = new System.Windows.Forms.DataGridView();
//            this.col_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
//            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.toolStrip2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // tree
//            // 
//            this.tree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left)));
//            this.tree.Location = new System.Drawing.Point(12, 55);
//            this.tree.Name = "tree";
//            treeNode29.Name = "节点5";
//            treeNode29.Text = "管理费用";
//            treeNode30.Name = "节点6";
//            treeNode30.Text = "主营业成本 ";
//            treeNode31.Name = "节点1";
//            treeNode31.Text = "支出";
//            treeNode32.Name = "节点2";
//            treeNode32.Text = "往来款";
//            treeNode33.Name = "节点3";
//            treeNode33.Text = "贷款流程";
//            treeNode34.Name = "节点4";
//            treeNode34.Text = "内部资金调动";
//            treeNode35.Name = "节点0";
//            treeNode35.Text = "全部资料 ";
//            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
//            treeNode35});
//            this.tree.Size = new System.Drawing.Size(151, 331);
//            this.tree.TabIndex = 18;
//            // 
//            // txtQName
//            // 
//            this.txtQName.Location = new System.Drawing.Point(53, 28);
//            this.txtQName.Name = "txtQName";
//            this.txtQName.Size = new System.Drawing.Size(151, 21);
//            this.txtQName.TabIndex = 5;
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
//            // tsbNew
//            // 
//            this.tsbNew.Image = global::Haimen.Properties.Resources.New;
//            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbNew.Name = "tsbNew";
//            this.tsbNew.Size = new System.Drawing.Size(52, 22);
//            this.tsbNew.Text = "新增";
//            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
//            // 
//            // toolStrip2
//            // 
//            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
//            this.tsbNew,
//            this.toolStripSeparator1,
//            this.tsbEdit,
//            this.tsbDelete,
//            this.toolStripSeparator2,
//            this.tsbExit});
//            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
//            this.toolStrip2.Name = "toolStrip2";
//            this.toolStrip2.Size = new System.Drawing.Size(528, 25);
//            this.toolStrip2.TabIndex = 14;
//            this.toolStrip2.Text = "toolStrip2";
//            // 
//            // toolStripSeparator1
//            // 
//            this.toolStripSeparator1.Name = "toolStripSeparator1";
//            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
//            // 
//            // toolStripSeparator2
//            // 
//            this.toolStripSeparator2.Name = "toolStripSeparator2";
//            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(10, 31);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(29, 12);
//            this.label2.TabIndex = 4;
//            this.label2.Text = "名称";
//            // 
//            // btnQuery
//            // 
//            this.btnQuery.Location = new System.Drawing.Point(210, 28);
//            this.btnQuery.Name = "btnQuery";
//            this.btnQuery.Size = new System.Drawing.Size(75, 23);
//            this.btnQuery.TabIndex = 16;
//            this.btnQuery.Text = "查询";
//            this.btnQuery.UseVisualStyleBackColor = true;
//            // 
//            // grid
//            // 
//            this.grid.AllowUserToAddRows = false;
//            this.grid.AllowUserToDeleteRows = false;
//            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.col_selected,
//            this.col_id,
//            this.col_name});
//            this.grid.Location = new System.Drawing.Point(169, 57);
//            this.grid.Name = "grid";
//            this.grid.RowTemplate.Height = 23;
//            this.grid.Size = new System.Drawing.Size(347, 329);
//            this.grid.TabIndex = 17;
//            // 
//            // col_selected
//            // 
//            this.col_selected.HeaderText = "选择";
//            this.col_selected.Name = "col_selected";
//            // 
//            // col_id
//            // 
//            this.col_id.HeaderText = "ID";
//            this.col_id.Name = "col_id";
//            this.col_id.Visible = false;
//            // 
//            // col_name
//            // 
//            this.col_name.HeaderText = "名称";
//            this.col_name.Name = "col_name";
//            this.col_name.ReadOnly = true;
//            // 
//            // frmFundsList
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(528, 398);
//            this.Controls.Add(this.txtQName);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.tree);
//            this.Controls.Add(this.toolStrip2);
//            this.Controls.Add(this.btnQuery);
//            this.Controls.Add(this.grid);
//            this.Name = "frmFundsList";
//            this.Text = "资金性质列表";
//            this.Load += new System.EventHandler(this.frmFundsList_Load);
//            this.toolStrip2.ResumeLayout(false);
//            this.toolStrip2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.TreeView tree;
//        private System.Windows.Forms.TextBox txtQName;
//        private System.Windows.Forms.ToolStripButton tsbExit;
//        private System.Windows.Forms.ToolStripButton tsbDelete;
//        private System.Windows.Forms.ToolStripButton tsbEdit;
//        private System.Windows.Forms.ToolStripButton tsbNew;
//        private System.Windows.Forms.ToolStrip toolStrip2;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button btnQuery;
//        private System.Windows.Forms.DataGridView grid;
//        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selected;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
//    }
//}