using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Qy;
using Haimen.Entity;

using System.IO;
using System.Reflection;

namespace Haimen.GUI
{
    public partial class DevAdmin : DevExpress.XtraEditors.XtraForm
    {
        Assembly _assembly;
        StreamReader _textStreamReader;

        public DevAdmin()
        {
            InitializeComponent();
        }


        private void DevAdmin_Load(object sender, EventArgs e)
        {
            //try
            //{

            //}
            //catch
            //{
            //    MessageBox.Show("Error accessing resources!");
            //}
        }

        // 为所有的外单位加一个现金帐户
        private void update_2013_11_08() {
            List<Bank> banks = Bank.Query("code = 'XJ' and name = '现金'");
            if (banks.Count == 0)
            {
                MessageBox.Show("请增加一个银行，其代码为‘XJ’，名称为‘现金’");
                return;
            }
            List<Company> list = Company.Query();
            foreach (Company cp in list)
            {
                bool finded = false;
                foreach (CompanyDetail cd in cp.DetailList)
                {
                    if (cd.Account == "现金")
                        finded = true;
                }
                if (!finded)        //没有找到现金户的话，就直接处理
                {
                    CompanyDetail newcd = new CompanyDetail();
                    newcd.Account = "现金";
                    newcd.AccountType = "现金户";
                    newcd.ParentID = cp.ID;
                    newcd.BankID = banks[0].ID;
                    newcd.Save();
                }
            }
        }

        // 将资金性质全部+父结点名称
        private void update_2013_11_12()
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "2013-11-08更新":
                    update_2013_11_08();
                    break;
                case "2013-11-12更新":
                    update_2013_11_12();
                    break;
            }
            MessageBox.Show("更新完成");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
                return;
            switch (listBox1.SelectedItem.ToString())
            {
                case "2013-11-08更新":
                    _assembly = Assembly.GetExecutingAssembly();
                    _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Haimen.Readme.2013-11-08.rtf"));
                    richTextBox1.Rtf = _textStreamReader.ReadToEnd();
                    break;
            }
        }

    }
}