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
        string[] resume;
        string[] jobDescription;
        string[] keywords;


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

                char[] delim = { '\r','|',' ', ',', '.', ':', ';', '-' };
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

                char[] delim = { ' ', ',', '.', ':', ';', '-' };
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
                listBox1.Items.Add(s);
            }
        }

        private void populateJobDescriptionBox(string[] list)
        {
            lbl_JobCount.Text = list.Count().ToString();

            foreach (string s in list)
            {
                listBox2.Items.Add(s);
            }
        }

        private void compare(string[] list, string[] list2)
        {

        }

    }
}

