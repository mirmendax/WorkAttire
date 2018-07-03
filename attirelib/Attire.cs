using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Security.Cryptography;

namespace attirelib
{
    public class Attire
    {
        /// <summary>
        /// Уникальный ИД
        /// </summary>
        public string ID = Const.getId("");
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
        
        public Attire()
        {
            ID = Const.getId("");
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
            this.Team = data.Team;
            this.Estr = data.Estr;
            this.Date_Time_Begin = data.Date_Time_Begin;
            this.Date_Time_End = data.Date_Time_End;
            this.Sec_Meas = data.Sec_Meas;
            this.Spec_Insrtrucion = data.Spec_Insrtrucion;
            this.Date_Time_Give = data.Date_Time_Give;
            this.GiveAttire = data.GiveAttire;
        }

    }
}
