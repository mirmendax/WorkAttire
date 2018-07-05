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
        fDateTime fData = new fDateTime();
        fSec_Measure fSec = new fSec_Measure();
        #endregion
        /*  private Measure */
        private List<string> meas_l = new List<string>();
        private List<string> meas_r = new List<string>();
        /* Global Attires, Emps */
        public Attires ListAttire = new Attires();
        public Emps ListEmps = new Emps();

        public Attire CurrentAttire = new Attire();
        /*            */

        private bool AddAttire(Attire a)
        {
            bool result = false;
            string[] L_Mes = { "A24", "A25", "A26", "A27", "A28", "A29", "A30", "A31", "A32", "A33", "A34" };
            string[] R_Mes = { "S24", "S25", "S26", "S27", "S28", "S29", "S30", "S31", "S32", "S33", "S34" };
            Excel exc = new Excel();
            try
            {
                exc.OpenDocument(Application.StartupPath + "\\" + Const.DOC_ATTIRE);
                exc.Visible = true;
                ///ResponseManager
                exc.SetValue("C7", a.ResponseManager.ToString());
                exc.SetValue("Y48", a.ResponseManager.ToString());
                exc.SetValue("T65", a.ResponseManager.ToString());
                exc.SetValue("F97", a.ResponseManager.ToString());
                //ForePerson
                exc.SetValue("H9", a.ForePerson.ToString());
                exc.SetValue("T67", a.ForePerson.ToString());
                exc.SetValue("T97", a.ForePerson.ToString());
                exc.SetValue("F101", a.ForePerson.ToString());
                ///GiveAttire
                exc.SetValue("Y41", a.GiveAttire.ToString());
                exc.SetValue("F48", a.GiveAttire.ToString());
                ///Date Time Give
                exc.SetValue("G40", a.Date_Time_Give.ToString(Const.FORMAT_DATA));
                exc.SetValue("U40", a.Date_Time_Give.ToString(Const.FORMAT_TIME));

                ///Estr
                if (a.Estr.Length > 60)
                {
                    string[] strArray1 = a.Estr.Split(Convert.ToChar(" "));
                    int index1 = 0;
                    string[] strArray2 = new string[4] { "", "", "", "" };
                    foreach (var str in strArray1)
                    {
                        string[] strArray3;
                        int index2;
                        (strArray3 = strArray2)[(int)(index2 = (int)index1)] = strArray3[index2] + str + " ";
                        if ((strArray2[0].Length > 80) && (index1 == 0)) ++index1;
                        if ((strArray2[index1].Length > 90) && (index1 != 0))
                            ++index1;
                    }
                    if (strArray2[0].Length != 0)
                        exc.SetValue("E15", strArray2[0]);
                    if (strArray2[1].Length != 0)
                        exc.SetValue("A16", strArray2[1]);
                    if (strArray2[2].Length != 0)
                        exc.SetValue("A17", strArray2[2]);
                    if (strArray2[3].Length != 0)
                        exc.SetValue("A18", strArray2[3]);

                }
                else exc.SetValue("E15", a.Estr);
                ///Instr
                if (a.Spec_Insrtrucion.Length > 60)
                {
                    string[] strArray1 = a.Spec_Insrtrucion.Split(Convert.ToChar(" "));
                    int index1 = 0;
                    string[] strArray2 = new string[5] { "", "", "", "", "" };
                    foreach (var str in strArray1)
                    {
                        string[] strArray3;
                        int index2;
                        (strArray3 = strArray2)[(int)(index2 = (int)index1)] = strArray3[index2] + str + " ";
                        if ((strArray2[0].Length > 75) && (index1 == 0)) ++index1;
                        if ((strArray2[index1].Length >= 91) && (index1 != 0))
                            ++index1;
                    }
                    if (strArray2[0].Length != 0)
                        exc.SetValue("H35", strArray2[0]);
                    if (strArray2[1].Length != 0)
                        exc.SetValue("A36", strArray2[1]);
                    if (strArray2[2].Length != 0)
                        exc.SetValue("A37", strArray2[2]);
                    if (strArray2[3].Length != 0)
                        exc.SetValue("A38", strArray2[3]);
                    if (strArray2[4].Length != 0)
                        exc.SetValue("A39", strArray2[4]);

                }
                else exc.SetValue("H35", a.Spec_Insrtrucion);
                ///Team
                string team_str = "";
                for (int i = 0; i < a.Team.Count; i++)
                {
                    if (i == a.Team.Count - 1)
                        team_str += a.Team[i].ToString();
                    else team_str += a.Team[i].ToString() + ", ";
                }
                exc.SetValue("G11", team_str);
                ///Team 1
                exc.SetValue("T69", a.Team[0].ToString());
                exc.SetValue("T99", a.Team[0].ToString());
                exc.SetValue("T101", a.Team[0].ToString());
                ///Team 2
                if (a.Team.Count > 1 && a.Team[1] != null)
                {
                    exc.SetValue("T71", a.Team[1].ToString());
                    exc.SetValue("AC97", a.Team[1].ToString());
                    exc.SetValue("T103", a.Team[1].ToString());
                }
                ///Team 3
                if (a.Team.Count > 2 && a.Team[2] != null)
                {
                    exc.SetValue("AC65", a.Team[2].ToString());
                    exc.SetValue("AC99", a.Team[2].ToString());
                    exc.SetValue("AC101", a.Team[2].ToString());
                }
                ///Measure
                ///
                
                for (int i = 0; i < meas_l.Count; i++)
                {
                    exc.SetValue(L_Mes[i], meas_l[i]);
                }
                for (int i = 0; i < meas_r.Count; i++)
                {
                    exc.SetValue(R_Mes[i], meas_r[i]);
                }
                exc.SetValue("G19", a.Date_Time_Begin.ToString(Const.FORMAT_DATA));
                exc.SetValue("U19", a.Date_Time_Begin.ToString(Const.FORMAT_TIME));

                exc.SetValue("H20", a.Date_Time_End.ToString(Const.FORMAT_DATA));
                exc.SetValue("U20", a.Date_Time_End.ToString(Const.FORMAT_TIME));
            }
            catch (Exception ex)
            {
                new Log("Error write Excel " + ex.Message);
            }
            ///DataTime Begin End
            

            return result;
        }

        private Point LocForm(object sender)
        {
            return new Point((sender as Button).Location.X + this.Location.X + (sender as Button).Parent.Location.X,
                (sender as Button).Location.Y + this.Location.Y + (sender as Button).Parent.Location.Y);
        }

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
            lDT_Give.Text = CurrentAttire.Date_Time_Give.ToString(Const.FORMAT_DATA + "  " + Const.FORMAT_TIME);
            lDT_Begin.Text = CurrentAttire.Date_Time_Begin.ToString(Const.FORMAT_DATA + "  " + Const.FORMAT_TIME);
            lDT_End.Text = CurrentAttire.Date_Time_End.ToString(Const.FORMAT_DATA + "  " + Const.FORMAT_TIME);
            ///Меры безопасности
            lBoxViewL.Items.Clear();
            lBoxViewR.Items.Clear();
            foreach (var item in meas_l)
            {
                lBoxViewL.Items.Add(item);
            }
            foreach (var item in meas_r)
            {
                lBoxViewR.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListAttire.Load();
            ListEmps.Load();
            ListEmps.Save();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            fEmpl.Location = LocForm(sender);
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
            fEmpl.Location = LocForm(sender);
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
            fEmpl.Location = LocForm(sender);
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
            fEmpl.Location = LocForm(sender);
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
            fData.Location = LocForm(sender);
            fData.ShowDialog();
            if (fData.isSelected)
            {
                DateTime temp = new DateTime();
                CurrentAttire.Date_Time_Give = fData.SelDT;
                temp = CurrentAttire.Date_Time_Give;
                
                while (true)
                {
                    temp = temp.AddDays(1);
                    if ((temp.DayOfWeek == DayOfWeek.Saturday) || (temp.DayOfWeek == DayOfWeek.Sunday))
                    {
                        continue;
                    }
                    else break;
                }
                temp = new DateTime(temp.Year, temp.Month, temp.Day, 8, 0, 0);
                CurrentAttire.Date_Time_Begin = temp;
                temp = new DateTime(temp.Year, temp.Month, temp.Day + Const.DAYS_ATTIRE, 17, 0, 0);
                CurrentAttire.Date_Time_End = temp;
                
                onRewrite();
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            fData.Location = LocForm(sender);
            fData.ShowDialog();
            if (fData.isSelected)
            {
                CurrentAttire.Date_Time_Begin = fData.SelDT;
                onRewrite();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fData.Location = LocForm(sender);
            fData.ShowDialog();
            if (fData.isSelected)
            {
                CurrentAttire.Date_Time_End = fData.SelDT;
                onRewrite();
            }
        }

        private void addOrderbtn_Click(object sender, EventArgs e)
        {
            CurrentAttire.Estr = tBoxEstr.Text;
            CurrentAttire.Spec_Insrtrucion = tBoxInstr.Text;
            AddAttire(CurrentAttire);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fSec.Location = LocForm(sender);
            fSec.sList = CurrentAttire.Sec_Meas;
            fSec.ShowDialog();
            if (fSec.isOk)
            {
                CurrentAttire.Sec_Meas = fSec.sList;
                meas_l = fSec.lView;
                meas_r = fSec.rView;
                onRewrite();
            }
        }
    }
}
