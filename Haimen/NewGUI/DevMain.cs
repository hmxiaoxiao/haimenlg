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

using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
namespace Haimen.NewGUI
{
    public partial class DevMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DevMain()
        {
            InitializeComponent();
        }

        public void OpenForm(XtraForm winForm)
        {
           // 检查是否已经存在
            if (!FormAlreadyOpen(winForm.GetType()))
            {
                winForm.MdiParent = this;
                winForm.Show();
            }
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

            SkinHelper.InitSkinGallery(rbSkins, true);
            rbSkins.Gallery.ImageSize = new Size(24, 24);

            CustomerINI.SetFormSkin();
        }

        // 打开银行管理
        private void mnuBank_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevBankList)))
            {
                DevBankList list = new DevBankList();
                list.MdiParent = this;
                list.Show();
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

        private void DevMain_Load(object sender, EventArgs e)
        {
            myInitialze();
        }


        // 打开修改密码窗口
        private void mnuChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevChangePassword win = new DevChangePassword();
            win.ShowDialog();
        }

        // 资金性质
        private void mnuFouds_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevFundsList)))
            {
                DevFundsList list = new DevFundsList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuAccountList_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevAccountList)))
            {
                DevAccountList list = new DevAccountList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevAccount)))
            {
                DevAccount list = new DevAccount();
                list.MdiParent = this;
                list.Show();
            }
        }

        // 选择皮肤的同时，将选择的皮肤记录到文件里，以便下一次使用。
        private void rbSkins_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            CustomerINI.WriteSkinName(e.Item.Caption);
        }

        // 打开银行
        private void mnuCompany_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevCompanyList)))
            {
                DevCompanyList list = new DevCompanyList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuCompanyDetail_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevCompanyDetailList)))
            {
                DevCompanyDetailList list = new DevCompanyDetailList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuUserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevUserList)))
            {
                DevUserList list = new DevUserList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuContractList_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevContractList)))
            {
                DevContractList list = new DevContractList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuContract_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevContract)))
            {
                DevContract list = new DevContract();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuBalanceList_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevBalanceList)))
            {
                DevBalanceList list = new DevBalanceList();
                list.MdiParent = this;
                list.Show();
            }
        }

        private void mnuBalance_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 检查是否已经存在
            if (!FormAlreadyOpen(typeof(DevBalance)))
            {
                DevBalance list = new DevBalance();
                list.MdiParent = this;
                list.Show();
            }
        }
    }
}