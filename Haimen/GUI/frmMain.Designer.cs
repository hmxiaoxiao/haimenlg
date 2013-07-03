namespace Haimen
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaseData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompanyAccountInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuDept = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBank = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunds = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZJ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAccountVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContract = new System.Windows.Forms.ToolStripMenuItem();
            this.合同审核ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.支付一览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDK = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreditList = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCreditVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.还贷一览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.贷款余额查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.初始化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEndInit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.通知ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSystem,
            this.menuBaseData,
            this.menuZJ,
            this.menuHT,
            this.menuDK,
            this.menuReport,
            this.初始化ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(548, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSystem
            // 
            this.menuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUser,
            this.menuChangePassword,
            this.toolStripMenuItem1,
            this.通知ToolStripMenuItem,
            this.toolStripMenuItem5,
            this.menuExit});
            this.menuSystem.Name = "menuSystem";
            this.menuSystem.Size = new System.Drawing.Size(44, 21);
            this.menuSystem.Text = "系统";
            // 
            // menuUser
            // 
            this.menuUser.Name = "menuUser";
            this.menuUser.Size = new System.Drawing.Size(152, 22);
            this.menuUser.Text = "用户管理";
            this.menuUser.Click += new System.EventHandler(this.menuUser_Click_1);
            // 
            // menuChangePassword
            // 
            this.menuChangePassword.Name = "menuChangePassword";
            this.menuChangePassword.Size = new System.Drawing.Size(152, 22);
            this.menuChangePassword.Text = "更改密码";
            this.menuChangePassword.Click += new System.EventHandler(this.menuChangePassword_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuBaseData
            // 
            this.menuBaseData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCompanyAccountInfo,
            this.toolStripMenuItem2,
            this.menuDept,
            this.menuEmployee,
            this.menuBank,
            this.menuCompany,
            this.menuFunds});
            this.menuBaseData.Name = "menuBaseData";
            this.menuBaseData.Size = new System.Drawing.Size(68, 21);
            this.menuBaseData.Text = "基础数据";
            // 
            // menuCompanyAccountInfo
            // 
            this.menuCompanyAccountInfo.Name = "menuCompanyAccountInfo";
            this.menuCompanyAccountInfo.Size = new System.Drawing.Size(148, 22);
            this.menuCompanyAccountInfo.Text = "单位帐户信息";
            this.menuCompanyAccountInfo.Click += new System.EventHandler(this.menuCompanyAccountInfo_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // menuDept
            // 
            this.menuDept.Name = "menuDept";
            this.menuDept.Size = new System.Drawing.Size(148, 22);
            this.menuDept.Text = "部门管理";
            this.menuDept.Click += new System.EventHandler(this.menuDept_Click);
            // 
            // menuEmployee
            // 
            this.menuEmployee.Name = "menuEmployee";
            this.menuEmployee.Size = new System.Drawing.Size(148, 22);
            this.menuEmployee.Text = "员工信息";
            this.menuEmployee.Click += new System.EventHandler(this.menuEmployee_Click);
            // 
            // menuBank
            // 
            this.menuBank.Name = "menuBank";
            this.menuBank.Size = new System.Drawing.Size(148, 22);
            this.menuBank.Text = "银行";
            this.menuBank.Click += new System.EventHandler(this.menuBank_Click);
            // 
            // menuCompany
            // 
            this.menuCompany.Name = "menuCompany";
            this.menuCompany.Size = new System.Drawing.Size(148, 22);
            this.menuCompany.Text = "单位";
            this.menuCompany.Click += new System.EventHandler(this.menuCompany_Click);
            // 
            // menuFunds
            // 
            this.menuFunds.Name = "menuFunds";
            this.menuFunds.Size = new System.Drawing.Size(148, 22);
            this.menuFunds.Text = "资金性质";
            this.menuFunds.Click += new System.EventHandler(this.menuFunds_Click);
            // 
            // menuZJ
            // 
            this.menuZJ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAccount,
            this.menuAccountVerify});
            this.menuZJ.Name = "menuZJ";
            this.menuZJ.Size = new System.Drawing.Size(68, 21);
            this.menuZJ.Text = "资金管理";
            // 
            // menuAccount
            // 
            this.menuAccount.Name = "menuAccount";
            this.menuAccount.Size = new System.Drawing.Size(124, 22);
            this.menuAccount.Text = "资金列表";
            this.menuAccount.Click += new System.EventHandler(this.menuAccount_Click);
            // 
            // menuAccountVerify
            // 
            this.menuAccountVerify.Name = "menuAccountVerify";
            this.menuAccountVerify.Size = new System.Drawing.Size(124, 22);
            this.menuAccountVerify.Text = "资金审核";
            this.menuAccountVerify.Click += new System.EventHandler(this.menuAccountVerify_Click);
            // 
            // menuHT
            // 
            this.menuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContract,
            this.合同审核ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.支付一览ToolStripMenuItem});
            this.menuHT.Name = "menuHT";
            this.menuHT.Size = new System.Drawing.Size(68, 21);
            this.menuHT.Text = "合同管理";
            // 
            // menuContract
            // 
            this.menuContract.Name = "menuContract";
            this.menuContract.Size = new System.Drawing.Size(124, 22);
            this.menuContract.Text = "合同列表";
            this.menuContract.Click += new System.EventHandler(this.menuContract_Click);
            // 
            // 合同审核ToolStripMenuItem
            // 
            this.合同审核ToolStripMenuItem.Name = "合同审核ToolStripMenuItem";
            this.合同审核ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.合同审核ToolStripMenuItem.Text = "合同审核";
            this.合同审核ToolStripMenuItem.Click += new System.EventHandler(this.合同审核ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // 支付一览ToolStripMenuItem
            // 
            this.支付一览ToolStripMenuItem.Name = "支付一览ToolStripMenuItem";
            this.支付一览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.支付一览ToolStripMenuItem.Text = "支付一览";
            // 
            // menuDK
            // 
            this.menuDK.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCreditList,
            this.menuCreditVerify,
            this.还贷一览ToolStripMenuItem});
            this.menuDK.Name = "menuDK";
            this.menuDK.Size = new System.Drawing.Size(68, 21);
            this.menuDK.Text = "贷款管理";
            // 
            // menuCreditList
            // 
            this.menuCreditList.Name = "menuCreditList";
            this.menuCreditList.Size = new System.Drawing.Size(124, 22);
            this.menuCreditList.Text = "贷款列表";
            this.menuCreditList.Click += new System.EventHandler(this.menuCreditList_Click);
            // 
            // menuCreditVerify
            // 
            this.menuCreditVerify.Name = "menuCreditVerify";
            this.menuCreditVerify.Size = new System.Drawing.Size(124, 22);
            this.menuCreditVerify.Text = "货款审批";
            this.menuCreditVerify.Click += new System.EventHandler(this.menuCreditVerify_Click);
            // 
            // 还贷一览ToolStripMenuItem
            // 
            this.还贷一览ToolStripMenuItem.Name = "还贷一览ToolStripMenuItem";
            this.还贷一览ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.还贷一览ToolStripMenuItem.Text = "还贷一览";
            // 
            // menuReport
            // 
            this.menuReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.贷款余额查询ToolStripMenuItem});
            this.menuReport.Name = "menuReport";
            this.menuReport.Size = new System.Drawing.Size(44, 21);
            this.menuReport.Text = "报表";
            // 
            // 贷款余额查询ToolStripMenuItem
            // 
            this.贷款余额查询ToolStripMenuItem.Name = "贷款余额查询ToolStripMenuItem";
            this.贷款余额查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.贷款余额查询ToolStripMenuItem.Text = "贷款余额查询";
            // 
            // 初始化ToolStripMenuItem
            // 
            this.初始化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuInit,
            this.toolStripMenuItem3,
            this.menuEndInit});
            this.初始化ToolStripMenuItem.Name = "初始化ToolStripMenuItem";
            this.初始化ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.初始化ToolStripMenuItem.Text = "初始化";
            // 
            // menuInit
            // 
            this.menuInit.Name = "menuInit";
            this.menuInit.Size = new System.Drawing.Size(136, 22);
            this.menuInit.Text = "金额初始化";
            this.menuInit.Click += new System.EventHandler(this.menuInit_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(133, 6);
            // 
            // menuEndInit
            // 
            this.menuEndInit.Name = "menuEndInit";
            this.menuEndInit.Size = new System.Drawing.Size(136, 22);
            this.menuEndInit.Text = "初始化结束";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 389);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(548, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(128, 17);
            this.toolStripStatusLabel1.Text = "当前登录用户：admin";
            // 
            // 通知ToolStripMenuItem
            // 
            this.通知ToolStripMenuItem.Name = "通知ToolStripMenuItem";
            this.通知ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.通知ToolStripMenuItem.Text = "通知";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(149, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 411);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "海门临江财政资金管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem;
        private System.Windows.Forms.ToolStripMenuItem menuUser;
        private System.Windows.Forms.ToolStripMenuItem menuChangePassword;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuBaseData;
        private System.Windows.Forms.ToolStripMenuItem menuDept;
        private System.Windows.Forms.ToolStripMenuItem menuEmployee;
        private System.Windows.Forms.ToolStripMenuItem menuBank;
        private System.Windows.Forms.ToolStripMenuItem menuCompany;
        private System.Windows.Forms.ToolStripMenuItem menuFunds;
        private System.Windows.Forms.ToolStripMenuItem menuZJ;
        private System.Windows.Forms.ToolStripMenuItem menuAccount;
        private System.Windows.Forms.ToolStripMenuItem menuAccountVerify;
        private System.Windows.Forms.ToolStripMenuItem menuHT;
        private System.Windows.Forms.ToolStripMenuItem menuDK;
        private System.Windows.Forms.ToolStripMenuItem menuReport;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuCompanyAccountInfo;
        private System.Windows.Forms.ToolStripMenuItem 初始化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuInit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuEndInit;
        private System.Windows.Forms.ToolStripMenuItem menuContract;
        private System.Windows.Forms.ToolStripMenuItem 支付一览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreditList;
        private System.Windows.Forms.ToolStripMenuItem 还贷一览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 贷款余额查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCreditVerify;
        private System.Windows.Forms.ToolStripMenuItem 合同审核ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 通知ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    }
}

