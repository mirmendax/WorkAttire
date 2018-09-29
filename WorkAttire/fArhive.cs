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
        fArhiveUnReg fUnReg = new fArhiveUnReg();
        #region Data
        public Attires Data = new Attires();

        #endregion
        private DateTime _Date_A = new DateTime();
        private DateTime _Date_B = new DateTime();

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

        private void mCalA_DateSelected(object sender, DateRangeEventArgs e)
        {
            _Date_A = e.Start;
            lDate_A.Text = _Date_A.ToString(Const.FORMAT_DATA);
        }

        private void mCalB_DateSelected(object sender, DateRangeEventArgs e)
        {
            _Date_B = e.Start;
            lDate_B.Text = _Date_B.ToString(Const.FORMAT_DATA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lCountAttire.Text = Data.ShowAttire(_Date_A, _Date_B).Count().ToString();
        }

        private void bListUnReg_Click(object sender, EventArgs e)
        {
            fUnReg = new fArhiveUnReg();
            fUnReg.ListUnReg = Data.ListNotVerifyAttire();
            fUnReg.ShowDialog();
            if (fUnReg.isReg)
            {
                foreach (var item in fUnReg.ListRegistred)
                {
                    Data.VerifyedAtiire(item.ID, item.Number);
                }
            }
            if (fUnReg.isDel)
            {
                foreach (var item in fUnReg.ListDeleted)
                {
                    Data.DeleteNotVerifyedAttire(item.ID);
                }
            }
            onRewrite();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void bListActive_Click(object sender, EventArgs e)
        {
            fArhiveAcive fAcive = new fArhiveAcive();
            fAcive.ListActive = Data.ListOpenedAttire();
            fAcive.ShowDialog();
            if (fAcive.isClosed)
            {
                foreach (var item in fAcive.ClosedAttire)
                {
                    Data.ClosedAttire(item.ID);
                }
            }
        }
    }
}
