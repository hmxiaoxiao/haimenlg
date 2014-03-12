using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using Haimen.Entity;
using Haimen.Helper;

namespace Haimen.GUI
{
    public partial class DevCompanyDetailList : DevExpress.XtraEditors.XtraForm
    {
        private List<Bank> banks = Bank.Query();
        private Company _company;
        private CompanyDetail _detail;
        private winStatusEnum _status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位帐户, (long)ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位帐户, (long)ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User,  (long)FctionEnum.单位帐户, (long)ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void SetFormStatus(winStatusEnum status)
        {
            _status = status;
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

            if (_status != winStatusEnum.查看)
            {
                if (MessageBox.Show("刷新会导致当前的操作的数据丢失，是否要继续？", "注意",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question,
                        MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            _company = null;
            _detail = null;

            Company.OrderBy = "order by code";
            
            List<Company> companies = Company.Query();
            tree.DataSource = companies;

            lueType.DataSource = null;
            lueType.DataSource = CompanyDetail.AccountTypeList;

            lueCompany.DataSource = Company.Query();
            SetFormStatus(winStatusEnum.查看);
        }

        private bool Verify()
        {
            if (!_detail.InsertUpdateVerify())
            {
                MessageBox.Show(_detail.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            // 如果当前正在编辑，则不用返回
            if (_status == winStatusEnum.新增 || _status == winStatusEnum.编辑)
                return;

            if (tree.FocusedNode == null)
                return;

            if (tree.FocusedNode.GetValue(node_id) == null)
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

            lueBanks1.DataSource = banks;
            lueBanks1.DisplayMember = "Name";
            lueBanks1.ValueMember = "ID";
            gridControl1.DataSource = null;
            gridControl1.DataSource = com.DetailList;

            _company = com;
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
            _detail = new CompanyDetail();
            _company.DetailList.Add(_detail);
            gridControl1.DataSource = null;
            gridControl1.DataSource = _company.DetailList;

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
            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, c_id).ToString());
            CompanyDetail cd = CompanyDetail.CreateByID(id);
            if (!cd.DeleteVerify())
            {
                MessageBox.Show(cd.ErrorString, "注意");
                return;
            }
            if (MessageBox.Show(this, "是否要删除指定的单位明细？", "警告", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
                _company.Save();
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

            if (_company == null || _company.Code != txtCode.Text)
                return;

            if (!Verify())
                return;

            if (!_company.Save())
            {
                string err = "";
                foreach (KeyValuePair<string, string> kv in _company.Error_Info)
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
            if (_status == winStatusEnum.新增 || _status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == _detail.ID)
                    e.Appearance.BackColor = Color.LightSteelBlue;
            }
        }

        private void gridView1_BeforeLeaveRow(object sender, DevExpress.XtraGrid.Views.Base.RowAllowEventArgs e)
        {
            if (e.RowHandle <= 0)
                return;

            if (_status == winStatusEnum.新增 || _status == winStatusEnum.编辑)
            {
                if (long.Parse(gridView1.GetRowCellValue(e.RowHandle, "ID").ToString()) == _detail.ID)
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
            if (_status != winStatusEnum.查看)
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
            foreach (CompanyDetail cd in _company.DetailList)
            {
                if (cd.ID == id)
                    _detail = cd;
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
            MyRefresh();
        }

        private void DevCompanyDetailList_Activated(object sender, EventArgs e)
        {
            MyRefresh();
        }


        // 查找对应的单位
        private void btnQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // 如果没有输入，则不查找
            if (string.IsNullOrEmpty(barFinded.EditValue.ToString()))
                return;

            // 在树里面查找
            tree.ExpandAll();
            string id = barFinded.EditValue.ToString();

            foreach (TreeListNode node in tree.Nodes){
                Console.WriteLine(String.Format("{0},{1}{2}", node.GetValue(node_id), id, id == node.GetValue(node_id).ToString()));
                if (id == node.GetValue(node_id).ToString())
                {
                    tree.SetFocusedNode(node);
                    return;
                }
                if (node.HasChildren)
                {
                    foreach (TreeListNode child in node.Nodes)
                    {
                        Console.WriteLine(String.Format("{0},{1}{2}", child.GetValue(node_id), id, id == child.GetValue(node_id).ToString()));
                        if (id == child.GetValue(node_id).ToString())
                        {
                            tree.SetFocusedNode(child);
                            return;
                        }
                    }
                }
            }

            //tree.MoveFirst();
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
    }}