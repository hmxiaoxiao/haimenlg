using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

using Haimen.GUI;

namespace Haimen
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 初始化
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 显示登录窗口
            frmLogin win = new frmLogin();
            win.ShowDialog();

            if (win.getVierfy())
            {
                Application.Run(new frmMain());
            }
        }
    }
}
