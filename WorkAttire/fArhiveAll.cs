using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using attirelib;

namespace WorkAttire
{
    public partial class fArhiveAll : Form
    {
        #region Data
        public List<Attire> ListAttire  = new List<Attire>();

        #endregion
        public fArhiveAll()
        {
            InitializeComponent();
        }

        public void onRewrite()
        {
            listBox1.Items.Clear();
            foreach (var item in ListAttire)
            {
                string estr = "";

                if (item.Estr.Length < Const.FORMAT_ESTR_LENGTH)
                    estr = item.Estr;
                else
                    estr = item.Estr.Substring(0, Const.FORMAT_ESTR_LENGTH) + "...";

                listBox1.Items.Add(string.Format(Const.FORMAT_ALL_ATTIRE_LIST,
                    (item.isClosed) ? Const.FORMAT_CLOSED_CHAR : "",
                    (item.isExtend) ? Const.FORMAT_EXTENDED_CHAR : "",
                    (item.Number != 0) ? item.Number.ToString() + "Э" : Const.FORMAT_NOT_REG_CHAR,
                    item.Date_Time_Give.ToString(Const.FORMAT_DATA),
                    item.GiveAttire.ToString(),
                    item.ResponseManager.ToString(),
                    estr));
            }
        }

        private void fArhiveAcive_Load(object sender, EventArgs e)
        {
            onRewrite();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

       
    }
}
