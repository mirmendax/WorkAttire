using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace attirelib
{
    [Serializable]
    public class Attire
    {
        /// <summary>
        /// Уникальный ИД
        /// </summary>
        public string ID = Const.getId();
        /// <summary>
        /// Номер зарегистрированного наряда
        /// </summary>
        public int Number = 0;
        /// <summary>
        /// Ответсвенный руководитель
        /// </summary>
        public Emp ResponseManager = new Emp();
        /// <summary>
        /// Производитель
        /// </summary>
        public Emp ForePerson = new Emp();
        /// <summary>
        /// Бригада
        /// </summary>
        public List<Emp> Team = new List<Emp>();
        /// <summary>
        /// Поручается
        /// </summary>
        public string Estr = string.Empty;
        /// <summary>
        /// Дата и время начала работ
        /// </summary>
        public DateTime Date_Time_Begin = new DateTime();
        /// <summary>
        /// Дата и время окончания работ
        /// </summary>
        public DateTime Date_Time_End = new DateTime();
        /// <summary>
        /// Продлен ли наряд
        /// </summary>
        public bool isExtend = false;
        /// <summary>
        /// Дата окончания при продлении
        /// </summary>
        public DateTime Date_Time_End_Extend = new DateTime();
        /// <summary>
        /// Меры безопасности
        /// </summary>
        public List<Sec_Measures> Sec_Meas = new List<Sec_Measures>();
        /// <summary>
        /// Отдельные указания
        /// </summary>
        public string Spec_Insrtrucion = string.Empty;
        /// <summary>
        /// Дата и время выдачи наряда
        /// </summary>
        public DateTime Date_Time_Give = new DateTime();
        /// <summary>
        /// Выдающий наряд
        /// </summary>
        public Emp GiveAttire = new Emp();
        /// <summary>
        /// Не нужная переменная
        /// </summary>
        public int Count = 0;
        /// <summary>
        /// Полностью закрытый наряд
        /// </summary>
        public bool isClosed = false;
        
        public Attire()
        {
            ID = Const.getId();
        }

        #region Override
        public override bool Equals(object obj)
        {
            if ((obj as Attire) == null) return false;
            return this.ID == (obj as Attire).ID;
        }

        public override int GetHashCode()
        {
            
            return base.GetHashCode();
        }
        #endregion
        public Attire(Attire data)
        {
            this.ID = data.ID;
            this.ResponseManager = data.ResponseManager;
            this.ForePerson = data.ForePerson;
            this.Team.Clear();
            foreach (var item in data.Team)
            {
                this.Team.Add(item);
            }
            this.Estr = data.Estr;
            this.Date_Time_Begin = data.Date_Time_Begin;
            this.Date_Time_End = data.Date_Time_End;
            this.isExtend = data.isExtend;
            this.Date_Time_End_Extend = data.Date_Time_End_Extend;
            this.Sec_Meas = data.Sec_Meas;
            this.Spec_Insrtrucion = data.Spec_Insrtrucion;
            this.Date_Time_Give = data.Date_Time_Give;
            this.GiveAttire = data.GiveAttire;
            this.Count = data.Count;
            this.isClosed = data.isClosed;
        }

        public Attire(Emp rManager, Emp fPerson, List<Emp> team, string estr, DateTime dtBegin, 
            DateTime dtEnd, List<Sec_Measures> sMeas, string sInstr, DateTime dtGive, Emp gAttire, int count=0, bool isclosed = false)
        {
            this.ID = Const.getId(gAttire.ToString()+estr+sInstr);
            this.ResponseManager = rManager;
            this.ForePerson = fPerson;
            this.Team.Clear();

            foreach (var item in team)
            {
                this.Team.Add(item);
            }
            this.Estr = estr;
            this.Date_Time_Begin = dtBegin;
            this.Date_Time_End = dtEnd;
            this.isExtend = false;
            this.Date_Time_End_Extend = dtEnd;
            this.Sec_Meas.Clear();
            foreach (var item in sMeas)
            {
                Sec_Meas.Add(item);
            }
            this.Spec_Insrtrucion = sInstr;
            this.Date_Time_Give = dtGive;
            this.GiveAttire = gAttire;
            this.Count = count;
            this.isClosed = isclosed;
        }


    }
}
