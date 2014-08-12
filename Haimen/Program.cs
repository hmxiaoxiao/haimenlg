using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Haimen.Entity;
using Haimen.Helper;

using Haimen.GUI;
using Haimen.DB;

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
            GlobalSet.SystemName = String.Format("资金管理系统 - ({0})", version);
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();
            Application.EnableVisualStyles();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.SetCompatibleTextRenderingDefault(false);

            string errinfo;
            if (!Haimen.DB.DBConnection.TestDBConnection(out errinfo))
            {
                MessageBox.Show("无法联接数据库服务器，请确认数据库服务器正常运行，网络联接并且配置正确！");
                return;
            }

            // 自动更新表
            DBMigrate.RunDBMigrate();

            //////初始化用户, 第一次使用时，没有用户时增加用户。
            //User.Init();

#if DEBUG
            //GlobalSet.Current_User = User.Login("yangxd", "heroes22");
            GlobalSet.Current_User = User.Login("admin", "qwer1234");
            Application.Run(new DevMain());
#else
            try
            {
                // 显示登录窗口
                DevLogin win = new DevLogin();
                win.ShowDialog();
                
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
#endif
        }
    }
}

// 以下为计算每个月所有的发生总金额

//select company_name, bank_name, account, y, m, sum(money)
//from(
//    select b.name as company_name, c.name as bank_name, a.account, 
//            datepart(yyyy, a.created_date)as y, datepart(mm, a.created_date)as m, 
//            balance as money, '初始化' as memo
//        from m_company_detail a,
//            m_company b,
//            m_bank c
//        where a.parent_id = b.id and a.bank_id = c.id and b.output = 'X'
//    union
//    select c.name as company_name, d.name as bank_name, b.account, a.y, a.m, -sum(a.money) as money, '授权支出' as memo
//        from(
//            select datepart(yyyy, signed_date) as y, datepart(mm, signed_date) as m,* from t_account
//            where deleted <> '1' and status = '2') a,
//            m_company_detail b,
//            m_company c,
//            m_bank d
//        where a.out_companydetail_id = b.id and b.parent_id = c.id and b.bank_id = d.id and c.output = 'X'
//        group by c.name, d.name, b.account, a.y, a.m
//    union
//    select c.name as company_name, d.name as bank_name, b.account, a.y, a.m, sum(a.money) as money, '授权收入' as memo
//        from(
//            select datepart(yyyy, signed_date) as y, datepart(mm, signed_date) as m,* from t_account
//            where deleted <> '1' and status = '2') a,
//            m_company_detail b,
//            m_company c,
//            m_bank d
//        where a.in_companydetail_id = b.id and b.parent_id = c.id and b.bank_id = d.id and c.output = 'X'
//        group by c.name, d.name, b.account, a.y, a.m
//    union
//    select c.name as company_name, d.name as bank_name, b.account, a.y, a.m, -sum(a.money) as money, '非授权支出' as memo
//        from(
//            select datepart(yyyy, signed_date) as y, datepart(mm, signed_date) as m,*  
//            from t_unauth where deleted <> '1' and output = 'X') a,
//            m_company_detail b,
//            m_company c,
//            m_bank d
//        where a.company_id = c.id and a.companydetail_id = b.id and b.bank_id = d.id
//        group by c.name, d.name, b.account, a.y, a.m
//    union
//    select c.name as company_name, d.name as bank_name, b.account, a.y, a.m, sum(a.money) as money, '非授权收入' as memo
//        from(
//            select datepart(yyyy, signed_date) as y, datepart(mm, signed_date) as m,*  
//            from t_unauth where deleted <> '1' and output = 'X') a,
//            m_company_detail b,
//            m_company c,
//            m_bank d
//        where a.company_id = c.id and a.companydetail_id = b.id and b.bank_id = d.id
//        group by c.name, d.name, b.account, a.y, a.m) a
//group by company_name, bank_name, account,y,m
