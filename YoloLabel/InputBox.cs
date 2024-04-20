using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace YoloLabel
{

    public partial class InputBox : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private static InputBox messageBox;
        public enum InputBoxAction { OK, No, NULL }
        public enum InputBoxType { Close, DongYKhong, DongYKhongDong }
        InputBox.InputBoxAction m_action;
        public string result = "";

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public InputBox(string message)
        {
            InitializeComponent();
            lbl_text.Text = message;
        }
        
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string Show(string text)
        {
            messageBox = new InputBox(text);
            messageBox.ShowDialog();
            return messageBox.result;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void btn_ok_Click(object sender, EventArgs e)
        {
            m_action = InputBoxAction.OK;
            Close();
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void MessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                m_action = InputBoxAction.NULL;
                Close();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if(txt_input.Text != "")
                {
                    result = txt_input.Text;
                    m_action = InputBoxAction.OK;
                    Close();
                }
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void lblCaption_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void InputBox_FormClosed(object sender, FormClosedEventArgs e)
        {
            result = txt_input.Text;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            txt_input.Focus();
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    public class InputBoxResult
    {
        InputBox.InputBoxAction action = InputBox.InputBoxAction.NULL;
        string text = "";

        public InputBoxResult(InputBox.InputBoxAction _action, string _text)
        {
            action = _action;
            text = _text;
        }
    }
}
