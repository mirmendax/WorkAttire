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
        /*      PRIVATE      */
        const string gTrue = "%";
        const string rTrue = "@";
        const string fTrue = "#";
        const string False = "";

        public fAddUser()
        {
            InitializeComponent();
        }

        private void onRewrite(List<Emp> list)
        {
            lBoxListEmp.Items.Clear();
           
            foreach (var item in list)
            {
                lBoxListEmp.Items.Add(string.Format("{0} \t\t {1} {2} {3}",
                    item.ToString(),
                    (item.RuleGiveAttire) ? gTrue : False,
                    (item.RuleResponManager) ? rTrue : False,
                    (item.RuleForePerson) ? fTrue : False));
            }
        }

        private void onRewriteEmpl(Emp e)
        {
            tBoxName.Text = e.Name;
            nBoxGroup.Value = e.Group;
            cBoxForePerson.Checked = e.RuleForePerson;
            cBoxGiveAttire.Checked = e.RuleGiveAttire;
            cBoxResponManager.Checked = e.RuleResponManager;
        }


        public void onLoad() { fAddUser_Load(null, null); }
        private void fAddUser_Load(object sender, EventArgs e)
        {
            onRewrite(this.ListEmp);
            tBoxName.Text = "";
            nBoxGroup.Value = 0;
            cBoxForePerson.Checked = cBoxGiveAttire.Checked = cBoxResponManager.Checked = false;
            isSave = false;
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            ListEmp.Clear();
            bSave.ForeColor = Color.Black;
            isSave = false;
            Hide();
        }

        private void lBoxListEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            int i = lb.SelectedIndex;
            if (i != -1)
            {
                if (ListEmp != null)
                    onRewriteEmpl(ListEmp[i]);
            }
        }

        private void bAddEmp_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text != "" && nBoxGroup.Value != 0)
            {
                Emp ne = new Emp(tBoxName.Text, (int)nBoxGroup.Value, cBoxGiveAttire.Checked, cBoxResponManager.Checked, cBoxForePerson.Checked);
                ListEmp.Add(ne);
                onRewrite(ListEmp);
                bSave.ForeColor = Color.Red;
                tBoxName.Text = "";
                nBoxGroup.Value = 0;
                cBoxGiveAttire.Checked = cBoxResponManager.Checked = cBoxForePerson.Checked = false;
            }
        }

        private void bEditEmp_Click(object sender, EventArgs e)
        {
            if (tBoxName.Text != "" && nBoxGroup.Value != 0)
            {
                Emp ee = new Emp(tBoxName.Text, (int)nBoxGroup.Value, cBoxGiveAttire.Checked, cBoxResponManager.Checked, cBoxForePerson.Checked);
                if (lBoxListEmp.SelectedIndex != -1)
                {
                    ListEmp[lBoxListEmp.SelectedIndex] = ee;
                    onRewrite(ListEmp);
                    onRewriteEmpl(new Emp());
                    bSave.ForeColor = Color.Red;
                }
            }
        }

        private void bDelEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (lBoxListEmp.SelectedIndex != -1)
                {
                    ListEmp.Remove(ListEmp[lBoxListEmp.SelectedIndex]);
                    onRewrite(ListEmp);
                    onRewriteEmpl(new Emp("", 0));
                    bSave.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                new Log("Error delete Emp: " + ex.Message);
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            NewListEmp.Clear();
            foreach (var item in ListEmp)
            {
                NewListEmp.Add(item);
            }
            isSave = true;
            bSave.ForeColor = Color.Black;
            Hide();
        }
    }
}
