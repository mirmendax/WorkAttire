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
    public partial class fAddAttire : Form
    {
        #region Forms
        fEmployes fEmpl = new fEmployes();
        #endregion


        /* Global Attires, Emps */
        public Attires ListAttire = new Attires();
        public Emps ListEmps = new Emps();

        public Attire CurrentAttire = new Attire();
        /*            */


        public fAddAttire()
        {
            InitializeComponent();
        }

        public void onRewrite()
        {
            lRespManager.Text = CurrentAttire.ResponseManager.ToString();
            lForePerson.Text = CurrentAttire.ForePerson.ToString();
            lBoxTeam.Items.Clear();
            foreach (var item in CurrentAttire.Team)
            {
                lBoxTeam.Items.Add(item.ToString());
            }
            lGiveAttire.Text = CurrentAttire.GiveAttire.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAttire.Load();
            ListEmps.Load();
            ListEmps.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fEmpl.Location = new Point((sender as Button).Location.X + this.Location.X + (sender as Button).Parent.Location.X,
                (sender as Button).Location.Y + this.Location.Y + (sender as Button).Parent.Location.Y);
            fEmpl.ListEmp = ListEmps.EmployeesOfRules(Const.RULE.ResponManager);
            fEmpl.ShowDialog();
            if (fEmpl.SelEmp != null)
            {
                CurrentAttire.ResponseManager = fEmpl.SelEmp;
            }
            if (fEmpl.isSelected)
                onRewrite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fEmpl.Location = new Point((sender as Button).Location.X + this.Location.X + (sender as Button).Parent.Location.X,
                (sender as Button).Location.Y + this.Location.Y + (sender as Button).Parent.Location.Y);
            fEmpl.ListEmp = ListEmps.EmployeesOfRules(Const.RULE.ForePerson);
            fEmpl.ShowDialog();
            if (fEmpl.SelEmp != null)
            {
                CurrentAttire.ForePerson = fEmpl.SelEmp;
            }
            if (fEmpl.isSelected)
                onRewrite();

        }

        private void addchrbtn_Click(object sender, EventArgs e)
        {
            fEmpl.Location = new Point((sender as Button).Location.X + this.Location.X + (sender as Button).Parent.Location.X,
                (sender as Button).Location.Y + this.Location.Y + (sender as Button).Parent.Location.Y);
            fEmpl.ListEmp = ListEmps.EmployeesOfRules(Const.RULE.Other);
            fEmpl.ShowDialog();
            if (fEmpl.SelEmp != null)
            {
                CurrentAttire.Team.Add(fEmpl.SelEmp);
            }
            if (fEmpl.isSelected)
                onRewrite();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fEmpl.Location = new Point((sender as Button).Location.X + this.Location.X + (sender as Button).Parent.Location.X,
                (sender as Button).Location.Y + this.Location.Y + (sender as Button).Parent.Location.Y);
            fEmpl.ListEmp = ListEmps.EmployeesOfRules(Const.RULE.GiveAttire);
            fEmpl.ShowDialog();
            if (fEmpl.SelEmp != null)
            {
                CurrentAttire.GiveAttire = fEmpl.SelEmp;
            }
            if (fEmpl.isSelected)
                onRewrite();
        }

        private void datebtn_Click(object sender, EventArgs e)
        {
            fDateTime ff = new fDateTime();
            ff.ShowDialog();
        }
    }
}
