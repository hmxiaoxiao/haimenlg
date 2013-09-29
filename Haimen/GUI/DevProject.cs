using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Qy;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevProject : DevExpress.XtraEditors.XtraForm
    {
        private List<Project> m_projects = new List<Project>();
        private Project m_project;
        private winStatusEnum m_status;

        /// <summary>
        /// 刷新界面
        /// </summary>
        private void MyRefresh()
        {
            m_projects = Project.Query();
            gridControl1.DataSource = m_projects;
            gridView1.OptionsBehavior.Editable = false;
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
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.项目, (long)ActionEnum.New))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.项目, (long)ActionEnum.Edit))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.项目, (long)ActionEnum.Delete))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        public DevProject()
        {
            InitializeComponent();
        }

        private void DevProject_Load(object sender, EventArgs e)
        {
            MyRefresh();
            setWinStatus(winStatusEnum.查看);       // 当前的状态为浏览
            SetControlAccess();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_project = new Project();
            m_projects.Add(m_project);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_projects;
            gridView1.OptionsBehavior.Editable = true;

            setWinStatus(winStatusEnum.新增);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Project bk in m_projects)
            {
                if (bk.ID == id)
                    m_project = bk;
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
            if (MessageBox.Show(this, "是否要删除指定的项目？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
                Project bk = Project.CreateByID(id);
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
            if (m_project != null)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            m_project = null;
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

            if (!m_project.Verify())
            {
                MessageBox.Show(m_project.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_project.Save();

            m_project = null;
            gridView1.OptionsBehavior.Editable = false;
            setWinStatus(winStatusEnum.查看);
        }

        // 设置新增或者行的颜色。
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_project.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }


        // 新增或者编辑时，不可以离开当前行
        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_project.ID)
                    e.Allow = false;
            }
        }
    }
}