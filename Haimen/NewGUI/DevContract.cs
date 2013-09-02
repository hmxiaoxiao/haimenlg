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
    public partial class DevContract : DevExpress.XtraEditors.XtraForm
    {

        private Contract m_contract;
        private List<Company> m_companies = Company.Query();

        private winStatus m_status;
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

        private void InitGUI()
        {
            lueCompany.Properties.DataSource = m_companies;
            lueCompany.Properties.DisplayMember = "Name";
            lueCompany.Properties.ValueMember = "ID";
        }

        private void Object2Form()
        {
            if (m_contract.ID > 0)
            {
                txtCode.Text = m_contract.Code;
                txtName.Text = m_contract.Name;
                lueCompany.EditValue = m_contract.CompanyID;
                dtSignedDate.Value = m_contract.SignedDate;
                dtBeginDate.Value = m_contract.BeginDate;
                dtEndDate.Value = m_contract.EndDate;
                txtMemo.Text = m_contract.Memo;
                txtMoney.Text = m_contract.Money.ToString();
                txtPayment_ratio.Text = m_contract.PaymentRatio.ToString();
                txtSecurity.Text = m_contract.Security.ToString();
            }
            else
            {
                txtCode.Text = "";
                txtName.Text = "";
                lueCompany.EditValue = null;
                dtSignedDate.Value = DateTime.Now;
                dtBeginDate.Value = DateTime.Now;
                dtEndDate.Value = DateTime.Now;
                txtMemo.Text = "";
                txtMoney.Text = "";
                txtPayment_ratio.Text = "";
                txtSecurity.Text = "";
            }
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;

            lstFiles.Items.Clear();
            foreach (Attach a in m_contract.AttachList)
            {
                lstFiles.Items.Add(a.ID.ToString() + "." + a.FileName, 2);
            }
        }

        private bool Verify()
        {
            m_contract.Code = txtCode.Text;
            m_contract.Name = txtName.Text;
            m_contract.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            m_contract.SignedDate = dtSignedDate.Value;
            m_contract.BeginDate = dtBeginDate.Value;
            m_contract.EndDate = dtEndDate.Value;
            m_contract.Memo = txtMemo.Text;
            m_contract.Money = decimal.Parse(txtMoney.Text);
            m_contract.PaymentRatio = decimal.Parse(txtPayment_ratio.Text);
            m_contract.Security = decimal.Parse(txtSecurity.Text);

            return true;
        }

        public DevContract(Contract con = null)
        {
            InitializeComponent();
            if (con != null)
            {
                m_contract = con;
                SetFormStatus(winStatus.Edit);
            }
            else
            {
                m_contract = new Contract();
                SetFormStatus(winStatus.New);
            }
        }

        private void DevContract_Load(object sender, EventArgs e)
        {
            InitGUI();
            Object2Form();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            m_contract.DetailList.Add(new ContractDetail());
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_contract.DetailList;
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            gridView1.DeleteRow(gridView1.FocusedRowHandle);
        }

        private void tbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_contract.Save();
            MessageBox.Show("保存成功！");
        }

        private void tbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            m_contract = new Contract();
            InitGUI();
            Object2Form();
            SetFormStatus(winStatus.New);
        }

        private void tbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
            {
                InitGUI();
                Object2Form();
                SetFormStatus(winStatus.Edit);
            }
        }

        private void tbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (m_contract != null && m_contract.ID > 0)
                m_contract.Destory();
            SetFormStatus(winStatus.View);
        }

        private void tbCheck_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

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

                m_contract.AttachList.Add(att);

                // 加入列表
                lstFiles.Items.Add(att.ID.ToString() + "." + fi.Name, 2);
            }
        }

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