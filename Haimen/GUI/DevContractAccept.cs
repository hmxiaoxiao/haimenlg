using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevContractAccept : DevExpress.XtraEditors.XtraForm
    {
        private Contract m_contract;  // 要验收的合同
        private ContractAccept m_contract_accept;

        public DevContractAccept(Contract ct)
        {
            InitializeComponent();
            m_contract = ct;
        }

        private bool Verify()
        {
            m_contract_accept.AcceptUnit = txtAcceptUnit.Text;
            m_contract_accept.AcceptDate = DateTime.Parse(dtAcceptDate.EditValue.ToString());
            if (chkPass.Checked)
                m_contract_accept.Pass = 1;
            else
                m_contract_accept.Pass = 0;
            m_contract_accept.Money = decimal.Parse(clMoney.EditValue.ToString());
            m_contract_accept.Memo = txtMemo.Text;

            m_contract_accept.Verify();
            dxErrorProvider1.ClearErrors();
            foreach (KeyValuePair<string, string> kv in m_contract_accept.Error_Info)
            {
                switch(kv.Key)
                {
                    case "ContractID":
                        dxErrorProvider1.SetError(txtContractCode, kv.Value);
                        break;
                    case "AcceptUnit":
                        dxErrorProvider1.SetError(txtAcceptUnit, kv.Value);
                        break;
                    case "Memo":
                        dxErrorProvider1.SetError(txtMemo, kv.Value);
                        break;
                }
            }

            return !dxErrorProvider1.HasErrors;
        }

        private void DevContractAccept_Load(object sender, EventArgs e)
        {
            txtContractCode.Text = m_contract.Code;
            txtContractName.Text = m_contract.Name;
            txtContractMoney.Text = m_contract.Money.ToString();
            txtContractPay.Text = m_contract.Pay.ToString();
            txtContractUnpay.Text = (m_contract.Money - m_contract.Pay).ToString();
            txtContractPartyAName.Text = m_contract.PartyA.Name;
            txtContractPartyBName.Text = m_contract.PartyB.Name;

            dtAcceptDate.EditValue = DateTime.Now;
            clMoney.EditValue = m_contract.Money - m_contract.Pay;

            m_contract_accept = new ContractAccept();
            m_contract_accept.ContractID = m_contract.ID;
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!Verify())
                return;

            m_contract_accept.Save();
            layoutControl1.Enabled = false;
            MessageBox.Show("保存成功！");
        }
    }
}