//namespace Haimen.GUI
//{
//    partial class frmCompanyList
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
//            this.grid = new System.Windows.Forms.DataGridView();
//            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
//            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
//            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
//            this.tsbNew = new System.Windows.Forms.ToolStripButton();
//            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
//            this.tsbExit = new System.Windows.Forms.ToolStripButton();
//            this.txtQCode = new System.Windows.Forms.TextBox();
//            this.txtQName = new System.Windows.Forms.TextBox();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.btnQuery = new System.Windows.Forms.Button();
//            this.col_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
//            this.col_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_account = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_bank = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_output = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.col_input = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
//            this.toolStrip2.SuspendLayout();
//            this.groupBox1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // grid
//            // 
//            this.grid.AllowUserToAddRows = false;
//            this.grid.AllowUserToDeleteRows = false;
//            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
//            | System.Windows.Forms.AnchorStyles.Left) 
//            | System.Windows.Forms.AnchorStyles.Right)));
//            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.col_selected,
//            this.col_id,
//            this.col_code,
//            this.col_name,
//            this.col_account,
//            this.col_bank,
//            this.col_doc,
//            this.col_output,
//            this.col_input});
//            this.grid.Location = new System.Drawing.Point(12, 117);
//            this.grid.Name = "grid";
//            this.grid.RowTemplate.Height = 23;
//            this.grid.Size = new System.Drawing.Size(730, 351);
//            this.grid.TabIndex = 17;
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
//            this.toolStrip2.Size = new System.Drawing.Size(754, 25);
//            this.toolStrip2.TabIndex = 14;
//            this.toolStrip2.Text = "toolStrip2";
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
//            // txtQCode
//            // 
//            this.txtQCode.Location = new System.Drawing.Point(78, 20);
//            this.txtQCode.Name = "txtQCode";
//            this.txtQCode.Size = new System.Drawing.Size(151, 21);
//            this.txtQCode.TabIndex = 3;
//            // 
//            // txtQName
//            // 
//            this.txtQName.Location = new System.Drawing.Point(78, 47);
//            this.txtQName.Name = "txtQName";
//            this.txtQName.Size = new System.Drawing.Size(151, 21);
//            this.txtQName.TabIndex = 5;
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
//            this.label2.Size = new System.Drawing.Size(41, 12);
//            this.label2.TabIndex = 4;
//            this.label2.Text = "名称：";
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.txtQCode);
//            this.groupBox1.Controls.Add(this.txtQName);
//            this.groupBox1.Controls.Add(this.label1);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Location = new System.Drawing.Point(12, 28);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(242, 83);
//            this.groupBox1.TabIndex = 15;
//            this.groupBox1.TabStop = false;
//            // 
//            // btnQuery
//            // 
//            this.btnQuery.Location = new System.Drawing.Point(260, 78);
//            this.btnQuery.Name = "btnQuery";
//            this.btnQuery.Size = new System.Drawing.Size(75, 23);
//            this.btnQuery.TabIndex = 16;
//            this.btnQuery.Text = "查询";
//            this.btnQuery.UseVisualStyleBackColor = true;
//            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
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
//            this.col_id.ReadOnly = true;
//            this.col_id.Visible = false;
//            // 
//            // col_code
//            // 
//            this.col_code.HeaderText = "编号";
//            this.col_code.Name = "col_code";
//            this.col_code.ReadOnly = true;
//            // 
//            // col_name
//            // 
//            this.col_name.HeaderText = "姓名";
//            this.col_name.Name = "col_name";
//            this.col_name.ReadOnly = true;
//            // 
//            // col_account
//            // 
//            this.col_account.HeaderText = "银行帐号";
//            this.col_account.Name = "col_account";
//            this.col_account.ReadOnly = true;
//            // 
//            // col_bank
//            // 
//            this.col_bank.HeaderText = "开户行";
//            this.col_bank.Name = "col_bank";
//            this.col_bank.ReadOnly = true;
//            // 
//            // col_doc
//            // 
//            this.col_doc.HeaderText = "单据字";
//            this.col_doc.Name = "col_doc";
//            this.col_doc.ReadOnly = true;
//            // 
//            // col_output
//            // 
//            this.col_output.HeaderText = "付款单位";
//            this.col_output.Name = "col_output";
//            this.col_output.ReadOnly = true;
//            // 
//            // col_input
//            // 
//            this.col_input.HeaderText = "收款单位";
//            this.col_input.Name = "col_input";
//            this.col_input.ReadOnly = true;
//            // 
//            // frmCompanyList
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(754, 480);
//            this.Controls.Add(this.grid);
//            this.Controls.Add(this.toolStrip2);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.btnQuery);
//            this.Name = "frmCompanyList";
//            this.Text = "单位列表";
//            this.Load += new System.EventHandler(this.frmCompanyList_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
//            this.toolStrip2.ResumeLayout(false);
//            this.toolStrip2.PerformLayout();
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.DataGridView grid;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
//        private System.Windows.Forms.ToolStripButton tsbDelete;
//        private System.Windows.Forms.ToolStripButton tsbEdit;
//        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
//        private System.Windows.Forms.ToolStripButton tsbNew;
//        private System.Windows.Forms.ToolStrip toolStrip2;
//        private System.Windows.Forms.ToolStripButton tsbExit;
//        private System.Windows.Forms.TextBox txtQCode;
//        private System.Windows.Forms.TextBox txtQName;
//        private System.Windows.Forms.Label label1;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Button btnQuery;
//        private System.Windows.Forms.DataGridViewCheckBoxColumn col_selected;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_id;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_code;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_account;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_bank;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_doc;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_output;
//        private System.Windows.Forms.DataGridViewTextBoxColumn col_input;
//    }
//}