using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WorkAttire
{
    public partial class fDateTime : Form
    {
        #region Data 
        public DateTime SelDT = DateTime.Now;
        #endregion
        public fDateTime()
        {
            InitializeComponent();
        }

        private void fDateTime_Load(object sender, EventArgs e)
        {
            nHour.Value = SelDT.Hour;
            nMin.Value = SelDT.Minute;
        }
    }
}
