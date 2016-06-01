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
    public partial class ImportActivityResult : BaseForm
    {
        public ImportActivityResult()
        {
            InitializeComponent();
            this.Text = "导入结果";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.TitleAlign = TitleAlignment.Left;
            this.IsTitleSplitLine = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
        }

        public string ResultMessage
        {
            set
            {
                tbMessage.Text = value;
            }
        }
    }
}
