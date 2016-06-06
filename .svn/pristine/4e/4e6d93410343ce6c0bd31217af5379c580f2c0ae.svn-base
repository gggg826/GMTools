using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FengNiao.GameTools.Util
{
    public class Graphics
    {
        #region 图形函数

        /// <summary>
        /// 根据图形生成路径
        /// </summary>
        /// <param name="bitmap">生成路径所使用的图片</param>
        /// <returns>返回路径</returns>

        public static GraphicsPath CalculateControlGraphicsPath(Bitmap bitmap)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            Color colorTransparent = bitmap.GetPixel(0, 0);
            int colOpaquePixel = 0;
            for (int row = 0; row < bitmap.Height; row++)
            {
                colOpaquePixel = 0;
                for (int col = 0; col < bitmap.Width; col++)
                {
                    if (bitmap.GetPixel(col, row) != colorTransparent)
                    {
                        colOpaquePixel = col;
                        int colNext = col;
                        for (colNext = colOpaquePixel; colNext < bitmap.Width; colNext++)
                            if (bitmap.GetPixel(colNext, row) == colorTransparent)
                                break;
                        graphicsPath.AddRectangle(new Rectangle(colOpaquePixel,
                         row, colNext - colOpaquePixel, 1));
                        col = colNext;
                    }
                }
            }
            return graphicsPath;
        }


        /// <summary>
        /// 根据不同状态来获取制订大图中的一张小图
        /// </summary>
        /// <param name="imagePath">要更改的图片路径</param>
        /// <param name="imageSize">图片的分辨率</param>
        /// <param name="blockNumber">要把一张大图分割成小图的数量</param>
        /// <param name="selectNumber">将要返回的图片索引，即图片的状态</param>
        /// <param name="isTransprent">是否接受透明</param>
        public static Bitmap GetButtonBackgroundImage(string imagePath, int blockNumber, int selectNumber, bool isTransprent)
        {
            try
            {
                Bitmap sourcebitmap = (Bitmap)Bitmap.FromFile(imagePath);
                int width = sourcebitmap.Size.Width / blockNumber;
                int height = sourcebitmap.Size.Height;
                Rectangle rectDesc = new Rectangle((selectNumber - 1) * width, 0, width, height);
                Bitmap bitmapDesc = sourcebitmap.Clone(rectDesc, System.Drawing.Imaging.PixelFormat.Undefined);
                if (isTransprent)
                {
                    Color transparentColor = bitmapDesc.GetPixel(0, 0);
                }
                //bitmapDesc.MakeTransparent(transparentColor);
                return bitmapDesc;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }


        /// <summary>
        /// 根据不同状态来获取制订大图中的一张小图
        /// </summary>
        /// <param name="imagePath">要更改的图片路径</param>
        /// <param name="imageSize">图片的分辨率</param>
        /// <param name="blockNumber">要把一张大图分割成小图的数量</param>
        /// <param name="selectNumber">将要返回的图片索引，即图片的状态</param>
        /// <param name="isTransprent">是否接受透明</param>
        public static Bitmap GetButtonBackgroundImage(Image image, int blockNumber, int selectNumber, bool isTransprent)
        {
            try
            {
                Bitmap sourcebitmap = (Bitmap)image;
                int width = sourcebitmap.Size.Width / blockNumber;
                int height = sourcebitmap.Size.Height;
                Rectangle rectDesc = new Rectangle((selectNumber - 1) * width, 0, width, height);
                Bitmap bitmapDesc = sourcebitmap.Clone(rectDesc, System.Drawing.Imaging.PixelFormat.Undefined);
                if (isTransprent)
                {
                    Color transparentColor = bitmapDesc.GetPixel(0, 0);
                }
                //bitmapDesc.MakeTransparent(transparentColor);
                return bitmapDesc;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }


        public static Bitmap GetButtonBackgroundImage(Image image, int blockNumber, int selectNumber)
        {
            try
            {
                Bitmap sourcebitmap = new Bitmap(image);
                int width = sourcebitmap.Size.Width / blockNumber;
                int height = sourcebitmap.Size.Height;
                Rectangle rectDesc = new Rectangle((selectNumber - 1) * width, 0, width, height);
                Bitmap bitmapDesc = sourcebitmap.Clone(rectDesc, System.Drawing.Imaging.PixelFormat.Undefined);
                Color transparentColor = bitmapDesc.GetPixel(0, 0);
                bitmapDesc.MakeTransparent(transparentColor);

                return bitmapDesc;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private Bitmap Transparent(string imagePath)
        {
            try
            {
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromFile(imagePath);
                Color c = sourceBitmap.GetPixel(1, 1);
                sourceBitmap.MakeTransparent(c);
                Bitmap descBitmap = (Bitmap)sourceBitmap.Clone();
                return descBitmap;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private Bitmap CreateTranspanrentRect(string imagePath)
        {
            try
            {
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromFile(imagePath);
                for (int i = 0; i < sourceBitmap.Width; i++)
                {
                    for (int j = 0; j < sourceBitmap.Height; j++)
                    {
                        Color c = sourceBitmap.GetPixel(i, j);
                        sourceBitmap.MakeTransparent(c);
                    }
                }
                return sourceBitmap;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region 算术函数

        /// <summary>
        /// 求最大数
        /// </summary>
        /// <param name="a">数一</param>
        /// <param name="b">数二</param>
        /// <returns>返回最大数</returns>
        /// 
        public static int Max(int a, int b)
        {
            int temp = a >= b ? a : b;
            return temp;
        }

        #endregion

        #region 返回资源文件中的图片流

        public static Bitmap GetResBitmap(string str)
        {
            Stream sm;
            sm = FindStream(str);
            if (sm == null) return null;
            return new Bitmap(sm);
        }

        private static Stream FindStream(string str)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            string[] resNames = assembly.GetManifestResourceNames();
            foreach (string s in resNames)
            {
                if (s == str)
                {
                    return assembly.GetManifestResourceStream(s);
                }
            }
            return null;
        }
        #endregion

        #region 窗体拖动API

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        #endregion

    }
}
