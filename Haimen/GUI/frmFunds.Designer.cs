//namespace Haimen.GUI
//{
//    partial class frmFunds
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
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFunds));
//            this.groupBox1 = new System.Windows.Forms.GroupBox();
//            this.label3 = new System.Windows.Forms.Label();
//            this.txtName = new System.Windows.Forms.TextBox();
//            this.label2 = new System.Windows.Forms.Label();
//            this.btnExit = new System.Windows.Forms.Button();
//            this.btnSave = new System.Windows.Forms.Button();
//            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
//            this.cboParent = new C1.Win.C1List.C1Combo();
//            this.groupBox1.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.cboParent)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // groupBox1
//            // 
//            this.groupBox1.Controls.Add(this.cboParent);
//            this.groupBox1.Controls.Add(this.label3);
//            this.groupBox1.Controls.Add(this.txtName);
//            this.groupBox1.Controls.Add(this.label2);
//            this.groupBox1.Location = new System.Drawing.Point(12, 12);
//            this.groupBox1.Name = "groupBox1";
//            this.groupBox1.Size = new System.Drawing.Size(260, 112);
//            this.groupBox1.TabIndex = 1;
//            this.groupBox1.TabStop = false;
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.Location = new System.Drawing.Point(18, 66);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(53, 12);
//            this.label3.TabIndex = 14;
//            this.label3.Text = "所属性质";
//            // 
//            // txtName
//            // 
//            this.txtName.Location = new System.Drawing.Point(95, 20);
//            this.txtName.Name = "txtName";
//            this.txtName.Size = new System.Drawing.Size(149, 21);
//            this.txtName.TabIndex = 2;
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.Location = new System.Drawing.Point(18, 25);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(29, 12);
//            this.label2.TabIndex = 12;
//            this.label2.Text = "名称";
//            // 
//            // btnExit
//            // 
//            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
//            this.btnExit.Location = new System.Drawing.Point(296, 57);
//            this.btnExit.Name = "btnExit";
//            this.btnExit.Size = new System.Drawing.Size(75, 23);
//            this.btnExit.TabIndex = 5;
//            this.btnExit.Text = "退出";
//            this.btnExit.UseVisualStyleBackColor = true;
//            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
//            // 
//            // btnSave
//            // 
//            this.btnSave.Location = new System.Drawing.Point(294, 28);
//            this.btnSave.Name = "btnSave";
//            this.btnSave.Size = new System.Drawing.Size(75, 23);
//            this.btnSave.TabIndex = 4;
//            this.btnSave.Text = "保存";
//            this.btnSave.UseVisualStyleBackColor = true;
//            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
//            // 
//            // errorProvider1
//            // 
//            this.errorProvider1.ContainerControl = this;
//            // 
//            // cboParent
//            // 
//            this.cboParent.AddItemSeparator = ';';
//            this.cboParent.Caption = "";
//            this.cboParent.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
//            this.cboParent.DeadAreaBackColor = System.Drawing.Color.Empty;
//            this.cboParent.EditorBackColor = System.Drawing.SystemColors.Window;
//            this.cboParent.EditorFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
//            this.cboParent.EditorForeColor = System.Drawing.SystemColors.WindowText;
//            this.cboParent.Images.Add(((System.Drawing.Image)(resources.GetObject("cboParent.Images"))));
//            this.cboParent.Location = new System.Drawing.Point(95, 66);
//            this.cboParent.MatchEntryTimeout = ((long)(2000));
//            this.cboParent.MaxDropDownItems = ((short)(5));
//            this.cboParent.MaxLength = 32767;
//            this.cboParent.MouseCursor = System.Windows.Forms.Cursors.Default;
//            this.cboParent.Name = "cboParent";
//            this.cboParent.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
//            this.cboParent.RowSubDividerColor = System.Drawing.Color.DarkGray;
//            this.cboParent.Size = new System.Drawing.Size(149, 22);
//            this.cboParent.TabIndex = 3;
//            this.cboParent.PropBag = resources.GetString("cboParent.PropBag");
//            // 
//            // frmFunds
//            // 
//            this.AcceptButton = this.btnSave;
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.CancelButton = this.btnExit;
//            this.ClientSize = new System.Drawing.Size(383, 137);
//            this.Controls.Add(this.groupBox1);
//            this.Controls.Add(this.btnExit);
//            this.Controls.Add(this.btnSave);
//            this.Name = "frmFunds";
//            this.Text = "资金性质";
//            this.groupBox1.ResumeLayout(false);
//            this.groupBox1.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.cboParent)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.GroupBox groupBox1;
//        private System.Windows.Forms.Label label3;
//        private System.Windows.Forms.TextBox txtName;
//        private System.Windows.Forms.Label label2;
//        private System.Windows.Forms.Button btnExit;
//        private System.Windows.Forms.Button btnSave;
//        private System.Windows.Forms.ErrorProvider errorProvider1;
//        private C1.Win.C1List.C1Combo cboParent;
//    }
//}