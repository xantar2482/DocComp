using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;



namespace DocComp
{
    public partial class MainForm : Form
    {
        List<string> resume;
        List<string> jobDescription;
        List<string> keywords;
        List<string> trash;
        List<string> results;
        //List<char> delim;

        char[] delim = { ' ', ',', '.', ':', ';', '-' };

        private bool resLoaded;
        private bool descLoaded;
        private bool ready;

        public MainForm()
        {
            InitializeComponent();
            InitTrash();
            keywords = new List<string>();
            jobDescription = new List<string>();
            resume = new List<string>();
            results = new List<string>();
            //delim = new List<char>();
            KeySearchNotReady();
            PopulateDelims();
            PopulateDelimBox();
        }

        private void PopulateResumeBox(string[] list)
        {
            lbl_ResCount.Text = list.Count().ToString();

            foreach (string s in list)
            {
                if (s != "")
                {
                    resume.Add(s);
                    listBox_Resume.Items.Add(s);
                }
            }
        }

        private void PopulateJobDescriptionBox(string[] list)
        {
            lbl_JobCount.Text = list.Count().ToString();

            foreach (string s in list)
            {
                if (s != "")
                {
                    jobDescription.Add(s);
                    listBox_Description.Items.Add(s);
                }
            }
        }

        private void Compare()
        {
            listBox_Results.Items.Clear();

            List<string> listCheck = resume.Intersect(jobDescription).ToList();
            List<string> listCheck2 = jobDescription.Intersect(resume).ToList();
            List<string> merged = listCheck.Concat(listCheck2).ToList();
            results = merged.Except(trash).ToList();

            lbl_mergedCount.Text = results.Count.ToString();

            foreach (string s in results)
            {
                listBox_Results.Items.Add(s);
            }

            if (resLoaded == true && descLoaded == true)
            {
                ready = true;
            }           
            
            if (ready == true)
            {
                KeySearchReady();
            }
        }

        private void FindKeywordResultsBoth()
        {
            listBox_KeyWordResults.Items.Clear();

            List<string> listCheck = keywords.Intersect(results).ToList();

            if (listCheck.Count == 0)
            {
                listBox_KeyWordResults.Items.Add("No Matching results");
            }
            else
            {
                PopulateKeywordResultsBox(listCheck);
            }
        }

        private void FindKeyWordsResultsResume()
        {
            listBox_KeyWordResults.Items.Clear();
            List<string> listCheck = keywords.Intersect(resume).ToList();

            if (listCheck.Count == 0)
            {
                listBox_KeyWordResults.Items.Add("No Matching results");
            }
            else
            {
                PopulateKeywordResultsBox(listCheck);
            }
        }

        private void PopulateKeywordResultsBox(List<string> list)
        {
            foreach (string s in list)
            {
                listBox_KeyWordResults.Items.Add(s);
            }
        }

        private void InitTrash()
        {
            trash = new List<string> { "the", "for", "a", "an", "from", "to", "of", "and", "in", "with", "their", "as", "will", "this", "on", "one" };
        }

        private void KeySearchReady()
        {
            gb_KeySearch.Enabled = true;
        }

        private void KeySearchNotReady()
        {
            gb_KeySearch.Enabled = false;
        }

        //  Deliminator Manipulations  //
        private void PopulateDelims()
        {
            char[] initDelim = {' ', ',', '.', ':', ';', '-'};
            //delim.AddRange(initDelim);
        }

        private void AddDelims(char addChar)
        {
            //delim.Add(addChar);
        }

        private void RemoveDelims(char removeChar)
        {
            //delim.Remove(removeChar);
        }

        private void PopulateDelimBox()
        {
            listBox_Delims.Items.Clear();
            
            foreach (char c in delim)
            {
                listBox_Delims.Items.Add(c);
            }
        }

        // Events //
        private void btn_LoadResume_Click(object sender, EventArgs e)
        {
            resume.Clear();
            listBox_Resume.Items.Clear();

            OpenFileDialog ofd = new OpenFileDialog()
            {
                RestoreDirectory = true,
                Filter = "Text Files|*.doc;*.docx;*.txt;*.text",
                FilterIndex = 2                
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                     
                string filename = ofd.FileName;
                
                Document doc = app.Documents.Open(filename);                
                string[] parsed = doc.Content.Text.Split(delim).ToArray();
              
                PopulateResumeBox(parsed);
                app.Quit();
                ofd.Dispose();

                resLoaded = true;
            }
        }

        private void btn_LoadJobDesc_Click(object sender, EventArgs e)
        {
            jobDescription.Clear();
            listBox_Description.Items.Clear();            

            OpenFileDialog ofd = new OpenFileDialog()

            {
                RestoreDirectory = true,
                Filter = "Text Files|*.doc;*.docx;*.txt;*.text",
                FilterIndex = 2                
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                                
                string filename = ofd.FileName;

                Document doc = app.Documents.Open(filename);
                string[] parsed = doc.Content.Text.Split(delim).ToArray();               

                PopulateJobDescriptionBox(parsed);
                app.Quit();
                ofd.Dispose();

                descLoaded = true;
            }
        }        

        private void btn_Compare_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void btn_AddKeyWord_Click(object sender, EventArgs e)
        {
            string temp = tBox_AddKeword.Text.ToString();
            keywords.Add(temp);
            listBox_KeyWordList.Items.Add(temp);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btn_FindKeyWords_Click(object sender, EventArgs e)
        {
            if (rb_FindInRes.Checked == true)
            {
                FindKeyWordsResultsResume();
            }
            if (rb_FindInBoth.Checked == true)
            {
                FindKeywordResultsBoth();
            }         
        }

        private void btn_ClearKWBox_Click(object sender, EventArgs e)
        {
            listBox_KeyWordList.Items.Clear();
            listBox_KeyWordResults.Items.Clear();
        }

        private void btn_RemoveItem_Click(object sender, EventArgs e)
        {
            keywords.Remove(listBox_KeyWordList.SelectedItems.ToString());
            listBox_KeyWordList.Items.Remove(listBox_KeyWordList.SelectedItems);
            
        }

        private void btn_AddDelims_Click(object sender, EventArgs e)
        {
            char[] temp = richTextBox1.Text.ToCharArray();
            //char[] temp = tb_Delims.Text.ToCharArray();
            

        }


    }
}

