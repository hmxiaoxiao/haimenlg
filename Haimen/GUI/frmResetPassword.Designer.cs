namespace Haimen.GUI
{
    partial class frmResetPassword
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChangepassword = new System.Windows.Forms.Button();
            this.txtPasswordConfirm = new System.Windows.Forms.TextBox();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtCurrentUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(226, 173);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "放弃修改";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChangepassword
            // 
            this.btnChangepassword.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnChangepassword.Location = new System.Drawing.Point(130, 173);
            this.btnChangepassword.Name = "btnChangepassword";
            this.btnChangepassword.Size = new System.Drawing.Size(75, 23);
            this.btnChangepassword.TabIndex = 5;
            this.btnChangepassword.Text = "修改密码";
            this.btnChangepassword.UseVisualStyleBackColor = true;
            this.btnChangepassword.Click += new System.EventHandler(this.btnChangepassword_Click);
            // 
            // txtPasswordConfirm
            // 
            this.txtPasswordConfirm.Location = new System.Drawing.Point(112, 127);
            this.txtPasswordConfirm.Name = "txtPasswordConfirm";
            this.txtPasswordConfirm.PasswordChar = '*';
            this.txtPasswordConfirm.Size = new System.Drawing.Size(149, 21);
            this.txtPasswordConfirm.TabIndex = 4;
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(112, 90);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.PasswordChar = '*';
            this.txtNewpassword.Size = new System.Drawing.Size(149, 21);
            this.txtNewpassword.TabIndex = 3;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(112, 53);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 21);
            this.txtUser.TabIndex = 0;
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(112, 16);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(149, 21);
            this.txtCurrentUser.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "重复新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "新密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "需重置的用户";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "当前登录用户";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmResetPassword
            // 
            this.AcceptButton = this.btnChangepassword;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnChangepassword;
            this.ClientSize = new System.Drawing.Size(341, 217);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnChangepassword);
            this.Controls.Add(this.txtPasswordConfirm);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtCurrentUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmResetPassword";
            this.Text = "重置密码";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnChangepassword;
        private System.Windows.Forms.TextBox txtPasswordConfirm;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtCurrentUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}