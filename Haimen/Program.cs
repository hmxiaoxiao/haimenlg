using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.GUI;
using Haimen.Entity;

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


            // 初始化用户, 第一次使用时，没有用户时增加用户。
            User.Init();


            //// 显示登录窗口
            //frmLogin win = new frmLogin();
            //win.ShowDialog();

            GlobalSet.Current_User = User.Verify("admin", "qwer1234");
            if ( GlobalSet.Current_User != null)
            {
                Application.Run(new frmMain());
            }
        }
    }
}
