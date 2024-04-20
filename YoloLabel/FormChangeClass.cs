using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;

namespace YoloLabel
{
    public partial class FormChangeClass : Form
    {
        public FormChangeClass()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormChangeClass_Load(object sender, EventArgs e)
        {
            txt_labelDir.Text = TGMTregistry.GetInstance().ReadString("txt_labelDir");
            numOldClass.Value = TGMTregistry.GetInstance().ReadInt("numOldClass", 0);
            numNewClass.Value = TGMTregistry.GetInstance().ReadInt("numNewClass", 0);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_run_Click(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("numOldClass", (int)numOldClass.Value);
            TGMTregistry.GetInstance().SaveValue("numNewClass", (int)numNewClass.Value);

            backgroundWorker1.RunWorkerAsync();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string labelDir = TGMTutil.CorrectPath(txt_labelDir.Text);

            var allowedExtensions = new[] { ".txt"};
            var fileList = Directory.GetFiles(labelDir)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();

            string oldClass = numOldClass.Value.ToString();
            string newClass = numNewClass.Value.ToString();

            int numObjectChanged = 0;

            foreach (string txtPath in fileList)
            {
                List<string> newLines = new List<string>();
                string[] lines = File.ReadAllLines(txtPath);
                foreach (string line in lines)
                {
                    string[] lineSplit = line.Split(' ');
                    //add rect to lsrect
                    if (lineSplit.Length != 5)
                        continue;


                    string classID = lineSplit[0];
                    if (classID == oldClass)
                    {
                        string newLine = newClass + " " + lineSplit[1] + " " + lineSplit[2] + " " + lineSplit[3] + " " + lineSplit[4];
                        newLines.Add(newLine);                                       
                    }
                    else
                    {
                        newLines.Add(line);
                        numObjectChanged += 1;
                    }  
                }
                if(newLines.Count > 0)
                {
                    File.WriteAllLines(txtPath, newLines);
                }
                
                backgroundWorker1.ReportProgress(0);
                
            }
            e.Result = "Change " + numObjectChanged.ToString() + " objects";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (progressBar1.Value >= progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
            progressBar1.Value += 1;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            MessageBox.Show(e.Result.ToString(), "Change success");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_labelDir_TextChanged(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("txt_labelDir", txt_labelDir.Text);
        }
    }
}
