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
        /// <summary>
        /// 0 - Версия
        /// </summary>
        public static string FORMAT_ABOUT = "WorkAttire {0} Programming [MIR] Mendax (c) 2006-2018// СТСУ уч. ТАиВ";
        public static string FORMAT_EXTENDED_CHAR = "@ ";
        public static string FORMAT_CLOSED_CHAR = "{X} ";
        public static string FORMAT_NOT_REG_CHAR = "*";
        /// <summary>
        /// 0 - Продлен ли 1 - Номер 2 - Дата начала 3 - Дата окончания 4 - Кто выдал 5 - Ответственный 
        /// </summary>
        public static string FORMAT_ACTIVE_ATTIRE_LIST = "{0}№{1} >> {2} -> {3}: [{4}] {5} - {6}";//
        public static string FORMAT_ALL_ATTIRE_LIST = "{0}{1}№{2} от {3} - [{4}] > {5}: {6}";//
        public static string FORMAT_PROGRAM_TO = "80/{0}-{1}";
        public static string FORMAT_PROGRAM_RAB = "80/{0}-{1}(р)";

        public static string FORMAT_TYPE_TO_K = "профилактического контроля";
        public static string FORMAT_TYPE_TO_K1 = "первого профилактического контроля";
        public static string FORMAT_TYPE_TO_B = "восстановления";

        public static string FORMAT_MEASURE_PROGRAM = "Не требуется";

        public static string FORMAT_TYPE_TO_K_ = "К";
        public static string FORMAT_TYPE_TO_K1_ = "К1";
        public static string FORMAT_TYPE_TO_B_ = "В";
        /// <summary>
        /// 0 - Рабочие места 1 - Тип ТО
        /// </summary>
        public static string FORMAT_ESTR_PROGRAMM = "{0}: техническое обслуживание цепей вторичной коммутации систем возбуждения в объеме {1}.";
        public static string FORMAT_WORKPLACE_LIST = "{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}";
        /// <summary>
        /// 0 - Номер программы ТО 1 - Дата программы ТО 2 - Номер рабочей программы 3 - Дата раб. программы
        /// </summary>
        public static string FORMAT_INST_PROGRAMM = "Работы выполнять в соответствии с программой {0} от {1}, рабочей программой {2} от {3}. Работы под напряжением на токоведущих частях выполнять по \"Технологической карте для работ под напряжением на токоведущих частях оборудования систем возбуждения генераторов ст. №1-23Г Волжской ГЭС\" под непрерывным управлением ответственного руководителя работ.";
        public static int FORMAT_ESTR_LENGTH = 130;
        
        /* Other  */
        public static int DAYS_ATTIRE = 14;
        public static string BR_OUT_DIAPOSON = "В бригаде достаточно членов!";
        public static string ATTIRE_IS_EXTENDED = "Наряд уже был продлен.";
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
