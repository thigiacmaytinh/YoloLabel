using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace TGMTcs
{
    public class TGMTimage
    {

        public static Bitmap CorrectOrientation(Bitmap bmp)
        {
            if (bmp == null)
                return null;

            if (Array.IndexOf(bmp.PropertyIdList, 274) > -1)
            {
                var orientation = (int)bmp.GetPropertyItem(274).Value[0];
                switch (orientation)
                {
                    case 1:
                        // No rotation required.
                        break;
                    case 2:
                        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        break;
                    case 3:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        break;
                    case 4:
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                        break;
                    case 5:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipX);
                        break;
                    case 6:
                        bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        break;
                    case 7:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipX);
                        break;
                    case 8:
                        bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        break;
                }
                // This EXIF data is now invalid and should be removed.
                bmp.RemovePropertyItem(274);
            }
            return bmp;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ImageToBase64(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] filebytes = new byte[fs.Length];
            fs.Read(filebytes, 0, Convert.ToInt32(fs.Length));
            fs.Close();
            return "data:image/png;base64," + Convert.ToBase64String(filebytes, Base64FormattingOptions.None);

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static string ImageToBase64(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, ImageFormat.Jpeg);
                byte[] imageBytes = ms.ToArray();

                // Convert byte[] to base 64 string
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static ImageCodecInfo GetJpegCodec()
        {
            foreach (ImageCodecInfo c in ImageCodecInfo.GetImageEncoders())
            {
                if (c.CodecName.ToLower().Contains("jpeg")
                    || c.FilenameExtension.ToLower().Contains("*.jpg")
                    || c.FormatDescription.ToLower().Contains("jpeg")
                    || c.MimeType.ToLower().Contains("image/jpeg"))
                    return c;
            }

            return null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsImage(string fileName)
        {
            string ext = Path.GetExtension(fileName).ToLower();
            return (ext == ".jpg" || ext == ".png" || ext == ".bmp");
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool IsBase64(string base64String)
        {
            // Credit: oybek https://stackoverflow.com/users/794764/oybek
            if (base64String == null || base64String.Length == 0 || base64String.Length % 4 != 0
               || base64String.Contains(" ") || base64String.Contains("\t") || base64String.Contains("\r") || base64String.Contains("\n"))
                return false;

            return true;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ResizeBitmap(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ResizeBitmapByWidth(Image image, int width)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int height = (int)((float)width / ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image ResizeImageByWidth(Image image, int width)
        {
            float ratio = (float)image.Width / (float)image.Height;
            int height = (int)((float)width / ratio);

            return ResizeBitmap(image, width, height);
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap CropBitmap(Bitmap bmp, Rectangle rect)
        {
            if (bmp == null)
                return null;

            if (rect.Width == 0 || rect.Height == 0)
                return bmp;

            if (rect.X + rect.Width > bmp.Width || rect.Y + rect.Height > bmp.Height)
                return bmp;

            Bitmap target = new Bitmap(rect.Width, rect.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(bmp, new Rectangle(0, 0, target.Width, target.Height),
                                 rect,
                                 GraphicsUnit.Pixel);                
            }

            return target;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public static Image CaptureScreen(Rectangle roi)
        {
            if (roi.Width == 0 || roi.Height == 0)
                return null;

            Bitmap target = new Bitmap(roi.Width, roi.Height);
            using (Graphics g = Graphics.FromImage(target))
            {
                g.CopyFromScreen(roi.X, roi.Y, 0, 0, new Size(roi.Width, roi.Height));
            }
            return target;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap LoadBitmapWithoutLock(string imagePath)
        {
            if (!File.Exists(imagePath))
                return null;
            string ext = Path.GetExtension(imagePath).ToLower();
            if(ext == ".jpg" || ext == ".png" || ext == ".bmp")
            {
                var bytes = File.ReadAllBytes(imagePath);
                var ms = new MemoryStream(bytes);
                var img = Image.FromStream(ms, true);
                return (Bitmap)img;
            }
            return null;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static byte[] ImageToBytes(Image image, ImageFormat imageFormat)
        {
            byte[] imageBytes;
            try
            {
                using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                {
                    image.Save(ms, imageFormat);
                    imageBytes = ms.ToArray();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return imageBytes;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Image BytesToImage(byte[] imageBytes)
        {
            Image image;
            try
            {
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imageBytes);
                image = Image.FromStream(ms);
            }
            catch (Exception)
            {
                throw;
            }
            return image;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static int GetNumChannels(Bitmap bitmap)
        {
            int numChannels = 0;

            switch (bitmap.PixelFormat)
            {
                case PixelFormat.Format24bppRgb:
                    numChannels = 3; // RGB
                    break;
                case PixelFormat.Format32bppArgb:
                case PixelFormat.Format32bppPArgb:
                    numChannels = 4; // RGBA
                    break;
                case PixelFormat.Format8bppIndexed:
                    numChannels = 1; // Grayscale or indexed
                    break;
                // Add other cases if needed
                default:
                    numChannels = 0; // Unknown or unsupported format
                    break;
            }

            return numChannels;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap ConvertRGBA2RGB(Bitmap bitmap)
        {
            // Create a new Bitmap with 24bppRgb format (3 channels)
            Bitmap rgbBitmap = new Bitmap(bitmap.Width, bitmap.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            // Iterate through each pixel
            for (int y = 0; y < bitmap.Height; y++)
            {
                for (int x = 0; x < bitmap.Width; x++)
                {
                    // Get the pixel from the original bitmap
                    Color pixelColor = bitmap.GetPixel(x, y);

                    // Create a new color without the alpha channel (RGB only)
                    Color rgbColor = Color.FromArgb(pixelColor.R, pixelColor.G, pixelColor.B);

                    // Set the pixel in the new bitmap
                    rgbBitmap.SetPixel(x, y, rgbColor);
                }
            }

            return rgbBitmap;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public static Bitmap CropToPolygon(Bitmap source, List<Point> polygon)
        {
            // Create a new empty bitmap with the same size as the source
            Bitmap croppedBitmap = new Bitmap(source.Width, source.Height);

            // Create a GraphicsPath from the polygon points
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(polygon.ToArray());

                // Create a Region from the path
                using (Region region = new Region(path))
                {
                    // Create the Graphics object for the new bitmap
                    using (Graphics g = Graphics.FromImage(croppedBitmap))
                    {
                        // Clear the new bitmap with transparent background
                        g.Clear(Color.Transparent);

                        // Set the clipping region to the polygon
                        g.SetClip(region, CombineMode.Replace);

                        // Draw the source image onto the new bitmap using the clipping region
                        g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height));
                    }
                }
            }

            // Crop the resulting bitmap to the bounding rectangle of the polygon
            Rectangle boundingRect = GetPolygonBoundingBox(polygon);
            Bitmap finalCroppedBitmap = croppedBitmap.Clone(boundingRect, croppedBitmap.PixelFormat);

            return finalCroppedBitmap;
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////

        private static Rectangle GetPolygonBoundingBox(List<Point> polygon)
        {
            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;

            foreach (var point in polygon)
            {
                if (point.X < minX) minX = point.X;
                if (point.Y < minY) minY = point.Y;
                if (point.X > maxX) maxX = point.X;
                if (point.Y > maxY) maxY = point.Y;
            }

            return new Rectangle(minX, minY, maxX - minX, maxY - minY);
        }
    }
}
