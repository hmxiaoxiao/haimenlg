namespace Haimen.NewGUI
{
    partial class DevChangePassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtUser = new C1.Win.C1Input.C1TextBox();
            this.txtOldPassword = new C1.Win.C1Input.C1TextBox();
            this.txtNewpassword = new C1.Win.C1Input.C1TextBox();
            this.txtPasswordConfirm = new C1.Win.C1Input.C1TextBox();
            this.btnChangepassword = new C1.Win.C1Input.C1Button();
            this.btnExit = new C1.Win.C1Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewpassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "重复新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "新密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "原密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "当前登录用户：";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(155, 37);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 22);
            this.txtUser.TabIndex = 17;
            this.txtUser.Tag = null;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(155, 74);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(149, 22);
            this.txtOldPassword.TabIndex = 18;
            this.txtOldPassword.Tag = null;
            this.txtOldPassword.Leave += new System.EventHandler(this.txtOldPassword_Leave);
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(155, 111);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.PasswordChar = '*';
            this.txtNewpassword.Size = new System.Drawing.Size(149, 22);
            this.txtNewpassword.TabIndex = 19;
            this.txtNewpassword.Tag = null;
            this.txtNewpassword.Leave += new System.EventHandler(this.txtNewpassword_Leave);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(155, 148);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(149, 22);
            this.txtPasswordConfirm.TabIndex = 20;
            this.txtPasswordConfirm.Tag = null;
            this.txtPasswordConfirm.Leave += new System.EventHandler(this.txtPasswordConfirm_Leave);
            // 
            // btnChangepassword
            // 
            this.btnChangepassword.Location = new System.Drawing.Point(133, 194);
            this.btnChangepassword.Name = "btnChangepassword";
            this.btnChangepassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangepassword.TabIndex = 21;
            this.btnChangepassword.Text = "修改密码";
            this.btnChangepassword.UseVisualStyleBackColor = true;
            this.btnChangepassword.Click += new System.EventHandler(this.btnChangepassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(229, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "放弃修改";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // DevChangePassword
            // 
            this.AcceptButton = this.btnChangepassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(386, 273);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangepassword);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DevChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DevChangePassword";
            this.Load += new System.EventHandler(this.txtUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNewpassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordConfirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private C1.Win.C1Input.C1TextBox txtPasswordConfirm;
        private C1.Win.C1Input.C1TextBox txtNewpassword;
        private C1.Win.C1Input.C1TextBox txtOldPassword;
        private C1.Win.C1Input.C1TextBox txtUser;
        private C1.Win.C1Input.C1Button btnChangepassword;
        private C1.Win.C1Input.C1Button btnExit;

    }
}