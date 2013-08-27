namespace Haimen.NewGUI
{
    partial class DevMain
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.mnuBank = new DevExpress.XtraBars.BarButtonItem();
            this.mnuCompany = new DevExpress.XtraBars.BarButtonItem();
            this.mnuFouds = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAccountList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuAccount = new DevExpress.XtraBars.BarButtonItem();
            this.mnuContractList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuContract = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBalanceList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuBalance = new DevExpress.XtraBars.BarButtonItem();
            this.mnuUserList = new DevExpress.XtraBars.BarButtonItem();
            this.mnuChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.mnuNotify = new DevExpress.XtraBars.BarButtonItem();
            this.statusText = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.mnuBank,
            this.mnuCompany,
            this.mnuFouds,
            this.barButtonItem1,
            this.mnuAccountList,
            this.mnuAccount,
            this.mnuContractList,
            this.mnuContract,
            this.mnuBalanceList,
            this.mnuBalance,
            this.mnuUserList,
            this.mnuChangePassword,
            this.mnuNotify,
            this.statusText});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Show;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(436, 149);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // mnuBank
            // 
            this.mnuBank.Caption = "银行";
            this.mnuBank.Glyph = global::Haimen.Properties.Resources.About;
            this.mnuBank.Id = 1;
            this.mnuBank.Name = "mnuBank";
            this.mnuBank.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.mnuBank.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuBank_ItemClick);
            // 
            // mnuCompany
            // 
            this.mnuCompany.Caption = "单位";
            this.mnuCompany.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuCompany.Glyph = global::Haimen.Properties.Resources.Address_Book;
            this.mnuCompany.Id = 2;
            this.mnuCompany.Name = "mnuCompany";
            this.mnuCompany.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuFouds
            // 
            this.mnuFouds.Caption = "资金性质";
            this.mnuFouds.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuFouds.Glyph = global::Haimen.Properties.Resources.Air_Brush;
            this.mnuFouds.Id = 3;
            this.mnuFouds.Name = "mnuFouds";
            this.mnuFouds.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.mnuFouds.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuFouds_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "单位帐户信息";
            this.barButtonItem1.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.barButtonItem1.Glyph = global::Haimen.Properties.Resources.Calendar_hot;
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuAccountList
            // 
            this.mnuAccountList.Caption = "资金列表";
            this.mnuAccountList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuAccountList.Glyph = global::Haimen.Properties.Resources.Air_Brush_hot;
            this.mnuAccountList.Id = 7;
            this.mnuAccountList.Name = "mnuAccountList";
            this.mnuAccountList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuAccount
            // 
            this.mnuAccount.Caption = "资金管理";
            this.mnuAccount.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuAccount.Glyph = global::Haimen.Properties.Resources.Bullets_2_hot;
            this.mnuAccount.Id = 8;
            this.mnuAccount.Name = "mnuAccount";
            this.mnuAccount.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuContractList
            // 
            this.mnuContractList.Caption = "合同列表";
            this.mnuContractList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuContractList.Glyph = global::Haimen.Properties.Resources.Sound_Fade_In_hot;
            this.mnuContractList.Id = 9;
            this.mnuContractList.Name = "mnuContractList";
            this.mnuContractList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuContract
            // 
            this.mnuContract.Caption = "合同管理";
            this.mnuContract.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuContract.Glyph = global::Haimen.Properties.Resources.Preview_hot;
            this.mnuContract.Id = 10;
            this.mnuContract.Name = "mnuContract";
            // 
            // mnuBalanceList
            // 
            this.mnuBalanceList.Caption = "贷款列表";
            this.mnuBalanceList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuBalanceList.Glyph = global::Haimen.Properties.Resources.Flag_hot;
            this.mnuBalanceList.Id = 11;
            this.mnuBalanceList.Name = "mnuBalanceList";
            this.mnuBalanceList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuBalance
            // 
            this.mnuBalance.Caption = "贷款管理";
            this.mnuBalance.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuBalance.Glyph = global::Haimen.Properties.Resources.Header_Previous_hot;
            this.mnuBalance.Id = 12;
            this.mnuBalance.Name = "mnuBalance";
            this.mnuBalance.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuUserList
            // 
            this.mnuUserList.Caption = "用户列表";
            this.mnuUserList.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuUserList.Glyph = global::Haimen.Properties.Resources.Flow_Chart_hot;
            this.mnuUserList.Id = 13;
            this.mnuUserList.Name = "mnuUserList";
            this.mnuUserList.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // mnuChangePassword
            // 
            this.mnuChangePassword.Caption = "更改密码";
            this.mnuChangePassword.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuChangePassword.Glyph = global::Haimen.Properties.Resources.User_Password;
            this.mnuChangePassword.Id = 14;
            this.mnuChangePassword.Name = "mnuChangePassword";
            this.mnuChangePassword.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.mnuChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.mnuChangePassword_ItemClick);
            // 
            // mnuNotify
            // 
            this.mnuNotify.Caption = "通知";
            this.mnuNotify.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
            this.mnuNotify.Glyph = global::Haimen.Properties.Resources.Notes;
            this.mnuNotify.Id = 15;
            this.mnuNotify.Name = "mnuNotify";
            this.mnuNotify.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // statusText
            // 
            this.statusText.Caption = "barStaticItem1";
            this.statusText.Id = 17;
            this.statusText.Name = "statusText";
            this.statusText.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup8});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "基础数据";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuBank);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuCompany);
            this.ribbonPageGroup1.ItemLinks.Add(this.mnuFouds);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.mnuChangePassword);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "业务管理";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.mnuAccountList);
            this.ribbonPageGroup5.ItemLinks.Add(this.mnuAccount);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuContractList);
            this.ribbonPageGroup3.ItemLinks.Add(this.mnuContractList);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.Glyph = global::Haimen.Properties.Resources.About;
            this.ribbonPageGroup4.ItemLinks.Add(this.mnuBalanceList);
            this.ribbonPageGroup4.ItemLinks.Add(this.mnuBalance);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "系统管理";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.mnuUserList);
            this.ribbonPageGroup6.ItemLinks.Add(this.mnuChangePassword);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.ShowCaptionButton = false;
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.mnuNotify);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.ShowCaptionButton = false;
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "报表";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.statusText);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 414);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(436, 35);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Seven Classic";
            // 
            // mdiManager
            // 
            this.mdiManager.MdiParent = this;
            // 
            // DevMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "DevMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "财政资金管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DevMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem mnuBank;
        private DevExpress.XtraBars.BarButtonItem mnuCompany;
        private DevExpress.XtraBars.BarButtonItem mnuFouds;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.BarButtonItem mnuAccountList;
        private DevExpress.XtraBars.BarButtonItem mnuAccount;
        private DevExpress.XtraBars.BarButtonItem mnuContractList;
        private DevExpress.XtraBars.BarButtonItem mnuContract;
        private DevExpress.XtraBars.BarButtonItem mnuBalanceList;
        private DevExpress.XtraBars.BarButtonItem mnuBalance;
        private DevExpress.XtraBars.BarButtonItem mnuUserList;
        private DevExpress.XtraBars.BarButtonItem mnuChangePassword;
        private DevExpress.XtraBars.BarButtonItem mnuNotify;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarStaticItem statusText;
    }
}