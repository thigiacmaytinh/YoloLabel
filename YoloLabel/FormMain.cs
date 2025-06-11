using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGMTcs;

namespace YoloLabel
{
    public partial class FormMain : Form
    {
        string m_imageDir = "";
        string m_labelDir = "";
        string m_classFile = "";
        string mCurrentImgName = "";

        double m_scaleX = 0;
        double m_scaleY = 0;
        double m_aspect = 0;


        List<Rectangle> mRects = new List<Rectangle>();
        Size MAX_PICTURE_BOX_SIZE = new Size(800, 600);

        Image m_img;

        public enum Colision
        {
            None,
            NewRect,
            All,
            Top,
            Right,
            Bottom,
            Left,
            TopLeft,
            TopRight,
            BotLeft,
            BotRight
        }
        Colision g_colisionState = Colision.None;


        int ANCHOR_WIDTH = 6;
        Size ANCHOR_SIZE;
        Size mDistanceCurrentRectToMouse;
        Point mCurrentRectBottomRight;

        //public string textFilePath;
        Point m_currentPoint;
        Point m_startPoint;
        bool g_isMouseDown = false;


        int newRectIdx = -1;


        int mTotalRects = 0;
        bool m_isFirstLoading = true;

        //use for draw on picture box



        Font myFont;
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Blue);

        string[] m_classes;
        string m_saveDir = "";
        int m_lastSearchIndex = 0;
        string m_lastSearch = "";

        bool m_isTextboxFocused = false;

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public FormMain()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ANCHOR_SIZE = new Size(ANCHOR_WIDTH, ANCHOR_WIDTH);

            LoadOption();

            txt_classFile.Text = TGMTregistry.GetInstance().ReadString("txt_classFile");
            txt_imageDir.Text = TGMTutil.CorrectPath(TGMTregistry.GetInstance().ReadString("txt_imageDir"));
            txt_labelDir.Text = TGMTutil.CorrectPath(TGMTregistry.GetInstance().ReadString("txt_labelDir"));
            


            this.KeyPreview = true;
            this.Text += " " + TGMTutil.GetVersion();

#if DEBUG
            this.Text += " (Debug)";
#endif


            LoadRecentDir();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveToFile();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                if(lstRect.Items.Count > 0)
                    lstRect.SelectedIndex = 0;
                if(lstImg.Items.Count > 0)
                    lstImg.EnsureVisible(0);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (m_isTextboxFocused)
                return;


            if (e.Control && e.KeyCode == Keys.S)
            {
                SaveToFile();
            }
            else if (e.KeyCode == Keys.Space)
            {
                if (lstRect.Items.Count >= 1)
                {
                    lstRect.SelectedIndex = 0;
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (lstRect.SelectedIndex > -1)
                {
                    lstRect_KeyDown(sender, e);
                    return;
                }
            }
            else if ((e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9))
            {
                if (lstRect.SelectedIndex > -1)
                {
                    int newClass = (int)e.KeyCode - 48;
                    if (newClass < cb_classes.Items.Count && newClass != cb_classes.SelectedIndex)
                    {
                        cb_classes.SelectedIndex = newClass;
                    }
                }
            }
            else if ((e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            {
                if (lstRect.SelectedIndex > -1)
                {
                    int newClass = (int)e.KeyCode - 96;
                    if (newClass < cb_classes.Items.Count)
                    {
                        cb_classes.SelectedIndex = newClass;
                    }
                }
            }
            else if (e.KeyCode == Keys.A)
            {
                if (lstImg.SelectedIndices.Count > 0)
                {
                    int currentIdx = lstImg.SelectedIndices[0];
                    if (currentIdx > 0)
                    {

                        lstImg.Items[currentIdx - 1].Selected = true;
                        lstImg.EnsureVisible(currentIdx - 1);
                    }
                }
            }
            else if (e.KeyCode == Keys.D)
            {
                if (lstImg.SelectedIndices.Count > 0)
                {
                    int currentIdx = lstImg.SelectedIndices[0];
                    if (currentIdx < lstImg.Items.Count - 1)
                    {

                        lstImg.Items[currentIdx + 1].Selected = true;
                        lstImg.EnsureVisible(currentIdx + 1);
                    }
                }
            }
            else if (e.KeyCode == Keys.Q)
            {
                GotoLastNotAnnotated();
            }
            else if (e.KeyCode == Keys.E)
            {
                GotoNextNotAnnotated();
            }
            else if (e.KeyCode == Keys.F)
            {
                if (e.Control)
                {
                    SearchFile();
                }
            }
            else if (lstRect.SelectedIndex > -1)
            {
                if (e.KeyCode == Keys.Up)
                {
                    if (e.Control) ResizeRect(0, -2); else MoveRect(0, -2);
                }
                else if (e.KeyCode == Keys.Down)
                {
                    if (e.Control) ResizeRect(0, 2); else MoveRect(0, 2);
                }
                else if (e.KeyCode == Keys.Left)
                {
                    if (e.Control) ResizeRect(-2, 0); else MoveRect(-2, 0);
                }
                else if (e.KeyCode == Keys.Right)
                {
                    if (e.Control) ResizeRect(2, 0); else MoveRect(2, 0);
                }
                else if (e.KeyCode == Keys.I)
                {
                    ResizeRect(0, -2);
                }
                else if (e.KeyCode == Keys.K)
                {
                    ResizeRect(0, 2);
                }
                else if (e.KeyCode == Keys.J)
                {
                    ResizeRect(-2, 0);
                }
                else if (e.KeyCode == Keys.L)
                {
                    ResizeRect(2, 0);
                }
            }
            else
            {
                e.Handled = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            double panelAspect = (double)panel4.Width / panel4.Height;

            //resize
            if (m_aspect > panelAspect)
            {
                pictureBox1.Width = panel4.Width;
                pictureBox1.Height = (int)(pictureBox1.Width / m_aspect);
            }
            else if (m_aspect < panelAspect)
            {
                pictureBox1.Height = panel4.Height;
                pictureBox1.Width = (int)(pictureBox1.Height * m_aspect);
            }

            mCurrentImgName = ""; //to repaint
            LoadRects();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_imageDir_TextChanged(object sender, EventArgs e)
        {
            if (txt_imageDir.Text == "")
                return;

            m_imageDir = TGMTutil.CorrectPath(txt_imageDir.Text);
            if(chk_sameDir.Checked)
            {
                txt_labelDir.Text = txt_imageDir.Text;
            }
            LoadImage();

            TGMTregistry.GetInstance().SaveValue("txt_imageDir", txt_imageDir.Text);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_labelDir_TextChanged(object sender, EventArgs e)
        {
            if (txt_labelDir.Text == "")
                return;

            m_labelDir = TGMTutil.CorrectPath(txt_labelDir.Text);
            LoadImage();

            TGMTregistry.GetInstance().SaveValue("txt_labelDir", txt_labelDir.Text);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_classFile_TextChanged(object sender, EventArgs e)
        {
            if (txt_classFile.Text == "")
                return;

            txt_classFile.Text = txt_classFile.Text.Replace("\"", "");

            m_classFile = txt_classFile.Text;
            LoadClasses();

            TGMTregistry.GetInstance().SaveValue("txt_classFile", txt_classFile.Text);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void chk_sameDir_CheckedChanged(object sender, EventArgs e)
        {
            txt_labelDir.Enabled = !chk_sameDir.Checked;

            if (chk_sameDir.Checked)
            {
                txt_labelDir.Text = txt_imageDir.Text;
            }

            TGMTregistry.GetInstance().SaveValue("chk_sameDir", chk_sameDir.Checked);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadRecentDir()
        {
            string recentDir = TGMTregistry.GetInstance().ReadString("recentDir");
            if (recentDir != "")
            {
                string[] recentDirs = recentDir.Split(';');

                if (recentDirs.Length > 0)
                {
                    
                }
            }
        }        

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadOption()
        {
            int fontsize = TGMTregistry.GetInstance().ReadInt("numFontSize", 14);
            myFont = new Font("Arial", fontsize);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadClasses()
        {
            cb_classes.Items.Clear();
            cb_classID.Items.Clear();

            string ext = Path.GetExtension(m_classFile);
            if (ext != ".names" && ext != ".txt")
                return;


            if (File.Exists(m_classFile))
            {
                m_classes = File.ReadAllLines(m_classFile);
                if (m_classes.Length == 0)
                {
                    PrintError("File classes is empty");
                    return;
                }
                for (int i = 0; i < m_classes.Length; i++)
                {
                    cb_classes.Items.Add(m_classes[i]);
                    cb_classID.Items.Add(i.ToString());
                }
            }
            else
            {
                m_classes = new string[]{ "person", "bicycle", "car", "motorcycle", "airplane", "bus", "train",
                    "truck", "boat", "traffic light", "fire hydrant", "stop sign", "parking meter", "bench", "bird",
                    "cat", "dog", "horse", "sheep", "cow", "elephant", "bear", "zebra", "giraffe", "backpack", "umbrella",
                    "handbag", "tie", "suitcase", "frisbee", "skis", "snowboard", "sports ball", "kite", "baseball bat",
                    "baseball glove", "skateboard", "surfboard", "tennis racket", "bottle", "wine glass", "cup", "fork",
                    "knife", "spoon", "bowl", "banana", "apple", "sandwich", "orange", "broccoli", "carrot", "hot dog",
                    "pizza", "donut", "cake", "chair", "couch", "potted plant", "bed", "dining table", "toilet", "tv",
                    "laptop", "mouse", "remote", "keyboard", "cell phone", "microwave", "oven", "toaster", "sink",
                    "refrigerator", "book", "clock", "vase", "scissors", "teddy bear", "hair drier", "toothbrush" };
                cb_classes.Items.AddRange(m_classes);

                for(int i=0; i<m_classes.Length; i++)
                {
                    cb_classID.Items.Add(i.ToString());
                }


                if(Directory.GetParent(m_classFile).Exists)
                {
                    File.WriteAllLines(m_classFile, m_classes);
                }
                
            }
            if(cb_classes.Items.Count > 0)
                cb_classes.SelectedIndex = 0;
        }

        
        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen blue_thick = new Pen(Color.Blue, 2);
            //draw new rect
            if (g_isMouseDown)
            {
                if (g_colisionState == Colision.None)
                {
                    int w = m_currentPoint.X - m_startPoint.X;
                    int h = m_currentPoint.Y - m_startPoint.Y;
                    if (w > 0 && h > 0)
                    {
                        e.Graphics.DrawRectangle(Pens.Blue, m_startPoint.X, m_startPoint.Y, w, h);
                    }
                }
            }
            else
            {
                e.Graphics.DrawLine(Pens.Black, new Point(0, m_currentPoint.Y), new Point(pictureBox1.Width - 1, m_currentPoint.Y));
                e.Graphics.DrawLine(Pens.Black, new Point(m_currentPoint.X, 0), new Point(m_currentPoint.X, pictureBox1.Height - 1));
            }


            int offset = ANCHOR_WIDTH / 2;
            for (int i = 0; i < lstRect.Items.Count; i++)
            {
                string elements = lstRect.Items[i].ToString();
                int spaceIdx = elements.IndexOf(" ");
                int classID = Convert.ToInt32(elements.Substring(0, spaceIdx));
                string className = "Unknown";
                if (classID < cb_classes.Items.Count)
                    className = cb_classes.Items[classID].ToString();

                Rectangle r = GetRect(i);
                if (i == lstRect.SelectedIndex)
                {

                    e.Graphics.DrawRectangle(Pens.Red, r);
                    //draw 8 anchor point


                    Rectangle topLeft = new Rectangle(r.Location - new Size(offset, offset), ANCHOR_SIZE);
                    Rectangle top = new Rectangle(r.Location + new Size(r.Width / 2 - offset, -offset), ANCHOR_SIZE);
                    Rectangle topRight = new Rectangle(r.Location + new Size(r.Width - offset, -offset), ANCHOR_SIZE);
                    Rectangle midRight = new Rectangle(r.Location + new Size(r.Width - offset, r.Height / 2 - offset), ANCHOR_SIZE);
                    Rectangle botRight = new Rectangle(r.Location + new Size(r.Width - offset, r.Height - offset), ANCHOR_SIZE);
                    Rectangle bot = new Rectangle(r.Location + new Size(r.Width / 2 - offset, r.Height - offset), ANCHOR_SIZE);
                    Rectangle botLeft = new Rectangle(r.Location + new Size(-offset, r.Height - offset), ANCHOR_SIZE);
                    Rectangle left = new Rectangle(r.Location + new Size(-offset, r.Height / 2 - offset), ANCHOR_SIZE);
                    e.Graphics.FillRectangle(redBrush, topLeft);
                    e.Graphics.FillRectangle(redBrush, top);
                    e.Graphics.FillRectangle(redBrush, topRight);
                    e.Graphics.FillRectangle(redBrush, midRight);
                    e.Graphics.FillRectangle(redBrush, botRight);
                    e.Graphics.FillRectangle(redBrush, bot);
                    e.Graphics.FillRectangle(redBrush, botLeft);
                    e.Graphics.FillRectangle(redBrush, left);

                    e.Graphics.DrawString(className, myFont, redBrush, r.X, r.Y);
                }
                else
                {

                    e.Graphics.DrawRectangle(blue_thick, r);
                    e.Graphics.DrawString(className, myFont, blueBrush, r.X, r.Y);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            timer1.Stop();

            m_currentPoint = Clamp(e.Location, new Point(0, 0), new Point(pictureBox1.Width, pictureBox1.Height));
            g_isMouseDown = false;
            //draw new rect
            if (g_colisionState == Colision.None)
            {
                int x = m_startPoint.X;
                int y = m_startPoint.Y;
                int w = Math.Abs(m_currentPoint.X - m_startPoint.X);
                int h = Math.Abs(m_currentPoint.Y - m_startPoint.Y);
                int cx = x + w / 2;
                int cy = y + h / 2;

                if (w <= 1 || h <= 1)
                {
                    return;
                }


                //if ((chkMinSize.Checked && Convert.ToInt32(w * g_scaleX) > numMinWidth.Value && Convert.ToInt32(h * g_scaleY) > numMinHeight.Value)
                //    || !chkMinSize.Checked)
                //{
                mRects.Add(new Rectangle(x, y, w, h));
                lstRect.Items.Add(
                    cb_classes.SelectedIndex + " " +
                    cx * m_scaleX / m_img.Width + " " +
                    cy * m_scaleY / m_img.Height + " " +
                    w * m_scaleX / m_img.Width + " " +
                    h * m_scaleY / m_img.Height);
                lstRect.SelectedIndex = lstRect.Items.Count - 1;
                //}
                CompleteEdit();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            timer1.Start();
            m_startPoint = e.Location;
            g_isMouseDown = true;
            if (lstRect.SelectedIndex > -1)
            {
                Rectangle rect = GetCurrentRect();
                mDistanceCurrentRectToMouse = new Size(e.Location.X - rect.X, e.Location.Y - rect.Y);
                mCurrentRectBottomRight = new Point(rect.X + rect.Width, rect.Y + rect.Height);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
                return;

            m_currentPoint = Clamp(e.Location, new Point(0, 0), new Point(pictureBox1.Width, pictureBox1.Height));
            int dx = m_currentPoint.X - m_startPoint.X;
            int dy = m_currentPoint.Y - m_startPoint.Y;


            if (g_isMouseDown)
            {

                if (g_colisionState == Colision.None)
                {

                }
                else if (g_colisionState == Colision.All)
                {
                    MoveRect(m_currentPoint);
                }
                else
                {
                    ResizeRect(m_currentPoint);
                }

            }
            else //not mouse down
            {
                ChangeCursor(e.Location);
                pictureBox1.Refresh();
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void GotoLastNotAnnotated()
        {
            if (lstImg.Items.Count == 0)
                return;

            int startIndex = lstImg.Items.Count - 1;
            if (lstImg.SelectedIndices.Count > 0)
                startIndex = lstImg.SelectedIndices[0] - 1;

            for (int i = startIndex; i > 0; i--)
            {
                string filePath = m_imageDir + lstImg.Items[i].Text;
                string txtPath = filePath.Replace(Path.GetExtension(filePath), ".txt");
                if (File.Exists(txtPath))
                {
                    string[] lines = File.ReadAllLines(txtPath);
                    if (lines.Length == 0)
                    {
                        lstImg.Items[i].Selected = true;
                        lstImg.EnsureVisible(i);
                        lstImg.Focus();
                        return;
                    }
                }
                else
                {
                    lstImg.Items[i].Selected = true;
                    lstImg.EnsureVisible(i);
                    lstImg.Focus();
                    return;
                }

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void GotoNextNotAnnotated()
        {
            int startIndex = 0;
            if (lstImg.SelectedIndices.Count > 0)
                startIndex = lstImg.SelectedIndices[0] + 1;
            for (int i = startIndex; i < lstImg.Items.Count; i++)
            {
                string filePath = TGMTutil.CorrectPath(m_imageDir) + lstImg.Items[i].Text;
                string txtPath = filePath.Replace(Path.GetExtension(filePath), ".txt");
                if (File.Exists(txtPath))
                {
                    string[] lines = File.ReadAllLines(txtPath);
                    if (lines.Length == 0)
                    {
                        lstImg.Items[i].Selected = true;
                        lstImg.EnsureVisible(i);
                        lstImg.Focus();
                        return;
                    }
                }
                else
                {
                    lstImg.Items[i].Selected = true;
                    lstImg.EnsureVisible(i);
                    lstImg.Focus();
                    return;
                }

            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void DeleteFile()
        {
            if (lstImg.Items.Count == 0 || lstImg.SelectedIndices.Count == 0)
                return;

            int index = lstImg.SelectedIndices[0];

            string filePath = TGMTutil.CorrectPath(m_imageDir) + lstImg.Items[index].Text;
            string txtPath = filePath.Replace(Path.GetExtension(filePath), ".txt");
            TGMTfile.MoveFileToRecycleBin(filePath);
            TGMTfile.MoveFileToRecycleBin(txtPath);

            lstImg.Items[index].Remove();
            lstImg.Items[index].Selected = true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void SearchFile()
        {
            if (txt_search.Text == "")
                return;

            if (txt_search.Text != m_lastSearch)
                m_lastSearchIndex = 0;
            m_lastSearch = txt_search.Text;
            if (m_lastSearchIndex >= lstImg.Items.Count)
                m_lastSearchIndex = 0;

            bool found = false;
            for (int i = m_lastSearchIndex; i < lstImg.Items.Count; i++)
            {
                if (lstImg.Items[i].Text.Contains(txt_search.Text))
                {
                    lstImg.Items[i].Selected = true;
                    lstImg.EnsureVisible(i);
                    found = true;
                    m_lastSearchIndex = i + 1;
                    break;
                }
            }

            if (!found)
            {
                m_lastSearchIndex = 0;
                MessageBox.Show("Not found");
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void MoveRect(Point mouseLocation)
        {
            Rectangle rect = GetCurrentRect();

            rect.X = mouseLocation.X - mDistanceCurrentRectToMouse.Width;
            rect.Y = mouseLocation.Y - mDistanceCurrentRectToMouse.Height;

            SetCurrentRect(rect);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void MoveRect(int dx, int dy)
        {
            Rectangle rect = GetCurrentRect();

            rect.X += dx;
            rect.Y += dy;

            SetCurrentRect(rect);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void ResizeRect(Point mouseLocation)
        {
            //Debug.WriteLine("ResizeRect");
            Rectangle rect = GetCurrentRect();

            switch (g_colisionState)
            {
                case Colision.Left:
                    rect.Width = mCurrentRectBottomRight.X - rect.X;
                    rect.X = mouseLocation.X;
                    break;
                case Colision.TopLeft:
                    rect.Location = mouseLocation;
                    rect.Width = mCurrentRectBottomRight.X - rect.X;
                    rect.Height = mCurrentRectBottomRight.Y - rect.Y;
                    break;
                case Colision.Top:
                    rect.Y = mouseLocation.Y;
                    rect.Height = mCurrentRectBottomRight.Y - rect.Y;
                    break;
                case Colision.TopRight:
                    rect.Width = mouseLocation.X - rect.X;
                    rect.Height = mCurrentRectBottomRight.Y - rect.Y;
                    rect.Y = mouseLocation.Y;
                    break;
                case Colision.Right:
                    rect.Width = mouseLocation.X - rect.X;
                    break;
                case Colision.BotRight:
                    rect.Width = mouseLocation.X - rect.X;
                    rect.Height = mouseLocation.Y - rect.Y;
                    break;
                case Colision.Bottom:
                    rect.Height = mouseLocation.Y - rect.Y;
                    break;
                case Colision.BotLeft:
                    rect.X = mouseLocation.X;
                    rect.Width = mCurrentRectBottomRight.X - rect.X;
                    rect.Height = mouseLocation.Y - rect.Y;
                    break;

            }

            SetCurrentRect(rect);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void ResizeRect(int dx, int dy)
        {
            Rectangle rect = GetCurrentRect();

            rect.Width += dx;
            rect.Height += dy;

            SetCurrentRect(rect);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void CountTotalRect()
        {
            mTotalRects = lstRect.Items.Count;
            //for (int i = 0; i < lstImg.Items.Count; i++)
            //{
            //    string line = lstImg.Items[i].ToString();
            //    string[] lineSplit = line.Split(' ');
            //    if (lineSplit.Length > 1)
            //    {
            //        int count = 0;
            //        if (int.TryParse(lineSplit[1], out count))
            //            mTotalRects += count;
            //    }
            //}

            //lblTotalRect.Text = mTotalRects.ToString();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        Point Clamp(Point p, Point min, Point max)
        {
            if (p.X > max.X)
            {
                p.X = max.X;
            }
            else if (p.X < min.X)
            {
                p.X = min.X;
            }

            if (p.Y > max.Y)
            {
                p.Y = max.Y;
            }
            else if (p.Y < min.Y)
            {
                p.Y = min.Y;
            }
            return p;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintError(string message)
        {
            lblMessage.ForeColor = Color.Red;
            lblMessage.Text = message;
            timerClear.Start();
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintSuccess(string message)
        {
            lblMessage.ForeColor = Color.Green;
            lblMessage.Text = message;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        void PrintMessage(string message)
        {
            lblMessage.ForeColor = Color.Black;
            lblMessage.Text = message;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void CompleteEdit()
        {
            //write rect to list image
            if (lstImg.SelectedItems.Count == 0)
                return;

            lstImg.Items[lstImg.SelectedIndices[0]].ForeColor = Color.Black;
            CountTotalRect();
            SaveToFile();
            this.Cursor = Cursors.Default;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        //write list image to file
        void SaveToFile()
        {
            if (lstImg.Items.Count == 0 || lstImg.SelectedIndices.Count == 0)
                return;

            TGMTregistry.GetInstance().SaveValue("imageIdx", lstImg.SelectedIndices[0]);

            lblMessage.Text = "Saving...";
            Thread.Sleep(1);
            string content = "";
            foreach (string item in lstRect.Items)
            {
                content += item + "\n";
            }
            if (content.Length > 0)
                content = content.Substring(0, content.Length - 1);

            if (content != "")
            {
                string txtPath = m_labelDir + Path.GetFileNameWithoutExtension(mCurrentImgName) + ".txt";
                File.WriteAllText(txtPath, content);
            }

            PrintSuccess("Saved");
            timerClear.Start();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bgLoadFile_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!Directory.Exists(m_imageDir))
            {
                MessageBox.Show("Không tìm thấy folder:" + m_imageDir);
                return;
            }


            var allowedExtensions = new[] { ".jpg", ".png", ".bmp", ".JPG", ".PNG", ".BMP" };
            var fileList = Directory.GetFiles(m_imageDir)
                .Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();


            lstImg.Items.Clear();
            List<int> listNoTxt = new List<int>();
            int index = 0;

            lstImg.BeginUpdate();


            foreach (string filePath in fileList)
            {
                string fileName = Path.GetFileName(filePath);
                lstImg.Items.Add(fileName);

                string txtPath = m_labelDir + Path.GetFileNameWithoutExtension(filePath) + ".txt";

                if (!File.Exists(txtPath))
                {
                    listNoTxt.Add(index);
                    lstImg.Items[index].ForeColor = Color.Red;
                }
                index++;
            }


            lstImg.EndUpdate();

            //if (fileNotAdd.Count > 0)
            //{
            //    lblMessage.Text = "add new images in directory";
            //    string files = "";
            //    for (int i = 0; i < Math.Min(10, fileNotAdd.Count); i++)
            //    {
            //        files += fileNotAdd[i] + "\n";
            //    }
            //    if (fileNotAdd.Count > 10)
            //        files += "...";
            //    if (MessageBox.Show("Do you want add " + fileNotAdd.Count + " new images in folder " + txtFolder.Text + " ? \n" + files, "Detected new images in folder", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            //    {
            //        int count = lstImg.Items.Count;
            //        lstImg.Items.AddRange(fileNotAdd.ToArray());
            //        lblLstImg.Text = lstImg.SelectedIndex + 1 + " / " + lstImg.Items.Count;
            //        SaveToFile();
            //        lstImg.TopIndex = count - 3;
            //        lstImg.SelectedIndex = count;
            //        MessageBox.Show("Added " + fileNotAdd.Count + " new images");
            //    }
            //    else
            //    {
            //        string currentDir = TGMTutil.CorrectPath(txtFolder.Text);
            //        string newdir = currentDir + "notmarked\\";
            //        if (!Directory.Exists(newdir))
            //            Directory.CreateDirectory(newdir);

            //        int count = 0;
            //        string error = "";
            //        foreach (string filePath in fileNotAdd)
            //        {
            //            try
            //            {
            //                File.Move(currentDir + filePath, newdir + filePath);
            //                count++;
            //            }
            //            catch (Exception ex)
            //            {
            //                Debug.WriteLine(ex.Message);
            //                error = ex.Message;
            //            }
            //        }
            //        string message = "Moved " + count + " images to folder " + newdir;
            //        if (error != "")
            //            message += ".\n\n Something else has error: " + error;
            //        MessageBox.Show(message);
            //    }
            //}

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bgLoadFile_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CountTotalRect();
            this.Enabled = true;
            timerLoading.Stop();
            progressBar1.Value = progressBar1.Minimum;
            lblMessage.Text = "";

            if (m_isFirstLoading && lstImg.Items.Count > 0)
            {
                int imageIdx = TGMTregistry.GetInstance().ReadInt("imageIdx");
                if (imageIdx >= 0 && imageIdx <= lstImg.Items.Count)
                {
                    lstImg.Items[imageIdx].Selected = true;
                    lstImg.EnsureVisible(imageIdx);
                }
                m_isFirstLoading = false;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Cursor == Cursors.SizeAll && newRectIdx < lstRect.Items.Count)
            {
                lstRect.SelectedIndex = newRectIdx;
                lstRect.Focus();
            }
        }

        private void lstRect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
            }
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (lstRect.Items.Count > 0 && lstRect.SelectedIndex > -1)
                {
                    int index = lstRect.SelectedIndex;
                    lstRect.Items.RemoveAt(index);
                    mRects.RemoveAt(index);

                    if (index > -1 & index < lstRect.Items.Count)
                    {
                        lstRect.SelectedIndex = index;
                    }
                    else if (index == lstRect.Items.Count)
                    {
                        lstRect.SelectedIndex = lstRect.Items.Count - 1;
                    }
                    CompleteEdit();
                    pictureBox1.Refresh();
                }

                this.Cursor = Cursors.Default;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                CompleteEdit();
                lstRect.SelectedIndex = -1;
                if (lstImg.SelectedIndices.Count > 0)
                {
                    int nextIndex = lstImg.SelectedIndices[0] + 1;
                    if (nextIndex < lstImg.Items.Count)
                    {
                        lstImg.Items[nextIndex].Selected = true;
                        lstImg.EnsureVisible(nextIndex);
                    }
                    lstImg.Focus();
                    e.Handled = true;
                }
            }
        }

        private void btn_openFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Select folder contain image";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                m_imageDir = TGMTutil.CorrectPath(folderPath);

                if (m_imageDir.Contains(" "))
                {
                    MessageBox.Show("Folder không được có khoảng trắng hay ký tự đặc biệt");
                    return;
                }


                if (!Directory.Exists(m_imageDir))
                {
                    MessageBox.Show("Folder không tồn tại");
                    return;
                }
                LoadImage();


            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadImage()
        {
            if (m_imageDir == "" || m_labelDir == "" || m_classFile == "")
                return;

            lstImg.Items.Clear();
            lstRect.Items.Clear();
            mRects.Clear();

            this.Enabled = false;
            timerLoading.Start();
            lblMessage.Text = "Loading file...";


            TGMTregistry.GetInstance().SaveValue("txtFolderImage", m_imageDir);

            string recentDir = TGMTregistry.GetInstance().ReadString("recentDir");
            if (recentDir == "")
                recentDir += m_imageDir;
            else
            {
                if (!recentDir.Contains(m_imageDir))
                    recentDir += ";" + m_imageDir;
            }


            TGMTregistry.GetInstance().SaveValue("recentDir", recentDir);


            if (!bgLoadFile.IsBusy)
            {
                bgLoadFile.RunWorkerAsync();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void LoadRects()
        {
            errorProvider1.Clear();
            if (lstImg.Items.Count == 0 || lstImg.SelectedIndices.Count == 0)
                return;

            if (string.IsNullOrEmpty(m_imageDir))
            {
                MessageBox.Show("Không tìm thấy folder");
                return;
            }


            string imgName = lstImg.SelectedItems[0].Text.ToString();
            if (imgName == mCurrentImgName)
                return;

            mCurrentImgName = imgName;


            string imgPath = m_imageDir + mCurrentImgName;
            if (!File.Exists(imgPath))
            {
                pictureBox1.Image = null;
                return;
            }

            //clear
            lstRect.Items.Clear();
            mRects.Clear();


            m_img = TGMTimage.LoadBitmapWithoutLock(imgPath);
            pictureBox1.Image = m_img;
            PrintMessage("Image " + (lstImg.SelectedIndices[0] + 1) + " / " + lstImg.Items.Count);


            m_aspect = (double)m_img.Width / (double)m_img.Height;
            double panelAspect = (double)panel4.Width / panel4.Height;

            //resize
            if (m_aspect > panelAspect)
            {
                pictureBox1.Width = panel4.Width;
                pictureBox1.Height = (int)(pictureBox1.Width / m_aspect);
            }
            else if (m_aspect < panelAspect)
            {
                pictureBox1.Height = panel4.Height;
                pictureBox1.Width = (int)(pictureBox1.Height * m_aspect);
            }
            m_scaleX = (double)m_img.Width / pictureBox1.Width;
            m_scaleY = (double)m_img.Height / pictureBox1.Height;

            string txtPath = m_labelDir + mCurrentImgName.Replace(Path.GetExtension(mCurrentImgName), ".txt");
            if (File.Exists(txtPath))
            {
                string[] lines = File.ReadAllLines(txtPath);

                foreach (string line in lines)
                {
                    

                    string[] lineSplit = line.Split(' ');
                    //add rect to lsrect
                    if (lineSplit.Length == 5)
                    {
                        int classID = int.Parse(lineSplit[0]);

                        double cx = double.Parse(lineSplit[1]);
                        double cy = double.Parse(lineSplit[2]);
                        double w = double.Parse(lineSplit[3]);
                        double h = double.Parse(lineSplit[4]);
                        double x = cx - w / 2;
                        double y = cy - h / 2;

                        mRects.Add(new Rectangle(
                            (int)(x * m_img.Width / m_scaleX),
                            (int)(y * m_img.Height / m_scaleY),
                            (int)(w * m_img.Width / m_scaleX),
                            (int)(h * m_img.Height / m_scaleY)));

                        lstRect.Items.Add(line);
                    }
                    
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        Colision CheckColision(Point p, Rectangle rect)
        {
            int distanceLeft = Math.Abs(p.X - rect.X);
            int distanceTop = Math.Abs(p.Y - rect.Y);
            int distanceRight = Math.Abs(p.X - (rect.X + rect.Width));
            int distanceBottom = Math.Abs(p.Y - (rect.Y + rect.Height));

            double offset = ANCHOR_WIDTH / 2;

            if (distanceLeft <= offset && distanceTop <= offset)
            {
                return Colision.TopLeft;
            }
            else if (distanceTop < 3 && distanceRight < 3)
            {
                return Colision.TopRight;
            }
            else if (distanceBottom < 3 && distanceRight < 3)
            {
                return Colision.BotRight;
            }
            else if (distanceBottom < 3 && distanceLeft < 3)
            {
                return Colision.BotLeft;
            }
            else if (distanceTop <= offset && p.X > rect.X + rect.Width / 2 - offset && p.X < rect.X + rect.Width / 2 + offset)
            {
                return Colision.Top;
            }
            else if (distanceRight <= offset && p.Y > rect.Y + rect.Height / 2 - offset && p.Y < rect.Y + rect.Height / 2 + offset)
            {
                return Colision.Right;
            }
            else if (distanceBottom <= offset && p.X > rect.X + rect.Width / 2 - offset && p.X < rect.X + rect.Width / 2 + offset)
            {
                return Colision.Bottom;
            }
            else if (distanceLeft <= offset && p.Y > rect.Y + rect.Height / 2 - offset && p.Y < rect.Y + rect.Height / 2 + offset)
            {
                return Colision.Left;
            }
            else if ((distanceTop <= offset && p.X > rect.X && p.X < (rect.X + rect.Width)) ||
                    (distanceRight <= offset && p.Y > rect.Y && p.Y < (rect.Y + rect.Height)) ||
                    (distanceBottom <= offset && p.X > rect.X && p.X < (rect.X + rect.Width)) ||
                    (distanceLeft <= offset && p.Y > rect.Y && p.Y < (rect.Y + rect.Height)))
            {
                return Colision.All;
            }
            else
            {
                return Colision.None;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        Rectangle GetCurrentRect()
        {
            if (lstRect.SelectedIndex == -1 && lstRect.Items.Count > 0)
                lstRect.SelectedIndex = 0;
            return GetRect(lstRect.SelectedIndex);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        Rectangle GetRect(int index)
        {
            return mRects[index];
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void SetCurrentRect(Rectangle rect)
        {
            mRects[lstRect.SelectedIndex] = rect;

            double x = rect.X * m_scaleX / m_img.Width;
            double y = rect.Y * m_scaleY / m_img.Height;
            double w = rect.Width * m_scaleX / m_img.Width;
            double h = rect.Height * m_scaleY / m_img.Height;
            double cx = x + w / 2;
            double cy = y + h / 2;
            lstRect.Items[lstRect.SelectedIndex] = cb_classes.SelectedIndex + " " + cx + " " + cy + " " + w + " " + h;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        void ChangeCursor(Point p)
        {
            if (lstRect.Items.Count == 0)
                g_colisionState = Colision.None;
            if (p.X > pictureBox1.Width || p.Y > pictureBox1.Height)
            {
                this.Cursor = Cursors.Default;
                return;
            }

            for (int i = 0; i < lstRect.Items.Count; i++)
            {
                g_colisionState = CheckColision(p, GetRect(i));
                if (g_colisionState == Colision.All)
                    this.Cursor = Cursors.SizeAll;
                else if (g_colisionState == Colision.TopLeft || g_colisionState == Colision.BotRight)
                    this.Cursor = Cursors.SizeNWSE;
                else if (g_colisionState == Colision.TopRight || g_colisionState == Colision.BotLeft)
                    this.Cursor = Cursors.SizeNESW;
                else if (g_colisionState == Colision.Left || g_colisionState == Colision.Right)
                    this.Cursor = Cursors.SizeWE;
                else if (g_colisionState == Colision.Top || g_colisionState == Colision.Bottom)
                    this.Cursor = Cursors.SizeNS;
                else if (g_colisionState == Colision.NewRect)
                    this.Cursor = Cursors.Hand;
                else
                    this.Cursor = Cursors.Default;


                if (g_colisionState != Colision.None)
                {
                    if (i != lstRect.SelectedIndex)
                    {
                        this.Cursor = Cursors.SizeAll;
                    }
                    newRectIdx = i;
                    return;
                }
            }
            this.Cursor = Cursors.Default;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lstRect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRect.SelectedIndex < 0 || lstRect.SelectedIndex > lstRect.Items.Count)
                return;

            if (pictureBox1.Image == null)
                return;

            string[] elements = lstRect.SelectedItem.ToString().Split(' ');
            int classIdx = Convert.ToInt32(elements[0]);
            if (classIdx < cb_classes.Items.Count)
            {
                cb_classes.SelectedIndex = classIdx;
                cb_classID.SelectedIndex = classIdx;

                Rectangle r = GetCurrentRect();

                r.X = (int)(r.X * m_scaleX);
                r.Y = (int)(r.Y * m_scaleY);
                r.Width = (int)(r.Width * m_scaleX);
                r.Height = (int)(r.Height * m_scaleY);
                int area = r.Width * r.Height;

                PrintMessage(r.ToString() + " Area: " + area.ToString("N0"));
            }

            cb_classes.Enabled = true;
            cb_classID.Enabled = true;

            pictureBox1.Refresh();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRect.SelectedIndex < 0)
                return;
            
            string elements = lstRect.Items[lstRect.SelectedIndex].ToString();
            int spaceIdx = elements.IndexOf(" ");

            string currentClass = elements.Substring(0, spaceIdx);
            string newClass = cb_classes.SelectedIndex.ToString();
            if (currentClass != newClass)
            {
                elements = newClass + elements.Substring(spaceIdx);
                lstRect.Items[lstRect.SelectedIndex] = elements;
                CompleteEdit();
            }

            lstRect.Focus();
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void cb_classID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstRect.SelectedIndex < 0)
                return;

            
            string elements = lstRect.Items[lstRect.SelectedIndex].ToString();
            int spaceIdx = elements.IndexOf(" ");

            string currentClass = elements.Substring(0, spaceIdx);
            cb_classes.SelectedIndex = cb_classID.SelectedIndex;
            string newClassID = cb_classID.SelectedItem.ToString();
            if (currentClass != newClassID)
            {
                elements = newClassID + elements.Substring(spaceIdx);
                lstRect.Items[lstRect.SelectedIndex] = elements;
                CompleteEdit();
            }

            lstRect.Focus();
            
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bgCrop_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i < m_classes.Length; i++)
                {
                    string classDir = m_saveDir + m_classes[i];
                    if (!Directory.Exists(classDir))
                        Directory.CreateDirectory(classDir);
                }



                int count = 0;
                int totalImage = lstImg.Items.Count;
                for (int i = 0; i < totalImage; i++)
                {
                    string fileName = lstImg.Items[i].Text;
                    string filePath = m_imageDir + fileName;
                    string txtPath = filePath.Replace(Path.GetExtension(filePath), ".txt");

                    if (!File.Exists(txtPath))
                    {
                        continue;
                    }
                    string[] lines = File.ReadAllLines(txtPath);


                    Bitmap bmp = TGMTimage.LoadBitmapWithoutLock(filePath);

                    for (int j = 0; j < lines.Length; j++)
                    {
                        string line = lines[j];
                        string[] elements = line.Split(' ');
                        if (elements.Length != 5)
                            continue;

                        int classID = Convert.ToInt32(elements[0]);

                        if (classID >= m_classes.Length)
                        {
                            if (MessageBox.Show("File " + txtPath + " wrong class ID", "Open text file?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Process.Start(txtPath);
                            }
                            return;
                        }
                        string className = m_classes[classID];



                        double cx = Convert.ToDouble(elements[1]);
                        double cy = Convert.ToDouble(elements[2]);
                        double w = Convert.ToDouble(elements[3]);
                        double h = Convert.ToDouble(elements[4]);
                        double x = cx - w / 2;
                        double y = cy - h / 2;

                        int ix = Convert.ToInt32(x * bmp.Width);
                        int iy = Convert.ToInt32(y * bmp.Height);
                        int iw = Convert.ToInt32(w * bmp.Width);
                        int ih = Convert.ToInt32(h * bmp.Height);


                        if (iw > bmp.Width || ih > bmp.Height || ix + iw > bmp.Width || iy + ih > bmp.Height)
                        {
                            if (MessageBox.Show("File " + txtPath + " wrong size", "Open text file?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                Process.Start(txtPath);
                            }
                            continue;
                        }

                        Rectangle cropRect = new Rectangle(ix, iy, iw, ih);
                        Bitmap cropBmp = TGMTimage.CropBitmap(bmp, cropRect);
                        string savePath = String.Format("{0}{1}\\{2}_{3}.jpg", m_saveDir, className, Path.GetFileNameWithoutExtension(fileName), j);
                        cropBmp.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                        cropBmp.Dispose();
                        cropBmp = null;
                        count++;
                    }

                    bmp.Dispose();
                    bmp = null;

                    int percentComplete = (int)((float)i / (float)totalImage * 100);
                    bgCrop.ReportProgress(percentComplete);

                }
                e.Result = "Crop " + count + " objects on " + totalImage + " total image";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lstImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_classes.Enabled = false;
            cb_classID.Enabled = false;

            LoadRects();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        private void lstImg_KeyDown(object sender, KeyEventArgs e)
        {
            int selectedIndex = lstImg.SelectedIndices[0];
            if (e.KeyCode == Keys.Delete)
            {
                if (lstImg.SelectedIndices.Count > 0 && lstRect.SelectedIndex == -1)
                {
                    int index = lstImg.SelectedIndices[0];
                    string imagePath = m_imageDir + lstImg.Items[index].Text;
                    string txtPath = m_labelDir + Path.GetFileNameWithoutExtension(imagePath) + ".txt";


                    lstImg.Items.RemoveAt(lstImg.SelectedIndices[0]);
                    lstRect.Items.Clear();

                    TGMTfile.MoveFileToRecycleBin(imagePath);
                    TGMTfile.MoveFileToRecycleBin(txtPath);

                    if (index < lstImg.Items.Count)
                    {
                        lstImg.Items[index].Selected = true;
                    }
                    else
                    {
                        lstImg.Items[lstImg.Items.Count - 1].Selected = true;
                    }
                }
                this.Cursor = Cursors.Default;
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (lstRect.SelectedIndex > -1)
                {
                    e.Handled = true;
                    return;
                }

                if (selectedIndex > 0)
                {
                    lstImg.Items[selectedIndex - 1].Selected = true;
                    lstImg.EnsureVisible(selectedIndex - 1);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                return;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (lstRect.SelectedIndex > -1)
                {
                    e.Handled = true;
                    return;
                }

                if (selectedIndex < lstImg.Items.Count - 1)
                {
                    lstImg.Items[selectedIndex + 1].Selected = true;
                    lstImg.EnsureVisible(selectedIndex + 1);
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
                return;
            }
            else
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void txt_search_TextBoxKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchFile();
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value >= progressBar1.Maximum)
                progressBar1.Value = progressBar1.Minimum;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bgCrop_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            PrintMessage(e.ProgressPercentage + "%");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void bgCrop_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            PrintMessage("");
            MessageBox.Show(e.Result.ToString(), "Crop success");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_search_Click(object sender, EventArgs e)
        {
            SearchFile();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_imageNoLabel_Click(object sender, EventArgs e)
        {
            bool found = false;

            for (int i = 0; i < lstImg.Items.Count; i++)
            {
                string txtPath = m_labelDir + lstImg.Items[i].Text.Replace(Path.GetExtension(mCurrentImgName), ".txt");
                if (!File.Exists(txtPath))
                {
                    found = true;
                    lstImg.EnsureVisible(i);
                    break;
                }
                string[] lines = File.ReadAllLines(txtPath);
                if (lines.Length == 0)
                {
                    found = true;
                    lstImg.EnsureVisible(i);
                    break;
                }
            }

            if (!found)
                PrintError("Not found");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_addClass_Click(object sender, EventArgs e)
        {
            string newClass = InputBox.Show("Add new class");
            cb_classes.Items.Add(newClass);
            cb_classID.Items.Add(cb_classID.Items.Count);


            string[] classes = cb_classes.Items.Cast<string>().ToArray();
            File.WriteAllLines(m_classFile, classes);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void timerClear_Tick(object sender, EventArgs e)
        {
            timerClear.Stop();
            lblMessage.Text = "";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_about_Click(object sender, EventArgs e)
        {

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            string filePath = m_imageDir + lstImg.SelectedItems[0].Text;
            if (!File.Exists(filePath))
            {
                PrintMessage("File does not exist");
                return;
            }


            if (e.ClickedItem.Name == "btnCopyPath")
            {
                Clipboard.SetText(filePath);
                PrintMessage("Copied path to clipboard");
            }
            else if (e.ClickedItem.Name == "btnCopyImage")
            {
                StringCollection paths = new StringCollection();
                paths.Add(filePath);
                Clipboard.SetFileDropList(paths);
                PrintMessage("Copied image to clipboard");
            }
            else if (e.ClickedItem.Name == "btnOpenImage")
            {
                System.Diagnostics.Process.Start(filePath);
            }
            else if (e.ClickedItem.Name == "btnDelete")
            {                
                if (File.Exists(filePath))
                {
                    FileSystem.DeleteFile(filePath, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                }

                string labelFile = Path.ChangeExtension(filePath, ".txt");
                if (File.Exists(labelFile))
                {
                    FileSystem.DeleteFile(labelFile, UIOption.AllDialogs, RecycleOption.SendToRecycleBin);
                }
            }
        }
    }
}
