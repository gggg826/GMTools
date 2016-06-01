using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FengNiao.GameTools.Util
{
    public partial class CustomButton : UserControl
    {

        /// <summary>
        /// 自定义按钮控件
        /// </summary>

        #region 构造函数


        public CustomButton()
            : base()
        {
            InitializeComponent();
            this.pictureBox1.Image = this.image;
            this.label1.Text = this.caption;
            //SetStyle(
            //              ControlStyles.SupportsTransparentBackColor
            //            | ControlStyles.UserPaint
            //            | ControlStyles.AllPaintingInWmPaint
            //            | ControlStyles.Opaque, true);
            this.ResizeRedraw = true;
            BackColor = Color.Transparent;
        }

        ~CustomButton()
        {
            if (_image != null)
            {
                _image.Dispose();
            }
            if (_mouseEnterImage != null)
            {
                _mouseEnterImage.Dispose();
            }
            if (_mouseDownImage != null)
            {
                _mouseDownImage.Dispose();
            }
        }


        #endregion

        #region 按钮控件的基本属性

        private Image _image;
        [Category("其他"), Description("设置或获取按钮的背景图")]
        public Image image
        {
            set
            {
                _image = value;
                this.pictureBox1.Image = value;
            }
            get { return _image; }
        }

        private Image _mouseEnterImage;
        public Image mouseEnterImage
        {
            set { _mouseEnterImage = value; }
            get { return _mouseEnterImage; }
        }


        private Image _mouseDownImage;
        public Image mouseDownImage
        {
            set { _mouseDownImage = value; }
            get { return _mouseDownImage; }
        }

        private string _caption;
        [Category("其他"), Description("设置或获取按钮的文本")]
        public string caption
        {
            set
            {
                _caption = value;
                this.label1.Text = value;
            }

            get { return _caption; }
        }

        private Color _buttonBackGroudColor;
        [Category("其他"), Description("获取或设置按钮背景颜色"), DefaultValue(typeof(Color), "Control")]
        public Color buttonBackGroudColor
        {
            set
            {
                _buttonBackGroudColor = value;
                this.BackColor = value;
            }
            get { return _buttonBackGroudColor; }

        }

        private bool _isVisibleCaption = true;
        [Category("其他"), Description("设置文本是否可见"), DefaultValue(true)]
        public bool isVisibleCaption
        {
            set
            {
                _isVisibleCaption = value;
                this.label1.Visible = value;
            }
            get { return _isVisibleCaption; }
        }

        private string _textTips;
        [Category("其他"), Description("设置提示文本"), DefaultValue("")]
        public string TextTips
        {
            set
            {
                _textTips = value;
                if (_toolTip != null && _toolTip1 != null && _toolTip2 != null)
                {
                    _toolTip.SetToolTip(this, value);
                    _toolTip1.SetToolTip(this.pictureBox1, value);
                    _toolTip2.SetToolTip(this.label1, value);
                }
            }
            get { return _textTips; }
        }

        private Size _imageSize;
        public Size imageSize
        {
            set { _imageSize = value; }
            get { return _imageSize; }
        }

        private ToolTip _toolTip = new ToolTip();
        public ToolTip toolTip
        {
            set
            {
                //value.ReshowDelay = 20;
                value.AutomaticDelay = 0;
                value.UseAnimation = true;
                value.UseFading = true;
                _toolTip = value;
                _toolTip1 = value;
                _toolTip2 = value;
            }
            get { return _toolTip; }
        }
        private ToolTip _toolTip1 = new ToolTip();
        private ToolTip _toolTip2 = new ToolTip();


        private bool IsHighLight = false;

        #endregion

        #region 初始化工作以及更换背景所使用的函数

        /// <summary>
        /// 初始化按钮，并计算出按钮的图片以及标题文字的位置
        /// </summary>

        public void Init()
        {
            this.Cursor = Cursors.Arrow;
            this.BackColor = Color.Transparent;
            this.pictureBox1.Width = imageSize.Width;
            this.pictureBox1.Height = imageSize.Height;
            EditButtonImage(this.image);
            label1.Visible = isVisibleCaption;
            label1.Text = caption;
            if (!isVisibleCaption)
            {
                this.Height = this.pictureBox1.Height;
            }
            else
            {
                this.Width = this.pictureBox1.Width;
                this.Height = this.pictureBox1.Height + this.label1.Height + 8;
                label1.Top = this.pictureBox1.Height + 4;
                label1.Left = (this.pictureBox1.Width - this.label1.Width) / 2 + 1;
            }
        }

        /// <summary>
        /// 修改按钮图片
        /// </summary>
        /// <param name="image">将要修改的图片</param>


        private void EditButtonImage(Image image)
        {
            this.pictureBox1.Image = image;
            Bitmap backgroundImage = (Bitmap)image;
            GraphicsPath graphicsPath = FengNiao.GameTools.Util.Graphics.CalculateControlGraphicsPath(backgroundImage);
            //if (isVisibleCaption)
            //{
            //    this.pictureBox1.Region = new Region(graphicsPath);
            //}
            graphicsPath.Dispose();
        }

        #endregion

        private void UserControl_Button_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.image;
            this.label1.Text = this.caption;
        }



        private void label1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseEnterImage);
            }
            IsHighLight = true;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            //System.Threading.Thread.Sleep(100);
            EditButtonImage(this.mouseEnterImage);
            IsHighLight = true;
        }

        private void UserControl_Button_MouseEnter(object sender, EventArgs e)
        {
            //base.OnMouseEnter(e);
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseEnterImage);
            }
            IsHighLight = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            //System.Threading.Thread.Sleep(50);
            if (isVisibleCaption)
            {
                EditButtonImage(this.image);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            base.OnMouseLeave(e);
            EditButtonImage(this.image);
        }


        private void UserControl_Button_MouseLeave(object sender, EventArgs e)
        {
            if (isVisibleCaption)
            {
                EditButtonImage(this.image);
            }
        }


        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseDownImage);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            EditButtonImage(this.mouseDownImage);
        }


        private void UserControl_Button_MouseDown(object sender, MouseEventArgs e)
        {
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseDownImage);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseEnterImage);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            EditButtonImage(this.mouseEnterImage);
        }

        private void UserControl_Button_MouseUp(object sender, MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            if (isVisibleCaption)
            {
                EditButtonImage(this.mouseEnterImage);
            }
        }

        public event EventHandler Button_Click = null;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Button_Click != null)
            {
                Button_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (isVisibleCaption)
            {
                if (Button_Click != null)
                {
                    Button_Click(sender, e);
                }
            }
        }

        private void UserControl_Button_Click(object sender, EventArgs e)
        {
            if (isVisibleCaption)
            {
                if (Button_Click != null)
                {
                    Button_Click(sender, e);
                }
            }
        }



    }
}
