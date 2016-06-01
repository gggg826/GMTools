using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;

namespace GameToolsClient
{
    public partial class UrlDetails : BaseForm
    {
        public UrlDetails()
        {
            InitializeComponent();
            this.Text = "URL查看";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Image = Properties.Resources.TK_2icon;
        }

        public string Url { set; get; }

        private void UrlDetails_Load(object sender, EventArgs e)
        {
            tbUrl.Text = Url;
        }
    }
}
