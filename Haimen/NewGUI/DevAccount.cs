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

        private winStatus m_status;

        /// <summary>
        /// 设置当前的状态，是新增，编辑，还是查看
        /// </summary>
        /// <param name="status"></param>
        private void SetFormStatus(winStatus status)
        {
            m_status = status;
            switch (status)
            {
                case winStatus.New:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.Edit:
                    tbNew.Enabled = false;
                    tbEdit.Enabled = false;
                    tbDelete.Enabled = false;
                    tbSave.Enabled = true;
                    break;
                case winStatus.View:
                    tbNew.Enabled = true;
                    tbEdit.Enabled = true;
                    tbDelete.Enabled = true;
                    tbSave.Enabled = false;
                    break;
            }
        }

        /// <summary>
        /// 将对象印射到窗口上
        /// </summary>
        private void Object2form()
        {
            if (m_account.ID > 0)
            {
                dtSigned.Value = m_account.SignedDate;
                txtCode.Text = m_account.Code;
                lueInCompany.EditValue = m_account.In_Company_ID;
                lueOutCompany.EditValue = m_account.Out_Company_ID;
                txtOutComapnyAccount.Text = m_account.OutCompany.Account;
                txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;

                txtInCompanyAccount.Text = m_account.InCompany.Account;
                txtInCompanyBank.Text = m_account.InCompany.Bank.Name;

                txtMemo.Text = m_account.Memo;
            }
            else
            {
                dtSigned.Value = DateTime.Now;
                txtCode.Text = "";
                lueInCompany.EditValue = null;
                lueOutCompany.EditValue = null;
                txtOutComapnyAccount.Text = "";
                txtOutCompanyBank.Text = "";

                txtInCompanyAccount.Text = "";
                txtInCompanyBank.Text = "";

                txtMemo.Text = "";
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
            m_account.SignedDate = dtSigned.Value;
            //TODO: 未完成
            return true;
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="account"></param>
        public DevAccount(Account account = null)
        {
            InitializeComponent();

            if (account != null)
            {
                m_account = account;
                SetFormStatus(winStatus.Edit);
            }
            else
            {
                m_account = new Account();
                SetFormStatus(winStatus.New);
            }
        }

        private void DevAccount_Load(object sender, EventArgs e)
        {
            // 初始化界面
            InitList();
            Object2form();
        }

        /// <summary>
        /// 同步支出单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueOutCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueOutCompany.EditValue != null)
                m_account.Out_Company_ID = long.Parse(lueOutCompany.EditValue.ToString());
            txtOutCompanyBank.Text = m_account.OutCompany.Bank.Name;
            txtOutComapnyAccount.Text = m_account.OutCompany.Account;
        }

        /// <summary>
        /// 同步收入单位的信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueInCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueInCompany.EditValue != null)
                m_account.In_Company_ID = long.Parse(lueInCompany.EditValue.ToString());
            txtInCompanyBank.Text = m_account.InCompany.Bank.Name;
            txtInCompanyAccount.Text = m_account.InCompany.Account;
        }

        private void dtSigned_ValueChanged(object sender, EventArgs e)
        {
            m_account.SignedDate = dtSigned.Value;
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            m_account.Code = txtCode.Text;
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {
            m_account.Memo = txtMemo.Text;
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_account.DetailList.Add(new AccountDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_account.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            if (m_account.Save())
            {
                MessageBox.Show("保存成功！");
                SetFormStatus(winStatus.View);
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
            SetFormStatus(winStatus.New);
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
            SetFormStatus(winStatus.Edit);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_account.ID > 0)
                m_account.Destory();
        }

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
            if (m_status != winStatus.View)
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
    }
}