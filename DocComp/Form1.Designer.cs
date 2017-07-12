namespace DocComp
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_LoadJobDesc = new System.Windows.Forms.Button();
            this.btn_LoadResume = new System.Windows.Forms.Button();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_JobCount = new System.Windows.Forms.Label();
            this.lbl_ResCount = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_AddKeyWord = new System.Windows.Forms.Button();
            this.tBox_AddKeword = new System.Windows.Forms.TextBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.lbl_mergedCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_mergedCount);
            this.groupBox1.Controls.Add(this.listBox3);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_LoadJobDesc);
            this.groupBox1.Controls.Add(this.btn_LoadResume);
            this.groupBox1.Location = new System.Drawing.Point(199, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 414);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(258, 19);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(166, 316);
            this.listBox2.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(86, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(166, 316);
            this.listBox1.TabIndex = 9;
            // 
            // btn_LoadJobDesc
            // 
            this.btn_LoadJobDesc.Location = new System.Drawing.Point(300, 361);
            this.btn_LoadJobDesc.Name = "btn_LoadJobDesc";
            this.btn_LoadJobDesc.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadJobDesc.TabIndex = 8;
            this.btn_LoadJobDesc.Text = "Load";
            this.btn_LoadJobDesc.UseVisualStyleBackColor = true;
            this.btn_LoadJobDesc.Click += new System.EventHandler(this.btn_LoadJobDesc_Click);
            // 
            // btn_LoadResume
            // 
            this.btn_LoadResume.Location = new System.Drawing.Point(128, 361);
            this.btn_LoadResume.Name = "btn_LoadResume";
            this.btn_LoadResume.Size = new System.Drawing.Size(75, 23);
            this.btn_LoadResume.TabIndex = 7;
            this.btn_LoadResume.Text = "Load";
            this.btn_LoadResume.UseVisualStyleBackColor = true;
            this.btn_LoadResume.Click += new System.EventHandler(this.btn_LoadResume_Click);
            // 
            // btn_Compare
            // 
            this.btn_Compare.Location = new System.Drawing.Point(68, 33);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(75, 23);
            this.btn_Compare.TabIndex = 9;
            this.btn_Compare.Text = "Compare";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_JobCount);
            this.groupBox2.Controls.Add(this.lbl_ResCount);
            this.groupBox2.Controls.Add(this.btn_Compare);
            this.groupBox2.Location = new System.Drawing.Point(837, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 414);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // lbl_JobCount
            // 
            this.lbl_JobCount.AutoSize = true;
            this.lbl_JobCount.Location = new System.Drawing.Point(31, 102);
            this.lbl_JobCount.Name = "lbl_JobCount";
            this.lbl_JobCount.Size = new System.Drawing.Size(49, 13);
            this.lbl_JobCount.TabIndex = 11;
            this.lbl_JobCount.Text = "jobCount";
            // 
            // lbl_ResCount
            // 
            this.lbl_ResCount.AutoSize = true;
            this.lbl_ResCount.Location = new System.Drawing.Point(31, 75);
            this.lbl_ResCount.Name = "lbl_ResCount";
            this.lbl_ResCount.Size = new System.Drawing.Size(49, 13);
            this.lbl_ResCount.TabIndex = 10;
            this.lbl_ResCount.Text = "resCount";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(430, 19);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(166, 316);
            this.listBox3.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox4);
            this.groupBox3.Controls.Add(this.tBox_AddKeword);
            this.groupBox3.Controls.Add(this.btn_AddKeyWord);
            this.groupBox3.Location = new System.Drawing.Point(2, 33);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 414);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // btn_AddKeyWord
            // 
            this.btn_AddKeyWord.Location = new System.Drawing.Point(125, 32);
            this.btn_AddKeyWord.Name = "btn_AddKeyWord";
            this.btn_AddKeyWord.Size = new System.Drawing.Size(60, 23);
            this.btn_AddKeyWord.TabIndex = 0;
            this.btn_AddKeyWord.Text = "Add";
            this.btn_AddKeyWord.UseVisualStyleBackColor = true;
            this.btn_AddKeyWord.Click += new System.EventHandler(this.btn_AddKeyWord_Click);
            // 
            // tBox_AddKeword
            // 
            this.tBox_AddKeword.Location = new System.Drawing.Point(6, 35);
            this.tBox_AddKeword.Name = "tBox_AddKeword";
            this.tBox_AddKeword.Size = new System.Drawing.Size(100, 20);
            this.tBox_AddKeword.TabIndex = 1;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(6, 113);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(179, 290);
            this.listBox4.TabIndex = 2;
            // 
            // lbl_mergedCount
            // 
            this.lbl_mergedCount.Location = new System.Drawing.Point(459, 361);
            this.lbl_mergedCount.Name = "lbl_mergedCount";
            this.lbl_mergedCount.Size = new System.Drawing.Size(100, 23);
            this.lbl_mergedCount.TabIndex = 12;
            this.lbl_mergedCount.Text = "MergedCount";
            this.lbl_mergedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_LoadJobDesc;
        private System.Windows.Forms.Button btn_LoadResume;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_JobCount;
        private System.Windows.Forms.Label lbl_ResCount;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.TextBox tBox_AddKeword;
        private System.Windows.Forms.Button btn_AddKeyWord;
        private System.Windows.Forms.Label lbl_mergedCount;
    }
}

