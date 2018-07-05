namespace WorkAttire
{
    partial class fSec_Measure
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSec_Measure));
            this.tBoxWhere = new System.Windows.Forms.TextBox();
            this.tBoxWhat = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lBoxViewL = new System.Windows.Forms.ListBox();
            this.lBoxViewR = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tBoxWhere
            // 
            this.tBoxWhere.Location = new System.Drawing.Point(12, 276);
            this.tBoxWhere.Name = "tBoxWhere";
            this.tBoxWhere.Size = new System.Drawing.Size(243, 20);
            this.tBoxWhere.TabIndex = 1;
            // 
            // tBoxWhat
            // 
            this.tBoxWhat.Location = new System.Drawing.Point(272, 276);
            this.tBoxWhat.Multiline = true;
            this.tBoxWhat.Name = "tBoxWhat";
            this.tBoxWhat.Size = new System.Drawing.Size(342, 145);
            this.tBoxWhat.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 5;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(39, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 6;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(39, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 39);
            this.button2.TabIndex = 4;
            this.button2.Text = "Отчистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Наименование электроустановки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Что должно быть отключено";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 3;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(519, 57);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 39);
            this.button3.TabIndex = 7;
            this.button3.Text = "ОК";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 2;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(519, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Отмена";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lBoxViewL
            // 
            this.lBoxViewL.FormattingEnabled = true;
            this.lBoxViewL.Location = new System.Drawing.Point(12, 12);
            this.lBoxViewL.Name = "lBoxViewL";
            this.lBoxViewL.Size = new System.Drawing.Size(243, 212);
            this.lBoxViewL.TabIndex = 8;
            // 
            // lBoxViewR
            // 
            this.lBoxViewR.FormattingEnabled = true;
            this.lBoxViewR.Location = new System.Drawing.Point(254, 12);
            this.lBoxViewR.Name = "lBoxViewR";
            this.lBoxViewR.Size = new System.Drawing.Size(243, 212);
            this.lBoxViewR.TabIndex = 8;
            // 
            // fSec_Measure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 438);
            this.Controls.Add(this.lBoxViewR);
            this.Controls.Add(this.lBoxViewL);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBoxWhat);
            this.Controls.Add(this.tBoxWhere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fSec_Measure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Меры по подготовке рабочих мест";
            this.Load += new System.EventHandler(this.fSec_Measure_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxWhere;
        private System.Windows.Forms.TextBox tBoxWhat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lBoxViewL;
        private System.Windows.Forms.ListBox lBoxViewR;
    }
}