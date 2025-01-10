namespace WindowsFormsApp2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.browseFile1 = new AltoControls.BrowseFile();
            this.browseDir1 = new AltoControls.BrowseDir();
            this.altoButton2 = new AltoControls.AltoButton();
            this.passwordBox1 = new AltoControls.PasswordBox();
            this.processingControl1 = new AltoControls.ProcessingControl();
            this.slideButton1 = new AltoControls.SlideButton();
            this.spinningCircles1 = new AltoControls.SpinningCircles();
            this.circularPB1 = new AltoControls.CircularPB();
            this.altoTextBox1 = new AltoControls.AltoTextBox();
            this.altoSlidingLabel1 = new AltoControls.AltoSlidingLabel();
            this.altoPB1 = new AltoControls.AltoProgressBar();
            this.altoNMUpDown1 = new AltoControls.AltoNMUpDown();
            this.altoButton1 = new AltoControls.AltoButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Numeric control";
            // 
            // browseFile1
            // 
            this.browseFile1.BackColor = System.Drawing.Color.Transparent;
            this.browseFile1.Br = System.Drawing.Color.White;
            this.browseFile1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.browseFile1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.browseFile1.Location = new System.Drawing.Point(321, 192);
            this.browseFile1.Name = "browseFile1";
            this.browseFile1.Padding = new System.Windows.Forms.Padding(5);
            this.browseFile1.Size = new System.Drawing.Size(328, 33);
            this.browseFile1.TabIndex = 15;
            this.browseFile1.Text = "browseFile1";
            // 
            // browseDir1
            // 
            this.browseDir1.BackColor = System.Drawing.Color.Transparent;
            this.browseDir1.Br = System.Drawing.Color.White;
            this.browseDir1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.browseDir1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.browseDir1.Location = new System.Drawing.Point(321, 143);
            this.browseDir1.Name = "browseDir1";
            this.browseDir1.Padding = new System.Windows.Forms.Padding(5);
            this.browseDir1.Size = new System.Drawing.Size(328, 33);
            this.browseDir1.TabIndex = 14;
            this.browseDir1.Text = "browseDir1";
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton2.ForeColor = System.Drawing.Color.White;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.Red;
            this.altoButton2.Location = new System.Drawing.Point(177, 24);
            this.altoButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(121, 61);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 12;
            this.altoButton2.Text = "Danger button";
            this.altoButton2.Transparency = false;
            // 
            // passwordBox1
            // 
            this.passwordBox1.BackColor = System.Drawing.Color.Transparent;
            this.passwordBox1.Br = System.Drawing.Color.White;
            this.passwordBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordBox1.Location = new System.Drawing.Point(321, 87);
            this.passwordBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordBox1.Name = "passwordBox1";
            this.passwordBox1.Padding = new System.Windows.Forms.Padding(5);
            this.passwordBox1.Size = new System.Drawing.Size(328, 39);
            this.passwordBox1.TabIndex = 10;
            this.passwordBox1.Text = "passwordBox1";
            this.passwordBox1.Click += new System.EventHandler(this.passwordBox1_Click);
            // 
            // processingControl1
            // 
            this.processingControl1.BackColor = System.Drawing.Color.Transparent;
            this.processingControl1.IndexColor = System.Drawing.Color.Gray;
            this.processingControl1.Interval = 100;
            this.processingControl1.Location = new System.Drawing.Point(26, 163);
            this.processingControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processingControl1.Name = "processingControl1";
            this.processingControl1.NCircle = 6;
            this.processingControl1.Others = System.Drawing.Color.LightGray;
            this.processingControl1.Radius = 10;
            this.processingControl1.Size = new System.Drawing.Size(82, 93);
            this.processingControl1.Spin = true;
            this.processingControl1.TabIndex = 8;
            this.processingControl1.Text = "processingControl1";
            // 
            // slideButton1
            // 
            this.slideButton1.BorderColor = System.Drawing.Color.White;
            this.slideButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slideButton1.IsOn = true;
            this.slideButton1.Location = new System.Drawing.Point(20, 297);
            this.slideButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slideButton1.Name = "slideButton1";
            this.slideButton1.Size = new System.Drawing.Size(88, 46);
            this.slideButton1.TabIndex = 7;
            this.slideButton1.Text = "slideButton1";
            this.slideButton1.TextEnabled = true;
            // 
            // spinningCircles1
            // 
            this.spinningCircles1.BackColor = System.Drawing.Color.Transparent;
            this.spinningCircles1.ForeColor = System.Drawing.Color.DarkCyan;
            this.spinningCircles1.FullTransparent = false;
            this.spinningCircles1.Increment = 1F;
            this.spinningCircles1.Interval = 100;
            this.spinningCircles1.Location = new System.Drawing.Point(359, 255);
            this.spinningCircles1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spinningCircles1.N = 8;
            this.spinningCircles1.Name = "spinningCircles1";
            this.spinningCircles1.Radius = 2.5F;
            this.spinningCircles1.Size = new System.Drawing.Size(103, 88);
            this.spinningCircles1.TabIndex = 6;
            this.spinningCircles1.Text = "spinningCircles1";
            // 
            // circularPB1
            // 
            this.circularPB1.AllowText = true;
            this.circularPB1.AutomaticFontCalculation = true;
            this.circularPB1.BackColor = System.Drawing.Color.Transparent;
            this.circularPB1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularPB1.Location = new System.Drawing.Point(177, 263);
            this.circularPB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularPB1.MaxValue = 100;
            this.circularPB1.MinimumSize = new System.Drawing.Size(90, 97);
            this.circularPB1.MinValue = 0;
            this.circularPB1.Name = "circularPB1";
            this.circularPB1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.circularPB1.Size = new System.Drawing.Size(120, 120);
            this.circularPB1.Stroke = 10;
            this.circularPB1.TabIndex = 5;
            this.circularPB1.Text = "circularPB1";
            this.circularPB1.Transparency = true;
            this.circularPB1.Value = 100;
            // 
            // altoTextBox1
            // 
            this.altoTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.altoTextBox1.Br = System.Drawing.Color.White;
            this.altoTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.altoTextBox1.Location = new System.Drawing.Point(321, 36);
            this.altoTextBox1.Margin = new System.Windows.Forms.Padding(8);
            this.altoTextBox1.Name = "altoTextBox1";
            this.altoTextBox1.Padding = new System.Windows.Forms.Padding(45, 48, 45, 48);
            this.altoTextBox1.Size = new System.Drawing.Size(328, 38);
            this.altoTextBox1.TabIndex = 4;
            this.altoTextBox1.Text = "Text box";
            // 
            // altoSlidingLabel1
            // 
            this.altoSlidingLabel1.Location = new System.Drawing.Point(518, 263);
            this.altoSlidingLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altoSlidingLabel1.Name = "altoSlidingLabel1";
            this.altoSlidingLabel1.Size = new System.Drawing.Size(98, 32);
            this.altoSlidingLabel1.Slide = false;
            this.altoSlidingLabel1.TabIndex = 3;
            this.altoSlidingLabel1.Text = "altoSlidingLabel1";
            // 
            // altoPB1
            // 
            this.altoPB1.Location = new System.Drawing.Point(49, 418);
            this.altoPB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altoPB1.MaxValue = 100;
            this.altoPB1.MinValue = 0;
            this.altoPB1.Name = "altoPB1";
            this.altoPB1.ProgressColor = System.Drawing.Color.RoyalBlue;
            this.altoPB1.Size = new System.Drawing.Size(280, 48);
            this.altoPB1.TabIndex = 2;
            this.altoPB1.Text = "altoPB1";
            this.altoPB1.Value = 7;
            // 
            // altoNMUpDown1
            // 
            this.altoNMUpDown1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.altoNMUpDown1.Location = new System.Drawing.Point(359, 418);
            this.altoNMUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altoNMUpDown1.Name = "altoNMUpDown1";
            this.altoNMUpDown1.Padding = new System.Windows.Forms.Padding(3);
            this.altoNMUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.altoNMUpDown1.SignColor = System.Drawing.Color.White;
            this.altoNMUpDown1.Size = new System.Drawing.Size(148, 49);
            this.altoNMUpDown1.TabIndex = 1;
            this.altoNMUpDown1.Text = "altoNMUpDown1";
            this.altoNMUpDown1.Value = 0D;
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(168)))), ((int)(((byte)(183)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(164)))), ((int)(((byte)(183)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoButton1.ForeColor = System.Drawing.Color.White;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(188)))), ((int)(((byte)(210)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(167)))), ((int)(((byte)(188)))));
            this.altoButton1.Location = new System.Drawing.Point(26, 24);
            this.altoButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(121, 61);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 0;
            this.altoButton1.Text = "Normal button";
            this.altoButton1.Transparency = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 499);
            this.Controls.Add(this.browseFile1);
            this.Controls.Add(this.browseDir1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.passwordBox1);
            this.Controls.Add(this.processingControl1);
            this.Controls.Add(this.slideButton1);
            this.Controls.Add(this.spinningCircles1);
            this.Controls.Add(this.circularPB1);
            this.Controls.Add(this.altoTextBox1);
            this.Controls.Add(this.altoSlidingLabel1);
            this.Controls.Add(this.altoPB1);
            this.Controls.Add(this.altoNMUpDown1);
            this.Controls.Add(this.altoButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AltoControls.AltoButton altoButton1;
        private AltoControls.AltoNMUpDown altoNMUpDown1;
        private AltoControls.AltoProgressBar altoPB1;
        private AltoControls.AltoSlidingLabel altoSlidingLabel1;
        private AltoControls.AltoTextBox altoTextBox1;
        private AltoControls.CircularPB circularPB1;
        private AltoControls.SpinningCircles spinningCircles1;
        private AltoControls.SlideButton slideButton1;
        private AltoControls.ProcessingControl processingControl1;
        private AltoControls.PasswordBox passwordBox1;
        private AltoControls.AltoButton altoButton2;
        private System.Windows.Forms.Label label1;
        private AltoControls.BrowseDir browseDir1;
        private AltoControls.BrowseFile browseFile1;
    }
}

