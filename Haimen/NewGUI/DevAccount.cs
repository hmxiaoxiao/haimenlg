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
using System.IO;
using System.Diagnostics;

namespace Haimen.NewGUI
{
    public partial class DevAccount : DevExpress.XtraEditors.XtraForm
    {

        private Account m_account;

        private List<Bank> m_banks = Bank.Query();
        private List<Company> m_companies = Company.Query();
        private List<Funds> m_funds = Funds.Query();

        private winStatusEnum m_status;

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if(!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.New))
            {
                if (tbNew.Enabled == true) tbNew.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Edit))
            {
                if (tbEdit.Enabled == true) tbEdit.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Delete))
            {
                if (tbDelete.Enabled == true) tbDelete.Enabled = false;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User.ID, GlobalSet.Current_User.UserGroupID, (long)FctionEnum.资金往来, (long)ActionEnum.Check))
            {
                if (tbCheckPassed.Enabled == true) tbCheckPassed.Enabled = false;
                if (tbCheckFaild.Enabled == true) tbCheckFaild.Enabled = false;
            }
        }

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatusEnum status)
        {
            m_status = status;
            switch (status)
            {
                case winStatusEnum.New:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.Edit:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.View:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.Check:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = true;
                    tbCheckPassed.Enabled = true;
                    SetEditorStatus(false);
                    break;
                case winStatusEnum.OnlyView:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = false;
                    tbCheckFaild.Enabled = false;
                    tbCheckPassed.Enabled = false;
                    SetEditorStatus(false);
                    break;
            }
        }

        /// <summary>
        /// 设置当前输入控件是否可用。
        /// </summary>
        /// <param name="status"></param>
        private void SetEditorStatus(bool status)
        {
            dtSigned.Properties.ReadOnly = !status;
            txtCode.Properties.ReadOnly = !status;
            lueInCompany.Properties.ReadOnly = !status;
            lueOutCompany.Properties.ReadOnly = !status;
            txtMemo.Properties.ReadOnly = !status;

            tsbNew.Enabled = status;
            tsbDelete.Enabled = status;
            gridView1.OptionsBehavior.ReadOnly = !status;

            tsbAttachDelete.Enabled = status;
            tsbAttachNew.Enabled = status;
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2form()
        {
            if (m_account.ID > 0)
            {
                dtSigned.EditValue = m_account.SignedDate;
                txtCode.Text = m_account.Code;

                lueOutCompany.EditValue = m_account.OutCompanyDetail.Parent_ID;
                List<CompanyDetail> out_list = CompanyDetail.Query("parent_id = " + m_account.OutCompanyDetail.Parent_ID);
                lueOutAccount.Properties.DataSource = null;
                lueOutAccount.Properties.DataSource = out_list;
                lueOutAccount.Properties.DisplayMember = "Account";
                lueOutAccount.Properties.ValueMember = "ID";
                lueOutAccount.EditValue = m_account.Out_CompanyDetail_ID;
                txtOutBank.Text = m_account.OutCompanyDetail.Bank.Name;

                lueInCompany.EditValue = m_account.InCompanyDetail.Parent_ID;
                List<CompanyDetail> in_list = CompanyDetail.Query("parent_id = " + m_account.InCompanyDetail.Parent_ID);
                lueInAccount.Properties.DataSource = null;
                lueInAccount.Properties.DataSource = in_list;
                lueInAccount.Properties.DisplayMember = "Account";
                lueInAccount.Properties.ValueMember = "ID";
                lueInAccount.EditValue = m_account.In_CompanyDetail_ID;
                txtInBank.Text = m_account.InCompanyDetail.Bank.Name;

                txtMemo.Text = m_account.Memo;
            }
            else
            {
                dtSigned.EditValue = DateTime.Now;
                txtCode.Text = "";
                lueInCompany.EditValue = null;
                lueInAccount.EditValue = null;
                txtOutBank.Text = "";

                lueOutCompany.EditValue = null;
                lueOutAccount.EditValue = null;
                txtInBank.Text = "";

                txtMemo.Text = "";
            }
            ShowCheckPic();
        }

        private void ShowCheckPic()
        {
            switch (m_account.Status)
            {
                case 1:
                    picPass.Visible = true;
                    picCheckFaild.Visible = false;
                    break;
                case 2:
                    picPass.Visible = false;
                    picCheckFaild.Visible = true;
                    break;
            }
        }

        /// <summary>
        /// 初始化列表
        /// </summary>
        private void InitList()
        {
            lueInCompany.Properties.DataSource = m_companies;
            lueInCompany.Properties.DisplayMember = "Name";
            lueInCompany.Properties.ValueMember = "ID";

            lueOutCompany.Properties.DataSource = m_companies;
            lueOutCompany.Properties.DisplayMember = "Name";
            lueOutCompany.Properties.ValueMember = "ID";

            gridControl1.DataSource = m_account.DetailList;

            luefunds.DataSource = m_funds;
            luefunds.DisplayMember = "Name";
            luefunds.ValueMember = "ID";

            lstFiles.Items.Clear();
            foreach (Attach a in m_account.AttachList)
            {
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);
            }
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Verify()
        {
            m_account.SignedDate = DateTime.Parse( dtSigned.EditValue.ToString());

            dxErrorProvider1.ClearErrors();
            m_account.Verify();
            foreach (KeyValuePair<string, string> kv in m_account.Error_Info)
            {
                switch (kv.Key)
                {
                    case "In_CompanyDetail_ID":
                        dxErrorProvider1.SetError(lueInAccount, kv.Value);
                        break;
                    case "Out_CompanyDetail_ID":
                        dxErrorProvider1.SetError(lueOutAccount, kv.Value);
                        break;
                }
            }
            return dxErrorProvider1.HasErrors;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(winStatusEnum status, Account account = null)
        {
            InitializeComponent();

            SetFormStatus(status);
            if (account != null)
                m_account = account;
            else
                m_account = new Account();
        }

        private void DevAccount_Load(object sender, EventArgs e)
        {
            // 初始化界面
            InitList();
            Object2form();

            SetControlAccess();
        }

        /// <summary>
        /// 同步支出单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutCompany.EditValue != null)
            {
                m_account.Out_CompanyDetail_ID = long.Parse(lueOutCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + m_account.Out_CompanyDetail_ID.ToString());
                lueOutAccount.Properties.DataSource = cd;
                lueOutAccount.Properties.DisplayMember = "Account";
                lueOutAccount.Properties.ValueMember = "ID";
            }
            
            // 生成单据字
            if (string.IsNullOrEmpty(txtCode.Text))
                txtCode.Text = Company.CreateByID( m_account.OutCompanyDetail.Parent_ID).NextDoc();
        }

        /// <summary>
        /// 同步收入单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInCompany.EditValue != null)
            {
                m_account.In_CompanyDetail_ID = long.Parse(lueInCompany.EditValue.ToString());
                List<CompanyDetail> cd = CompanyDetail.Query("parent_id = " + m_account.Out_CompanyDetail_ID.ToString());
                lueInAccount.Properties.DataSource = cd;
                lueInAccount.Properties.DisplayMember = "Account";
                lueInAccount.Properties.ValueMember = "ID";
            }
        }

        private void dtSigned_ValueChanged(object sender, EventArgs e)
        {
            m_account.SignedDate = DateTime.Parse( dtSigned.EditValue.ToString());
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            m_account.Code = txtCode.Text;
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            m_account.Memo = txtMemo.Text;
        }

        /// <summary>
        /// 增加明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_account.DetailList;
        }

        /// <summary>
        /// 删除明细
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            //if (gridView1.FocusedRowHandle < 0)
            //    return;

            //long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());


            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtMemo.Focus();
            txtCode.Focus();
            
            if (!Verify())
                return;

            if (m_account.Save())
            {
                MessageBox.Show("保存成功！");
                SetFormStatus(winStatusEnum.View);
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account = new Account();
            Object2form();
            SetFormStatus(winStatusEnum.New);
        }


        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID <= 0)
                return;

            Object2form();
            SetFormStatus(winStatusEnum.Edit);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID > 0)
            {
                m_account.Destory();
                m_account = null;
            }
        }

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAttachNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "请选择需要上传的文件";
            fd.ValidateNames = true;
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;

            if (fd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                FileInfo fi = new FileInfo(fd.FileName);
                // 先保存到数据库里
                Attach att = new Attach();
                att.FileName = fi.Name;
                att.FileType = fi.Extension;
                att.Save();

                FTPClient ftp = CustomerINI.GetFTPClient();
                ftp.fileUpload(fi, @"\", att.ID.ToString() + fi.Extension);

                m_account.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(att.ID.ToString() + "." +  fi.Name, 2);
            }
        }

        /// <summary>
        /// 关闭窗口
        /// 如果当前属新增或者编辑，则提示是否真的退出，只能选择了是才能退出。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!(m_status == winStatusEnum.View || m_status == winStatusEnum.OnlyView))
            {
                if (MessageBox.Show("现在退出，当前做的工作将会丢失！是否真的退出？",
                                   "警告",
                                   MessageBoxButtons.YesNoCancel,
                                   MessageBoxIcon.Warning,
                                   MessageBoxDefaultButton.Button2) != System.Windows.Forms.DialogResult.Yes)
                    return;
            }
            this.Close();
        }

        /// <summary>
        /// 删除附件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbAttachDelete_Click(object sender, EventArgs e)
        {
            string[] temp = lstFiles.Items[lstFiles.SelectedIndex].Value.ToString().Split('.');
            if (temp.Length > 0)
            {
                long id = long.Parse(temp[0]);
                Attach att = Attach.CreateByID(id);

                FTPClient ftp = CustomerINI.GetFTPClient();
                ftp.fileDelete(@"\", att.FileName);

                att.Destory();

                lstFiles.Items.Remove(lstFiles.Items[lstFiles.SelectedIndex]);

            }
        }


        /// <summary>
        /// 双击附件，显示附件内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstFiles_DoubleClick(object sender, EventArgs e)
        {
            string[] temp = lstFiles.Items[lstFiles.SelectedIndex].Value.ToString().Split('.');
            if (temp.Length > 0)
            {
                long id = long.Parse(temp[0]);
                Attach att = Attach.CreateByID(id);

                FTPClient ftp = CustomerINI.GetFTPClient();
                string tempPath = Path.GetTempPath();
                if (ftp.fileDownload(tempPath, att.FileName, @"\", att.ID.ToString() + att.FileType))
                {
                    Process.Start(Path.Combine(tempPath, att.FileName));
                }
                else
                {
                    MessageBox.Show("下载附件失败！");
                }

            }
        }


        /// <summary>
        /// 审核通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCheckPassed_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.CheckPass();
            SetFormStatus(winStatusEnum.OnlyView);      //审核通过后，只能看。
            ShowCheckPic();
        }

        /// <summary>
        /// 审核不通过
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbCheckFaild_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_account.CheckFaild();
            SetFormStatus(winStatusEnum.View);      
        }


        /// <summary>
        /// 选择帐户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutAccount.EditValue == null)
                return;

            long CD_id = long.Parse(lueOutAccount.EditValue.ToString());
            //CompanyDetail cd = CompanyDetail.CreateByID(CD_id);
            m_account.Out_CompanyDetail_ID = CD_id;
            txtOutBank.Text = m_account.OutCompanyDetail.Bank.Name;
        }

        private void lueInAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInAccount.EditValue == null)
                return;

            long id = long.Parse(lueInAccount.EditValue.ToString());
            m_account.In_CompanyDetail_ID = id;
            txtInBank.Text = m_account.InCompanyDetail.Bank.Name;
        }
    }
}