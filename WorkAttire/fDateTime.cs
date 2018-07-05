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
        #region Data SelDT, isSelected
        public DateTime SelDT = DateTime.Now;
        public bool isSelected = false;
        
        #endregion
        bool isSelDay = false;
        public fDateTime()
        {
            InitializeComponent();
        }

        private void fDateTime_Load(object sender, EventArgs e)
        {
            SelDT = DateTime.Now;
            nHour.Value = SelDT.Hour;
            nMin.Value = SelDT.Minute;
            isSelected = false;
            isSelDay = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (!isSelDay)
                SelDT = monthCalendar1.SelectionStart;

            SelDT = new DateTime(SelDT.Year, SelDT.Month, SelDT.Day, (int)nHour.Value, (int)nMin.Value, 00);
            
            isSelected = true;
            Hide();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelDT = e.Start;
           
            isSelDay = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isSelected = false;
            Hide();
        }
    }
}
