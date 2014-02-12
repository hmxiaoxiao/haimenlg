using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.DB;
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

        // 将更新单位中的单位
        private void update_2013_11_14()
        {
            List<Company> coms = Company.Query("name = '收入单位'");
            if (coms.Count == 1)
            {
                coms[0].Code = "WDW001";
                coms[0].Name = "外单位";
                coms[0].Save();
            }

            coms = Company.Query("name='支出单位'");
            if (coms.Count == 1)
            {
                coms[0].Code = "BDW001";
                coms[0].Name = "本单位";
                coms[0].Save();
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedItem.ToString())
            {
                case "2013-11-08更新":
                    update_2013_11_08();
                    break;
                case "2013-11-14更新":
                    update_2013_11_14();
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
                    btnUpdate.Enabled = true;
                    break;
                case "2013-11-12更新":
                    _assembly = Assembly.GetExecutingAssembly();
                    _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Haimen.Readme.2013-11-12.rtf"));
                    richTextBox1.Rtf = _textStreamReader.ReadToEnd();
                    btnUpdate.Enabled = false;
                    break;
                case "2013-11-13更新":
                    _assembly = Assembly.GetExecutingAssembly();
                    _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Haimen.Readme.2013-11-13.rtf"));
                    richTextBox1.Rtf = _textStreamReader.ReadToEnd();
                    btnUpdate.Enabled = false;
                    break;
                case "2013-11-14更新":
                    _assembly = Assembly.GetExecutingAssembly();
                    _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Haimen.Readme.2013-11-14.rtf"));
                    richTextBox1.Rtf = _textStreamReader.ReadToEnd();
                    btnUpdate.Enabled = true;
                    break;
                case "2013-11-21更新":
                    _assembly = Assembly.GetExecutingAssembly();
                    _textStreamReader = new StreamReader(_assembly.GetManifestResourceStream("Haimen.Readme.2013-11-21.rtf"));
                    richTextBox1.Rtf = _textStreamReader.ReadToEnd();
                    btnUpdate.Enabled = false;
                    break;
            }
        }

    }
}