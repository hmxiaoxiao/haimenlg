using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Entity;

namespace Haimen.NewGUI
{
    public partial class DevBalanceList : DevExpress.XtraEditors.XtraForm
    {
        private List<Balance> m_balances;
        private DevMain m_main ;

        /// <summary>
        /// 编辑当前的行对象
        /// </summary>
        private void OpenEditForm()
        {
            Balance bal = CurrentSelectObject();
            if (bal != null)
                m_main.OpenForm(new DevBalance(bal));
            return;
        }

        /// <summary>
        /// 当前表格选中的行所对应的对象
        /// </summary>
        /// <returns></returns>
        private Balance CurrentSelectObject()
        {
            if (gridView1.FocusedRowHandle < 0)
                return null;

            long id = long.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, col_id).ToString());
            foreach (Balance bl in m_balances)
            {
                if (bl.ID == id)
                {
                    return bl;
                }
            }
            return null;
        }

        /// <summary>
        /// 自定义更新
        /// </summary>
        private void MyRefresh()
        {
            m_balances = Balance.Query();
            gridControl1.DataSource = null;
            gridControl1.DataSource = m_balances;
        }


        public DevBalanceList()
        {
            InitializeComponent();
        }

        private void DevBalanceList_Load(object sender, EventArgs e)
        {
            m_main = (DevMain)this.ParentForm;

            MyRefresh();
        }

        private void tsbNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevBalance());
        }

        private void tsbEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenEditForm();
        }

        private void tsbDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Balance bal = CurrentSelectObject();
            if (bal != null)
            {
                bal.Destory();
                MyRefresh();
            }
        }

        private void tsbGene_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void tsbVerify_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevMain main = (DevMain)this.ParentForm;
            main.OpenForm(new DevBalance());
        }

        private void tsbQuery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DevBalanceQuery query = new DevBalanceQuery();
            if (query.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                //生成查询
                List<string> filters = new List<string>();
                if (query.Q_Code.Length > 0)
                    filters.Add(" Code = '%" + query.Q_Code + "%' ");
                if (query.Q_Bank_ID.Length > 0)
                    filters.Add(" bank_id = " + query.Q_Bank_ID + " ");
                if (query.Q_Company_ID.Length > 0)
                    filters.Add(" Company_id = " + query.Q_Company_ID + " ");

                string where = "";
                foreach (string filter in filters)
                {
                    where += filter + " and ";
                }
                if (where.Length > 0)
                    where = where.Substring(0, where.Length - 4);

                m_balances = Balance.Query(where);
                gridControl1.DataSource = null;
                gridControl1.DataSource = m_balances;
            }
        }

        private void tsbExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}