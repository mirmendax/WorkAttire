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
    public partial class fArhive : Form
    {
        #region Data
        public Attires Data = new Attires();

        #endregion

        public fArhive()
        {
            InitializeComponent();
        }

        private void onRewrite()
        {
            lActiveAttire.Text = Data.ListOpenedAttire().Count().ToString();
            lUnRegAttire.Text = Data.ListNotVerifyAttire().Count().ToString();
            lAllAttire.Text = Data.ListAttire.Count().ToString();
        }

        private void fArhive_Load(object sender, EventArgs e)
        {
            onRewrite();
            
        }
    }
}
