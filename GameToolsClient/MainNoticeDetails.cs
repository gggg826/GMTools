using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using GameToolsCommon;
using FengNiao.GameToolsCommon;
using System.Net;
using System.IO;

namespace GameToolsClient
{
    public partial class MainNoticeDetails : BaseForm
    {
        public MainNoticeDetails()
        {
            InitializeComponent();
            this.Text = "新公告";
            this.lbTitle.Text = "新公告";
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
            this.CdnDataUrl = string.Empty;
        }

        public string CdnDataUrl;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContent.Text))
            {
                CustomMessageBox.Error(this, "内容不能为空");
                return;
            }

            string strContent = EncodeString(tbContent);
            if (strContent.Length > 4096)
            {
                CustomMessageBox.Error(this, "公告内容过长");
                return;
            }

            if (CreateCDN(strContent))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                CustomMessageBox.Error(this, "创建公告失败");
                return;
            }
        }

        private bool CreateCDN(string content)
        {
            string cachePath;
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                cachePath = fbd.SelectedPath;
            }
            else
            {
                return false;
            }

            string cdnPackageName = string.Format("Notice_{0}.txt", DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss"));
            string cdnFullPath = Path.Combine(cachePath, cdnPackageName);

            using (FileStream fs = File.Open(cdnFullPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.Write(content);
                }
            }

            UploadCDNProgress frmUploadCDNProgress = new UploadCDNProgress();
            frmUploadCDNProgress.AddFile(cdnFullPath);
            frmUploadCDNProgress.ShowDialog();
            if (frmUploadCDNProgress.UploadCompleteCounter > 0)
            {
                CdnDataUrl = string.Format("http://qtcdn.yingxiong.com/CDNData/{0}", cdnPackageName);
                return true;
            }
            else
            {
                CustomMessageBox.Error(this, "上传失败");
                return false;
            }
        }

        private string EncodeString(RichTextBox textbox)
        {
            StringBuilder sb = new StringBuilder();
            string strColor = string.Empty;
            for (int i = 0; i < textbox.Text.Length; i++)
            {
                char c = textbox.Text[i];
                textbox.SelectionStart = i;
                textbox.SelectionLength = 1;
                Color selectedColor = textbox.SelectionColor;
                string strR = selectedColor.R.ToString("x2");
                string strG = selectedColor.G.ToString("x2");
                string strB = selectedColor.B.ToString("x2");
                string tempColor = "[" + strR + strG + strB + "]";
                if (!strColor.Equals(tempColor))
                {
                    sb.Append(tempColor == "[ffffff]" ? "[-]" : tempColor);
                    strColor = tempColor;
                }
                sb.Append(c.ToString());
            }

            return sb.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "notice files (*.notice)|*.notice";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;
                try
                {
                    using (FileStream fs = File.Open(fileName, FileMode.Open))
                    {
                        using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
                        {
                            tbContent.Rtf = sr.ReadToEnd();
                        }
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "打开模板失败，文件无效");
                }
            }
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContent.Text))
            {
                CustomMessageBox.Error(this, "公告内容不能为空");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "notice files (*.notice)|*.notice";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = sfd.FileName;
                try
                {
                    using (FileStream fs = File.Open(fileName, FileMode.Create))
                    {
                        using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                        {
                            sw.Write(tbContent.Rtf);
                        }
                    }

                    CustomMessageBox.Info(this, "保存模板成功");
                }
                catch
                {
                    CustomMessageBox.Error(this, "保存模板失败");
                }
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int selectStart = tbContent.SelectionStart;
            int selectLength = tbContent.SelectionLength;
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.Color = tbContent.SelectionBackColor;
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbContent.SelectionColor = colorDialog.Color;
            }
        }
    }
}
