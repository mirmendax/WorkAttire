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
    public partial class fAddUser : Form
    {
        #region Data ListEmp isSave NewListEmp
        public List<Emp> ListEmp = new List<Emp>();
        public bool isSave = false;
        public List<Emp> NewListEmp = new List<Emp>();
        #endregion

        public fAddUser()
        {
            InitializeComponent();
        }

        private void onRewrite()
        {

        }

        private void fAddUser_Load(object sender, EventArgs e)
        {

        }
    }
}
