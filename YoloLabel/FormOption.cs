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
    public partial class FormOption : Form
    {
        public FormOption()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FormOption_Load(object sender, EventArgs e)
        {
            numFontSize.Value = TGMTregistry.GetInstance().ReadInt("numFontSize", 14);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_save_Click(object sender, EventArgs e)
        {
            TGMTregistry.GetInstance().SaveValue("numFontSize", numFontSize.Value);
        }
    }
}
