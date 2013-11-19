using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.Skins;

using Haimen.Entity;
using Haimen.Helper;
using Haimen.GUI;
using Haimen.Report;

using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Haimen.GUI
{
    public partial class DevMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        /// <summary>
        /// 打开指定的窗口
        /// </summary>
        /// <param name="winForm"></param>
        public void OpenForm(XtraForm winForm)
        {
            if (!FormAlreadyOpen(winForm.GetType()))
            {
                winForm.MdiParent = this;
                winForm.Show();
            }
        }
        


        /// <summary>
        /// 判断是否已经打开对应的窗口
        /// </summary>
        /// <param name="win"></param>
        /// <returns></returns>
        private bool FormAlreadyOpen(Type win)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage page in mdiManager.Pages)
            {
                if (page.MdiChild.GetType().Name == win.Name)
                {
                    mdiManager.SelectedPage = page;
                    return true;
                }
            }
            return false;
        }
        
        public void SetAccount(string title)
        {
            statusCurrentAccount.Caption = "当前帐期为：" + title;
        }

        // 当前窗口的初始化设置
        private void MyInitialze()
        {
            statusCurrentUser.Caption = "当前登录用户为：" + GlobalSet.Current_User.Name;
            statusCurrentAccount.Caption = "当前帐期为：" + SystemSet.CurrentAccount();

            // 设置皮肤列表
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                mnuComboSkins.Items.Add(cnt.SkinName);
            }
            SkinHelper.InitSkinGallery(rbSkins, true);
            rbSkins.Gallery.ImageSize = new Size(24, 24);

            // 设置皮肤
            CustomerINI.SetFormSkin();

            // 根据权限显示可以访问的菜单
            SetAccess();

        }

        /// <summary>
        /// 设置权限
        /// </summary>
        private void SetAccess()
        {
            mnuAccess.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.权限, (long)ActionEnum.查看);
            mnuAccount.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.资金, (long)ActionEnum.新增);
            mnuAccountList.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.资金, (long)ActionEnum.查看);
            mnuBalance.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.贷款, (long)ActionEnum.新增);
            mnuBalanceList.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.贷款, (long)ActionEnum.查看);
            mnuBank.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.银行, (long)ActionEnum.新增);
            mnuCompany.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.单位, (long)ActionEnum.查看);
            mnuCompanyDetail.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.单位帐户, (long)ActionEnum.查看);
            mnuContract.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.合同, (long)ActionEnum.新增);
            mnuContractList.Enabled = Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.合同, (long)ActionEnum.查看);
            mnuFouds.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.资金性质, (long)ActionEnum.查看);
            mnuNotify.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.通知, (long)ActionEnum.查看);
            mnuUserList.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.用户, (long)ActionEnum.查看);
            mnuAcceptanceBill.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.承兑汇票, (long)ActionEnum.新增);
            mnuAcceptanceBillList.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.承兑汇票, (long)ActionEnum.查看);
            mnuProject.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.项目, (long)ActionEnum.查看);
            mnuContractAcceptList.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.合同验收, (long)ActionEnum.查看);
            mnuBCBalance.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.余额表, (long)ActionEnum.查看);
            mnuCBBalance.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.余额表, (long)ActionEnum.查看);
            mnuReportBalance.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.余额表, (long)ActionEnum.查看);
            mnuUserGroup.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.用户组, (long)ActionEnum.查看);
            mnuMonthly.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.月结, (long)ActionEnum.查看);
            mnuqueryaccount.Enabled = Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.资金, (long)ActionEnum.查看);

            // 更新按钮只有超级用户可以用
            if (GlobalSet.Current_User.Admin == "X")
                mnuAdmin.Visibility = BarItemVisibility.Always;
            else
                mnuAdmin.Visibility = BarItemVisibility.Never;
        }

        public DevMain()
        {
            InitializeComponent();
        }


        // 打开银行管理
        private void mnuBank_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevBankList());
        }

        // 调用时初始化
        private void DevMain_Load(object sender, EventArgs e)
        {
            MyInitialze();

            // 设置标题
            this.Text = GlobalSet.SystemName;
        }

        // 资金性质
        private void mnuFouds_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevFundsList());
        }

        private void mnuAccountList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAccountList());
        }

        private void mnuAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAccount(winStatusEnum.新增));
        }

        // 选择皮肤的同时，将选择的皮肤记录到文件里，以便下一次使用。
        private void rbSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            CustomerINI.WriteSkinName(e.Item.Caption);
        }

        // 打开银行
        private void mnuCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevCompanyList());
        }

        private void mnuCompanyDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevCompanyDetailList());
        }

        private void mnuUserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevUserList());
        }

        private void mnuContractList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevContractList());
        }

        private void mnuContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevContract(winStatusEnum.新增));
        }

        private void mnuBalanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevBalanceList());
        }

        private void mnuBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevBalance(winStatusEnum.新增));
        }

        private void mnuAccess_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAccess());
        }

        private void mnuAcceptanceBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAcceptanceBill(winStatusEnum.新增));
        }

        private void mnuAcceptanceBillList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAcceptanceBillList());
        }

        private void mnuContractAcceptList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevContractAcceptList());
        }

        private void mnuProject_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevProjectList());
        }

        private void mnuBCBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevQueryBalance());
        }

        private void mnuCBBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevQueryBalance2());
        }

        private void mnuUserGroup_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new devUserGroupList());
        }

        private void mnuReportBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevQueryBalance3());
        }

        private void mnuAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevAdmin());
        }

        private void mnuIODetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevQueryIODetail());}

        private void mnuMonthly_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevMonthly());
        }

        private void mnuqueryaccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevQueryAccount());    // 资金查询
        }

        private void statusCurrentUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevChangePassword win = new DevChangePassword();
            win.ShowDialog();
        }

        private void mnuUnAuthList_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevUnAuthList());
        }

        private void mnuUnAuth_ItemClick(object sender, ItemClickEventArgs e)
        {
            OpenForm(new DevUnAuth());
        }
    }
}