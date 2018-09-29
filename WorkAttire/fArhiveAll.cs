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
        public List<Attire> ListActive = new List<Attire>();
        public List<Attire> ClosedAttire = new List<Attire>();
        public List<Attire> ExtendAttire = new List<Attire>();
        public bool isEstended = false;
        public bool isClosed = false;
        #endregion
        public fArhiveAll()
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
                listBox1.Items.Add(string.Format(Const.FORMAT_ACTIVE_ATTIRE_LIST,
                    (item.isExtend) ? Const.FORMAT_EXTENDED_CHAR : "",
                    item.Number.ToString(),
                    item.Date_Time_Give.ToString(Const.FORMAT_DATA),
                    (item.isExtend) ? item.Date_Time_End_Extend.ToString(Const.FORMAT_DATA) : item.Date_Time_End.ToString(Const.FORMAT_DATA),
                    item.GiveAttire.ToString(),
                    item.ForePerson.ToString(),
                    estr));
            }
        }

        private void fArhiveAcive_Load(object sender, EventArgs e)
        {
            onRewrite();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Attire temp = ListActive[listBox1.SelectedIndex];
                ListActive.Remove(temp);
                temp.isClosed = true;
                ClosedAttire.Add(temp);
                isClosed = true;
                onRewrite();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                fExtended_Data fData = new fExtended_Data();
                Attire temp = ListActive[listBox1.SelectedIndex];
                if (temp.isExtend)
                {
                    MessageBox.Show(Const.ATTIRE_IS_EXTENDED);
                    onRewrite();
                }
                else
                {
                    fData.OutDate = DateTime.Today;
                    fData.ShowDialog();
                    if (fData.isExtend)
                    {
                        temp.Date_Time_End_Extend = fData.ExtendDate;
                        temp.isExtend = true;
                        ExtendAttire.Add(temp);
                        onRewrite();
                    }
                }
            }
        }
    }
}
