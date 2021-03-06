﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace attirelib
{
    [Serializable]
    public class Emp
    {
        public string Name = string.Empty;
        /// <summary>
        /// Группа по эл.безопасности
        /// </summary>
        public int Group = 0;
        /// <summary>
        /// Выдающий наряд
        /// </summary>
        public bool RuleGiveAttire = false;
        /// <summary>
        /// Ответственный руководитель
        /// </summary>
        public bool RuleResponManager = false;
        /// <summary>
        /// Производитель работ
        /// </summary>
        public bool RuleForePerson = false;

        #region Override
        public override bool Equals(object obj)
        {
            if ((obj as Emp) == null) return false;
            return (this.Name == (obj as Emp).Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            string result;
            switch (this.Group)
            {
                case 1: result = this.Name + " I гр.";
                    break;
                case 2: result = this.Name + " II гр.";
                    break;
                case 3: result = this.Name + " III гр.";
                    break;
                case 4: result = this.Name + " IV гр.";
                    break;
                case 5: result = this.Name + " V гр.";
                    break;
                default: result = "ФИО";
                    break;
            }
            return result;
        }
        #endregion

        public Emp()
        {
            Name = "";
            Group = 0;
            RuleGiveAttire = false;
            RuleResponManager = false;
            RuleForePerson = false;
        }

        public Emp(string name, int group)
        {
            Name = name;
            Group = group;
        }

        public Emp(string name, int group, bool rGiveAttire, bool rRespManager, bool rForePerson)
        {
            Name = name;
            Group = group;
            RuleGiveAttire = rGiveAttire;
            RuleResponManager = rRespManager;
            RuleForePerson = rForePerson;
        }
    }
}
