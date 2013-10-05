using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.NewGUI
{
    /// <summary>
    /// 银行列表
    /// </summary>
    public partial class DevBankList : DevExpress.XtraEditors.XtraForm
    {
        // 当前表格中的银行列表
        private List<Bank> m_banks = new List<Bank>();
        private Bank m_bank;        // 当前编辑(新增)的银行

        private winStatusEnum m_status;


        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.新增))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.编辑))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.银行, (long)ActionEnum.删除))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
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

        public DevBankList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载窗口时，初始化树
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DevBankList_Load(object sender, EventArgs e)
        {
            initTree();
            ShowBank2Grid();
            setWinStatus(winStatusEnum.查看);       // 当前的状态为浏览
            SetControlAccess();
        }

        /// <summary>
        /// 初始化树
        /// </summary>
        private void initTree()
        {
            List<Bank> banks = Bank.Query();
            tree.KeyFieldName = "ID";
            tree.ParentFieldName = "ParentID";
            tree.DataSource = banks;
        }

        /// <summary>
        /// 当点击树结点时，显示在表格中显示该银行及下属银行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tree_Click(object sender, EventArgs e)
        {
            ShowBank2Grid();
        }

        // 在列表中显示当前树结点对应的资金性质以及子结点。
        private void ShowBank2Grid()
        {
            if (tree.FocusedNode == null)
                return;

            long id = long.Parse(tree.FocusedNode.GetValue(node_id).ToString());
            m_banks.Clear();
            AddBank2List(id);

            lueBanks.DataSource = Bank.Query();
            gridControl1.DataSource = m_banks;
            gridView1.OptionsBehavior.Editable = false;
        }

        // 将对应ID的银行以及下属银行加到grid中
        private void AddBank2List(long id)
        {
            Bank bank = Bank.CreateByID(id);
            m_banks.Add(bank);

            List<Bank> banks = Bank.Query("parent_id = " + id.ToString());
            foreach (Bank bk in banks)
            {
                AddBank2List(bk.ID);
            }
        }

        // 新增一个银行
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_bank = new Bank();
            m_banks.Add(m_bank);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_banks;
            gridView1.OptionsBehavior.Editable = true;

            setWinStatus(winStatusEnum.新增);
        }


        // 保存
        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 更新数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (!m_bank.Verify())
            {
                MessageBox.Show(m_bank.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            m_bank.Save();

            m_bank = null;
            gridView1.OptionsBehavior.Editable = false;
            setWinStatus(winStatusEnum.查看);
        }

        // 修改银行信息
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (Bank bk in m_banks)
            {
                if (bk.ID == id)
                    m_bank = bk;
            }
            gridView1.OptionsBehavior.Editable = true;
            setWinStatus(winStatusEnum.编辑);
        }

        // 设置新增或者行的颜色。
        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑 )
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_bank.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }


        // 新增或者编辑时，不可以离开当前行
        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_bank.ID)
                    e.Allow = false;
            }
        }

        // 新增和编辑时，代码自动从名称中转换过来。
        private void gridView1_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if ((m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑) && e.Column.Name == "col_name")
            {
                gridView1.SetRowCellValue(e.RowHandle, "Code", PinyinHelper.GetShortPinyin(e.Value.ToString()).ToUpper());
                //m_bank.Name = e.Value.ToString();
            }
        }

        // 刷新界面，就是重建树
        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyRefresh();
        }

        /// <summary>
        /// 刷新界面
        /// </summary>
        private void MyRefresh()
        {
            if (m_bank != null)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }
            m_bank = null;
            setWinStatus(winStatusEnum.查看);
            initTree();
            ShowBank2Grid();
        }


        // 关闭窗口退出
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

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;
            if (MessageBox.Show(this, "是否要删除指定的银行？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
                Bank bk = Bank.CreateByID(id);
                bk.Destory();
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
        }

        private void DevBankList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
        }
    }
}