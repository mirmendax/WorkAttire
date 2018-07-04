using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace attirelib
{
    [Serializable]
    public class Emps
    {
        public List<Emp> Employees = new List<Emp>();

        public Emps()
        {
            Employees = new List<Emp>();
        }
        /// <summary>
        /// Вывести список работников по Роли
        /// </summary>
        /// <param name="rule">Роль</param>
        /// <returns></returns>
        public List<Emp> EmployeesOfRules(Const.RULE rule)
        {
            List<Emp> result = new List<Emp>();
            foreach (var item in Employees)
            {
                switch (rule)
                {
                    case Const.RULE.None:
                        result = null;
                        break;
                    case Const.RULE.Other:
                        result.Add(item);
                        break;
                    case Const.RULE.ForePerson:
                        if (item.RuleForePerson || item.RuleGiveAttire || item.RuleResponManager)
                            result.Add(item);
                        break;
                    case Const.RULE.ResponManager:
                        if (item.RuleResponManager || item.RuleGiveAttire)
                            result.Add(item);
                        break;
                    case Const.RULE.GiveAttire:
                        if (item.RuleGiveAttire)
                            result.Add(item);
                        break;
                    default:
                        result = null;
                        break;
                }
            }
            return result;
        }
        
        public void Save()
        {
            BinaryFormatter data = new BinaryFormatter();
            FileStream file = File.Open(Const.FILE_EMPS, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            data.Serialize(file, Employees);
            file.Close();
        }

        public void Load()
        {
            BinaryFormatter data = new BinaryFormatter();
            if (!File.Exists(Const.FILE_EMPS))
            {
                File.Open(Const.FILE_EMPS, FileMode.OpenOrCreate, FileAccess.ReadWrite).Close();
            }
            FileStream file = File.Open(Const.FILE_EMPS, FileMode.Open, FileAccess.ReadWrite);
            try
            {
                Employees = (data.Deserialize(file) as List<Emp>);
            }
            catch (SerializationException ex)
            {
                new Log("Error load Emps: " + ex.Message);
            }
        }
    }
}
