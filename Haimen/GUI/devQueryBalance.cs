using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Qy;

namespace Haimen.GUI
{
    public partial class devQueryBalance : DevExpress.XtraEditors.XtraForm
    {
        private List<string> bankid_list = new List<string>();
        private bool bank_selected_all = true;

        private List<string> companyid_list = new List<string>();
        private bool company_selected_all = true;

        public devQueryBalance()
        {
            InitializeComponent();
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void tsbSelectBank_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            devQuerySelectBank dia = new devQuerySelectBank();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bankid_list = dia.ID_List;
                //bank_selected_all =
                bank_selected_all = dia.SelectAll;
                MyQuery();
            }
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MyQuery();
        }

        private void MyQuery()
        {
            string sql = "select c.name as companyname, b.name as bankname, d.account, d.balance, d.credit ";
            sql += " from m_company_detail d, m_bank b, m_company c ";
            sql += " where d.parent_id = c.id and d.bank_id = b.id";

            // 如果不是显示全部银行数据,则只显示选择中数据
            if (!bank_selected_all)
            {
                string ids = "";
                foreach (string id in bankid_list)
                {
                    ids += id + ",";
                }
                if (ids.Length > 0)
                    ids = ids.Substring(0, ids.Length - 1);
                if (bankid_list.Count > 0)
                    sql += " and d.bank_id in (" + ids + ")";
                else
                    sql += " and d.bank_id in ( 0 )";
            }

            // 单位数据同上处理
            if (!company_selected_all)
            {
                string ids = "";
                foreach (string id in companyid_list)
                {
                    ids += id + ",";
                }
                if (ids.Length > 0)
                    ids = ids.Substring(0, ids.Length - 1);
                if (companyid_list.Count > 0)
                    sql += " and d.parent_id in (" + ids + ")";
                else
                    sql += " and d.parent_id in ( 0 )";
            }
            sql += " order by c.name, b.name";

            gridControl1.DataSource = DBFunction.RunQuerySql(sql).Tables[0];
            gridView1.BestFitColumns();
        }

        private void tsbSelectCompany_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            devQuerySelectCompany dia = new devQuerySelectCompany();
            if (dia.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                companyid_list = dia.ID_List;
                //bank_selected_all =
                company_selected_all = dia.SelectAll;
                MyQuery();
            }
        }
    }
}