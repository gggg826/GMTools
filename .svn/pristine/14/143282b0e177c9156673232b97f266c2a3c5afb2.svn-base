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
    public partial class GiftCodeView : BaseForm
    {
        public GiftCodeView()
        {
            InitializeComponent();
            this.Text = "礼包码预览";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.Image = Properties.Resources.TK_2icon;
        }

        public List<string> GiftCodes
        {
            set
            {
                for (int i = 0; i < value.Count; i++)
                {
                    tbGiftCode.AppendText(value[i] + "\r\n");
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }

        private void RefreshLayout()
        {
            if (this.IsHandleCreated && tbGiftCode.IsHandleCreated)
            {
                tbGiftCode.Left = base.ClientBounds.X;
                tbGiftCode.Top = base.ClientBounds.Y;
                tbGiftCode.Width = base.ClientBounds.Width;
                tbGiftCode.Height = base.ClientBounds.Height;
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbGiftCode.Text);
        }

    }
}
