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
    public partial class fProgram : Form
    {
        #region Data
        public string OUT_Estr = string.Empty;
        public string OUT_Instr = string.Empty;
        public bool isOK = false;
        #endregion


        public fProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isOK = false;
            Hide();
        }

        private void fProgram_Load(object sender, EventArgs e)
        {
            n_AGR.Value = 1;
            d_TO.Value = DateTime.Today;
            d_WorkProgram.Value = DateTime.Today;
            cB_SV.Checked = false;
            cB_1TN.Checked = false;
            cB_2TN.Checked = false;
            cB_3TN.Checked = false;
            cB_1KTN.Checked = false;
            cB_2KTN.Checked = false;
            cB_PR3.Checked = false;
            cB_ASU.Checked = false;
            cB_SUG.Checked = false;
            cB_MPRZ.Checked = false;
            cB_23PR.Checked = false;
            cB_23PR.Checked = false;
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            string r_m = "";
            try
            {
                //Estr
                r_m = string.Format(Const.FORMAT_WORKPLACE_LIST,
                    cB_SV.Checked ? "ЩВ-{0}Г, " : "",
                    cB_1TN.Checked ? "1ТН-{0}Г, " : "",
                    cB_2TN.Checked ? "2ТН-{0}Г, " : "",
                    cB_3TN.Checked ? "3ТН-{0}Г, " : "",
                    cB_1KTN.Checked ? "1КТН-{0}Г, " : "",
                    cB_2KTN.Checked ? "2КТН-{0}Г, " : "",
                    cB_PR3.Checked ? "{0}-ПР3, " : "",
                    cB_ASU.Checked ? "АЩУ-{0}Г, " : "",
                    cB_SUG.Checked ? "СУГ-23Г, " : "",
                    cB_MPRZ.Checked ? "МПРЗ СВ-23Г, " : "",
                    cB_23PR.Checked ? "3КТН-{0}Г, " : "",
                    cB_23PR.Checked ? "23ПР-ЩВ, " : ""
                    );
                r_m = r_m.Remove(r_m.Length - 2);//удалить последние символы (", ")

                r_m = string.Format(r_m, n_AGR.Value.ToString());
                string type_to = "";
                string t_to = "";
                if ((string)cBox_Type_TO.SelectedItem == "К")
                {
                    type_to = Const.FORMAT_TYPE_TO_K;
                    t_to = Const.FORMAT_TYPE_TO_K_;
                }
                if ((string)cBox_Type_TO.SelectedItem == "К1")
                {
                    type_to = Const.FORMAT_TYPE_TO_K1;
                    t_to = Const.FORMAT_TYPE_TO_K1_;
                }
                if ((string)cBox_Type_TO.SelectedItem == "В")
                {
                    type_to = Const.FORMAT_TYPE_TO_B;
                    t_to = Const.FORMAT_TYPE_TO_B_;
                }
                string estr = string.Format(Const.FORMAT_ESTR_PROGRAMM, r_m, type_to);
                //End Estr
                //Instr
                string n_agr = "";
                if (n_AGR.Value < 10) n_agr = "0" + n_AGR.Value.ToString();
                else
                    n_agr = n_AGR.Value.ToString();
                string p_to = string.Format(Const.FORMAT_PROGRAM_TO, n_agr, t_to);
                string p_r = string.Format(Const.FORMAT_PROGRAM_RAB, n_agr, t_to);
                string instr = string.Format(Const.FORMAT_INST_PROGRAMM,
                p_to,
                d_TO.Value.ToString(Const.FORMAT_DATA),
                p_r,
                d_WorkProgram.Value.ToString(Const.FORMAT_DATA)
                );
               
                //End Instr
                OUT_Estr = estr;
                OUT_Instr = instr;
                isOK = true;
                Hide();
            }
            catch (Exception ee)
            {
                new Log("Error PROGRAMM TEMPLATE " + ee.Message);
            }
        }
    }
}
