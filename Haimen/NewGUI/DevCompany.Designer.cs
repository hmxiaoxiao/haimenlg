namespace Haimen.NewGUI
{
    partial class DevCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevCompany));
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbOutput = new C1.Win.C1Input.C1CheckBox();
            this.cbInput = new C1.Win.C1Input.C1CheckBox();
            this.cboBankList = new C1.Win.C1List.C1Combo();
            this.btnExit = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBankList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(361, 21);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(163, 22);
            this.txtDoc.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 14);
            this.label5.TabIndex = 12;
            this.label5.Text = "单据字";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(77, 65);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(447, 22);
            this.txtName.TabIndex = 3;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "名称";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(77, 154);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(447, 22);
            this.txtAccount.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(77, 21);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(167, 22);
            this.txtCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "帐号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 109);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbOutput);
            this.groupBox1.Controls.Add(this.cbInput);
            this.groupBox1.Controls.Add(this.cboBankList);
            this.groupBox1.Controls.Add(this.txtDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(538, 278);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cbOutput
            // 
            this.cbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbOutput.Location = new System.Drawing.Point(77, 229);
            this.cbOutput.Name = "cbOutput";
            this.cbOutput.Size = new System.Drawing.Size(104, 24);
            this.cbOutput.TabIndex = 14;
            this.cbOutput.Text = "支出单位";
            this.cbOutput.Value = null;
            // 
            // cbInput
            // 
            this.cbInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbInput.Location = new System.Drawing.Point(77, 198);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(104, 24);
            this.cbInput.TabIndex = 13;
            this.cbInput.Text = "收入单位";
            this.cbInput.Value = null;
            // 
            // cboBankList
            // 
            this.cboBankList.AddItemSeparator = ';';
            this.cboBankList.AlternatingRows = true;
            this.cboBankList.Caption = "";
            this.cboBankList.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cboBankList.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cboBankList.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cboBankList.EditorFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboBankList.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cboBankList.Images.Add(((System.Drawing.Image)(resources.GetObject("cboBankList.Images"))));
            this.cboBankList.Location = new System.Drawing.Point(77, 109);
            this.cboBankList.MatchEntryTimeout = ((long)(2000));
            this.cboBankList.MaxDropDownItems = ((short)(5));
            this.cboBankList.MaxLength = 32767;
            this.cboBankList.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cboBankList.Name = "cboBankList";
            this.cboBankList.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.cboBankList.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cboBankList.Size = new System.Drawing.Size(447, 22);
            this.cboBankList.TabIndex = 4;
            this.cboBankList.PropBag = resources.GetString("cboBankList.PropBag");
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(472, 304);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DevCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 344);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Name = "DevCompany";
            this.Text = "单位管理";
            this.Load += new System.EventHandler(this.DevCompany_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboBankList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1Input.C1CheckBox cbOutput;
        private C1.Win.C1Input.C1CheckBox cbInput;
        private C1.Win.C1List.C1Combo cboBankList;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}