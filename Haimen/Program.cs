using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.GUI;
using Haimen.Entity;

using Haimen.NewGUI;

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
            //  C#winForm的初始化
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 系统初始化
            GlobalSet.SystemName = "临江财政资金管理系统";
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //初始化用户, 第一次使用时，没有用户时增加用户。
            //User.Init();


            // 显示登录窗口
            DevLogin win = new DevLogin();
            win.ShowDialog();

            //frmSplash fs = new frmSplash();
            //fs.Show();

            //frmBalanceList bank = new frmBalanceList();
            //bank.ShowDialog();

            //GlobalSet.Current_User = User.Login("admin", "qwer1234");
            if (GlobalSet.Current_User != null)
            {
                Application.Run(new DevMain());
            }
        }
    }
}
