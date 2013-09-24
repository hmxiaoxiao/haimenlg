//namespace Haimen.GUI
//{
//    partial class frmBankList
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
//            this.treeBank = new System.Windows.Forms.TreeView();
//            this.txtName = new System.Windows.Forms.TextBox();
//            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
//            this.tsbNew = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
//            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbExit = new System.Windows.Forms.ToolStripButton();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.txtCode = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.btnQuery = new System.Windows.Forms.Button();
//            this.grid = new System.Windows.Forms.DataGridView();
//            this.col_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
//            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.toolStrip2.SuspendLayout();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // treeBank
//            // 
//            this.treeBank.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left)));
//            this.treeBank.Location = new System.Drawing.Point(12, 122);
//            this.treeBank.Name = "treeBank";
//            this.treeBank.Size = new System.Drawing.Size(151, 288);
//            this.treeBank.TabIndex = 18;
//            this.treeBank.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeBank_NodeMouseClick);
//            // 
//            // txtName
//            // 
//            this.txtName.Location = new System.Drawing.Point(78, 47);
//            this.txtName.Name = "txtName";
//            this.txtName.Size = new System.Drawing.Size(151, 21);
//            this.txtName.TabIndex = 2;
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
//            this.toolStrip2.Size = new System.Drawing.Size(670, 25);
//            this.toolStrip2.TabIndex = 14;
//            this.toolStrip2.Text = "toolStrip2";
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
//            // toolStripSeparator1
//            // 
//            this.toolStripSeparator1.Name = "toolStripSeparator1";
//            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
//            // tsbDelete
//            // 
//            this.tsbDelete.Image = global::Haimen.Properties.Resources.Delete;
//            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
//            this.tsbDelete.Name = "tsbDelete";
//            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
//            this.tsbDelete.Text = "删除";
//            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
//            // 
//            // toolStripSeparator2
//            // 
//            this.toolStripSeparator2.Name = "toolStripSeparator2";
//            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.txtCode);
//            this.groupBox1.Controls.Add(this.txtName);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Location = new System.Drawing.Point(12, 28);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(242, 83);
//            this.groupBox1.TabIndex = 15;
//            this.groupBox1.TabStop = false;
//            // 
//            // txtCode
//            // 
//            this.txtCode.Location = new System.Drawing.Point(78, 20);
//            this.txtCode.Name = "txtCode";
//            this.txtCode.Size = new System.Drawing.Size(151, 21);
//            this.txtCode.TabIndex = 1;
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
//            this.label2.Location = new System.Drawing.Point(14, 50);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(29, 12);
//            this.label2.TabIndex = 4;
//            this.label2.Text = "名称";
//            // 
//            // btnQuery
//            // 
//            this.btnQuery.Location = new System.Drawing.Point(260, 73);
//            this.btnQuery.Name = "btnQuery";
//            this.btnQuery.Size = new System.Drawing.Size(75, 23);
//            this.btnQuery.TabIndex = 3;
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
//            this.col_code,
//            this.col_name});
//            this.grid.Location = new System.Drawing.Point(169, 122);
//            this.grid.Name = "grid";
//            this.grid.RowTemplate.Height = 23;
//            this.grid.Size = new System.Drawing.Size(490, 288);
//            this.grid.StandardTab = true;
//            this.grid.TabIndex = 17;
//            // 
//            // col_selected
//            // 
//            this.col_selected.FalseValue = "";
//            this.col_selected.HeaderText = "选择";
//            this.col_selected.Name = "col_selected";
//            this.col_selected.TrueValue = "";
//            this.col_selected.Width = 35;
//            // 
//            // col_id
//            // 
//            this.col_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
//            this.col_id.HeaderText = "编号";
//            this.col_id.Name = "col_id";
//            this.col_id.ReadOnly = true;
//            this.col_id.Width = 54;
//            // 
//            // col_code
//            // 
//            this.col_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
//            this.col_code.HeaderText = "代码";
//            this.col_code.Name = "col_code";
//            this.col_code.ReadOnly = true;
//            this.col_code.Width = 54;
//            // 
//            // col_name
//            // 
//            this.col_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
//            this.col_name.HeaderText = "名称";
//            this.col_name.Name = "col_name";
//            this.col_name.ReadOnly = true;
//            this.col_name.Width = 54;
//            // 
//            // frmBankList
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(670, 415);
//            this.Controls.Add(this.treeBank);
//            this.Controls.Add(this.toolStrip2);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.btnQuery);
//            this.Controls.Add(this.grid);
//            this.Name = "frmBankList";
//            this.Text = "银行列表";
//            this.toolStrip2.ResumeLayout(false);
//            this.toolStrip2.PerformLayout();
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.TreeView treeBank;
//        private System.Windows.Forms.TextBox txtName;
//        private System.Windows.Forms.ToolStripButton tsbExit;
//        private System.Windows.Forms.ToolStripButton tsbDelete;
//        private System.Windows.Forms.ToolStripButton tsbEdit;
//        private System.Windows.Forms.ToolStripButton tsbNew;
//        private System.Windows.Forms.ToolStrip toolStrip2;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.TextBox txtCode;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button btnQuery;
//        private System.Windows.Forms.DataGridView grid;
//        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selected;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
//    }
//}