using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace DocComp
{
    public partial class Form1 : Form
    {
        List<string> resume = new List<string>();
        List<string> jobDescription = new List<string>();
        string[] keywords;
        char[] delim = { ' ', ',', '.', ':', ';', '-'};
        List<string> trash = new List<string>{"the", "for", "a", "an", "from", "to", "of", "and", "in", "with"};


        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_LoadResume_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                InitialDirectory = "e:\\",
                Filter = "Text Files|*.doc;*.docx;*.txt;*.text",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                     
                string filename = ofd.FileName;
                
                Document doc = app.Documents.Open(filename);

                string[] parsed = doc.Content.Text.Split(delim).ToArray();
              
                populateResumeBox(parsed);
                app.Quit();
                ofd.Dispose();
            }
        }

        private void btn_LoadJobDesc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()

            {
                InitialDirectory = "e:\\",
                Filter = "Text Files|*.doc;*.docx;*.txt;*.text",
                FilterIndex = 2,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                                
                string filename = ofd.FileName;

                Document doc = app.Documents.Open(filename);

                string[] parsed = doc.Content.Text.Split(delim).ToArray();               

                populateJobDescriptionBox(parsed);
                app.Quit();
                ofd.Dispose();
            }
        }

        private void populateResumeBox(string[] list)
        {
            lbl_ResCount.Text = list.Count().ToString();

            foreach (string s in list)
            {
                if (s != "")
                {
                    resume.Add(s);
                    listBox1.Items.Add(s);
                }
            }     
        }

        private void populateJobDescriptionBox(string[] list)
        {
            lbl_JobCount.Text = list.Count().ToString();

            foreach (string s in list)
            {
                if (s != "")
                {
                    jobDescription.Add(s);
                    listBox2.Items.Add(s);
                }
            }
        }

        private void compare()
        {
            List<string> listCheck = resume.Intersect(jobDescription).ToList();
            List<string> listCheck2= jobDescription.Intersect(resume).ToList();
            List<string> merged = listCheck.Concat(listCheck2).ToList();
            List<string> merged2 = merged.Except(trash).ToList();

            foreach (string s in merged2)
            {
                listBox3.Items.Add(s);
            }
        }

        private void btn_Compare_Click(object sender, EventArgs e)
        {
            compare();
        }
    }
}

