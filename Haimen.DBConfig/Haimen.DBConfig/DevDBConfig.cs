using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Haimen.Helper;
using System.Data.SqlClient;


namespace Haimen.DBConfig
{
    public partial class DevDBConfig : DevExpress.XtraEditors.XtraForm
    {
        public DevDBConfig()
        {
            InitializeComponent();
        }

        private void DevDBConfig_Load(object sender, EventArgs e)
        {
            CustomerINI.SetFormSkin();

            txtHost.Text = CustomerINI.GetDBConfigValue(INIDBKeyEnum.Host);
            txtDB.Text = CustomerINI.GetDBConfigValue(INIDBKeyEnum.DB);
            txtUser.Text = CustomerINI.GetDBConfigValue(INIDBKeyEnum.User);
            txtPassword.Text = CustomerINI.GetDBConfigValue(INIDBKeyEnum.Password);

            txtFTPURL.Text = CustomerINI.GetFTPConfigValue(INIFTPKeyEnum.Host);
            txtFTPName.Text = CustomerINI.GetFTPConfigValue(INIFTPKeyEnum.User);
            txtFTPPassword.Text = CustomerINI.GetFTPConfigValue(INIFTPKeyEnum.Password);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            try
            {
                string connStr = @"Data Source=" + txtHost.Text +
                    ";Initial Catalog=" + txtDB.Text + ";User ID=" + txtUser.Text +
                    ";Password=" + txtPassword.Text;
                conn = new SqlConnection(connStr);
                conn.Open();
                MessageBox.Show("参数正确！");
            }
            catch(Exception err)
            {
                MessageBox.Show("参数不正确，请重新设置: \n\r" + err.Message, "注意");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerINI.WriteDBConfig(txtHost.Text, txtDB.Text, txtUser.Text, txtPassword.Text);
            CustomerINI.WriteFTPConfig(txtFTPURL.Text, txtFTPName.Text, txtFTPPassword.Text);
            MessageBox.Show("参数设置保存成功！", "注意");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
