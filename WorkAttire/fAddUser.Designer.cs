namespace WorkAttire
{
    partial class fAddUser
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAddUser));
            this.bDelEmp = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bEditEmp = new System.Windows.Forms.Button();
            this.bAddEmp = new System.Windows.Forms.Button();
            this.nBoxGroup = new System.Windows.Forms.NumericUpDown();
            this.cBoxForePerson = new System.Windows.Forms.CheckBox();
            this.cBoxGiveAttire = new System.Windows.Forms.CheckBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxListEmp = new System.Windows.Forms.ListBox();
            this.cBoxResponManager = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nBoxGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // bDelEmp
            // 
            this.bDelEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDelEmp.ImageIndex = 2;
            this.bDelEmp.ImageList = this.imageList1;
            this.bDelEmp.Location = new System.Drawing.Point(335, 234);
            this.bDelEmp.Name = "bDelEmp";
            this.bDelEmp.Size = new System.Drawing.Size(253, 34);
            this.bDelEmp.TabIndex = 27;
            this.bDelEmp.Text = "Удалить";
            this.bDelEmp.UseVisualStyleBackColor = true;
            this.bDelEmp.Click += new System.EventHandler(this.bDelEmp_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "11.png");
            this.imageList1.Images.SetKeyName(1, "12.png");
            this.imageList1.Images.SetKeyName(2, "17.png");
            this.imageList1.Images.SetKeyName(3, "18.png");
            this.imageList1.Images.SetKeyName(4, "19.png");
            this.imageList1.Images.SetKeyName(5, "20.png");
            this.imageList1.Images.SetKeyName(6, "21.png");
            this.imageList1.Images.SetKeyName(7, "29.png");
            this.imageList1.Images.SetKeyName(8, "36.png");
            this.imageList1.Images.SetKeyName(9, "41.png");
            this.imageList1.Images.SetKeyName(10, "43.png");
            this.imageList1.Images.SetKeyName(11, "54.png");
            this.imageList1.Images.SetKeyName(12, "98.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(12, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 39);
            this.label3.TabIndex = 26;
            this.label3.Text = "% - Отдающий распоряжение\r\n@ - Ответственный руководитель\r\n# - Производитель рабо" +
    "т";
            // 
            // bCancel
            // 
            this.bCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.bCancel.ImageIndex = 12;
            this.bCancel.ImageList = this.imageList1;
            this.bCancel.Location = new System.Drawing.Point(473, 331);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(129, 36);
            this.bCancel.TabIndex = 25;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSave.ImageIndex = 7;
            this.bSave.ImageList = this.imageList1;
            this.bSave.Location = new System.Drawing.Point(335, 331);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(128, 36);
            this.bSave.TabIndex = 24;
            this.bSave.Text = "Сохранить";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bEditEmp
            // 
            this.bEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditEmp.ImageIndex = 3;
            this.bEditEmp.ImageList = this.imageList1;
            this.bEditEmp.Location = new System.Drawing.Point(466, 178);
            this.bEditEmp.Name = "bEditEmp";
            this.bEditEmp.Size = new System.Drawing.Size(122, 34);
            this.bEditEmp.TabIndex = 23;
            this.bEditEmp.Text = "Изменить";
            this.bEditEmp.UseVisualStyleBackColor = true;
            this.bEditEmp.Click += new System.EventHandler(this.bEditEmp_Click);
            // 
            // bAddEmp
            // 
            this.bAddEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bAddEmp.ImageIndex = 5;
            this.bAddEmp.ImageList = this.imageList1;
            this.bAddEmp.Location = new System.Drawing.Point(335, 178);
            this.bAddEmp.Name = "bAddEmp";
            this.bAddEmp.Size = new System.Drawing.Size(125, 34);
            this.bAddEmp.TabIndex = 22;
            this.bAddEmp.Text = "Добавить";
            this.bAddEmp.UseVisualStyleBackColor = true;
            this.bAddEmp.Click += new System.EventHandler(this.bAddEmp_Click);
            // 
            // nBoxGroup
            // 
            this.nBoxGroup.Location = new System.Drawing.Point(395, 54);
            this.nBoxGroup.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nBoxGroup.Name = "nBoxGroup";
            this.nBoxGroup.Size = new System.Drawing.Size(120, 20);
            this.nBoxGroup.TabIndex = 21;
            // 
            // cBoxForePerson
            // 
            this.cBoxForePerson.AutoSize = true;
            this.cBoxForePerson.Location = new System.Drawing.Point(395, 132);
            this.cBoxForePerson.Name = "cBoxForePerson";
            this.cBoxForePerson.Size = new System.Drawing.Size(156, 17);
            this.cBoxForePerson.TabIndex = 20;
            this.cBoxForePerson.Text = "Производитель работ  (#)";
            this.cBoxForePerson.UseVisualStyleBackColor = true;
            // 
            // cBoxGiveAttire
            // 
            this.cBoxGiveAttire.AutoSize = true;
            this.cBoxGiveAttire.Location = new System.Drawing.Point(395, 86);
            this.cBoxGiveAttire.Name = "cBoxGiveAttire";
            this.cBoxGiveAttire.Size = new System.Drawing.Size(177, 17);
            this.cBoxGiveAttire.TabIndex = 19;
            this.cBoxGiveAttire.Text = "Отдающий распоряжение  (%)";
            this.cBoxGiveAttire.UseVisualStyleBackColor = true;
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(395, 22);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(207, 20);
            this.tBoxName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Группа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Фамилия И.О.";
            // 
            // lBoxListEmp
            // 
            this.lBoxListEmp.FormattingEnabled = true;
            this.lBoxListEmp.Location = new System.Drawing.Point(12, 12);
            this.lBoxListEmp.Name = "lBoxListEmp";
            this.lBoxListEmp.Size = new System.Drawing.Size(286, 342);
            this.lBoxListEmp.TabIndex = 15;
            this.lBoxListEmp.SelectedIndexChanged += new System.EventHandler(this.lBoxListEmp_SelectedIndexChanged);
            // 
            // cBoxResponManager
            // 
            this.cBoxResponManager.AutoSize = true;
            this.cBoxResponManager.Location = new System.Drawing.Point(395, 109);
            this.cBoxResponManager.Name = "cBoxResponManager";
            this.cBoxResponManager.Size = new System.Drawing.Size(201, 17);
            this.cBoxResponManager.TabIndex = 28;
            this.cBoxResponManager.Text = "Ответственный руководитель  (@)";
            this.cBoxResponManager.UseVisualStyleBackColor = true;
            // 
            // fAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 404);
            this.Controls.Add(this.cBoxResponManager);
            this.Controls.Add(this.bDelEmp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bEditEmp);
            this.Controls.Add(this.bAddEmp);
            this.Controls.Add(this.nBoxGroup);
            this.Controls.Add(this.cBoxForePerson);
            this.Controls.Add(this.cBoxGiveAttire);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lBoxListEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Работники";
            this.Load += new System.EventHandler(this.fAddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nBoxGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bDelEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bEditEmp;
        private System.Windows.Forms.Button bAddEmp;
        private System.Windows.Forms.NumericUpDown nBoxGroup;
        private System.Windows.Forms.CheckBox cBoxForePerson;
        private System.Windows.Forms.CheckBox cBoxGiveAttire;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxListEmp;
        private System.Windows.Forms.CheckBox cBoxResponManager;
        private System.Windows.Forms.ImageList imageList1;
    }
}