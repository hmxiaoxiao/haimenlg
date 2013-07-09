using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Security.Cryptography;

using Haimen.Entity;

namespace Haimen.Entity
{
    // 用户类
    [Table("m_user")]
    public class User : BaseEntity
    {
        [Field("code")]
        public string Code { get; set; }

        [Field("name")]
        public string Name { get; set; }

        [Field("salt")]
        public string Salt { get; set; }

        [Field("admin")]
        public string IsAdmin { get; set; }

        public string Password { get; set; }

        // 用户初始化
        // 第一次使用时，增加一个超级用户
        public static void Init()
        {
            List<User> list = DBFactory.Query<User>().toList<User>();
            if (list.Count == 0)
            {
                User admin = new User();
                admin.Code = "admin";
                admin.Name = "超级用户";
                admin.Password = "qwer1234";
                DBFactory.Save<User>(admin);
            }
        }

        // 传入用户的CODE以及密码，判断是否可以登录
        // 这里是唯一不会返回错误原因的地方
        public static User Verify(string code, string password)
        {
            if (code == null || code == "")
                return null;

            User q = DBFactory.CreateQueryEntity<User>();
            q.Code = code;
            List<User> list = DBFactory.Query<User>(q).toList<User>();

            if (list.Count != 1)
                return null;

            if (verifyMd5Hash(code, password, list[0].Salt))
                return list[0];
            else
                return null;
        }

        // 创建时的校验
        override public bool BeforeSave()
        {
            // 初始化错误信息列表
            if (Err_Info == null)
                Err_Info = new List<KeyValuePair<string, string>>();
            else
                Err_Info.Clear();

            // 判断代码是否为空
            string err = "";
            if (Code == null || Code == "")
            {
                err = "用户代码不能为空！";
                Err_Info.Add(new KeyValuePair<string,string>("Code", err));
                return false;
            }

            // 判断代码是否重复
            User q = DBFactory.CreateQueryEntity<User>();
            q.Code = Code;
            List<User> users = DBFactory.Query<User>(q).toList<User>();
            if (users.Count > 0)
            {
                err = "用户代码已经存在，请重新输入一个。";
                Err_Info.Add(new KeyValuePair<string, string>("Code", err));
                return false;
            }

            // 将密码转换为hash后保存在hash字段里。
            Salt = User.getMd5Hash(Password, Code);
            return true;
        }


        // Hash an input string and return the hash as
        // a 32 character hexadecimal string.
        private static string getMd5Hash(string code, string password)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            password = password + "hmxiaoxiao@gmail.com" + password + code;
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
