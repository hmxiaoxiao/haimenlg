﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.DB;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class devUserGroupList : DevExpress.XtraEditors.XtraForm
    {
        public devUserGroupList()
        {
            InitializeComponent();
        }
                
        private List<UserGroup> m_UserGroups = new List<UserGroup>();
        private UserGroup m_usergroup;
        private winStatusEnum m_status;

        /// <summary>
        /// 刷新界面
        /// </summary>
        private void MyRefresh()
        {
            if (m_status != winStatusEnum.查看)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            m_UserGroups = UserGroup.Query();
            gridControl1.DataSource = m_UserGroups;
            gridView1.OptionsBehavior.Editable = false;
            setWinStatus(winStatusEnum.查看);
        }

        /// <summary>
        /// 设置当前窗口状态，也就是控制几个按钮的状态
        /// </summary>
        /// <param name="status"></param>
        private void setWinStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.查看:
                    tsbDelete.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbNew.Enabled = true;
                    tsbSave.Enabled = false;
                    break;
                case winStatusEnum.编辑:
                    tsbDelete.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbNew.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
                case winStatusEnum.新增:
                    tsbDelete.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbNew.Enabled = false;
                    tsbSave.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.用户组, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.用户组, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User, (long)FctionEnum.用户组, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void DevUserGroup_Load(object sender, EventArgs e)
        {
            MyRefresh();
            SetControlAccess();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_usergroup = new UserGroup();
            m_UserGroups.Add(m_usergroup);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_UserGroups;
            gridView1.OptionsBehavior.Editable = true;

            setWinStatus(winStatusEnum.新增);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (UserGroup bk in m_UserGroups)
            {
                if (bk.ID == id)
                    m_usergroup = bk;
            }
            gridView1.OptionsBehavior.Editable = true;
            setWinStatus(winStatusEnum.编辑);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;
            if (MessageBox.Show(this, "是否要删除指定的数据？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
                UserGroup bk = UserGroup.CreateByID(id);
                bk.Destory();
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_usergroup != null)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            m_usergroup = null;
            setWinStatus(winStatusEnum.查看);
            MyRefresh();
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_status != winStatusEnum.查看)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 更新数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (!m_usergroup.InsertVerify())
            {
                MessageBox.Show(m_usergroup.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_usergroup.Save();

            m_usergroup = null;
            gridView1.OptionsBehavior.Editable = false;
            setWinStatus(winStatusEnum.查看);
        }

        // 设置新增或者行的颜色。
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_usergroup.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }


        // 新增或者编辑时，不可以离开当前行
        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_usergroup.ID)
                    e.Allow = false;
            }
        }

        private void devUserGroupList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
        }
    }
}