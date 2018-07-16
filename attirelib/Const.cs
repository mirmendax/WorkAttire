using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace attirelib
{
    public class Const
    {
        /* Files */
        public static string FILE_EMPS = "emps.wa";
        public static string FILE_ATTIRE = "arhive.wa";
        public static string FILE_LOG = "error.log";
        public static string FILE_VERSION = "version";
        public static string FILE_TEMPLATE_ATTIRE = "attire.xltx";
        /* Formats string */
        public static string FORMAT_DATA = "dd.MM.yy";
        public static string FORMAT_TIME = "HH.mm";
        public static string FORMAT_ABOUT = "WorkAttire {0} Programming [MIR] Mendax (c) 2006-2018// СТСУ уч. ТАиВ";
        public static int FORMAT_ESTR_LENGTH = 150;
        
        /* Other  */
        public static int DAYS_ATTIRE = 14;
        public static string BR_OUT_DIAPOSON = "В бригаде достаточно членов!";
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
        public static string Version()
        {
            string result = "";
            if (File.Exists(FILE_VERSION))
            {
                FileStream fver = File.Open(FILE_VERSION, FileMode.Open);
                byte[] ver = new byte[fver.Length];
                fver.Read(ver, 0, (int)fver.Length);
                fver.Close();
                string v = Encoding.ASCII.GetString(ver, 0, ver.Length);
                result = "v"+v;
            }
            else
            {
                result = "v1.0a";
            }
            return result;
        }
    }
}
