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
    public partial class fArhiveUnReg : Form
    {
        #region Data
        public List<Attire> ListUnReg = new List<Attire>();
        public List<Attire> ListRegistred = new List<Attire>();
        public List<Attire> ListDeleted = new List<Attire>();
        public bool isReg = false;
        public bool isDel = false;
        #endregion
        public fArhiveUnReg()
        {
            InitializeComponent();
        }

        private void onRewrite()
        {
            listBox1.Items.Clear();
            foreach (var item in ListUnReg)
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

        private void fArhiveUnReg_Load(object sender, EventArgs e)
        {
            onRewrite();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Attire temp = ListUnReg[listBox1.SelectedIndex];
                Random r = new Random();
                ListUnReg.Remove(temp);
                isReg = true;
                temp.Number = r.Next(0, 1000);
                ListRegistred.Add(temp);
                onRewrite();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Attire temp = ListUnReg[listBox1.SelectedIndex];
                ListUnReg.Remove(temp);
                isDel = true;
                ListDeleted.Add(temp);
                onRewrite();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
