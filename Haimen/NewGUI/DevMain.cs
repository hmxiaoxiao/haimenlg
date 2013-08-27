﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

using Haimen.Entity;

namespace Haimen.NewGUI
{
    public partial class DevMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public DevMain()
        {
            InitializeComponent();
        }

        private void myInitialze()
        {
            statusText.Caption = "当前登录用户为：" + GlobalSet.Current_User.Name;
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
    }
}