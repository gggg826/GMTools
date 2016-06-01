using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FengNiao.GameTools.Util
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            titleAlign = TitleAlignment.Center;
            MaximizeBox = false;
            MinimizeBox = false;
            btnMax.Visible = false;
            btnMin.Visible = false;
            maxChangeWidth = true;
            maxLocation = MaxLocation.Left;
            clientBounds = new Rectangle();
            IsShowCaptionText = true;
            IsShowCaptionImage = true;
            IsTitleSplitLine = true;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == Win32API.WM_GETMINMAXINFO)
            {
                Win32API.MINMAXINFO mmi = (Win32API.MINMAXINFO)m.GetLParam(typeof(Win32API.MINMAXINFO));
                mmi.ptMinTrackSize.x = this.MinimumSize.Width;
                mmi.ptMinTrackSize.y = this.MinimumSize.Height;
                if (this.MaximumSize.Width != 0 || this.MaximumSize.Height != 0)
                {
                    mmi.ptMaxTrackSize.x = this.MaximumSize.Width;
                    mmi.ptMaxTrackSize.y = this.MaximumSize.Height;
                }
                if (this.MaximumLocation == MaxLocation.Left)
                {
                    mmi.ptMaxPosition.x = 0;
                    mmi.ptMaxPosition.y = 0;
                }
                else if (this.MaximumLocation == MaxLocation.Center)
                {
                    Screen screen = Screen.FromControl(this);
                    mmi.ptMaxPosition.x = (screen.WorkingArea.Width - this.MaximumSize.Width) / 2;
                    mmi.ptMaxPosition.y = 0; 
                }
                else if (this.MaximumLocation == MaxLocation.Right)
                {
                    Screen screen = Screen.FromControl(this);
                    mmi.ptMaxPosition.x = screen.WorkingArea.Width - this.MaximumSize.Width;
                    mmi.ptMaxPosition.y = 0; ;
                }
                System.Runtime.InteropServices.Marshal.StructureToPtr(mmi, m.LParam, true);
            }
            //base.WndProc(ref m);
        }

        int borderWidth = 6;
        bool isFront;

        public new string Text
        {
            get { return this.pbTitleCaption.Text; }
            set { this.pbTitleCaption.Text = value; RefreshLayout(); }
        }

        public new Image Image
        {
            get { return this.pbTitleImage.Image; }
            set { this.pbTitleImage.Image = value; }
        }
        /// <summary>
        /// 是否显示最大化按钮
        /// </summary>
        public new bool MaximizeBox
        {
            set
            {
                base.MaximizeBox = value;
                btnMax.Visible = value;
                RefreshLayout();
            }
            get { return base.MaximizeBox; }
        }
        /// <summary>
        /// 是否显示最小化按钮
        /// </summary>
        public new bool MinimizeBox
        {
            set
            {
                base.MinimizeBox = value;
                btnMin.Visible = value;
                RefreshLayout();
            }
            get { return base.MinimizeBox; }
        }

        public bool CloseBox
        {
            set
            {
                btnClose.Visible = value;
                RefreshLayout();
            }
            get { return btnClose.Visible; }
        }

        private bool topMostBox;

        public bool TopMostBox
        {
            get { return topMostBox; }
            set
            {
                topMostBox = value;
                btnPin.Visible = value;
                RefreshLayout();
            }
        }


        public new bool TopMost
        {
            get { return base.TopMost; }
            set
            {
                base.TopMost = value;
                isFront = value;
                if (isFront)
                {
                    btnPin.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 1, true);
                    btnPin.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 2, true);
                    btnPin.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 3, true);
                    //this.TopMost = true;
                }
                else
                {
                    btnPin.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 4, true);
                    btnPin.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 5, true);
                    btnPin.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 6, true);
                    //this.TopMost = false;
                }
            }
        }

        private bool isAcceptResize;
        /// <summary>
        /// 是否接受改变大小
        /// </summary>
        public bool IsAcceptResize
        {
            get { return isAcceptResize; }
            set { isAcceptResize = value; }
        }

        private Point formPoint;
        /// <summary>
        /// 初始位置
        /// </summary>
        public Point DefaultPoint
        {
            get { return formPoint; }
            set { formPoint = value; }
        }

        private TitleAlignment titleAlign;
        /// <summary>
        /// 标题对齐方式，默认为居中对齐
        /// </summary>
        public TitleAlignment TitleAlign
        {
            get { return titleAlign; }
            set { titleAlign = value; RefreshTitleLayout(); }
        }

        private MaxLocation maxLocation;
        /// <summary>
        /// 最大化后的位置
        /// </summary>
        public MaxLocation MaximumLocation
        {
            get { return maxLocation; }
            set { maxLocation = value; }
        }

        private Rectangle clientBounds;
        /// <summary>
        /// 客户区边框
        /// </summary>
        [Browsable(false)]
        public Rectangle ClientBounds
        {
            get
            {
                clientBounds.X = 4;
                clientBounds.Y = 41;
                clientBounds.Width = this.Width - 8;
                clientBounds.Height = this.Height - 41 - 3;
                return clientBounds;
            }
        }

        private bool maxChangeWidth;
        /// <summary>
        /// 最大化时是否更改宽度
        /// </summary>
        public bool MaxChangeWidth
        {
            get { return maxChangeWidth; }
            set { maxChangeWidth = value; }
        }

        private bool isTitleSplitLine;
        /// <summary>
        /// 是否显示标题分割线
        /// </summary>
        public bool IsTitleSplitLine
        {
            get { return isTitleSplitLine; }
            set { isTitleSplitLine = value; RefreshTitleLayout(); }
        }

        private bool isShowText;

        public bool IsShowCaptionText
        {
            get { return isShowText; }
            set { isShowText = value; pbTitleCaption.Visible = value; }
        }

        private bool isShowCaptionImage;

        public bool IsShowCaptionImage
        {
            get { return isShowCaptionImage; }
            set { isShowCaptionImage = value; pbTitleImage.Visible = value; }
        }

        //private int WS_SIZEBOX = 0x00040000;
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        // TODO:  添加 Form1.CreateParams getter 实现
        //        CreateParams param = base.CreateParams;
        //        param.Style |= WS_SIZEBOX;
        //        return param;
        //    }
        //} 


        public enum MouseDirection
        {
            None,
            WMSZ_LEFT = 0xF001,
            WMSZ_RIGHT,
            WMSZ_TOP,
            WMSZ_TOPLEFT,
            WMSZ_TOPRIGHT,
            WMSZ_BOTTOM,
            WMSZ_BOTTOMLEFT,
            WMSZ_BOTTOMRIGHT
        }
        MouseDirection direction = MouseDirection.None;//表示拖动的方向，起始为 None，表示不拖动

        private void RefreshLayout()
        {
            int left = 0;
            this.btnClose.Left = this.Width - 38;
            left = this.btnClose.Left;

            if (this.MaximizeBox)
            {
                this.btnMax.Left = left - 21;
                left = this.btnMax.Left;
            }
            if (this.MinimizeBox)
            {
                this.btnMin.Left = left - 19;
                left = this.btnMin.Left;
            }

            this.btnPin.Left = left - 21;
            RefreshTitleLayout();
        }

        private void RefreshTitleLayout()
        {
            if (TitleAlign == TitleAlignment.Center)
            {
                this.pbTitleImage.Left = (this.Width - (this.pbTitleImage.Width + 6 + this.pbTitleCaption.Width)) / 2;
                this.pbTitleCaption.Left = this.pbTitleImage.Left + this.pbTitleImage.Width + 6;
            }
            else if (TitleAlign == TitleAlignment.Left)
            {
                this.pbTitleImage.Left = 12;
                this.pbTitleCaption.Left = this.pbTitleImage.Left + this.pbTitleImage.Width + 6;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (IsTitleSplitLine)
            {
                e.Graphics.DrawLine(new Pen(Color.FromArgb(255, 43, 17, 154), 1), 0, 40, this.Width - 2, 40);
            }

            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(255, 43, 17, 154), 3), 1, 1, this.Width - 3, this.Height - 3);
        }

        protected override void OnResize(EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMax.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 1, false);
                btnMax.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 2, false);
                btnMax.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 3, false);
            }
            else
            {
                btnMax.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max2, 4, 1, false);
                btnMax.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max2, 4, 2, false);
                btnMax.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max2, 4, 3, false);
            }
            if (!DesignMode)
            {
                if (this.Width < 300)
                {

                    Win32API.ReleaseCapture();
                    this.direction = MouseDirection.None;
                    //this.Width = 300;
                }
            }
            base.OnResize(e);
            RefreshLayout();
            if (!DesignMode)
            {
                this.Refresh();
            }
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            direction = MouseDirection.None;
            base.OnMouseUp(e);
        }


        protected virtual void FormMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Win32API.ReleaseCapture();
                Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.SC_MOVE + Win32API.HTCAPTION, 0);
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            direction = MouseDirection.None;
            this.Cursor = Cursors.Arrow;
            base.OnMouseLeave(e);
        }

        protected virtual void ResizeForm(MouseEventArgs e)
        {
            if (!DesignMode)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Win32API.ReleaseCapture();
                    if (direction == MouseDirection.WMSZ_BOTTOM)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_BOTTOM, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_RIGHT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_RIGHT, 0);

                    }
                    else if (direction == MouseDirection.WMSZ_BOTTOMRIGHT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_BOTTOMRIGHT, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_BOTTOMLEFT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_BOTTOMLEFT, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_TOPLEFT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_TOPLEFT, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_TOPRIGHT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_TOPRIGHT, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_LEFT)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_LEFT, 0);
                    }
                    else if (direction == MouseDirection.WMSZ_TOP)
                    {
                        Win32API.SendMessage(this.Handle, Win32API.WM_SYSCOMMAND, Win32API.WMSZ_TOP, 0);
                    }
                }
            }
        }


        protected override void OnMouseMove(MouseEventArgs e)
        {
            //设定好方向后，调用下面方法，改变窗体大小 
            if (this.WindowState != FormWindowState.Maximized)
            {
                //鼠标移动过程中，坐标时刻在改变
                //当鼠标移动时横坐标距离窗体右边缘5像素以内且纵坐标距离下边缘也在5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Declining     
                if (IsAcceptResize)
                {
                    if (e.Location.X >= this.Width - borderWidth && e.Location.Y > this.Height - borderWidth)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        direction = MouseDirection.WMSZ_BOTTOMRIGHT;
                    }
                    else if (e.Location.X < borderWidth && e.Location.Y > this.Height - borderWidth)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        direction = MouseDirection.WMSZ_BOTTOMLEFT;
                    }
                    else if (e.Location.X < borderWidth && e.Location.Y < borderWidth)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        direction = MouseDirection.WMSZ_TOPLEFT;
                    }
                    else if (e.Location.X >= this.Width - borderWidth && e.Location.Y < borderWidth)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        direction = MouseDirection.WMSZ_TOPRIGHT;
                    }
                    //当鼠标移动时横坐标距离窗体右边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Herizontal             
                    else if (e.Location.X >= this.Width - borderWidth)
                    {
                        this.Cursor = Cursors.SizeWE;
                        direction = MouseDirection.WMSZ_RIGHT;
                    }
                    //同理当鼠标移动时纵坐标距离窗体下边缘5像素以内时，要将光标变为倾斜的箭头形状，同时拖拽方向direction置为MouseDirection.Vertical         
                    else if (e.Location.Y >= this.Height - borderWidth)
                    {
                        this.Cursor = Cursors.SizeNS;
                        direction = MouseDirection.WMSZ_BOTTOM;
                    }
                    else if (e.Location.X < borderWidth)
                    {
                        this.Cursor = Cursors.SizeWE;
                        direction = MouseDirection.WMSZ_LEFT;
                    }
                    else if (e.Location.Y < borderWidth)
                    {
                        this.Cursor = Cursors.SizeNS;
                        direction = MouseDirection.WMSZ_TOP;
                    }
                    //否则，以外的窗体区域，鼠标星座均为单向箭头（默认） 
                    else
                    {
                        this.Cursor = Cursors.Arrow;
                        direction = MouseDirection.None;
                    }
                }
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    //ResizeWindow();
                    if (direction == MouseDirection.None)
                    {
                        FormMove(e);
                    }
                    else
                    {
                        if (IsAcceptResize)
                        {
                            ResizeForm(e);
                        }
                    }
                }
            }
            base.OnMouseMove(e);
        }

        private void btnMax_Button_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Screen screen = Screen.FromControl(this);
                if (MaxChangeWidth)
                {
                    this.MaximumSize = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
                }
                else
                {
                    this.MaximumSize = new Size(this.Width, screen.WorkingArea.Height);
                }
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                Screen screen = Screen.FromControl(this);
                this.MaximumSize = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPin_Button_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            //isFront = !isFront;
            //if (isFront)
            //{
            //    //btnPin.image = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 1, true);
            //    //btnPin.mouseEnterImage = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 2, true);
            //    //btnPin.mouseDownImage = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 3, true);
            //    this.TopMost = true;
            //}
            //else
            //{
            //    //btnPin.image = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 4, true);
            //    //btnPin.mouseEnterImage = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 5, true);
            //    //btnPin.mouseDownImage = Utility.Graphics.GetButtonBackgroundImage(Properties.Resources.pik, 6, 6, true);
            //    this.TopMost = false;
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            OnBtnCloseClick(sender, e);
        }

        protected virtual void OnBtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (this.StartPosition == FormStartPosition.CenterScreen)
            {
                Screen screen = Screen.FromControl(this);
                DefaultPoint = new Point((screen.WorkingArea.Width - this.Width) / 2, (screen.WorkingArea.Height - this.Height) / 2);
            }
            if (DefaultPoint != null)
            {
                this.Location = DefaultPoint;
            }
            btnClose.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.close, 4, 1, true);
            btnClose.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.close, 4, 2, true);
            btnClose.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.close, 4, 3, true);
            btnClose.Button_Click += new EventHandler(btnClose_Click);
            btnClose.isVisibleCaption = false;
            btnClose.imageSize = new Size(26, 23);
            btnClose.Init();

            btnMax.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 1, false);
            btnMax.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 2, false);
            btnMax.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.max, 4, 3, false);
            btnMax.Button_Click += new EventHandler(btnMax_Button_Click);
            btnMax.isVisibleCaption = false;
            btnMax.imageSize = new Size(26, 23);
            btnMax.Init();


            btnMin.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.min, 4, 1, true);
            btnMin.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.min, 4, 2, true);
            btnMin.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.min, 4, 3, true);
            btnMin.Button_Click += new EventHandler(btnMin_Button_Click);
            btnMin.isVisibleCaption = false;
            btnMin.imageSize = new Size(26, 23);
            btnMin.Init();


            btnPin.image = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 4, true);
            btnPin.mouseEnterImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 5, true);
            btnPin.mouseDownImage = FengNiao.GameTools.Util.Graphics.GetButtonBackgroundImage(global::Util.Properties.Resource.pik, 6, 6, true);
            btnPin.Button_Click += new EventHandler(btnPin_Button_Click);
            btnPin.isVisibleCaption = false;
            btnPin.imageSize = new Size(26, 26);
            btnPin.Init();

            RefreshLayout();
        }

        private void pbTitleCaption_MouseMove(object sender, MouseEventArgs e)
        {
            FormMove(e);
        }

        private void pbTitleImage_MouseMove(object sender, MouseEventArgs e)
        {
            FormMove(e);
        }


        public enum TitleAlignment
        {
            Left, Center
        }

        public enum MaxLocation
        {
            Left, Center, Right
        }

        private void BaseForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.MaximizeBox)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    Rectangle titleRect = new Rectangle(1, 1, this.Width - 3, 40);
                    if (titleRect.Contains(e.X, e.Y))
                    {
                        if (this.WindowState == FormWindowState.Normal)
                        {
                            Screen screen = Screen.FromControl(this);
                            if (MaxChangeWidth)
                            {
                                this.MaximumSize = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
                            }
                            else
                            {
                                this.MaximumSize = new Size(this.Width, screen.WorkingArea.Height);
                            }
                            this.WindowState = FormWindowState.Maximized;
                        }
                        else
                        {
                            Screen screen = Screen.FromControl(this);
                            this.MaximumSize = new Size(screen.WorkingArea.Width, screen.WorkingArea.Height);
                            this.WindowState = FormWindowState.Normal;
                        }
                    }
                }
            }
        }
    }
}
