using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace AltoControls
{
    [Description("Text")]
    public class ImageButton : Control
    {
        #region Variables
        int radius;
        bool transparency;
        MouseState state;
        RoundedRectangleF roundedRect;
        Color inactive1, inactive2;
        private Color strokeColor;

        Image m_backgroundImage;

        Image m_hoverImage;

        #endregion

        #region AltoButton
        public ImageButton()
        {
            Width = 32;
            Height = 32;
            strokeColor = Color.Gray;
            inactive1 = Color.DeepSkyBlue;
            inactive2 = Color.DodgerBlue;

            radius = 10;
            roundedRect = new RoundedRectangleF(Width, Height, radius);

            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.UserPaint, true);
            BackColor = Color.Transparent;
            ForeColor = Color.White;
            Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
            state = MouseState.Leave;
            transparency = false;

        }
        #endregion
        #region Events

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            base.OnClick(e);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            Invalidate();
            base.OnEnabledChanged(e);
        }
        protected override void OnResize(EventArgs e)
        {
            Invalidate();
            base.OnResize(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            if (m_backgroundImage == null)
                m_backgroundImage = BackgroundImage;


            if (m_hoverImage == null)
                m_hoverImage = ReduceBrightness((Bitmap)m_backgroundImage, 30);

                BackgroundImage = m_hoverImage;

            state = MouseState.Enter;
            base.OnMouseEnter(e);
            Invalidate();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            BackgroundImage = m_backgroundImage;

            state = MouseState.Leave;
            base.OnMouseLeave(e);
            Invalidate();
        }
      
        #endregion
        #region Properties

        public Image HoverImage
        {
            get
            {
                return m_hoverImage;
            }
            set
            {
                m_hoverImage = value;
                Invalidate();
            }
        }
     

        #endregion

        public Bitmap ReduceBrightness(Bitmap original, int brightnessReduction)
        {
            Bitmap adjustedImage = new Bitmap(original.Width, original.Height);

            for (int y = 0; y < original.Height; y++)
            {
                for (int x = 0; x < original.Width; x++)
                {
                    Color originalColor = original.GetPixel(x, y);
                    int r = Math.Max(0, originalColor.R - brightnessReduction);
                    int g = Math.Max(0, originalColor.G - brightnessReduction);
                    int b = Math.Max(0, originalColor.B - brightnessReduction);
                    Color adjustedColor = Color.FromArgb(originalColor.A, r, g, b);
                    adjustedImage.SetPixel(x, y, adjustedColor);
                }
            }

            return adjustedImage;
        }
    }

}
