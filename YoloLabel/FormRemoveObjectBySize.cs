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
    public partial class FormRemoveObjectBySize : Form
    {
        public FormRemoveObjectBySize()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormRemoveObjectBySize_Load(object sender, EventArgs e)
        {
            numMinWidth.Value = TGMTregistry.GetInstance().ReadInt("numMinWidth", 20);
            numMinHeight.Value = TGMTregistry.GetInstance().ReadInt("numMinHeight", 20);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_run_Click(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("numMinWidth", (int)numMinWidth.Value);
            TGMTregistry.GetInstance().SaveValue("numMinHeight", (int)numMinHeight.Value);

            backgroundWorker1.RunWorkerAsync();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //string imageDir = TGMTutil.CorrectPath(FormMain_old.GetInstance().txtFolderImage.Text);
            //string labelDir = TGMTutil.CorrectPath(FormMain_old.GetInstance().txtFolderLabel.Text);

            //var allowedExtensions = new[] { ".jpg", ".png", ".bmp", ".JPG", ".PNG", ".BMP" };
            //var fileList = Directory.GetFiles(imageDir)
            //    .Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();

            //int minWidth = (int)numMinWidth.Value;
            //int minHeight = (int)numMinHeight.Value;

            //int numObjectRemoved = 0;

            //foreach (string filePath in fileList)
            //{
            //    string fileName = Path.GetFileName(filePath);
            //    string txtPath = labelDir + Path.GetFileNameWithoutExtension(filePath) + ".txt";

            //    if (!File.Exists(txtPath))
            //        continue;

            //    Bitmap bmp = TGMTimage.LoadBitmapWithoutLock(filePath);

            //    List<string> validLines = new List<string>();
            //    string[] lines = File.ReadAllLines(txtPath);
            //    foreach (string line in lines)
            //    {
            //        string[] lineSplit = line.Split(' ');
            //        //add rect to lsrect
            //        if (lineSplit.Length != 5)
            //            continue;


            //        int classID = int.Parse(lineSplit[0]);

            //        double cx = double.Parse(lineSplit[1]);
            //        double cy = double.Parse(lineSplit[2]);
            //        double w = double.Parse(lineSplit[3]);
            //        double h = double.Parse(lineSplit[4]);
            //        double x = cx - w / 2;
            //        double y = cy - h / 2;

            //        Rectangle rect = new Rectangle(
            //            (int)(x * bmp.Width),
            //            (int)(y * bmp.Height),
            //            (int)(w * bmp.Width),
            //            (int)(h * bmp.Height));

            //        if(rect.Width > minWidth && rect.Height > minHeight)
            //        {
            //            validLines.Add(line);
            //        }
            //        else
            //        {
            //            numObjectRemoved += 1;
            //        }
            //    }
            //    File.WriteAllLines(txtPath, validLines);
            //    backgroundWorker1.ReportProgress(0);
                
            //}
            //e.Result = "Removed " + numObjectRemoved.ToString() + " rects";
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
            MessageBox.Show(e.Result.ToString(), "Remove success");
        }
    }
}
