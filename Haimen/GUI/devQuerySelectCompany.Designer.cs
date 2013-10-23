namespace Haimen.GUI
{
    partial class DevQuerySelectCompany
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
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.tree = new DevExpress.XtraTreeList.TreeList();
            this.tree_id = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tree_name = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tree_code = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(505, 53);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "取消退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(505, 13);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(96, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确认选择";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tree
            // 
            this.tree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tree_id,
            this.tree_name,
            this.tree_code});
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.OptionsView.ShowCheckBoxes = true;
            this.tree.Size = new System.Drawing.Size(442, 380);
            this.tree.TabIndex = 5;
            this.tree.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tree_AfterCheckNode);
            // 
            // tree_id
            // 
            this.tree_id.Caption = "ID";
            this.tree_id.FieldName = "ID";
            this.tree_id.Name = "tree_id";
            // 
            // tree_name
            // 
            this.tree_name.Caption = "名称";
            this.tree_name.FieldName = "Name";
            this.tree_name.MinWidth = 32;
            this.tree_name.Name = "tree_name";
            this.tree_name.Visible = true;
            this.tree_name.VisibleIndex = 0;
            this.tree_name.Width = 184;
            // 
            // tree_code
            // 
            this.tree_code.Caption = "代码";
            this.tree_code.FieldName = "Code";
            this.tree_code.Name = "tree_code";
            this.tree_code.Visible = true;
            this.tree_code.VisibleIndex = 1;
            this.tree_code.Width = 153;
            // 
            // DevQuerySelectCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 401);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConfirm);
            this.Name = "DevQuerySelectCompany";
            this.Text = "7";
            this.Load += new System.EventHandler(this.devQuerySelectCompany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraTreeList.TreeList tree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tree_id;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tree_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tree_name;
    }
}