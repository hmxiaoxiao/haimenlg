using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Haimen.Entity;

namespace Haimen.GUI
{
    public partial class DevMonthly : DevExpress.XtraEditors.XtraForm
    {


        public DevMonthly()
        {
            InitializeComponent();
            init();
        }

        // 初始化数据
        private void init()
        {
            cboYear.Items.Clear();
            for (int i = DateTime.Now.Year - 1; i <= DateTime.Now.Year + 1; i ++)
            {
                cboYear.Items.Add(i.ToString());
            }

            // 初始化值
            string monthly_year = SystemSet.GetValue(SystemSet.MONTHLY_YEAR);
            string monthly_month = SystemSet.GetValue(SystemSet.MONTHLY_MONTH);

            if (string.IsNullOrEmpty(monthly_year))
            {
                cboYear.SelectedItem = DateTime.Now.Year.ToString();
                cboMonth.SelectedItem = DateTime.Now.Month.ToString();
            }
            else
            {
                int year = int.Parse(monthly_year);
                int month = int.Parse(monthly_month);
                if(month == 12)
                {
                    month = 1;
                    year += 1;
                }
                else
                {
                    month += 1;
                }
                cboYear.SelectedItem = year.ToString();
                cboMonth.SelectedItem = month.ToString();
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboYear.SelectedItem.ToString()))
            {
                MessageBox.Show("请选择月结的年份");
                return;
            }

            if (string.IsNullOrEmpty(cboMonth.SelectedItem.ToString()))
            {
                MessageBox.Show("请选择月结的月份");
                return;
            }

            // 检查一下是否有未审核完的单据，
            int year = int.Parse(cboYear.SelectedItem.ToString());
            int month = int.Parse(cboMonth.SelectedItem.ToString());
            if(month == 12)
            {
                month = 1;
                year += 1;
            }
            else
            {
                month += 1;
            }
            string filter = String.Format("status <> {0} and signed_date < ", (long)Account.AccountStatusEnum.已审核);
            filter += String.Format("'{0}-{1}-01 0:0:0'", year, month);
            List<Account> lists = Account.Query(filter);
            if (lists.Count > 0)
            {
                MessageBox.Show("还有单据没有审核，请全部审核后再月结");
                return;
            }

            SystemSet.SetValue(SystemSet.MONTHLY_YEAR, cboYear.SelectedItem.ToString());
            SystemSet.SetValue(SystemSet.MONTHLY_MONTH, cboMonth.SelectedItem.ToString());
            DevMain main = (DevMain)this.ParentForm;
            main.SetAccount(SystemSet.CurrentAccount());

            MessageBox.Show("月结完成");
        }
    }
}