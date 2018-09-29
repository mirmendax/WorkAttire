namespace WorkAttire
{
    partial class fProgram
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.n_AGR = new System.Windows.Forms.NumericUpDown();
            this.cB_SV = new System.Windows.Forms.CheckBox();
            this.cB_1TN = new System.Windows.Forms.CheckBox();
            this.cB_2TN = new System.Windows.Forms.CheckBox();
            this.cB_3TN = new System.Windows.Forms.CheckBox();
            this.cB_1KTN = new System.Windows.Forms.CheckBox();
            this.cB_2KTN = new System.Windows.Forms.CheckBox();
            this.cB_PR3 = new System.Windows.Forms.CheckBox();
            this.cB_ASU = new System.Windows.Forms.CheckBox();
            this.cB_SUG = new System.Windows.Forms.CheckBox();
            this.cB_MPRZ = new System.Windows.Forms.CheckBox();
            this.cB_23PR = new System.Windows.Forms.CheckBox();
            this.d_TO = new System.Windows.Forms.DateTimePicker();
            this.cBox_Type_TO = new System.Windows.Forms.ComboBox();
            this.d_WorkProgram = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.n_AGR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "№ аргегата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Тип ТО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рабочие места";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Дата программы ТО";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Дата рабочей программы";
            // 
            // btn_Ok
            // 
            this.btn_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Ok.ImageIndex = 5;
            this.btn_Ok.Location = new System.Drawing.Point(42, 151);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(118, 32);
            this.btn_Ok.TabIndex = 15;
            this.btn_Ok.Text = "ОК";
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Cancel.ImageIndex = 5;
            this.btn_Cancel.Location = new System.Drawing.Point(223, 151);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(118, 32);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Отмена";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // n_AGR
            // 
            this.n_AGR.Location = new System.Drawing.Point(154, 7);
            this.n_AGR.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.n_AGR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.n_AGR.Name = "n_AGR";
            this.n_AGR.Size = new System.Drawing.Size(100, 20);
            this.n_AGR.TabIndex = 16;
            this.n_AGR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cB_SV
            // 
            this.cB_SV.AutoSize = true;
            this.cB_SV.Location = new System.Drawing.Point(310, 25);
            this.cB_SV.Name = "cB_SV";
            this.cB_SV.Size = new System.Drawing.Size(56, 17);
            this.cB_SV.TabIndex = 17;
            this.cB_SV.Text = "ЩВ-*Г";
            this.cB_SV.UseVisualStyleBackColor = true;
            // 
            // cB_1TN
            // 
            this.cB_1TN.AutoSize = true;
            this.cB_1TN.Location = new System.Drawing.Point(310, 48);
            this.cB_1TN.Name = "cB_1TN";
            this.cB_1TN.Size = new System.Drawing.Size(60, 17);
            this.cB_1TN.TabIndex = 17;
            this.cB_1TN.Text = "1ТН-*Г";
            this.cB_1TN.UseVisualStyleBackColor = true;
            // 
            // cB_2TN
            // 
            this.cB_2TN.AutoSize = true;
            this.cB_2TN.Location = new System.Drawing.Point(310, 71);
            this.cB_2TN.Name = "cB_2TN";
            this.cB_2TN.Size = new System.Drawing.Size(60, 17);
            this.cB_2TN.TabIndex = 17;
            this.cB_2TN.Text = "2ТН-*Г";
            this.cB_2TN.UseVisualStyleBackColor = true;
            // 
            // cB_3TN
            // 
            this.cB_3TN.AutoSize = true;
            this.cB_3TN.Location = new System.Drawing.Point(310, 94);
            this.cB_3TN.Name = "cB_3TN";
            this.cB_3TN.Size = new System.Drawing.Size(60, 17);
            this.cB_3TN.TabIndex = 17;
            this.cB_3TN.Text = "3ТН-*Г";
            this.cB_3TN.UseVisualStyleBackColor = true;
            // 
            // cB_1KTN
            // 
            this.cB_1KTN.AutoSize = true;
            this.cB_1KTN.Location = new System.Drawing.Point(310, 117);
            this.cB_1KTN.Name = "cB_1KTN";
            this.cB_1KTN.Size = new System.Drawing.Size(67, 17);
            this.cB_1KTN.TabIndex = 17;
            this.cB_1KTN.Text = "1КТН-*Г";
            this.cB_1KTN.UseVisualStyleBackColor = true;
            // 
            // cB_2KTN
            // 
            this.cB_2KTN.AutoSize = true;
            this.cB_2KTN.Location = new System.Drawing.Point(415, 25);
            this.cB_2KTN.Name = "cB_2KTN";
            this.cB_2KTN.Size = new System.Drawing.Size(67, 17);
            this.cB_2KTN.TabIndex = 17;
            this.cB_2KTN.Text = "2КТН-*Г";
            this.cB_2KTN.UseVisualStyleBackColor = true;
            // 
            // cB_PR3
            // 
            this.cB_PR3.AutoSize = true;
            this.cB_PR3.Location = new System.Drawing.Point(415, 48);
            this.cB_PR3.Name = "cB_PR3";
            this.cB_PR3.Size = new System.Drawing.Size(54, 17);
            this.cB_PR3.TabIndex = 17;
            this.cB_PR3.Text = "*ПР-3";
            this.cB_PR3.UseVisualStyleBackColor = true;
            // 
            // cB_ASU
            // 
            this.cB_ASU.AutoSize = true;
            this.cB_ASU.Location = new System.Drawing.Point(415, 71);
            this.cB_ASU.Name = "cB_ASU";
            this.cB_ASU.Size = new System.Drawing.Size(64, 17);
            this.cB_ASU.TabIndex = 17;
            this.cB_ASU.Text = "АЩУ-*Г";
            this.cB_ASU.UseVisualStyleBackColor = true;
            // 
            // cB_SUG
            // 
            this.cB_SUG.AutoSize = true;
            this.cB_SUG.Location = new System.Drawing.Point(415, 94);
            this.cB_SUG.Name = "cB_SUG";
            this.cB_SUG.Size = new System.Drawing.Size(68, 17);
            this.cB_SUG.TabIndex = 17;
            this.cB_SUG.Text = "СУГ-23Г";
            this.cB_SUG.UseVisualStyleBackColor = true;
            // 
            // cB_MPRZ
            // 
            this.cB_MPRZ.AutoSize = true;
            this.cB_MPRZ.Location = new System.Drawing.Point(415, 117);
            this.cB_MPRZ.Name = "cB_MPRZ";
            this.cB_MPRZ.Size = new System.Drawing.Size(95, 17);
            this.cB_MPRZ.TabIndex = 17;
            this.cB_MPRZ.Text = "МПРЗ СВ-23Г";
            this.cB_MPRZ.UseVisualStyleBackColor = true;
            // 
            // cB_23PR
            // 
            this.cB_23PR.AutoSize = true;
            this.cB_23PR.Location = new System.Drawing.Point(415, 140);
            this.cB_23PR.Name = "cB_23PR";
            this.cB_23PR.Size = new System.Drawing.Size(73, 17);
            this.cB_23PR.TabIndex = 17;
            this.cB_23PR.Text = "23ПР-ЩВ";
            this.cB_23PR.UseVisualStyleBackColor = true;
            // 
            // d_TO
            // 
            this.d_TO.Location = new System.Drawing.Point(154, 29);
            this.d_TO.Name = "d_TO";
            this.d_TO.Size = new System.Drawing.Size(132, 20);
            this.d_TO.TabIndex = 18;
            // 
            // cBox_Type_TO
            // 
            this.cBox_Type_TO.AutoCompleteCustomSource.AddRange(new string[] {
            "К",
            "К1",
            "В"});
            this.cBox_Type_TO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBox_Type_TO.FormattingEnabled = true;
            this.cBox_Type_TO.Items.AddRange(new object[] {
            "К",
            "К1",
            "В"});
            this.cBox_Type_TO.Location = new System.Drawing.Point(154, 84);
            this.cBox_Type_TO.Name = "cBox_Type_TO";
            this.cBox_Type_TO.Size = new System.Drawing.Size(100, 21);
            this.cBox_Type_TO.TabIndex = 3;
            // 
            // d_WorkProgram
            // 
            this.d_WorkProgram.Location = new System.Drawing.Point(154, 55);
            this.d_WorkProgram.Name = "d_WorkProgram";
            this.d_WorkProgram.Size = new System.Drawing.Size(132, 20);
            this.d_WorkProgram.TabIndex = 18;
            // 
            // fProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 199);
            this.Controls.Add(this.d_WorkProgram);
            this.Controls.Add(this.d_TO);
            this.Controls.Add(this.cB_23PR);
            this.Controls.Add(this.cB_MPRZ);
            this.Controls.Add(this.cB_SUG);
            this.Controls.Add(this.cB_ASU);
            this.Controls.Add(this.cB_PR3);
            this.Controls.Add(this.cB_2KTN);
            this.Controls.Add(this.cB_1KTN);
            this.Controls.Add(this.cB_3TN);
            this.Controls.Add(this.cB_2TN);
            this.Controls.Add(this.cB_1TN);
            this.Controls.Add(this.cB_SV);
            this.Controls.Add(this.n_AGR);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBox_Type_TO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работа по программе";
            this.Load += new System.EventHandler(this.fProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.n_AGR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.NumericUpDown n_AGR;
        private System.Windows.Forms.CheckBox cB_SV;
        private System.Windows.Forms.CheckBox cB_1TN;
        private System.Windows.Forms.CheckBox cB_2TN;
        private System.Windows.Forms.CheckBox cB_3TN;
        private System.Windows.Forms.CheckBox cB_1KTN;
        private System.Windows.Forms.CheckBox cB_2KTN;
        private System.Windows.Forms.CheckBox cB_PR3;
        private System.Windows.Forms.CheckBox cB_ASU;
        private System.Windows.Forms.CheckBox cB_SUG;
        private System.Windows.Forms.CheckBox cB_MPRZ;
        private System.Windows.Forms.CheckBox cB_23PR;
        private System.Windows.Forms.DateTimePicker d_TO;
        private System.Windows.Forms.DateTimePicker d_WorkProgram;
        private System.Windows.Forms.ComboBox cBox_Type_TO;
    }
}