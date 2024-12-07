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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_classFile = new AltoControls.BrowseFile();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new AltoControls.ImageButton();
            this.txt_search = new AltoControls.AltoTextBox();
            this.chk_sameDir = new System.Windows.Forms.CheckBox();
            this.txt_labelDir = new AltoControls.BrowseDir();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_imageDir = new AltoControls.BrowseDir();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_classID = new System.Windows.Forms.ComboBox();
            this.cb_classes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_addClass = new AltoControls.ImageButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findImageNoLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_about = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCopyPath = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopyImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenImage = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstImg
            // 
            this.lstImg.AllowDrop = true;
            this.lstImg.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstImg.ContextMenuStrip = this.contextMenuStrip1;
            this.lstImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstImg.FullRowSelect = true;
            this.lstImg.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstImg.HideSelection = false;
            this.lstImg.Location = new System.Drawing.Point(0, 0);
            this.lstImg.MultiSelect = false;
            this.lstImg.Name = "lstImg";
            this.lstImg.Size = new System.Drawing.Size(346, 363);
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
            this.lstRect.Location = new System.Drawing.Point(0, 402);
            this.lstRect.Name = "lstRect";
            this.lstRect.ScrollAlwaysVisible = true;
            this.lstRect.Size = new System.Drawing.Size(346, 132);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(347, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 499);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.txt_classFile);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.chk_sameDir);
            this.panel1.Controls.Add(this.txt_labelDir);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_imageDir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1221, 102);
            this.panel1.TabIndex = 40;
            // 
            // txt_classFile
            // 
            this.txt_classFile.BackColor = System.Drawing.Color.Transparent;
            this.txt_classFile.BackgroundColor = System.Drawing.Color.White;
            this.txt_classFile.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_classFile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_classFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_classFile.Location = new System.Drawing.Point(82, 69);
            this.txt_classFile.Name = "txt_classFile";
            this.txt_classFile.Padding = new System.Windows.Forms.Padding(5);
            this.txt_classFile.Pattern = "Text file |*.txt;*.names";
            this.txt_classFile.Size = new System.Drawing.Size(564, 26);
            this.txt_classFile.TabIndex = 15;
            this.txt_classFile.TextChanged += new System.EventHandler(this.txt_classFile_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(12, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Classes file";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label4.Location = new System.Drawing.Point(730, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Search";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.BackgroundImage = global::YoloLabel.Properties.Resources.find32;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.HoverImage = null;
            this.btn_search.Location = new System.Drawing.Point(1061, 9);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(32, 32);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "imageButton1";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.Transparent;
            this.txt_search.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_search.Br = System.Drawing.Color.White;
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_search.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_search.Location = new System.Drawing.Point(780, 14);
            this.txt_search.Name = "txt_search";
            this.txt_search.Padding = new System.Windows.Forms.Padding(5);
            this.txt_search.Radius = 4;
            this.txt_search.Size = new System.Drawing.Size(275, 26);
            this.txt_search.TabIndex = 11;
            // 
            // chk_sameDir
            // 
            this.chk_sameDir.AutoSize = true;
            this.chk_sameDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.chk_sameDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.chk_sameDir.Location = new System.Drawing.Point(652, 45);
            this.chk_sameDir.Name = "chk_sameDir";
            this.chk_sameDir.Size = new System.Drawing.Size(114, 19);
            this.chk_sameDir.TabIndex = 10;
            this.chk_sameDir.Text = "Same image dir";
            this.chk_sameDir.UseVisualStyleBackColor = true;
            this.chk_sameDir.CheckedChanged += new System.EventHandler(this.chk_sameDir_CheckedChanged);
            // 
            // txt_labelDir
            // 
            this.txt_labelDir.BackColor = System.Drawing.Color.Transparent;
            this.txt_labelDir.BackgroundColor = System.Drawing.Color.White;
            this.txt_labelDir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_labelDir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_labelDir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_labelDir.Location = new System.Drawing.Point(82, 38);
            this.txt_labelDir.Name = "txt_labelDir";
            this.txt_labelDir.Padding = new System.Windows.Forms.Padding(5);
            this.txt_labelDir.Size = new System.Drawing.Size(564, 26);
            this.txt_labelDir.TabIndex = 9;
            this.txt_labelDir.TextChanged += new System.EventHandler(this.txt_labelDir_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Label dir";
            // 
            // txt_imageDir
            // 
            this.txt_imageDir.BackColor = System.Drawing.Color.Transparent;
            this.txt_imageDir.BackgroundColor = System.Drawing.Color.White;
            this.txt_imageDir.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(133)))), ((int)(((byte)(200)))));
            this.txt_imageDir.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_imageDir.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_imageDir.Location = new System.Drawing.Point(82, 6);
            this.txt_imageDir.Name = "txt_imageDir";
            this.txt_imageDir.Padding = new System.Windows.Forms.Padding(5);
            this.txt_imageDir.Size = new System.Drawing.Size(564, 26);
            this.txt_imageDir.TabIndex = 1;
            this.txt_imageDir.TextChanged += new System.EventHandler(this.txt_imageDir_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image dir";
            // 
            // cb_classID
            // 
            this.cb_classID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_classID.FormattingEnabled = true;
            this.cb_classID.Location = new System.Drawing.Point(245, 7);
            this.cb_classID.Name = "cb_classID";
            this.cb_classID.Size = new System.Drawing.Size(59, 24);
            this.cb_classID.TabIndex = 4;
            this.cb_classID.SelectedIndexChanged += new System.EventHandler(this.cb_classID_SelectedIndexChanged);
            // 
            // cb_classes
            // 
            this.cb_classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_classes.FormattingEnabled = true;
            this.cb_classes.Location = new System.Drawing.Point(41, 7);
            this.cb_classes.Name = "cb_classes";
            this.cb_classes.Size = new System.Drawing.Size(198, 24);
            this.cb_classes.TabIndex = 3;
            this.cb_classes.SelectedIndexChanged += new System.EventHandler(this.cb_classes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.label2.Location = new System.Drawing.Point(2, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstImg);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lstRect);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 534);
            this.panel2.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panel3.Controls.Add(this.cb_classID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cb_classes);
            this.panel3.Controls.Add(this.btn_addClass);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(346, 39);
            this.panel3.TabIndex = 8;
            // 
            // btn_addClass
            // 
            this.btn_addClass.BackColor = System.Drawing.Color.Transparent;
            this.btn_addClass.BackgroundImage = global::YoloLabel.Properties.Resources.add32x32;
            this.btn_addClass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_addClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_addClass.ForeColor = System.Drawing.Color.White;
            this.btn_addClass.HoverImage = null;
            this.btn_addClass.Location = new System.Drawing.Point(311, 6);
            this.btn_addClass.Name = "btn_addClass";
            this.btn_addClass.Size = new System.Drawing.Size(25, 26);
            this.btn_addClass.TabIndex = 7;
            this.btn_addClass.Text = "imageButton1";
            this.btn_addClass.Click += new System.EventHandler(this.btn_addClass_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(225)))), ((int)(((byte)(243)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolToolStripMenuItem,
            this.btn_about});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 24);
            this.menuStrip1.TabIndex = 42;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findImageNoLabelToolStripMenuItem});
            this.toolToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.toolToolStripMenuItem.Text = "Tool";
            // 
            // findImageNoLabelToolStripMenuItem
            // 
            this.findImageNoLabelToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.findImageNoLabelToolStripMenuItem.Name = "findImageNoLabelToolStripMenuItem";
            this.findImageNoLabelToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.findImageNoLabelToolStripMenuItem.Text = "Find image no label";
            // 
            // btn_about
            // 
            this.btn_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(66)))), ((int)(((byte)(139)))));
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(52, 20);
            this.btn_about.Text = "About";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopyPath,
            this.btnCopyImage,
            this.btnOpenImage,
            this.btnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 114);
            this.contextMenuStrip1.Text = "Copy path";
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.btnCopyPath.Size = new System.Drawing.Size(180, 22);
            this.btnCopyPath.Text = "Copy path";
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(180, 22);
            this.btnCopyImage.Text = "Copy image";
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(180, 22);
            this.btnOpenImage.Text = "Open image";
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 22);
            this.btnDelete.Text = "Delete image";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Yolo Locator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ListView lstImg;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ListBox lstRect;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Timer timerClear;
        private System.ComponentModel.BackgroundWorker bgLoadFile;
        private System.ComponentModel.BackgroundWorker bgCrop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private AltoControls.BrowseDir txt_imageDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_classes;
        private System.Windows.Forms.ComboBox cb_classID;
        private AltoControls.ImageButton btn_addClass;
        private AltoControls.BrowseDir txt_labelDir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_sameDir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private AltoControls.AltoTextBox txt_search;
        private AltoControls.ImageButton btn_search;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findImageNoLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_about;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private AltoControls.BrowseFile txt_classFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnCopyPath;
        private System.Windows.Forms.ToolStripMenuItem btnCopyImage;
        private System.Windows.Forms.ToolStripMenuItem btnOpenImage;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
    }
}