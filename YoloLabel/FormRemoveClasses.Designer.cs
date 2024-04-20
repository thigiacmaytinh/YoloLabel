namespace YoloLabel
{
    partial class FormRemoveClasses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_remove = new System.Windows.Forms.Button();
            this.lbl_remove = new System.Windows.Forms.Label();
            this.lbl_keep = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.bgLoadFile = new System.ComponentModel.BackgroundWorker();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_moveRight = new System.Windows.Forms.Button();
            this.btn_moveRightAll = new System.Windows.Forms.Button();
            this.btn_moveLeft = new System.Windows.Forms.Button();
            this.btn_moveLeftAll = new System.Windows.Forms.Button();
            this.lstRemove = new System.Windows.Forms.ListBox();
            this.lstKeep = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_remove);
            this.groupBox1.Controls.Add(this.lbl_remove);
            this.groupBox1.Controls.Add(this.lbl_keep);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // btn_remove
            // 
            this.btn_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remove.Location = new System.Drawing.Point(420, 24);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(123, 43);
            this.btn_remove.TabIndex = 34;
            this.btn_remove.TabStop = false;
            this.btn_remove.Text = "Remove selected class";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // lbl_remove
            // 
            this.lbl_remove.AutoSize = true;
            this.lbl_remove.Location = new System.Drawing.Point(360, 78);
            this.lbl_remove.Name = "lbl_remove";
            this.lbl_remove.Size = new System.Drawing.Size(58, 19);
            this.lbl_remove.TabIndex = 33;
            this.lbl_remove.Text = "Remove";
            // 
            // lbl_keep
            // 
            this.lbl_keep.AutoSize = true;
            this.lbl_keep.Location = new System.Drawing.Point(78, 78);
            this.lbl_keep.Name = "lbl_keep";
            this.lbl_keep.Size = new System.Drawing.Size(39, 19);
            this.lbl_keep.TabIndex = 32;
            this.lbl_keep.Text = "Keep";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFolder.Location = new System.Drawing.Point(338, 32);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(34, 28);
            this.btnSelectFolder.TabIndex = 31;
            this.btnSelectFolder.TabStop = false;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(33, 34);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(299, 25);
            this.txtFolder.TabIndex = 30;
            this.txtFolder.TabStop = false;
            this.txtFolder.TextChanged += new System.EventHandler(this.txtFolder_TextChanged);
            // 
            // bgLoadFile
            // 
            this.bgLoadFile.WorkerReportsProgress = true;
            this.bgLoadFile.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoadFile_DoWork);
            this.bgLoadFile.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoadFile_RunWorkerCompleted);
            // 
            // timerLoading
            // 
            this.timerLoading.Interval = 50;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1,
            this.lblMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(555, 22);
            this.statusStrip1.TabIndex = 38;
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
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // btn_moveRight
            // 
            this.btn_moveRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveRight.Location = new System.Drawing.Point(258, 171);
            this.btn_moveRight.Name = "btn_moveRight";
            this.btn_moveRight.Size = new System.Drawing.Size(38, 29);
            this.btn_moveRight.TabIndex = 41;
            this.btn_moveRight.Text = ">";
            this.btn_moveRight.UseVisualStyleBackColor = true;
            this.btn_moveRight.Click += new System.EventHandler(this.btn_moveRight_Click);
            // 
            // btn_moveRightAll
            // 
            this.btn_moveRightAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveRightAll.Location = new System.Drawing.Point(258, 136);
            this.btn_moveRightAll.Name = "btn_moveRightAll";
            this.btn_moveRightAll.Size = new System.Drawing.Size(38, 29);
            this.btn_moveRightAll.TabIndex = 42;
            this.btn_moveRightAll.Text = ">>";
            this.btn_moveRightAll.UseVisualStyleBackColor = true;
            this.btn_moveRightAll.Click += new System.EventHandler(this.btn_moveRightAll_Click);
            // 
            // btn_moveLeft
            // 
            this.btn_moveLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveLeft.Location = new System.Drawing.Point(258, 206);
            this.btn_moveLeft.Name = "btn_moveLeft";
            this.btn_moveLeft.Size = new System.Drawing.Size(38, 29);
            this.btn_moveLeft.TabIndex = 43;
            this.btn_moveLeft.Text = "<";
            this.btn_moveLeft.UseVisualStyleBackColor = true;
            this.btn_moveLeft.Click += new System.EventHandler(this.btn_moveLeft_Click);
            // 
            // btn_moveLeftAll
            // 
            this.btn_moveLeftAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_moveLeftAll.Location = new System.Drawing.Point(258, 241);
            this.btn_moveLeftAll.Name = "btn_moveLeftAll";
            this.btn_moveLeftAll.Size = new System.Drawing.Size(38, 29);
            this.btn_moveLeftAll.TabIndex = 44;
            this.btn_moveLeftAll.Text = "<<";
            this.btn_moveLeftAll.UseVisualStyleBackColor = true;
            this.btn_moveLeftAll.Click += new System.EventHandler(this.btn_moveLeftAll_Click);
            // 
            // lstRemove
            // 
            this.lstRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.lstRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRemove.FormattingEnabled = true;
            this.lstRemove.ItemHeight = 16;
            this.lstRemove.Location = new System.Drawing.Point(303, 100);
            this.lstRemove.Name = "lstRemove";
            this.lstRemove.Size = new System.Drawing.Size(252, 328);
            this.lstRemove.TabIndex = 40;
            // 
            // lstKeep
            // 
            this.lstKeep.Dock = System.Windows.Forms.DockStyle.Left;
            this.lstKeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstKeep.FormattingEnabled = true;
            this.lstKeep.ItemHeight = 16;
            this.lstKeep.Location = new System.Drawing.Point(0, 100);
            this.lstKeep.Name = "lstKeep";
            this.lstKeep.Size = new System.Drawing.Size(252, 328);
            this.lstKeep.TabIndex = 39;
            // 
            // FormClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 450);
            this.Controls.Add(this.btn_moveLeftAll);
            this.Controls.Add(this.btn_moveLeft);
            this.Controls.Add(this.btn_moveRightAll);
            this.Controls.Add(this.btn_moveRight);
            this.Controls.Add(this.lstRemove);
            this.Controls.Add(this.lstKeep);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClasses";
            this.Text = "FormClasses";
            this.Load += new System.EventHandler(this.FormClasses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnSelectFolder;
        internal System.Windows.Forms.TextBox txtFolder;
        private System.ComponentModel.BackgroundWorker bgLoadFile;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.Label lbl_remove;
        private System.Windows.Forms.Label lbl_keep;
        private System.Windows.Forms.Button btn_moveRight;
        private System.Windows.Forms.Button btn_moveRightAll;
        private System.Windows.Forms.Button btn_moveLeft;
        private System.Windows.Forms.Button btn_moveLeftAll;
        internal System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.ListBox lstRemove;
        private System.Windows.Forms.ListBox lstKeep;
    }
}