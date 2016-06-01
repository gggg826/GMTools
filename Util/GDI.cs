using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace FengNiao.GameTools.Util
{
    public class GDI
    {
        public static GraphicsPath FromImageGetGraphicsPath(Bitmap bitmap)
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




        private static Bitmap Transparent(Image image)
        {
            Bitmap sourceBitmap = new Bitmap(image);
            Color c = sourceBitmap.GetPixel(0, 0);
            sourceBitmap.MakeTransparent(c);
            return sourceBitmap;
        }

    }
}
