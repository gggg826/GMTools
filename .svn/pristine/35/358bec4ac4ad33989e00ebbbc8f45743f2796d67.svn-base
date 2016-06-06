using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FengNiao.GameTools.Util
{
    public class CustomContextMenuStripRenderer : ToolStripProfessionalRenderer, IDisposable
    {

        #region 构造函数

        public CustomContextMenuStripRenderer()
            : base()
        {
        }
        ~CustomContextMenuStripRenderer()
        {
            if (_menuStrip_MouseEnterImage != null)
            {
                _menuStrip_MouseEnterImage.Dispose();
            }
            if (_menuStrip_MouseDownImage != null)
            {
                _menuStrip_MouseDownImage.Dispose();
            }
            if (_toolStripDropDown_MouseEnterImage != null)
            {
                _toolStripDropDown_MouseEnterImage.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool m_disposed;


        protected virtual void Dispose(bool disposing)
        {
            if (!m_disposed)
            {
                if (disposing)
                {
                    // Release managed resources
                }

                // Release unmanaged resources

                m_disposed = true;
            }
        }




        #endregion


        #region 基本属性

        private Image _menuStrip_MouseEnterImage;
        public Image menuStrip_MouseEnterImage
        {
            set { _menuStrip_MouseEnterImage = value; }
            get { return _menuStrip_MouseEnterImage; }
        }

        private Image _menuStrip_MouseDownImage;
        public Image menuStrip_MouseDownImage
        {
            set { _menuStrip_MouseDownImage = value; }
            get { return _menuStrip_MouseDownImage; }
        }

        private Image _toolStripDropDown_MouseEnterImage;
        public Image toolStripDropDown_MouseEnterImage
        {
            set { _toolStripDropDown_MouseEnterImage = value; }
            get { return _toolStripDropDown_MouseEnterImage; }
        }

        #endregion

        #region 重画菜单的激活与选中样式

        /// <summary>
        /// 画菜单激活与选中的样式
        /// </summary>
        /// <param name="e"></param>

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            System.Drawing.Graphics g = e.Graphics;
            ToolStripItem item = e.Item;
            ToolStrip toolstrip = e.ToolStrip;
            if (toolstrip is MenuStrip)
            {
                if (e.Item.Selected)
                {
                    using (Bitmap mouse_EnterBitmap = new Bitmap(_menuStrip_MouseEnterImage))
                    {
                        using (Brush mouse_EnterBrush = new TextureBrush(mouse_EnterBitmap))
                        {
                            using (GraphicsPath gp = Graphics.CalculateControlGraphicsPath(mouse_EnterBitmap))
                            {
                                g.DrawImage(mouse_EnterBitmap, 0, 0, item.Width, item.Height);
                            }
                        }
                    }
                }
                if (item.Pressed)
                {
                    using (Bitmap mouse_DownBitmap = new Bitmap(_menuStrip_MouseDownImage))
                    {
                        using (Brush mouse_DownBrush = new TextureBrush(mouse_DownBitmap))
                        {
                            using (GraphicsPath gp = Graphics.CalculateControlGraphicsPath(mouse_DownBitmap))
                            {
                                g.DrawImage(mouse_DownBitmap, 0, 0, item.Width, item.Height);
                            }
                        }
                    }
                }
            }
            if (toolstrip is ToolStripDropDown)
            {

                if (e.Item.Selected)
                {

                    g.FillRectangle(new SolidBrush(Color.FromArgb(255, 51, 153, 255)), 3, 0, e.Item.Width, e.Item.Height);
                    //Bitmap mouse_EnterBitmap = new Bitmap(toolStripDropDown_MouseEnterImage);
                    //using (Bitmap mouse_EnterBitmap1 = mouse_EnterBitmap.Clone(new Rectangle(new Point(0, 0), new Size(mouse_EnterBitmap.Width / 3, mouse_EnterBitmap.Height)), System.Drawing.Imaging.PixelFormat.Undefined))
                    //{
                    //    using (Bitmap mouse_EnterBitmap2 = mouse_EnterBitmap.Clone(new Rectangle(new Point(mouse_EnterBitmap1.Width, 0), new Size(mouse_EnterBitmap.Width / 3, mouse_EnterBitmap.Height)), System.Drawing.Imaging.PixelFormat.Undefined))
                    //    {
                    //        using (Bitmap mouse_EnterBitmap3 = mouse_EnterBitmap.Clone(new Rectangle(new Point(mouse_EnterBitmap1.Width + mouse_EnterBitmap1.Width, 0), new Size(mouse_EnterBitmap.Width / 3, mouse_EnterBitmap.Height)), System.Drawing.Imaging.PixelFormat.Undefined))
                    //        {
                    //            g.DrawImage(mouse_EnterBitmap1, 2, 0, mouse_EnterBitmap1.Width, item.Height);
                    //            g.DrawImage(mouse_EnterBitmap2, mouse_EnterBitmap1.Width, 0, item.Width - mouse_EnterBitmap1.Width - mouse_EnterBitmap3.Width + 6, item.Height);
                    //            g.DrawImage(mouse_EnterBitmap3, mouse_EnterBitmap1.Width + (item.Width - mouse_EnterBitmap1.Width - mouse_EnterBitmap3.Width) - 1, 0, mouse_EnterBitmap3.Width, item.Height);
                    //        }
                    //    }
                    //}
                }
            }
        }

        #endregion

        #region 重画菜单左边的竖条

        /// <summary>
        /// 画菜单左边竖条
        /// </summary>
        /// <param name="e"></param>

        protected override void OnRenderImageMargin(ToolStripRenderEventArgs e)
        {
            ToolStrip toolStrip = e.ToolStrip;
            if (toolStrip is ToolStripDropDown)
            {
                System.Drawing.Graphics g = e.Graphics;
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(255, 124, 124, 124)))
                {
                    g.FillRectangle(brush, new Rectangle(2, 2, e.AffectedBounds.Width - 5, e.AffectedBounds.Height - 4));
                }
            }

        }

        #endregion

        #region 重画菜单边框

        /// <summary>
        /// 画菜单边框
        /// </summary>
        /// <param name="e"></param>

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {

            ToolStrip toolStrip = e.ToolStrip;
            System.Drawing.Graphics g = e.Graphics;
            Rectangle bounds = e.AffectedBounds;
            if (toolStrip is ToolStripDropDown)
            {
                Rectangle rect = new Rectangle(new Point(0, 0), new Size(toolStrip.Width - 1, toolStrip.Height - 1));
                using (Pen pen = new Pen(Color.Gainsboro))
                {
                    g.DrawRectangle(pen, rect);
                }
            }
            if (toolStrip is MenuStrip)
            {
                base.OnRenderToolStripBorder(e);
            }
            //g.Dispose();
        }

        #endregion

        #region 重画菜单文字

        /// <summary>
        /// 画菜单文字
        /// </summary>
        /// <param name="e"></param>

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            //ToolStrip toolStrip = e.ToolStrip;
            //System.Drawing.Graphics g = e.Graphics;
            //if (toolStrip is ToolStripDropDown)
            //{
            //    using (SolidBrush brush = new SolidBrush(Color.Black))
            //    {
            //        g.DrawString(e.Text, e.TextFont, brush, 25, 2);
            //        e.Item.TextAlign = ContentAlignment.MiddleLeft;
            //    }
            //}
            //if (toolStrip is MenuStrip)
            //{
            //    e.TextColor = Color.Silver;
            //    base.OnRenderItemText(e);
            //    if (e.Item.Pressed)
            //    {
            //        e.TextColor = Color.White;
            //        base.OnRenderItemText(e);
            //    }
            //}
            //g.Dispose();
        }

        #endregion
    }
}
