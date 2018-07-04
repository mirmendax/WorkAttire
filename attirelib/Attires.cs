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
                if (!item.isClosed)
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
        /// Удаление наряда по ID или по объекту
        /// </summary>
        /// <param name="delAt">Объект наряда</param>
        /// <param name="id">Уникальный номер</param>
        /// <returns></returns>
        public bool DeleteNotVerifyedAttire(Attire delAt, string id = "")
        {
            bool result = false;
            if (id == "")
            {
                if (ListAttire.Remove(delAt)) result = true;
                else result = false;
            }
            else
            {
                Attire temp = FindAttire(id);
                if (ListAttire.Remove(temp)) result = true;
                else result = false;
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
            Attire result = new Attire();
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

        public int AddCountAttire(string ID)
        {
            int result = 0;
            Attire temp = FindAttire(ID);
            temp.Count++;
            result = temp.Count;
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
