using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

using System.Data;

namespace Haimen.Report
{
    public partial class rptBalance : DevExpress.XtraReports.UI.XtraReport
    {
        private DataSet m_ds;

        public rptBalance(DataSet ds)
        {
            InitializeComponent();
            m_ds = ds;

            // 设置日期
            txtDate.Text = "截止日期：" + string.Format("{0:d}", DateTime.Now);

            // 设置标题
            capDoc1.Text = m_ds.Tables["company"].Rows[0]["doc"].ToString();
            capDoc2.Text = m_ds.Tables["company"].Rows[1]["doc"].ToString();
            capDoc3.Text = m_ds.Tables["company"].Rows[2]["doc"].ToString();
            capDoc4.Text = m_ds.Tables["company"].Rows[3]["doc"].ToString();
            capDoc5.Text = m_ds.Tables["company"].Rows[4]["doc"].ToString();
            capDoc6.Text = m_ds.Tables["company"].Rows[5]["doc"].ToString();
            capDoc7.Text = m_ds.Tables["company"].Rows[6]["doc"].ToString();

            // 绑定数据
            this.DataSource = ds.Tables["report"];

            txtSN.DataBindings.Add("Text", this.DataSource, "序号");
            this.txtBank.DataBindings.Add("Text", this.DataSource, "银行名称");
            txtCount.DataBindings.Add("Text", this.DataSource, "小计", "{0:c}");
            txtDoc1.DataBindings.Add("Text", this.DataSource, capDoc1.Text, "{0:c}");
            txtDoc2.DataBindings.Add("Text", this.DataSource, capDoc2.Text, "{0:c}");
            txtDoc3.DataBindings.Add("Text", this.DataSource, capDoc3.Text, "{0:c}");
            txtDoc4.DataBindings.Add("Text", this.DataSource, capDoc4.Text, "{0:c}");
            txtDoc5.DataBindings.Add("Text", this.DataSource, capDoc5.Text, "{0:c}");
            txtDoc6.DataBindings.Add("Text", this.DataSource, capDoc6.Text, "{0:c}");
            txtDoc7.DataBindings.Add("Text", this.DataSource, capDoc7.Text, "{0:c}");



        }

    }
}
