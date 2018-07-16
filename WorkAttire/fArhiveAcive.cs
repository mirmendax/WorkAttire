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
    public partial class fArhiveAcive : Form
    {
        #region Data
        public List<Attire> ListActive = new List<Attire>();
        public List<Attire> ClosedAttire = new List<Attire>();
        public bool isClosed = false;
        #endregion
        public fArhiveAcive()
        {
            InitializeComponent();
        }

        public void onRewrite()
        {
            listBox1.Items.Clear();
            foreach (var item in ListActive)
            {
                string estr = "";
                if (item.Estr.Length < Const.FORMAT_ESTR_LENGTH)
                    estr = item.Estr;
                else
                    estr = item.Estr.Substring(0, Const.FORMAT_ESTR_LENGTH);
                listBox1.Items.Add(string.Format("{0}: [{1}] {2} - {3}...",
                    item.Date_Time_Give.ToString(Const.FORMAT_DATA),
                    item.GiveAttire.ToString(),
                    item.ForePerson.ToString(),
                    estr));
            }
        }

        private void fArhiveAcive_Load(object sender, EventArgs e)
        {
            onRewrite();
        }
    }
}
