using System;
using System.Collections.Generic;
using System.Text;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace GameToolsClient
{
    public class CustomMessageBox
    {
        public static void Info(IWin32Window window,string strMsg, string strTitle = "提示")
        {
            MessageBoxEx.Show(strMsg, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(IWin32Window window,string strMsg, string strTitle = "错误")
        {
            MessageBoxEx.Show(strMsg, strTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult Confirm(IWin32Window window,string strMsg, string strTitle = "提示")
        {
            return MessageBoxEx.Show(window, strMsg, strTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
