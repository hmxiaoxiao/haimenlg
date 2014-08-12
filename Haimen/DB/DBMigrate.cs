using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Haimen.DB
{
    /// <summary>
    /// 数据库自动更新工具
    /// </summary>
    public class DBMigrate
    {
        // 判断是否存在某个表
        public static bool IsExistTable(string table_name)
        {
            string sql = string.Format("SELECT  * FROM dbo.SysObjects WHERE ID = object_id(N'{0}') AND OBJECTPROPERTY(ID, 'IsTable') = 1", table_name);
            return DBConnection.RunQuerySql(sql).Tables[0].Rows.Count > 0;
        }

        // 自动增加数据表
        public static void RunDBMigrate()
        {
            if (!IsExistTable("m_log"))
                DBConnection.RunNoQuerySql(m_log);
        }

        // 初始化数据库语句
        static DBMigrate()
        {
            //migrate.Add(new KeyValuePair<string, string>("dbmigrate", dbmigrate));
        }

        //private static List<KeyValuePair<string,string>> migrate = new List<KeyValuePair<string,string>>();
        private static string m_log = @"
CREATE TABLE [dbo].[m_log](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[oper_date] [datetime] NULL,
	[model_name] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[oper] [nvarchar](50) NULL,
	[object] [nvarchar](2000) NULL,
	[created_date] [datetime] NULL,
	[updated_date] [datetime] NULL,
	[deleted] [bigint] NOT NULL,
 CONSTRAINT [PK_m_log] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
";



    }

}
