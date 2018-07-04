using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace attirelib
{
    public class Const
    {
        public static string FILE_EMPS = "emps.wa";
        public static string FILE_ATTIRE = "arhive.wa";
        public static string FILE_LOG = "error.log";
        public static int DAYS_ATTIRE = 15;
        public enum RULE
        {
            /// <summary>
            /// Пустой
            /// </summary>
            None = 0,
            /// <summary>
            /// Член бригады
            /// </summary>
            Other = 10,
            /// <summary>
            /// Производитель
            /// </summary>
            ForePerson = 20,
            /// <summary>
            /// Ответственный руководитель
            /// </summary>
            ResponManager = 30,
            /// <summary>
            /// Выдающий наряд
            /// </summary>
            GiveAttire = 40
            
        }
        public static string getId(string s = "")
        {
            Random r = new Random();
            string iss = s + DateTime.Now.ToString() + r.Next().ToString();
            MD5 m = MD5.Create();
            byte[] data = m.ComputeHash(Encoding.Default.GetBytes(iss));
            StringBuilder sB = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sB.Append(data[i].ToString("x2"));
            }
            return sB.ToString();
        }
    }
}
