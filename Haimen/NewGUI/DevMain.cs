﻿using System;
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

using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
namespace Haimen.NewGUI
{
    public partial class DevMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        // 打开指定的窗口
        public void OpenForm(XtraForm winForm)
        {
            if (!FormAlreadyOpen(winForm.GetType()))
            {
                winForm.MdiParent = this;
                winForm.Show();
            }
        }
        // 判断是否已经打开对应的窗口
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

        // 当前窗口的初始化设置
        private void myInitialze()
        {
            statusText.Caption = "当前登录用户为：" + GlobalSet.Current_User.Name;
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                //comboBoxEdit1.Properties.Items.Add(cnt.SkinName);
                mnuComboSkins.Items.Add(cnt.SkinName);
            }

            // 设置皮肤列表
            SkinHelper.InitSkinGallery(rbSkins, true);
            rbSkins.Gallery.ImageSize = new Size(24, 24);

            // 设置皮肤
            CustomerINI.SetFormSkin();

            // 根据权限显示可以访问的菜单
            if (GlobalSet.Current_User.Admin != "X")    // 超级用户可以使用全部
            {
                mnuAccess.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.权限, (long)ActionEnum.View);
                mnuAccount.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.New);
                mnuAccountList.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.View);
                mnuBalance.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.New);
                mnuBalanceList.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.View);
                mnuBank.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.View);
                mnuCompany.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位, (long)ActionEnum.View);
                mnuCompanyDetail.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位帐户明细, (long)ActionEnum.View);
                mnuContract.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.New);
                mnuContractList.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.View);
                mnuFouds.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金性质, (long)ActionEnum.View);
                mnuNotify.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.通知, (long)ActionEnum.View);
                mnuUserList.Enabled = Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.用户, (long)ActionEnum.View);
            }
        }

        public DevMain()
        {
            InitializeComponent();
        }


        // 打开银行管理
        private void mnuBank_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.View))
                OpenForm(new DevBankList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        // 调用时初始化
        private void DevMain_Load(object sender, EventArgs e)
        {
            myInitialze();

            // 设置标题
            this.Text = GlobalSet.SystemName;
        }

        // 资金性质
        private void mnuFouds_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金性质, (long)ActionEnum.View))
                OpenForm(new DevFundsList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuAccountList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.View))
                OpenForm(new DevAccountList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.New))
                OpenForm(new DevAccount(winStatusEnum.New));
            else
                MessageBox.Show("您无权限使用该功能");
        }

        // 选择皮肤的同时，将选择的皮肤记录到文件里，以便下一次使用。
        private void rbSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            CustomerINI.WriteSkinName(e.Item.Caption);
        }

        // 打开银行
        private void mnuCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.View))
                OpenForm(new DevCompanyList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuCompanyDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位帐户明细, (long)ActionEnum.View))
                OpenForm(new DevCompanyDetailList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuUserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.用户, (long)ActionEnum.View))
                OpenForm(new DevUserList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuContractList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.View))
                OpenForm(new DevContractList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.合同, (long)ActionEnum.New))
                OpenForm(new DevContract(winStatusEnum.New));
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuBalanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.View))
                OpenForm(new DevBalanceList());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.贷款, (long)ActionEnum.New))
                OpenForm(new DevBalance(winStatusEnum.New));
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuAccess_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.权限, (long)ActionEnum.View))
                OpenForm(new DevAccess());
            if (GlobalSet.Current_User.Admin == "X")
                OpenForm(new DevAccess());
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuAcceptanceBill_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.承兑汇票, (long)ActionEnum.New))
                OpenForm(new DevAcceptanceBill(winStatusEnum.New));
            else
                MessageBox.Show("您无权限使用该功能");
        }

        private void mnuAcceptanceBillList_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.承兑汇票, (long)ActionEnum.View))
                OpenForm(new DevAcceptanceBillList());
            else
                MessageBox.Show("您无权限使用该功能");
        }
    }
}