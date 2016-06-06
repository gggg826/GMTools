using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GameToolsClient
{
    public partial class LoadingControl : UserControl
    {
        public LoadingControl()
        {
            InitializeComponent();
        }

        protected override void  OnSizeChanged(EventArgs e)
        {
            progressBar.Left = (this.Width - progressBar.Width) / 2;
            progressBar.Top = (this.Height - progressBar.Height) / 2;
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            if (!this.DesignMode)
            {
            }
            progressBar.ProgressType = DevComponents.DotNetBar.eProgressItemType.Marquee;
        }
    }
}
