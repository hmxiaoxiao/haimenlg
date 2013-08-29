using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Helper;
using System.IO;

namespace Haimen.NewGUI
{
    public partial class DevAttach : DevExpress.XtraEditors.XtraForm
    {
        private FTPClient m_ftp = new FTPClient("localhost", "", "");

        public DevAttach()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "请选择需要上传的文件";
            fd.ValidateNames = true;
            fd.CheckFileExists = true;
            fd.CheckPathExists = true;
            fd.Multiselect = true;
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in fd.FileNames)
                {
                    lstFiles.Items.Add(file);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstFiles.Items.Count; i++)
            {
                FileInfo fi = new FileInfo(lstFiles.Items[i].ToString());
               
                m_ftp.fileUpload(fi, @"\", fi.Name);
                lstFiles.SetItemChecked(i, true);
                MessageBox.Show(lstFiles.Items[i].ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}