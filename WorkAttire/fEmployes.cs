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
    public partial class fEmployes : Form
    {
        #region Data ListEmp, SelEmp isSelected
        public List<Emp> ListEmp = new List<Emp>();
        public Emp SelEmp = new Emp();
        public bool isSelected = false;
        #endregion
        public fEmployes()
        {
            InitializeComponent();
        }

       
        private void fEmployes_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in ListEmp)
            {
                listBox1.Items.Add(item.ToString());
            }
            SelEmp = null;
            isSelected = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = sender as ListBox;
            if (lb.SelectedIndex != -1)
            {
                SelEmp = ListEmp[lb.SelectedIndex];
                isSelected = true;
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isSelected = false;
            Hide();
        }
    }
}
