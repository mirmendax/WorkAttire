using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace attirelib
{
    public class Attires
    {
        public List<Attire> ListAttire = new List<Attire>();
        /// <summary>
        /// Список не зарегистрированных нарядов
        /// </summary>
        /// <returns></returns>
        public List<Attire> ListNotVerifyAttire()
        {
            List<Attire> result = new List<Attire>();
            foreach (var item in ListAttire)
            {
                if (item.Number == 0)
                    result.Add(item);
            }
            return result;
        }
        /// <summary>
        /// Список открытых нарядов
        /// </summary>
        /// <returns></returns>
        public List<Attire> ListOpenedAttire()
        {
            List<Attire> result = new List<Attire>();
            foreach (var item in ListAttire)
            {
                if (!item.isClosed && item.Number != 0)
                    result.Add(item);
            }
            return result;
        }
        /// <summary>
        /// Список закрытых нарядов
        /// </summary>
        /// <returns></returns>
        public List<Attire> ListClosedAttire()
        {
            List<Attire> result = new List<Attire>();
            foreach (var item in ListAttire)
            {
                if (item.isClosed)
                    result.Add(item);
            }
            return result;
        }
        /// <summary>
        /// Удаление наряда по ID
        /// </summary>
        /// <param name="id">Уникальный номер</param>
        /// <returns></returns>
        public bool DeleteNotVerifyedAttire(string id)
        {
            bool result = false;
            Attire temp = FindAttire(id);
            if (temp != null)
                if (ListAttire.Remove(temp)) result = true;
                else result = false;

            return result;
        }
        /// <summary>
        /// Регистрация наряда
        /// </summary>
        /// <param name="ID">Уникальный номер наряда</param>
        /// <param name="number">Присвоенный номер наряда</param>
        /// <returns></returns>
        public bool VerifyedAtiire(string ID, int number)
        {
            bool result = false;
            Attire temp = FindAttire(ID);
            if (temp != null)
            {

            }
            return result;
        }
        /// <summary>
        /// Поиск наряда по ID
        /// </summary>
        /// <param name="ID">ID Hash</param>
        /// <returns></returns>
        public Attire FindAttire(string ID)
        {
            Attire result = null;
            foreach (var item in ListAttire)
            {
                if (item.ID == ID)
                {
                    result = item;
                }
            }
            return result;
        }
        /// <summary>
        /// Проверка наличия наряда в базе по ID
        /// </summary>
        /// <param name="ID">ID Hash</param>
        /// <returns></returns>
        public bool isAvaibleHash(string ID)
        {
            bool result = false;
            Attire temp = FindAttire(ID);
            if (temp != null)
                if (temp.ID == ID) result = true;
            return result;
        }
        /// <summary>
        /// Добовление нового наряда
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool AddAttire(Attire data)
        {
            bool result = false;
            ListAttire.Add(data);
            if (isAvaibleHash(data.ID)) result = true;
            return result;
        }
        /// <summary>
        /// Проверка просроченности открытых нарядов и перевод их в закрытые
        /// </summary>
        /// <returns>False - Нет просроченных, True - Есть</returns>
        public bool CheckOpenedAttire()
        {
            bool result = false;
            DateTime ToDAy = DateTime.Today;
            List<Attire> openedList = ListOpenedAttire();
            for (int i = 0; i < openedList.Count; i++)
            {
                if (openedList[i].isExtend)
                {
                    if (openedList[i].Date_Time_End_Extend > ToDAy)
                    {
                        openedList[i].isClosed = true;
                        result = true;
                    }
                }
                else
                {
                    if (openedList[i].Date_Time_End > ToDAy)
                    {
                        openedList[i].isClosed = true;
                        result = true;
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Продление наряда 
        /// </summary>
        /// <param name="ID">ID наряда</param>
        /// <param name="DateOut">Продлить от даты</param>
        /// <param name="Days">Кол-во дней</param>
        /// <returns></returns>
        public Attire ExtendAttire(string ID, DateTime DateOut, int Days)
        {
            Attire result = new Attire();
            Attire temp = FindAttire(ID);
            if (temp != null)
            {
                temp.isExtend = true;
                if (Days > 15) Days = 15;
                temp.Date_Time_End_Extend = DateOut.AddDays(Days);
                result = temp;

            }
            else result = null;
            return result;
        }

        /// <summary>
        /// Вывод нарядов за определенный срок
        /// </summary>
        /// <param name="a">Дата начала</param>
        /// <param name="b">Дата окончания</param>
        /// <returns></returns>
        public List<Attire> ShowOrder(DateTime a, DateTime b)
        {
            List<Attire> result = new List<Attire>();
            List<DateTime> dd = new List<DateTime>();
            DateTime dcount = a;
            while (dcount <= b)
            {
                dd.Add(dcount);
                dcount = dcount.AddDays(1);
            }
            IEnumerable<Attire> query = from o in ListAttire
                                        join t in dd on o.Date_Time_Give equals t
                                        select o;
            result = query.ToList(); 
            return result;
        }


        public void Load()
        {
            BinaryFormatter data = new BinaryFormatter();
            if (!File.Exists(Const.FILE_ATTIRE))
            {
                File.Open(Const.FILE_ATTIRE, FileMode.OpenOrCreate, FileAccess.ReadWrite).Close();
            }
            FileStream file = File.Open(Const.FILE_ATTIRE, FileMode.Open, FileAccess.ReadWrite);
            try
            {
                ListAttire = (data.Deserialize(file) as List<Attire>);
            }
            catch (SerializationException ex)
            {
                new Log("Error load Attires: " + ex.Message);
            }
            file.Close();
        }

        public void Save()
        {
            BinaryFormatter data = new BinaryFormatter();
            FileStream file = File.Open(Const.FILE_ATTIRE, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            data.Serialize(file, ListAttire);
            file.Close();
        }
    }
}
