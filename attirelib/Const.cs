using System;
using System.Collections.Generic;
using System.Linq;
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
            None = 0,
            Other = 10,
            ForePerson = 20,
            ResponManager = 30,
            GiveAttire = 40
            
        }
    }
}
