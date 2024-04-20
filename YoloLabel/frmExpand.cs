using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace YoloLabel
{
    public partial class frmExpand : Form
    {
        public frmExpand()
        {
            InitializeComponent();
        }

        private void txtTop_ValueChanged(object sender, EventArgs e)
        {
            Program.expandTop = (int)txtTop.Value;
        }

        private void txtLeft_ValueChanged(object sender, EventArgs e)
        {
            Program.expandLeft = (int)txtLeft.Value;
        }

        private void txtDown_ValueChanged(object sender, EventArgs e)
        {
            Program.expandDown = (int)txtBottom.Value;
        }

        private void txtRight_ValueChanged(object sender, EventArgs e)
        {
            Program.expandRight = (int)txtRight.Value;
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExpand_Load(object sender, EventArgs e)
        {
            Program.expandDown = 0;
            Program.expandLeft = 0;
            Program.expandRight = 0;
            Program.expandTop = 0;
        }

        private void chkTop_CheckedChanged(object sender, EventArgs e)
        {
            txtTop.Enabled = chkTop.Checked;
        }

        private void chkRight_CheckedChanged(object sender, EventArgs e)
        {
            txtRight.Enabled = chkRight.Checked;
        }

        private void chkBottom_CheckedChanged(object sender, EventArgs e)
        {
            txtBottom.Enabled = chkBottom.Checked;
        }

        private void chkLeft_CheckedChanged(object sender, EventArgs e)
        {
            txtLeft.Enabled = chkLeft.Checked;
        }
    }
}
