namespace Haimen.DBConfig
{
    partial class DevDBConfig
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.txtHost = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtDB = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFTPURL = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFTPName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtFTPPassword = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnTest = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPURL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtPassword);
            this.layoutControl1.Controls.Add(this.txtUser);
            this.layoutControl1.Controls.Add(this.txtDB);
            this.layoutControl1.Controls.Add(this.txtHost);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(3, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(754, 178, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(459, 182);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 2;
            this.layoutControlGroup1.Size = new System.Drawing.Size(459, 182);
            this.layoutControlGroup1.Text = "Root";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 250);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnTest);
            this.tabPage1.Controls.Add(this.layoutControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 223);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "数据库设置";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.layoutControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 350);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "文件服务器设置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.txtFTPPassword);
            this.layoutControl2.Controls.Add(this.txtFTPName);
            this.layoutControl2.Controls.Add(this.txtFTPURL);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl2.Location = new System.Drawing.Point(3, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(459, 145);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(459, 145);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(82, 20);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(357, 20);
            this.txtHost.StyleController = this.layoutControl1;
            this.txtHost.TabIndex = 0;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtHost;
            this.layoutControlItem8.CustomizationFormText = "主机：";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem8.Size = new System.Drawing.Size(439, 40);
            this.layoutControlItem8.Text = "主机：";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(60, 14);
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(82, 60);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(357, 20);
            this.txtDB.StyleController = this.layoutControl1;
            this.txtDB.TabIndex = 1;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.txtDB;
            this.layoutControlItem9.CustomizationFormText = "数据库名：";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem9.Size = new System.Drawing.Size(439, 40);
            this.layoutControlItem9.Text = "数据库名：";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(60, 14);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(82, 100);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(357, 20);
            this.txtUser.StyleController = this.layoutControl1;
            this.txtUser.TabIndex = 2;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.txtUser;
            this.layoutControlItem10.CustomizationFormText = "用户：";
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem10.Size = new System.Drawing.Size(439, 40);
            this.layoutControlItem10.Text = "用户：";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(60, 14);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 140);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(357, 20);
            this.txtPassword.StyleController = this.layoutControl1;
            this.txtPassword.TabIndex = 3;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.txtPassword;
            this.layoutControlItem11.CustomizationFormText = "密码：";
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem11.Size = new System.Drawing.Size(439, 42);
            this.layoutControlItem11.Text = "密码：";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(60, 14);
            // 
            // txtFTPURL
            // 
            this.txtFTPURL.Location = new System.Drawing.Point(71, 20);
            this.txtFTPURL.Name = "txtFTPURL";
            this.txtFTPURL.Size = new System.Drawing.Size(368, 20);
            this.txtFTPURL.StyleController = this.layoutControl2;
            this.txtFTPURL.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtFTPURL;
            this.layoutControlItem1.CustomizationFormText = "服务器：";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem1.Size = new System.Drawing.Size(439, 40);
            this.layoutControlItem1.Text = "服务器：";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtFTPName
            // 
            this.txtFTPName.Location = new System.Drawing.Point(71, 60);
            this.txtFTPName.Name = "txtFTPName";
            this.txtFTPName.Size = new System.Drawing.Size(368, 20);
            this.txtFTPName.StyleController = this.layoutControl2;
            this.txtFTPName.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtFTPName;
            this.layoutControlItem2.CustomizationFormText = "用户名：";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem2.Size = new System.Drawing.Size(439, 40);
            this.layoutControlItem2.Text = "用户名：";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // txtFTPPassword
            // 
            this.txtFTPPassword.Location = new System.Drawing.Point(71, 100);
            this.txtFTPPassword.Name = "txtFTPPassword";
            this.txtFTPPassword.Size = new System.Drawing.Size(368, 20);
            this.txtFTPPassword.StyleController = this.layoutControl2;
            this.txtFTPPassword.TabIndex = 6;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtFTPPassword;
            this.layoutControlItem3.CustomizationFormText = "用户名：";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10);
            this.layoutControlItem3.Size = new System.Drawing.Size(439, 45);
            this.layoutControlItem3.Text = "用户名：";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(491, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存设置";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(491, 65);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "退出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(367, 191);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 1;
            this.btnTest.Text = "测试";
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // DevDBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 286);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Name = "DevDBConfig";
            this.Text = "资金管理系统-数据库设置";
            this.Load += new System.EventHandler(this.DevDBConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPURL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFTPPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.TextEdit txtDB;
        private DevExpress.XtraEditors.TextEdit txtHost;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.SimpleButton btnTest;
        private DevExpress.XtraEditors.TextEdit txtFTPPassword;
        private DevExpress.XtraEditors.TextEdit txtFTPName;
        private DevExpress.XtraEditors.TextEdit txtFTPURL;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnExit;


    }
}

