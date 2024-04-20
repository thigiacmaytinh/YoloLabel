namespace YoloLabel
{
    partial class FormRemoveObjectBySize
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
            this.label2 = new System.Windows.Forms.Label();
            this.numMinWidth = new System.Windows.Forms.NumericUpDown();
            this.numMinHeight = new System.Windows.Forms.NumericUpDown();
            this.btn_run = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numMinWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHeight)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Min width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(206, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Min height";
            // 
            // numMinWidth
            // 
            this.numMinWidth.Location = new System.Drawing.Point(83, 29);
            this.numMinWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinWidth.Name = "numMinWidth";
            this.numMinWidth.Size = new System.Drawing.Size(92, 20);
            this.numMinWidth.TabIndex = 4;
            this.numMinWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numMinHeight
            // 
            this.numMinHeight.Location = new System.Drawing.Point(282, 30);
            this.numMinHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numMinHeight.Name = "numMinHeight";
            this.numMinHeight.Size = new System.Drawing.Size(92, 20);
            this.numMinHeight.TabIndex = 5;
            this.numMinHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btn_run
            // 
            this.btn_run.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_run.Location = new System.Drawing.Point(429, 24);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(75, 29);
            this.btn_run.TabIndex = 6;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 136);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(571, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progressBar1
            // 
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // FormRemoveObjectBySize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 158);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_run);
            this.Controls.Add(this.numMinHeight);
            this.Controls.Add(this.numMinWidth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRemoveObjectBySize";
            this.Text = "FormRemoveObjectBySize";
            this.Load += new System.EventHandler(this.FormRemoveObjectBySize_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMinWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinHeight)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinWidth;
        private System.Windows.Forms.NumericUpDown numMinHeight;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}