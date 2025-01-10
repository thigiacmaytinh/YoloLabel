using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AltoControls
{
    #region AltoPasswordBox

    public class PasswordBox : Control
    {
        int radius = 8;
        public TextBox box = new TextBox();
        GraphicsPath shape;
        GraphicsPath innerRect;
        Color br;
        PictureBox btn = new PictureBox();

        public PasswordBox()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            box.Parent = this;
            Controls.Add(box);

            box.BorderStyle = BorderStyle.None;
            box.TextAlign = HorizontalAlignment.Left;
            box.Font = Font;

            BackColor = Color.Transparent;
            ForeColor = SystemColors.WindowText;
            br = Color.White;
            box.BackColor = br;
            Padding = new Padding(5);
            Text = null;
            Font = new Font("Segoe UI", 12);
            Size = new Size(135, 33);
            DoubleBuffered = true;
            box.KeyDown += box_KeyDown;
            box.TextChanged += box_TextChanged;
            box.MouseDoubleClick += box_MouseDoubleClick;
            box.PasswordChar = '*';

            btn.SizeMode = PictureBoxSizeMode.StretchImage;
            btn.Location = new Point(this.ClientSize.Width - btn.Width -this.Padding.Right, -1);
            btn.Cursor = Cursors.Default;
            btn.Click += Btn_Click;
            btn.Image = Properties.Resources.eye_32;
            this.Controls.Add(btn);
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if(box.PasswordChar == '\0')
                box.PasswordChar = '*';
            else
                box.PasswordChar = '\0';
        }

        void box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left) return;

            box.SelectAll();
        }

        void box_TextChanged(object sender, EventArgs e)
        {
            Text = box.Text;
        }
        public void SelectAll()
        {
            box.SelectAll();
        }
        void box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                box.SelectionStart = 0;
                box.SelectionLength = Text.Length;
            }
        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            box.Text = Text;
        }
        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            box.Font = Font;
            Invalidate();
        }
        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);
            box.ForeColor = ForeColor;
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            shape = new RoundedRectangleF(Width, Height, radius).Path;


            innerRect = new RoundedRectangleF(Width - 0.5f, Height - 0.5f, radius, 0.5f, 0.5f).Path;
            if (box.Height >= Height - 4)
                Height = box.Height + 4;
            box.Location = new Point(radius , Height / 2 - box.Font.Height / 2);
            box.Width = Width - (int)(radius * 1.5) - btn.Width - this.Padding.Right;

            btn.Size = new Size(this.Height - this.Padding.Top - this.Padding.Bottom, this.Height - this.Padding.Top - this.Padding.Bottom);
            btn.Location = new Point(this.ClientSize.Width - btn.Width - this.Padding.Right, this.Padding.Top);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            Bitmap bmp = new Bitmap(Width, Height);
            Graphics grp = Graphics.FromImage(bmp);
            e.Graphics.DrawPath(Pens.Gray, shape);
            using (SolidBrush brush = new SolidBrush(br))
                e.Graphics.FillPath(brush, innerRect);
            Transparenter.MakeTransparent(this, e.Graphics);

            base.OnPaint(e);
        }
        public Color Br
        {
            get
            {
                return br;
            }
            set
            {
                br = value;
                if (br != Color.Transparent)
                    box.BackColor = br;
                Invalidate();
            }
        }
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = Color.Transparent;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                this.radius = value;
                Invalidate();
            }
        }

        public event KeyEventHandler KeyUp
        {
            add { box.KeyUp += value; }
            remove { box.KeyUp -= value; }
        }
    }

    #endregion
}
