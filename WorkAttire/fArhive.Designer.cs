namespace WorkAttire
{
    partial class fArhive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fArhive));
            this.label1 = new System.Windows.Forms.Label();
            this.lActiveAttire = new System.Windows.Forms.Label();
            this.lUnRegAttire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lAllAttire = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bListActive = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.bListUnReg = new System.Windows.Forms.Button();
            this.bListAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lCountAttire = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lDate_B = new System.Windows.Forms.Label();
            this.lDate_A = new System.Windows.Forms.Label();
            this.mCalB = new System.Windows.Forms.MonthCalendar();
            this.mCalA = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Действующие наряды:";
            // 
            // lActiveAttire
            // 
            this.lActiveAttire.AutoSize = true;
            this.lActiveAttire.Location = new System.Drawing.Point(199, 30);
            this.lActiveAttire.Name = "lActiveAttire";
            this.lActiveAttire.Size = new System.Drawing.Size(13, 13);
            this.lActiveAttire.TabIndex = 1;
            this.lActiveAttire.Text = "0";
            // 
            // lUnRegAttire
            // 
            this.lUnRegAttire.AutoSize = true;
            this.lUnRegAttire.Location = new System.Drawing.Point(199, 94);
            this.lUnRegAttire.Name = "lUnRegAttire";
            this.lUnRegAttire.Size = new System.Drawing.Size(13, 13);
            this.lUnRegAttire.TabIndex = 3;
            this.lUnRegAttire.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Не зарегистрированные \r\nнаряды:";
            // 
            // lAllAttire
            // 
            this.lAllAttire.AutoSize = true;
            this.lAllAttire.Location = new System.Drawing.Point(199, 145);
            this.lAllAttire.Name = "lAllAttire";
            this.lAllAttire.Size = new System.Drawing.Size(13, 13);
            this.lAllAttire.TabIndex = 7;
            this.lAllAttire.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Все наряды:";
            // 
            // bListActive
            // 
            this.bListActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bListActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bListActive.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bListActive.ImageIndex = 8;
            this.bListActive.ImageList = this.imageList1;
            this.bListActive.Location = new System.Drawing.Point(235, 18);
            this.bListActive.Name = "bListActive";
            this.bListActive.Size = new System.Drawing.Size(164, 40);
            this.bListActive.TabIndex = 41;
            this.bListActive.Text = "Список   ";
            this.bListActive.UseVisualStyleBackColor = true;
            this.bListActive.Click += new System.EventHandler(this.bListActive_Click);
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
            // bListUnReg
            // 
            this.bListUnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bListUnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bListUnReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bListUnReg.ImageIndex = 8;
            this.bListUnReg.ImageList = this.imageList1;
            this.bListUnReg.Location = new System.Drawing.Point(235, 71);
            this.bListUnReg.Name = "bListUnReg";
            this.bListUnReg.Size = new System.Drawing.Size(164, 40);
            this.bListUnReg.TabIndex = 41;
            this.bListUnReg.Text = "Список   ";
            this.bListUnReg.UseVisualStyleBackColor = true;
            this.bListUnReg.Click += new System.EventHandler(this.bListUnReg_Click);
            // 
            // bListAll
            // 
            this.bListAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bListAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bListAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bListAll.ImageIndex = 8;
            this.bListAll.ImageList = this.imageList1;
            this.bListAll.Location = new System.Drawing.Point(235, 126);
            this.bListAll.Name = "bListAll";
            this.bListAll.Size = new System.Drawing.Size(164, 40);
            this.bListAll.TabIndex = 41;
            this.bListAll.Text = "Список   ";
            this.bListAll.UseVisualStyleBackColor = true;
            this.bListAll.Click += new System.EventHandler(this.bListAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.lCountAttire);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lDate_B);
            this.groupBox1.Controls.Add(this.lDate_A);
            this.groupBox1.Controls.Add(this.mCalB);
            this.groupBox1.Controls.Add(this.mCalA);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 206);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "За срок:";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 6;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(371, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 40);
            this.button3.TabIndex = 43;
            this.button3.Text = "Посчитать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lCountAttire
            // 
            this.lCountAttire.AutoSize = true;
            this.lCountAttire.Location = new System.Drawing.Point(485, 35);
            this.lCountAttire.Name = "lCountAttire";
            this.lCountAttire.Size = new System.Drawing.Size(13, 13);
            this.lCountAttire.TabIndex = 43;
            this.lCountAttire.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(370, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Кол-во нарядов:";
            // 
            // lDate_B
            // 
            this.lDate_B.AutoSize = true;
            this.lDate_B.Location = new System.Drawing.Point(191, 179);
            this.lDate_B.Name = "lDate_B";
            this.lDate_B.Size = new System.Drawing.Size(33, 13);
            this.lDate_B.TabIndex = 3;
            this.lDate_B.Text = "Дата";
            // 
            // lDate_A
            // 
            this.lDate_A.AutoSize = true;
            this.lDate_A.Location = new System.Drawing.Point(9, 179);
            this.lDate_A.Name = "lDate_A";
            this.lDate_A.Size = new System.Drawing.Size(33, 13);
            this.lDate_A.TabIndex = 2;
            this.lDate_A.Text = "Дата";
            // 
            // mCalB
            // 
            this.mCalB.Location = new System.Drawing.Point(194, 14);
            this.mCalB.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.mCalB.MaxSelectionCount = 1;
            this.mCalB.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.mCalB.Name = "mCalB";
            this.mCalB.ShowToday = false;
            this.mCalB.TabIndex = 1;
            this.mCalB.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalB_DateSelected);
            // 
            // mCalA
            // 
            this.mCalA.Location = new System.Drawing.Point(12, 14);
            this.mCalA.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.mCalA.MaxSelectionCount = 1;
            this.mCalA.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.mCalA.Name = "mCalA";
            this.mCalA.ShowToday = false;
            this.mCalA.TabIndex = 0;
            this.mCalA.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mCalA_DateSelected);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 3;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(402, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 40);
            this.button1.TabIndex = 43;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fArhive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 471);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bListAll);
            this.Controls.Add(this.bListUnReg);
            this.Controls.Add(this.bListActive);
            this.Controls.Add(this.lAllAttire);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lUnRegAttire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lActiveAttire);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fArhive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Наряды";
            this.Load += new System.EventHandler(this.fArhive_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lActiveAttire;
        private System.Windows.Forms.Label lUnRegAttire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lAllAttire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bListActive;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button bListUnReg;
        private System.Windows.Forms.Button bListAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lCountAttire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lDate_B;
        private System.Windows.Forms.Label lDate_A;
        private System.Windows.Forms.MonthCalendar mCalB;
        private System.Windows.Forms.MonthCalendar mCalA;
        private System.Windows.Forms.Button button1;

    }
}