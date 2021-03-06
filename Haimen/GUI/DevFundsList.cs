﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevFundsList : DevExpress.XtraEditors.XtraForm
    {
        // 当前表格中的银行列表
        private List<Funds> m_fundses = new List<Funds>();
        private Funds m_funds;        // 当前编辑(新增)的银行

        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.资金性质, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.资金性质, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.资金性质, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        // 设置当前窗口状态，也就是控制几个按钮的状态
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
        /// 初始化树
        /// </summary>
        private void initTree()
        {
            List<Funds> fs = Funds.Query();
            tree.KeyFieldName = "ID";
            tree.ParentFieldName = "ParentID";
            tree.DataSource = fs;
        }

        // 在列表中显示当前树结点对应的银行以及子结点。
        private void ShowFunds2Grid()
        {
            if (tree.FocusedNode == null)
                return;

            long id = long.Parse(tree.FocusedNode.GetValue(node_id).ToString());
            m_fundses.Clear();
            AddFunds2List(id);

            lueFunds.DataSource = Funds.Query();
            gridControl1.DataSource = m_fundses;
            gridView1.OptionsBehavior.Editable = false;
        }

        // 将对应ID的银行以及下属银行加到grid中
        private void AddFunds2List(long id)
        {
            Funds fs = Funds.CreateByID(id);
            m_fundses.Add(fs);

            List<Funds> fundses = Funds.Query("parent_id = " + id);
            foreach (Funds bk in fundses)
            {
                AddFunds2List(bk.ID);
            }
        }

        public DevFundsList()
        {
            InitializeComponent();
        }

        private void DevFundsList_Load(object sender, EventArgs e)
        {
            initTree();
            ShowFunds2Grid();
            setWinStatus(winStatusEnum.查看);       // 当前的状态为浏览
            SetControlAccess();
        }

        private void tree_Click(object sender, EventArgs e)
        {
            ShowFunds2Grid();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_funds = new Funds();
            m_fundses.Add(m_funds);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_fundses;
            gridView1.OptionsBehavior.Editable = true;

            setWinStatus(winStatusEnum.新增);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Funds bk in m_fundses)
            {
                if (bk.ID == id)
                    m_funds = bk;
            }
            gridView1.OptionsBehavior.Editable = true;
            setWinStatus(winStatusEnum.编辑);
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            if (m_status != winStatusEnum.查看)
                return;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            Funds fd = Funds.CreateByID(id);
            if (!fd.DeleteVerify())
            {
                MessageBox.Show(fd.ErrorString, "注意");
                return;
            }

            if (MessageBox.Show("要删除指定的资金性质，是否要继续？", "注意",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }

            Funds.Delete(id);

            initTree();
            ShowFunds2Grid();

        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 更新数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (!m_funds.InsertUpdateVerify())
            {
                MessageBox.Show(m_funds.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_funds.Save();

            m_funds = null;
            gridView1.OptionsBehavior.Editable = false;
            setWinStatus(winStatusEnum.查看);
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_funds != null)
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

        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        private void MyRefresh()
        {
            if (m_funds != null)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            m_funds = null;
            setWinStatus(winStatusEnum.查看);
            initTree();
            ShowFunds2Grid();
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_funds.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_funds.ID)
                    e.Allow = false;
            }
        }

        private void DevFundsList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
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