using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

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
            // 系统初始化
            string version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            GlobalSet.SystemName = "资金管理系统 - (" + version + ")";
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);

            //////初始化用户, 第一次使用时，没有用户时增加用户。
            try
            {
                User.Init();

#if DEBUG
                //GlobalSet.Current_User = User.Login("yangxd", "heroes22");
                GlobalSet.Current_User = User.Login("admin", "qwer1234");
#else
                // 显示登录窗口
                DevLogin win = new DevLogin();
                win.ShowDialog();
#endif


                //DevAccess bank = new DevAccess();
                //bank.ShowDialog();
                //CustomerINI.WriteDBConfig("r400", "haimen", "sa", "heroes22");

                if (GlobalSet.Current_User != null)
                {
                    Application.Run(new DevMain());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.ToString(), "错误");
            }


        }
    }
}
