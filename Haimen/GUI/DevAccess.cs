﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevAccess : XtraForm
    {
        private List<User> m_users = User.Query();
        private List<UserGroup> m_usergroups = UserGroup.Query();

        // 初始化
        private void init()
        {
            cboUType.Properties.Items.Clear();
            cboUType.Properties.Items.Add("用户");
            cboUType.Properties.Items.Add("用户组");
            cboUType.SelectedIndex = 0;

            if (Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.权限, (long)ActionEnum.编辑))
            {
                btnSave.Enabled = true;
                gridView1.OptionsBehavior.Editable = true;
            }
            else
            {
                btnSave.Enabled = false;
                gridView1.OptionsBehavior.Editable = false;
            }
        }

        public DevAccess()
        {
            InitializeComponent();
        }


        // 退出
        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void DevAccess_Load(object sender, EventArgs e)
        {
            init();
        }

        private void cboUType_EditValueChanged(object sender, EventArgs e)
        {
            if (cboUType.Text == "用户")
            {
                lueList.Properties.DataSource = null;
                lueList.Properties.DataSource = m_users;
                lueList.Properties.DisplayMember = "Name";
                lueList.Properties.ValueMember = "ID";
            }
            else
            {
                lueList.Properties.DataSource = null;
                lueList.Properties.DataSource = m_usergroups;
                lueList.Properties.DisplayMember = "Name";
                lueList.Properties.ValueMember = "ID";
            }
        }


        // 选择了具体用户后再显示可操作的内容
        private void lueList_EditValueChanged(object sender, EventArgs e)
        {
            if (lueList.EditValue == null)
                return;

            Cursor.Current = Cursors.AppStarting;       // 修改光标样式 
            long id = long.Parse(lueList.EditValue.ToString());
            if (cboUType.Text == "用户")
            {
                gridControl1.DataSource = null;
                gridControl1.DataSource = Access.GetAccessList(id);
            }
            else
            {
                gridControl1.DataSource = null;
                gridControl1.DataSource = Access.GetAccessList(id, false);
            }
            gridView1.BestFitColumns();

            Cursor.Current = Cursors.Default;           // 恢复光标样式
        }

        // 保存权限
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //// 记录下时间
            //DateTime n = DateTime.Now;
            // 切换一下焦点,保证不会丢失数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (lueList.EditValue == null)
                return;

            Cursor.Current = Cursors.AppStarting;
            Access.SaveAccessList();
            Cursor.Current = Cursors.Default;
            MessageBox.Show("保存成功！");

        }

        private void gridView1_CellMerge(object sender, DevExpress.XtraGrid.Views.Grid.CellMergeEventArgs e)
        {
            if (e.Column == col_access)
            {
                e.Merge = false;
                e.Handled = true;
            }
        }

        private void gridView1_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            e.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            if (e.Info.IsRowIndicator)
            {
                if (e.RowHandle >= 0)
                {
                    e.Info.DisplayText = (e.RowHandle + 1).ToString();
                }
                else if (e.RowHandle < 0 && e.RowHandle > -1000)
                {
                    e.Info.Appearance.BackColor = Color.AntiqueWhite;
                    e.Info.DisplayText = "G" + e.RowHandle;
                }
            }
        }


    }
}