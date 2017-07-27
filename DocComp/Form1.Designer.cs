namespace DocComp
{
    partial class MainForm
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
            this.gb_ListShow = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox_KeyWordResults = new System.Windows.Forms.ListBox();
            this.gb_Res = new System.Windows.Forms.GroupBox();
            this.listBox_Resume = new System.Windows.Forms.ListBox();
            this.btn_LoadResume = new System.Windows.Forms.Button();
            this.gb_JD = new System.Windows.Forms.GroupBox();
            this.listBox_Description = new System.Windows.Forms.ListBox();
            this.btn_LoadJobDesc = new System.Windows.Forms.Button();
            this.gb_Results = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_Results = new System.Windows.Forms.ListBox();
            this.gb_Stats = new System.Windows.Forms.GroupBox();
            this.lbl_mergedCount = new System.Windows.Forms.Label();
            this.btn_Compare = new System.Windows.Forms.Button();
            this.lbl_JobCount = new System.Windows.Forms.Label();
            this.lbl_ResCount = new System.Windows.Forms.Label();
            this.gb_Delims = new System.Windows.Forms.GroupBox();
            this.btn_RemoveDelims = new System.Windows.Forms.Button();
            this.listBox_Delims = new System.Windows.Forms.ListBox();
            this.btn_AddDelims = new System.Windows.Forms.Button();
            this.tb_Delims = new System.Windows.Forms.TextBox();
            this.btn_FindKeyWords = new System.Windows.Forms.Button();
            this.gb_KeySearch = new System.Windows.Forms.GroupBox();
            this.btn_RemoveItem = new System.Windows.Forms.Button();
            this.btn_ClearKWBox = new System.Windows.Forms.Button();
            this.rb_FindInBoth = new System.Windows.Forms.RadioButton();
            this.rb_FindInRes = new System.Windows.Forms.RadioButton();
            this.listBox_KeyWordList = new System.Windows.Forms.ListBox();
            this.tBox_AddKeword = new System.Windows.Forms.TextBox();
            this.btn_AddKeyWord = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gb_ListShow.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gb_Res.SuspendLayout();
            this.gb_JD.SuspendLayout();
            this.gb_Results.SuspendLayout();
            this.gb_Stats.SuspendLayout();
            this.gb_Delims.SuspendLayout();
            this.gb_KeySearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            // gb_ListShow
            // 
            this.gb_ListShow.Controls.Add(this.groupBox4);
            this.gb_ListShow.Controls.Add(this.gb_Res);
            this.gb_ListShow.Controls.Add(this.gb_JD);
            this.gb_ListShow.Controls.Add(this.gb_Results);
            this.gb_ListShow.Controls.Add(this.gb_Stats);
            this.gb_ListShow.Location = new System.Drawing.Point(365, 61);
            this.gb_ListShow.Margin = new System.Windows.Forms.Padding(6);
            this.gb_ListShow.Name = "gb_ListShow";
            this.gb_ListShow.Padding = new System.Windows.Forms.Padding(6);
            this.gb_ListShow.Size = new System.Drawing.Size(1540, 912);
            this.gb_ListShow.TabIndex = 5;
            this.gb_ListShow.TabStop = false;
            this.gb_ListShow.Text = "Comparator";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.listBox_KeyWordResults);
            this.groupBox4.Location = new System.Drawing.Point(772, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 330);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Key Word Results";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(93, 529);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(138, 42);
            this.button4.TabIndex = 9;
            this.button4.Text = "Compare";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // listBox_KeyWordResults
            // 
            this.listBox_KeyWordResults.FormattingEnabled = true;
            this.listBox_KeyWordResults.ItemHeight = 24;
            this.listBox_KeyWordResults.Location = new System.Drawing.Point(12, 28);
            this.listBox_KeyWordResults.Name = "listBox_KeyWordResults";
            this.listBox_KeyWordResults.Size = new System.Drawing.Size(312, 292);
            this.listBox_KeyWordResults.TabIndex = 13;
            // 
            // gb_Res
            // 
            this.gb_Res.Controls.Add(this.listBox_Resume);
            this.gb_Res.Controls.Add(this.btn_LoadResume);
            this.gb_Res.Location = new System.Drawing.Point(100, 44);
            this.gb_Res.Name = "gb_Res";
            this.gb_Res.Size = new System.Drawing.Size(330, 666);
            this.gb_Res.TabIndex = 17;
            this.gb_Res.TabStop = false;
            this.gb_Res.Text = "Resume";
            // 
            // listBox_Resume
            // 
            this.listBox_Resume.FormattingEnabled = true;
            this.listBox_Resume.ItemHeight = 24;
            this.listBox_Resume.Location = new System.Drawing.Point(9, 31);
            this.listBox_Resume.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_Resume.Name = "listBox_Resume";
            this.listBox_Resume.Size = new System.Drawing.Size(312, 508);
            this.listBox_Resume.TabIndex = 9;
            // 
            // btn_LoadResume
            // 
            this.btn_LoadResume.Location = new System.Drawing.Point(96, 588);
            this.btn_LoadResume.Margin = new System.Windows.Forms.Padding(6);
            this.btn_LoadResume.Name = "btn_LoadResume";
            this.btn_LoadResume.Size = new System.Drawing.Size(138, 42);
            this.btn_LoadResume.TabIndex = 7;
            this.btn_LoadResume.Text = "Load";
            this.btn_LoadResume.UseVisualStyleBackColor = true;
            this.btn_LoadResume.Click += new System.EventHandler(this.btn_LoadResume_Click);
            // 
            // gb_JD
            // 
            this.gb_JD.Controls.Add(this.listBox_Description);
            this.gb_JD.Controls.Add(this.btn_LoadJobDesc);
            this.gb_JD.Location = new System.Drawing.Point(436, 44);
            this.gb_JD.Name = "gb_JD";
            this.gb_JD.Size = new System.Drawing.Size(330, 666);
            this.gb_JD.TabIndex = 17;
            this.gb_JD.TabStop = false;
            this.gb_JD.Text = "Job Description";
            // 
            // listBox_Description
            // 
            this.listBox_Description.FormattingEnabled = true;
            this.listBox_Description.ItemHeight = 24;
            this.listBox_Description.Location = new System.Drawing.Point(9, 31);
            this.listBox_Description.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_Description.Name = "listBox_Description";
            this.listBox_Description.Size = new System.Drawing.Size(312, 508);
            this.listBox_Description.TabIndex = 10;
            // 
            // btn_LoadJobDesc
            // 
            this.btn_LoadJobDesc.Location = new System.Drawing.Point(95, 588);
            this.btn_LoadJobDesc.Margin = new System.Windows.Forms.Padding(6);
            this.btn_LoadJobDesc.Name = "btn_LoadJobDesc";
            this.btn_LoadJobDesc.Size = new System.Drawing.Size(138, 42);
            this.btn_LoadJobDesc.TabIndex = 8;
            this.btn_LoadJobDesc.Text = "Load";
            this.btn_LoadJobDesc.UseVisualStyleBackColor = true;
            this.btn_LoadJobDesc.Click += new System.EventHandler(this.btn_LoadJobDesc_Click);
            // 
            // gb_Results
            // 
            this.gb_Results.Controls.Add(this.button1);
            this.gb_Results.Controls.Add(this.listBox_Results);
            this.gb_Results.Location = new System.Drawing.Point(772, 44);
            this.gb_Results.Name = "gb_Results";
            this.gb_Results.Size = new System.Drawing.Size(330, 330);
            this.gb_Results.TabIndex = 16;
            this.gb_Results.TabStop = false;
            this.gb_Results.Text = "Common Words";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Compare";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox_Results
            // 
            this.listBox_Results.FormattingEnabled = true;
            this.listBox_Results.ItemHeight = 24;
            this.listBox_Results.Location = new System.Drawing.Point(9, 31);
            this.listBox_Results.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_Results.Name = "listBox_Results";
            this.listBox_Results.Size = new System.Drawing.Size(312, 292);
            this.listBox_Results.TabIndex = 11;
            // 
            // gb_Stats
            // 
            this.gb_Stats.Controls.Add(this.lbl_mergedCount);
            this.gb_Stats.Controls.Add(this.btn_Compare);
            this.gb_Stats.Controls.Add(this.lbl_JobCount);
            this.gb_Stats.Controls.Add(this.lbl_ResCount);
            this.gb_Stats.Location = new System.Drawing.Point(1108, 44);
            this.gb_Stats.Name = "gb_Stats";
            this.gb_Stats.Size = new System.Drawing.Size(330, 666);
            this.gb_Stats.TabIndex = 15;
            this.gb_Stats.TabStop = false;
            this.gb_Stats.Text = "Stats";
            // 
            // lbl_mergedCount
            // 
            this.lbl_mergedCount.Location = new System.Drawing.Point(75, 273);
            this.lbl_mergedCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_mergedCount.Name = "lbl_mergedCount";
            this.lbl_mergedCount.Size = new System.Drawing.Size(183, 42);
            this.lbl_mergedCount.TabIndex = 12;
            this.lbl_mergedCount.Text = "MergedCount";
            this.lbl_mergedCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Compare
            // 
            this.btn_Compare.Location = new System.Drawing.Point(93, 529);
            this.btn_Compare.Margin = new System.Windows.Forms.Padding(6);
            this.btn_Compare.Name = "btn_Compare";
            this.btn_Compare.Size = new System.Drawing.Size(138, 42);
            this.btn_Compare.TabIndex = 9;
            this.btn_Compare.Text = "Compare";
            this.btn_Compare.UseVisualStyleBackColor = true;
            this.btn_Compare.Click += new System.EventHandler(this.btn_Compare_Click);
            // 
            // lbl_JobCount
            // 
            this.lbl_JobCount.AutoSize = true;
            this.lbl_JobCount.Location = new System.Drawing.Point(50, 248);
            this.lbl_JobCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_JobCount.Name = "lbl_JobCount";
            this.lbl_JobCount.Size = new System.Drawing.Size(220, 25);
            this.lbl_JobCount.TabIndex = 11;
            this.lbl_JobCount.Text = "Description Word Count";
            // 
            // lbl_ResCount
            // 
            this.lbl_ResCount.AutoSize = true;
            this.lbl_ResCount.Location = new System.Drawing.Point(75, 219);
            this.lbl_ResCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_ResCount.Name = "lbl_ResCount";
            this.lbl_ResCount.Size = new System.Drawing.Size(195, 25);
            this.lbl_ResCount.TabIndex = 10;
            this.lbl_ResCount.Text = "Resume Word Count";
            // 
            // gb_Delims
            // 
            this.gb_Delims.Controls.Add(this.richTextBox1);
            this.gb_Delims.Controls.Add(this.btn_RemoveDelims);
            this.gb_Delims.Controls.Add(this.listBox_Delims);
            this.gb_Delims.Controls.Add(this.btn_AddDelims);
            this.gb_Delims.Location = new System.Drawing.Point(4, 619);
            this.gb_Delims.Margin = new System.Windows.Forms.Padding(6);
            this.gb_Delims.Name = "gb_Delims";
            this.gb_Delims.Padding = new System.Windows.Forms.Padding(6);
            this.gb_Delims.Size = new System.Drawing.Size(350, 354);
            this.gb_Delims.TabIndex = 10;
            this.gb_Delims.TabStop = false;
            this.gb_Delims.Text = "Delimiters";
            // 
            // btn_RemoveDelims
            // 
            this.btn_RemoveDelims.Location = new System.Drawing.Point(12, 300);
            this.btn_RemoveDelims.Margin = new System.Windows.Forms.Padding(6);
            this.btn_RemoveDelims.Name = "btn_RemoveDelims";
            this.btn_RemoveDelims.Size = new System.Drawing.Size(326, 42);
            this.btn_RemoveDelims.TabIndex = 18;
            this.btn_RemoveDelims.Text = "Remove Item";
            this.btn_RemoveDelims.UseVisualStyleBackColor = true;
            // 
            // listBox_Delims
            // 
            this.listBox_Delims.FormattingEnabled = true;
            this.listBox_Delims.ItemHeight = 24;
            this.listBox_Delims.Location = new System.Drawing.Point(12, 94);
            this.listBox_Delims.Name = "listBox_Delims";
            this.listBox_Delims.Size = new System.Drawing.Size(326, 196);
            this.listBox_Delims.TabIndex = 0;
            // 
            // btn_AddDelims
            // 
            this.btn_AddDelims.Location = new System.Drawing.Point(195, 32);
            this.btn_AddDelims.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AddDelims.Name = "btn_AddDelims";
            this.btn_AddDelims.Size = new System.Drawing.Size(143, 42);
            this.btn_AddDelims.TabIndex = 18;
            this.btn_AddDelims.Text = "Add";
            this.btn_AddDelims.UseVisualStyleBackColor = true;
            this.btn_AddDelims.Click += new System.EventHandler(this.btn_AddDelims_Click);
            // 
            // tb_Delims
            // 
            this.tb_Delims.Location = new System.Drawing.Point(506, 1035);
            this.tb_Delims.Margin = new System.Windows.Forms.Padding(6);
            this.tb_Delims.Name = "tb_Delims";
            this.tb_Delims.Size = new System.Drawing.Size(169, 29);
            this.tb_Delims.TabIndex = 19;
            // 
            // btn_FindKeyWords
            // 
            this.btn_FindKeyWords.Location = new System.Drawing.Point(11, 220);
            this.btn_FindKeyWords.Margin = new System.Windows.Forms.Padding(6);
            this.btn_FindKeyWords.Name = "btn_FindKeyWords";
            this.btn_FindKeyWords.Size = new System.Drawing.Size(327, 42);
            this.btn_FindKeyWords.TabIndex = 12;
            this.btn_FindKeyWords.Text = "Find Key Words";
            this.btn_FindKeyWords.UseVisualStyleBackColor = true;
            this.btn_FindKeyWords.Click += new System.EventHandler(this.btn_FindKeyWords_Click);
            // 
            // gb_KeySearch
            // 
            this.gb_KeySearch.Controls.Add(this.btn_RemoveItem);
            this.gb_KeySearch.Controls.Add(this.btn_ClearKWBox);
            this.gb_KeySearch.Controls.Add(this.rb_FindInBoth);
            this.gb_KeySearch.Controls.Add(this.rb_FindInRes);
            this.gb_KeySearch.Controls.Add(this.listBox_KeyWordList);
            this.gb_KeySearch.Controls.Add(this.btn_FindKeyWords);
            this.gb_KeySearch.Controls.Add(this.tBox_AddKeword);
            this.gb_KeySearch.Controls.Add(this.btn_AddKeyWord);
            this.gb_KeySearch.Location = new System.Drawing.Point(4, 61);
            this.gb_KeySearch.Margin = new System.Windows.Forms.Padding(6);
            this.gb_KeySearch.Name = "gb_KeySearch";
            this.gb_KeySearch.Padding = new System.Windows.Forms.Padding(6);
            this.gb_KeySearch.Size = new System.Drawing.Size(350, 541);
            this.gb_KeySearch.TabIndex = 11;
            this.gb_KeySearch.TabStop = false;
            this.gb_KeySearch.Text = "Key Words";
            // 
            // btn_RemoveItem
            // 
            this.btn_RemoveItem.Location = new System.Drawing.Point(176, 482);
            this.btn_RemoveItem.Margin = new System.Windows.Forms.Padding(6);
            this.btn_RemoveItem.Name = "btn_RemoveItem";
            this.btn_RemoveItem.Size = new System.Drawing.Size(162, 42);
            this.btn_RemoveItem.TabIndex = 17;
            this.btn_RemoveItem.Text = "Remove Item";
            this.btn_RemoveItem.UseVisualStyleBackColor = true;
            this.btn_RemoveItem.Click += new System.EventHandler(this.btn_RemoveItem_Click);
            // 
            // btn_ClearKWBox
            // 
            this.btn_ClearKWBox.Location = new System.Drawing.Point(11, 482);
            this.btn_ClearKWBox.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ClearKWBox.Name = "btn_ClearKWBox";
            this.btn_ClearKWBox.Size = new System.Drawing.Size(160, 42);
            this.btn_ClearKWBox.TabIndex = 16;
            this.btn_ClearKWBox.Text = "Clear List";
            this.btn_ClearKWBox.UseVisualStyleBackColor = true;
            this.btn_ClearKWBox.Click += new System.EventHandler(this.btn_ClearKWBox_Click);
            // 
            // rb_FindInBoth
            // 
            this.rb_FindInBoth.AutoSize = true;
            this.rb_FindInBoth.Location = new System.Drawing.Point(79, 97);
            this.rb_FindInBoth.Name = "rb_FindInBoth";
            this.rb_FindInBoth.Size = new System.Drawing.Size(145, 29);
            this.rb_FindInBoth.TabIndex = 15;
            this.rb_FindInBoth.TabStop = true;
            this.rb_FindInBoth.Text = "Search Both";
            this.rb_FindInBoth.UseVisualStyleBackColor = true;
            // 
            // rb_FindInRes
            // 
            this.rb_FindInRes.AutoSize = true;
            this.rb_FindInRes.Location = new System.Drawing.Point(79, 62);
            this.rb_FindInRes.Name = "rb_FindInRes";
            this.rb_FindInRes.Size = new System.Drawing.Size(177, 29);
            this.rb_FindInRes.TabIndex = 14;
            this.rb_FindInRes.TabStop = true;
            this.rb_FindInRes.Text = "Search Resume";
            this.rb_FindInRes.UseVisualStyleBackColor = true;
            // 
            // listBox_KeyWordList
            // 
            this.listBox_KeyWordList.FormattingEnabled = true;
            this.listBox_KeyWordList.ItemHeight = 24;
            this.listBox_KeyWordList.Location = new System.Drawing.Point(11, 274);
            this.listBox_KeyWordList.Margin = new System.Windows.Forms.Padding(6);
            this.listBox_KeyWordList.Name = "listBox_KeyWordList";
            this.listBox_KeyWordList.Size = new System.Drawing.Size(327, 196);
            this.listBox_KeyWordList.TabIndex = 2;
            // 
            // tBox_AddKeword
            // 
            this.tBox_AddKeword.Location = new System.Drawing.Point(12, 172);
            this.tBox_AddKeword.Margin = new System.Windows.Forms.Padding(6);
            this.tBox_AddKeword.Name = "tBox_AddKeword";
            this.tBox_AddKeword.Size = new System.Drawing.Size(169, 29);
            this.tBox_AddKeword.TabIndex = 1;
            // 
            // btn_AddKeyWord
            // 
            this.btn_AddKeyWord.Location = new System.Drawing.Point(193, 166);
            this.btn_AddKeyWord.Margin = new System.Windows.Forms.Padding(6);
            this.btn_AddKeyWord.Name = "btn_AddKeyWord";
            this.btn_AddKeyWord.Size = new System.Drawing.Size(145, 42);
            this.btn_AddKeyWord.TabIndex = 0;
            this.btn_AddKeyWord.Text = "Add";
            this.btn_AddKeyWord.UseVisualStyleBackColor = true;
            this.btn_AddKeyWord.Click += new System.EventHandler(this.btn_AddKeyWord_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2276, 38);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(101, 34);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 32);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(169, 42);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2276, 1254);
            this.Controls.Add(this.gb_KeySearch);
            this.Controls.Add(this.gb_Delims);
            this.Controls.Add(this.gb_ListShow);
            this.Controls.Add(this.tb_Delims);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Doc Parser";
            this.gb_ListShow.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.gb_Res.ResumeLayout(false);
            this.gb_JD.ResumeLayout(false);
            this.gb_Results.ResumeLayout(false);
            this.gb_Stats.ResumeLayout(false);
            this.gb_Stats.PerformLayout();
            this.gb_Delims.ResumeLayout(false);
            this.gb_KeySearch.ResumeLayout(false);
            this.gb_KeySearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.GroupBox gb_ListShow;
        private System.Windows.Forms.Button btn_LoadJobDesc;
        private System.Windows.Forms.Button btn_LoadResume;
        private System.Windows.Forms.Button btn_Compare;
        private System.Windows.Forms.GroupBox gb_Delims;
        private System.Windows.Forms.ListBox listBox_Description;
        private System.Windows.Forms.ListBox listBox_Resume;
        private System.Windows.Forms.Label lbl_JobCount;
        private System.Windows.Forms.Label lbl_ResCount;
        private System.Windows.Forms.ListBox listBox_Results;
        private System.Windows.Forms.GroupBox gb_KeySearch;
        private System.Windows.Forms.ListBox listBox_KeyWordList;
        private System.Windows.Forms.TextBox tBox_AddKeword;
        private System.Windows.Forms.Button btn_AddKeyWord;
        private System.Windows.Forms.Label lbl_mergedCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.Button btn_FindKeyWords;
        private System.Windows.Forms.ListBox listBox_KeyWordResults;
        private System.Windows.Forms.RadioButton rb_FindInBoth;
        private System.Windows.Forms.RadioButton rb_FindInRes;
        private System.Windows.Forms.Button btn_ClearKWBox;
        private System.Windows.Forms.Button btn_RemoveItem;
        private System.Windows.Forms.Button btn_RemoveDelims;
        private System.Windows.Forms.TextBox tb_Delims;
        private System.Windows.Forms.ListBox listBox_Delims;
        private System.Windows.Forms.Button btn_AddDelims;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox gb_Res;
        private System.Windows.Forms.GroupBox gb_JD;
        private System.Windows.Forms.GroupBox gb_Results;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_Stats;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

