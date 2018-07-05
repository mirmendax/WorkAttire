using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace attirelib
{
    [Serializable]
    /// <summary>
    /// Меры безопасности
    /// </summary>
    public class Sec_Measures
    {
        public string ID = Const.getId();
        /// <summary>
        /// Где отключить
        /// </summary>
        public string Where = string.Empty;
        /// <summary>
        /// Что отключить
        /// </summary>
        public List<string> What = new List<string>();

        public Sec_Measures()
        {
            ID = Const.getId();
        }
    }
}
