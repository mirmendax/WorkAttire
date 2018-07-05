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
    public partial class fSec_Measure : Form
    {
        #region Data
        public List<Sec_Measures> sList = new List<Sec_Measures>();
        public List<string> lView = new List<string>();
        public List<string> rView = new List<string>();
        public bool isOk = false;
        #endregion

        void onRewrite()
        {
            lBoxViewL.Items.Clear();
            lBoxViewR.Items.Clear();
            lView.Clear();
            rView.Clear();
            foreach (var item in sList)
            {
                lBoxViewL.Items.Add(item.Where);
                lView.Add(item.Where);
                int n = 0;
                foreach (var nn in item.What)
                {
                    lBoxViewR.Items.Add(nn);
                    rView.Add(nn);
                    n++;
                }
                for (int i = 0; i < n - 1; i++)
                {
                    lBoxViewL.Items.Add("");
                    lView.Add("");
                }
            }
            
        }

        public fSec_Measure()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sec_Measures temp = new Sec_Measures();
            temp.Where = tBoxWhere.Text;
            string[] ts = { "" };
            string[] ss = tBoxWhat.Lines;
            ///Убираем пустые строки
            if (ss[ss.Length - 1] == "")
            {
                ts = new string[ss.Length - 1];
                for (int i = 0; i < ss.Length - 1; i++)
                {
                    ts[i] = ss[i];
                }
            }
                ///
            else
            {
                ts = new string[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    ts[i] = ss[i];
                }
            }
            for (int i = 0; i < ts.Length; i++)
            {
                temp.What.Add(ts[i]);
            }
            sList.Add(temp);
            onRewrite();
            tBoxWhat.Text = "";
            tBoxWhere.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sList = new List<Sec_Measures>();
            onRewrite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            isOk = false;
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            isOk = true;
            Hide();
        }

        private void fSec_Measure_Load(object sender, EventArgs e)
        {
            onRewrite();
            isOk = false;
        }
    }
}
