using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Helper;
using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevUnAuth : DevExpress.XtraEditors.XtraForm
    {
        private winStatusEnum _status;

        private UnAuth _unauth;

        public DevUnAuth(winStatusEnum status, UnAuth unauth = null)
        {
            InitializeComponent();
            SetFormStatus(status);

            _unauth = unauth;
            if (status == winStatusEnum.新增)
                _unauth = new UnAuth();
            Object2Form();
        }

        /// <summary>
        /// 根据用户的权限设置控件的可用与否
        /// </summary>
        private void SetControlAccess()
        {
            if (!Access.getUserAccess(GlobalSet.Current_User, (long) FctionEnum.非授权资金, (long) ActionEnum.新增))
            {
                tsbNew.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User, (long) FctionEnum.非授权资金, (long) ActionEnum.编辑))
            {
                tsbEdit.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            if (!Access.getUserAccess(GlobalSet.Current_User, (long) FctionEnum.非授权资金, (long) ActionEnum.删除))
            {
                tsbDelete.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
        }

        private void SetFormStatus(winStatusEnum status)
        {
            _status = status;
            switch (status)
            {
                case winStatusEnum.新增:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.编辑:
                    tsbNew.Enabled = false;
                    tsbEdit.Enabled = false;
                    tsbDelete.Enabled = false;
                    tsbSave.Enabled = true;
                    SetEditorStatus(true);
                    break;
                case winStatusEnum.查看:
                    tsbNew.Enabled = true;
                    tsbEdit.Enabled = true;
                    tsbDelete.Enabled = true;
                    tsbSave.Enabled = false;
                    SetEditorStatus(false);
                    break;
            }
        }

        private void SetEditorStatus(bool enabled)
        {
            dtSignedDate.Enabled = enabled;
            txtCode.Enabled = enabled;
            txtMemo.Enabled = enabled;
            txtMoney.Enabled = enabled;
            lueCompany.Enabled = enabled;
            lueAccount.Enabled = enabled;
            chkOutput.Enabled = enabled;
        }


        private bool Verify()
        {
            Form2Object();

            dxErrorProvider1.ClearErrors();
            _unauth.InsertVerify();
            foreach (KeyValuePair<string, string> kv in _unauth.Error_Info)
            {
                switch (kv.Key)
                {
                    case "Code":
                        dxErrorProvider1.SetError(txtCode, kv.Value);
                        break;
                    case "CompanyID":
                        dxErrorProvider1.SetError(lueCompany, kv.Value);
                        break;
                    case "CompanyDetailID":
                        dxErrorProvider1.SetError(lueAccount, kv.Value);
                        break;
                    case "Money":
                        dxErrorProvider1.SetError(txtMoney, kv.Value);
                        break;
                }
            }
            if (_unauth.Error_Info.Count > 0)
                MessageBox.Show(_unauth.ErrorString, "出错了！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return _unauth.Error_Info.Count == 0;
        }

        private void Form2Object()
        {

            _unauth.Code = txtCode.Text;
            if (lueCompany.EditValue != null)
                _unauth.CompanyID = long.Parse(lueCompany.EditValue.ToString());
            if (lueAccount.EditValue != null)
                _unauth.CompanyDetailID = long.Parse(lueAccount.EditValue.ToString());
            _unauth.Output = "";
            _unauth.Input = "";
            if (chkOutput.Checked)
                _unauth.Output = "X";
            else
                _unauth.Input = "X";

            _unauth.Money = txtMoney.Value;
            _unauth.Memo = txtMemo.Text;
            _unauth.SignedDate = dtSignedDate.DateTime;
        }

        private void Object2Form()
        {
            List<Company> companies = Company.Query("output = 'X'");
            lueCompany.Properties.DataSource = null;
            lueCompany.Properties.DataSource = companies;

            if (_unauth != null)
            {
                List<CompanyDetail> details = CompanyDetail.Query("parent_id = " + _unauth.CompanyID);
                lueAccount.Properties.DataSource = null;
                lueAccount.Properties.DataSource = details;

                txtCode.Text = _unauth.Code;
                if (_unauth.CompanyID > 0)
                    lueCompany.EditValue = _unauth.CompanyID;

                if (_unauth.CompanyDetailID > 0)
                    lueAccount.EditValue = _unauth.CompanyDetailID;

                if (_unauth.ID > 0)
                    dtSignedDate.DateTime = _unauth.SignedDate;
                else
                    dtSignedDate.DateTime = DateTime.Now;

                chkOutput.Checked = ( _unauth.Input == "X" ? false : true);
                txtMoney.Value = _unauth.Money;
                txtMemo.Text = _unauth.Memo;
            }
        }

        private void DevUnAuth_Load(object sender, EventArgs e)
        {
            if(_unauth != null)
                Object2Form();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _unauth = new UnAuth();
            Object2Form();
            SetFormStatus(winStatusEnum.新增);
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_unauth == null)
            {
                MessageBox.Show("当前没有可以编辑的数据");
                return;
            }

            SetFormStatus(winStatusEnum.编辑);
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (_unauth == null)
            {
                MessageBox.Show("当前没有可以删除的数据");
                return;
            }

            _unauth.Destory();
            _unauth = new UnAuth();
            Object2Form();
            _unauth = null;

            SetFormStatus(winStatusEnum.查看);
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            _unauth.Save();
            SetFormStatus(winStatusEnum.查看);
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void lueCompany_EditValueChanged(object sender, EventArgs e)
        {
            if (lueCompany.EditValue == null)
                return;

            List<CompanyDetail> details =
                CompanyDetail.Query("parent_id =" + long.Parse(lueCompany.EditValue.ToString()));

            lueAccount.Properties.DataSource = null;
            lueAccount.Properties.DataSource = details;

        }

        private void txtMoney_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }
        delegate void EditorSelectAllProc(Control c);
        void EditorSelectAll(Control c)
        {
            ((TextBox)c.Controls[0]).SelectAll();
        }

        private void txtMoney_Click(object sender, EventArgs e)
        {
            this.BeginInvoke(new EditorSelectAllProc(EditorSelectAll), (Control)sender);
        }

        private void lueAccount_EditValueChanged(object sender, EventArgs e)
        {
            if (lueAccount.EditValue == null)
                return;

            long id = long.Parse(lueAccount.EditValue.ToString());
            CompanyDetail cd = CompanyDetail.CreateByID(id);

            txtBank.Text = cd.BankName;
        }
    }
}