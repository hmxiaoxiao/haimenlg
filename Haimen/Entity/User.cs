using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using Haimen.DB;


namespace Haimen.Entity
{
    /// <summary>
    ///  用户类
    /// </summary>
    [Table("m_user")]
    public class User : SingleEntity<User>
    {
        /// <summary>
        /// 用户代码 
        /// </summary>
        [Field("code")]
        public string Code { get; set; }


        /// <summary>
        /// 用户名称 
        /// </summary>
        [Field("name")]
        public string Name { get; set; }


        /// <summary>
        /// 密码的混淆码
        /// </summary>
        [Field("salt")]
        public string Salt { get; set; }


        /// <summary>
        /// 是否超级用户, 'X'是超级用户(大写)
        /// </summary>
        [Field("admin")]
        public string Admin { get; set; }


        /// <summary>
        /// 所在的用户组
        /// </summary>
        [Field("ugroup")]
        public long GroupID { get; set; }


        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }


        // 用户初始化
        // 第一次使用时，增加一个超级用户
        public static bool Init()
        {
            try
            {
                List<User> list = Query();
                if (list.Count == 0)
                {
                    User admin = new User() { Code = "admin", Name = "超级用户", Password = "qwer1234", Admin = "X" };
                    admin.Save();
                }
                return true;
            }
            catch (Exception e)
            {
                User.ExceptionString = String.Format("取得数据库信息出错！原因如下：{0}{1}", Environment.NewLine, e.Message);
                return false;
            }
        }


        // 传入用户的CODE以及密码，判断是否可以登录
        // 这里是唯一不会返回错误原因的地方
        public static User Login(string code, string password)
        {
            if (string.IsNullOrEmpty(code))
                return null;

            List<User> list = User.Query(String.Format("Code = '{0}'", code)); ;

            if (list.Count != 1)
                return null;

            if (verifyMd5Hash(code, password, list[0].Salt))
                return list[0];
            else
                return null;
        }

        
        /// <summary>
        /// 用户保存前，要将密码混淆
        /// </summary>
        /// <returns>成功与否</returns>
        public override bool Insert(bool hasTrans = false)
        {
            Salt = User.getMd5Hash(Code, Password);
            return base.Insert(hasTrans);
        }


        /// <summary>
        /// 用户更新前，要将密码混淆
        /// </summary>
        /// <returns>成功与否</returns>
        public override bool Update(bool hasTrans = false)
        {
            if (!string.IsNullOrEmpty(Password))
                Salt = User.getMd5Hash(Code, Password);
            return base.Update(hasTrans);
        }

        // 校验
        override public bool InsertVerify()
        {
            // 初始化错误信息列表
            Error_Info.Clear();

            // 判断代码是否为空
            string err = "";
            if (string.IsNullOrEmpty(Code))
            {
                err = "用户代码不能为空！";
                Error_Info.Add(new KeyValuePair<string, string>("Code", err));
                return false;
            }

            // 判断代码是否重复
            List<User> users;
            if (ID > 0)
                users = User.Query(String.Format("Code = '{0}' and id <> {1}", Code, ID));
            else
                users = User.Query(String.Format("Code = '{0}'", Code));
            if (users.Count > 0)
            {
                err = "用户代码已经存在，请重新输入。";
                Error_Info.Add(new KeyValuePair<string, string>("Code", err));
                return false;
            }

            // 判断是否加了用户组
            if (GroupID <= 0)
            {
                Error_Info.Add(new KeyValuePair<string, string>("GroupID", "用户组必须选择！"));
                return false;
            }
            return true;
        }


        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        private static string getMd5Hash(string code, string password)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            password = String.Format("{0}hmxiaoxiao@gmail.com{0}{1}", password, code);
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(password));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        private static bool verifyMd5Hash(string code, string password, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(code, password);

            // Create a StringComparer an comare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
