using attirelib;
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
    public partial class fExtended_Data : Form
    {
        #region Data
        public DateTime OutDate = DateTime.Today;
        public DateTime ExtendDate = new DateTime();
        public bool isExtend = false;
        #endregion

        int Days = 1;
        public fExtended_Data()
        {
            InitializeComponent();
        }

        void MaxExtendedDaysCalendar(DateTime outdate)
        {
            monthCalendar2.MaxDate = outdate.AddDays(Const.DAYS_ATTIRE);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = true;
            monthCalendar2.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown1.Visible = false;
            monthCalendar2.Visible = true;
            monthCalendar2.SelectionStart = OutDate;
            monthCalendar2.SelectionStart = monthCalendar2.SelectionStart.AddDays(Days);
            monthCalendar2.SelectionEnd = monthCalendar2.SelectionStart;
            monthCalendar2.Select();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Days = (int)numericUpDown1.Value;
        }

        private void fExtended_Data_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = OutDate;
            monthCalendar1.SelectionEnd = monthCalendar1.SelectionStart;
            MaxExtendedDaysCalendar(OutDate);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            OutDate = monthCalendar1.SelectionStart;
            MaxExtendedDaysCalendar(OutDate);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isExtend = false;
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isExtend = true;
            if (radioButton1.Checked)
            {
                ExtendDate = monthCalendar1.SelectionStart.AddDays(Days);
            }
            if (radioButton2.Checked)
            {
                ExtendDate = monthCalendar2.SelectionStart;
            }
            if ((!radioButton1.Checked) && (!radioButton2.Checked)) isExtend = false;
            Hide();
        }
    }
}
