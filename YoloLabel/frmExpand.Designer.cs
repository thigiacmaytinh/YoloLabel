namespace YoloLabel
{
    partial class frmExpand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpand));
            this.txtTop = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.NumericUpDown();
            this.txtBottom = new System.Windows.Forms.NumericUpDown();
            this.txtRight = new System.Windows.Forms.NumericUpDown();
            this.btnExpand = new System.Windows.Forms.Button();
            this.chkBottom = new System.Windows.Forms.CheckBox();
            this.chkLeft = new System.Windows.Forms.CheckBox();
            this.chkTop = new System.Windows.Forms.CheckBox();
            this.chkRight = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTop
            // 
            this.txtTop.Enabled = false;
            this.txtTop.Location = new System.Drawing.Point(156, 47);
            this.txtTop.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(75, 20);
            this.txtTop.TabIndex = 0;
            this.txtTop.ValueChanged += new System.EventHandler(this.txtTop_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unit: pixel";
            // 
            // txtLeft
            // 
            this.txtLeft.Enabled = false;
            this.txtLeft.Location = new System.Drawing.Point(52, 119);
            this.txtLeft.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(75, 20);
            this.txtLeft.TabIndex = 3;
            this.txtLeft.ValueChanged += new System.EventHandler(this.txtLeft_ValueChanged);
            // 
            // txtBottom
            // 
            this.txtBottom.Enabled = false;
            this.txtBottom.Location = new System.Drawing.Point(156, 183);
            this.txtBottom.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtBottom.Name = "txtBottom";
            this.txtBottom.Size = new System.Drawing.Size(75, 20);
            this.txtBottom.TabIndex = 5;
            this.txtBottom.ValueChanged += new System.EventHandler(this.txtDown_ValueChanged);
            // 
            // txtRight
            // 
            this.txtRight.Enabled = false;
            this.txtRight.Location = new System.Drawing.Point(260, 119);
            this.txtRight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txtRight.Name = "txtRight";
            this.txtRight.Size = new System.Drawing.Size(75, 20);
            this.txtRight.TabIndex = 7;
            this.txtRight.ValueChanged += new System.EventHandler(this.txtRight_ValueChanged);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(147, 246);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(98, 43);
            this.btnExpand.TabIndex = 9;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // chkBottom
            // 
            this.chkBottom.AutoSize = true;
            this.chkBottom.Location = new System.Drawing.Point(156, 154);
            this.chkBottom.Name = "chkBottom";
            this.chkBottom.Size = new System.Drawing.Size(97, 17);
            this.chkBottom.TabIndex = 10;
            this.chkBottom.Text = "Expand bottom";
            this.chkBottom.UseVisualStyleBackColor = true;
            this.chkBottom.CheckedChanged += new System.EventHandler(this.chkBottom_CheckedChanged);
            // 
            // chkLeft
            // 
            this.chkLeft.AutoSize = true;
            this.chkLeft.Location = new System.Drawing.Point(53, 94);
            this.chkLeft.Name = "chkLeft";
            this.chkLeft.Size = new System.Drawing.Size(79, 17);
            this.chkLeft.TabIndex = 11;
            this.chkLeft.Text = "Expand left";
            this.chkLeft.UseVisualStyleBackColor = true;
            this.chkLeft.CheckedChanged += new System.EventHandler(this.chkLeft_CheckedChanged);
            // 
            // chkTop
            // 
            this.chkTop.AutoSize = true;
            this.chkTop.Location = new System.Drawing.Point(156, 24);
            this.chkTop.Name = "chkTop";
            this.chkTop.Size = new System.Drawing.Size(80, 17);
            this.chkTop.TabIndex = 12;
            this.chkTop.Text = "Expand top";
            this.chkTop.UseVisualStyleBackColor = true;
            this.chkTop.CheckedChanged += new System.EventHandler(this.chkTop_CheckedChanged);
            // 
            // chkRight
            // 
            this.chkRight.AutoSize = true;
            this.chkRight.Location = new System.Drawing.Point(260, 94);
            this.chkRight.Name = "chkRight";
            this.chkRight.Size = new System.Drawing.Size(85, 17);
            this.chkRight.TabIndex = 13;
            this.chkRight.Text = "Expand right";
            this.chkRight.UseVisualStyleBackColor = true;
            this.chkRight.CheckedChanged += new System.EventHandler(this.chkRight_CheckedChanged);
            // 
            // frmExpand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 319);
            this.Controls.Add(this.chkRight);
            this.Controls.Add(this.chkTop);
            this.Controls.Add(this.chkLeft);
            this.Controls.Add(this.chkBottom);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.txtRight);
            this.Controls.Add(this.txtBottom);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpand";
            this.Text = "Expand";
            this.Load += new System.EventHandler(this.frmExpand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtLeft;
        private System.Windows.Forms.NumericUpDown txtBottom;
        private System.Windows.Forms.NumericUpDown txtRight;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.CheckBox chkBottom;
        private System.Windows.Forms.CheckBox chkLeft;
        private System.Windows.Forms.CheckBox chkTop;
        private System.Windows.Forms.CheckBox chkRight;
    }
}