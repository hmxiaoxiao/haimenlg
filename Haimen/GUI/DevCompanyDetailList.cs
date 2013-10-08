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

namespace Haimen.GUI
{
    public partial class DevCompanyDetailList : DevExpress.XtraEditors.XtraForm
    {
        private List<Bank> banks = Bank.Query();
        private Company m_company;
        private CompanyDetail m_detail;
        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位帐户明细, (long)ActionEnum.新增))
            {
                if (tsbNew.Enabled == true) tsbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位帐户明细, (long)ActionEnum.编辑))
            {
                if (tsbEdit.Enabled == true) tsbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.单位帐户明细, (long)ActionEnum.删除))
            {
                if (tsbDelete.Enabled == true) tsbDelete.Enabled = false;
            }
        }

        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.查看:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbSave.Enabled = false;

                    gridView1.OptionsBehavior.Editable = false;
                    break;
                case winStatusEnum.编辑:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    gridView1.OptionsBehavior.Editable = true;
                    break;
                case winStatusEnum.新增:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    gridView1.OptionsBehavior.Editable = true;
                    break;
            }
        }

        private void MyRefresh()
        {
            List<Company> companies = Company.Query();
            tree.DataSource = companies;
        }

        private bool Verify()
        {
            if (!m_detail.Verify())
            {
                MessageBox.Show(m_detail.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public DevCompanyDetailList()
        {
            InitializeComponent();
        }

        private void DevCompanyDetailList_Load(object sender, EventArgs e)
        {
            MyRefresh();
            SetFormStatus(winStatusEnum.查看);
            SetControlAccess();
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            ShowCompanyDetail();
        }

        private void ShowCompanyDetail()
        {
            if (tree.FocusedNode == null)
                return;

            long id = long.Parse(tree.FocusedNode.GetValue(node_id).ToString());
            Company com = Company.CreateByID(id);
            if (com == null)
                return;    // 如果是空对象，可能被删除了。

            txtCode.Text = com.Code;
            txtDoc.Text = com.Doc;
            txtName.Text = com.Name;

            txtCode.Enabled = false;
            txtDoc.Enabled = false;
            txtName.Enabled = false;

            lueBanks.DataSource = banks;
            lueBanks.DisplayMember = "Name";
            lueBanks.ValueMember = "ID";
            gridControl1.DataSource = com.DetailList;

            m_company = com;
        }


        private void tree_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            ShowCompanyDetail();
        }

        /// <summary>
        ///  新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_detail = new CompanyDetail();
            m_company.DetailList.Add(m_detail);
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_company.DetailList;

            SetFormStatus(winStatusEnum.新增);
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
            if (MessageBox.Show(this, "是否要删除指定的资金凭证？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                m_company.Save();
            }
        }


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 更新编辑中的数据
            gridView1.CloseEditor();
            gridView1.UpdateCurrentRow();

            if (m_company == null || m_company.Code != txtCode.Text)
                return;

            if (!Verify())
                return;

            if (!m_company.Save())
            {
                string err = "";
                foreach (KeyValuePair<string, string> kv in m_company.Error_Info)
                {
                    err += kv.Value + Environment.NewLine;
                }
                MessageBox.Show(err, "出错啦!");
            }
            else
            {
                MessageBox.Show("保存成功！", "注意");
                SetFormStatus(winStatusEnum.查看);
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_detail.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (m_status == winStatusEnum.新增 || m_status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == m_detail.ID)
                    e.Allow = false;
            }
        }

        /// <summary>
        /// 保存
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

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (gridView1.FocusedRowHandle < 0)
                return;

            // 找到要编辑的银行
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            foreach (CompanyDetail cd in m_company.DetailList)
            {
                if (cd.ID == id)
                    m_detail = cd;
            }
            SetFormStatus(winStatusEnum.编辑);
        }


        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
            MyRefresh();
            SetFormStatus(winStatusEnum.查看);
        }
    }
}