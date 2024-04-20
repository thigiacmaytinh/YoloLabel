namespace YoloLabel
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.btn_openFolder = new System.Windows.Forms.RibbonOrbMenuItem();
            this.recentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.recentItem2 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.recentItem3 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.cb_classes = new System.Windows.Forms.RibbonComboBox();
            this.cb_classID = new System.Windows.Forms.RibbonComboBox();
            this.btn_addClass = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.txt_search = new System.Windows.Forms.RibbonTextBox();
            this.btn_search = new System.Windows.Forms.RibbonButton();
            this.btn_imageNoLabel = new System.Windows.Forms.RibbonButton();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lstImg = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstRect = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClear = new System.Windows.Forms.Timer(this.components);
            this.bgLoadFile = new System.ComponentModel.BackgroundWorker();
            this.bgCrop = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 2;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.btn_openFolder);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.RecentItems.Add(this.recentItem1);
            this.ribbon1.OrbDropDown.RecentItems.Add(this.recentItem2);
            this.ribbon1.OrbDropDown.RecentItems.Add(this.recentItem3);
            this.ribbon1.OrbDropDown.RecentItemsCaption = "Recent folder";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(800, 200);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.ribbon1.OrbText = "FILE";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1221, 150);
            this.ribbon1.TabIndex = 1;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue_2010;
            // 
            // btn_openFolder
            // 
            this.btn_openFolder.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.btn_openFolder.Image = global::YoloLabel.Properties.Resources.close32;
            this.btn_openFolder.LargeImage = global::YoloLabel.Properties.Resources.close32;
            this.btn_openFolder.Name = "btn_openFolder";
            this.btn_openFolder.SmallImage = global::YoloLabel.Properties.Resources.close32;
            this.btn_openFolder.Text = "Open folder";
            this.btn_openFolder.Click += new System.EventHandler(this.btn_openFolder_Click);
            // 
            // recentItem1
            // 
            this.recentItem1.Image = ((System.Drawing.Image)(resources.GetObject("recentItem1.Image")));
            this.recentItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("recentItem1.LargeImage")));
            this.recentItem1.Name = "recentItem1";
            this.recentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("recentItem1.SmallImage")));
            // 
            // recentItem2
            // 
            this.recentItem2.Image = ((System.Drawing.Image)(resources.GetObject("recentItem2.Image")));
            this.recentItem2.LargeImage = ((System.Drawing.Image)(resources.GetObject("recentItem2.LargeImage")));
            this.recentItem2.Name = "recentItem2";
            this.recentItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("recentItem2.SmallImage")));
            // 
            // recentItem3
            // 
            this.recentItem3.Image = ((System.Drawing.Image)(resources.GetObject("recentItem3.Image")));
            this.recentItem3.LargeImage = ((System.Drawing.Image)(resources.GetObject("recentItem3.LargeImage")));
            this.recentItem3.Name = "recentItem3";
            this.recentItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("recentItem3.SmallImage")));
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Text = "Manual label";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ButtonMoreVisible = false;
            this.ribbonPanel1.Items.Add(this.ribbonLabel1);
            this.ribbonPanel1.Items.Add(this.ribbonItemGroup1);
            this.ribbonPanel1.Items.Add(this.btn_addClass);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "Rectangle";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Classes";
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Items.Add(this.cb_classes);
            this.ribbonItemGroup1.Items.Add(this.cb_classID);
            this.ribbonItemGroup1.Name = "ribbonItemGroup1";
            this.ribbonItemGroup1.Text = "";
            // 
            // cb_classes
            // 
            this.cb_classes.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.cb_classes.Name = "cb_classes";
            this.cb_classes.SelectedIndex = -1;
            this.cb_classes.Text = "";
            this.cb_classes.TextBoxText = "";
            this.cb_classes.TextBoxWidth = 200;
            this.cb_classes.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.cb_classes_DropDownItemClicked);
            // 
            // cb_classID
            // 
            this.cb_classID.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.cb_classID.Name = "cb_classID";
            this.cb_classID.SelectedIndex = -1;
            this.cb_classID.Text = "";
            this.cb_classID.TextBoxText = "";
            this.cb_classID.TextBoxWidth = 50;
            this.cb_classID.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.cb_classID_DropDownItemClicked);
            // 
            // btn_addClass
            // 
            this.btn_addClass.Image = global::YoloLabel.Properties.Resources.add32x32;
            this.btn_addClass.LargeImage = global::YoloLabel.Properties.Resources.add32x32;
            this.btn_addClass.MinimumSize = new System.Drawing.Size(60, 0);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_addClass.SmallImage")));
            this.btn_addClass.Text = "Add class";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ButtonMoreVisible = false;
            this.ribbonPanel2.Items.Add(this.txt_search);
            this.ribbonPanel2.Items.Add(this.btn_search);
            this.ribbonPanel2.Items.Add(this.btn_imageNoLabel);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "Image 0/0";
            // 
            // txt_search
            // 
            this.txt_search.Name = "txt_search";
            this.txt_search.Text = "";
            this.txt_search.TextBoxText = "";
            this.txt_search.TextBoxWidth = 200;
            this.txt_search.TextBoxKeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_TextBoxKeyUp);
            // 
            // btn_search
            // 
            this.btn_search.Image = global::YoloLabel.Properties.Resources.find32;
            this.btn_search.LargeImage = global::YoloLabel.Properties.Resources.find32;
            this.btn_search.MinimumSize = new System.Drawing.Size(60, 0);
            this.btn_search.Name = "btn_search";
            this.btn_search.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_search.SmallImage")));
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_imageNoLabel
            // 
            this.btn_imageNoLabel.Image = global::YoloLabel.Properties.Resources.printpreview32;
            this.btn_imageNoLabel.LargeImage = global::YoloLabel.Properties.Resources.printpreview32;
            this.btn_imageNoLabel.MinimumSize = new System.Drawing.Size(90, 0);
            this.btn_imageNoLabel.Name = "btn_imageNoLabel";
            this.btn_imageNoLabel.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_imageNoLabel.SmallImage")));
            this.btn_imageNoLabel.Text = "Search image no label";
            this.btn_imageNoLabel.Click += new System.EventHandler(this.btn_imageNoLabel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GroupBox1.Controls.Add(this.lstImg);
            this.GroupBox1.Controls.Add(this.lstRect);
            this.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GroupBox1.Location = new System.Drawing.Point(0, 150);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(352, 510);
            this.GroupBox1.TabIndex = 8;
            this.GroupBox1.TabStop = false;
            // 
            // lstImg
            // 
            this.lstImg.AllowDrop = true;
            this.lstImg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImg.FullRowSelect = true;
            this.lstImg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstImg.HideSelection = false;
            this.lstImg.Location = new System.Drawing.Point(3, 16);
            this.lstImg.MultiSelect = false;
            this.lstImg.Name = "lstImg";
            this.lstImg.Size = new System.Drawing.Size(346, 327);
            this.lstImg.TabIndex = 2;
            this.lstImg.TabStop = false;
            this.lstImg.UseCompatibleStateImageBehavior = false;
            this.lstImg.View = System.Windows.Forms.View.Details;
            this.lstImg.SelectedIndexChanged += new System.EventHandler(this.lstImg_SelectedIndexChanged);
            this.lstImg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstImg_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 337;
            // 
            // lstRect
            // 
            this.lstRect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRect.FormattingEnabled = true;
            this.lstRect.HorizontalScrollbar = true;
            this.lstRect.ItemHeight = 16;
            this.lstRect.Location = new System.Drawing.Point(3, 343);
            this.lstRect.Name = "lstRect";
            this.lstRect.ScrollAlwaysVisible = true;
            this.lstRect.Size = new System.Drawing.Size(346, 164);
            this.lstRect.TabIndex = 7;
            this.lstRect.TabStop = false;
            this.lstRect.SelectedIndexChanged += new System.EventHandler(this.lstRect_SelectedIndexChanged);
            this.lstRect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstRect_KeyDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 660);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1221, 22);
            this.statusStrip1.TabIndex = 39;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // timerClear
            // 
            this.timerClear.Interval = 2000;
            this.timerClear.Tick += new System.EventHandler(this.timerClear_Tick);
            // 
            // bgLoadFile
            // 
            this.bgLoadFile.WorkerReportsProgress = true;
            this.bgLoadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoadFile_DoWork);
            this.bgLoadFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoadFile_RunWorkerCompleted);
            // 
            // bgCrop
            // 
            this.bgCrop.WorkerReportsProgress = true;
            this.bgCrop.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgCrop_DoWork);
            this.bgCrop.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgCrop_ProgressChanged);
            this.bgCrop.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgCrop_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(352, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "Yolo Locator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.GroupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ListView lstImg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ListBox lstRect;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTextBox txt_search;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonComboBox cb_classes;
        private System.Windows.Forms.RibbonComboBox cb_classID;
        private System.Windows.Forms.RibbonOrbRecentItem recentItem1;
        private System.Windows.Forms.RibbonOrbRecentItem recentItem2;
        private System.Windows.Forms.RibbonOrbRecentItem recentItem3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Timer timerClear;
        private System.ComponentModel.BackgroundWorker bgLoadFile;
        private System.Windows.Forms.RibbonOrbMenuItem btn_openFolder;
        private System.ComponentModel.BackgroundWorker bgCrop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.RibbonButton btn_search;
        private System.Windows.Forms.RibbonButton btn_imageNoLabel;
        private System.Windows.Forms.RibbonButton btn_addClass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}