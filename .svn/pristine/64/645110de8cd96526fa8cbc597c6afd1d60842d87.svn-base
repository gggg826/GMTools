using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using GameToolsCommon;
using FengNiao.GameToolsCommon;
using System.Net;
using System.IO;

namespace GameToolsClient
{
    public partial class RollingNoticeConfigDetails : BaseForm
    {
        FengNiao.GMTools.Database.Model.tbl_server CurrentServerData;
        FengNiao.GMTools.Database.Model.tbl_notice_config CurrentNoticeConfig;
        public RollingNoticeConfigDetails(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            InitializeComponent();
            this.Text = "新跑马灯公告";
            this.lbTitle.Text = "新跑马灯公告";
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
            isNewNotice = true;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            tbInterval.Text = "15";
            dtStartDate.Value = DateTime.Now;
            dtStartTime.Value = DateTime.Now;
            dtStopDate.Value = DateTime.Now;
            dtStopTime.Value = DateTime.Now;
            CurrentServerData = serverData;
        }


        public RollingNoticeConfigDetails(FengNiao.GMTools.Database.Model.tbl_server serverData, FengNiao.GMTools.Database.Model.tbl_notice_config noticeConfig)
            : this(serverData)
        {
            CurrentNoticeConfig = noticeConfig;
            this.Text = "公告编辑";
            this.lbTitle.Text = "公告编辑";
            isNewNotice = false;
            tbServer.Enabled = false;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            tbTitle.Text = noticeConfig.title;
            tbContent.Rtf = noticeConfig.rtfcontent;
            tbImage.Text = noticeConfig.image;
            tbInterval.Text = noticeConfig.interval.ToString();
            dtStartDate.Value = noticeConfig.starttime.Value;
            dtStartTime.Value = noticeConfig.starttime.Value;
            dtStopDate.Value = noticeConfig.stoptime.Value;
            dtStopTime.Value = noticeConfig.stoptime.Value;
            cbIsOpen.Checked = !Convert.ToBoolean(noticeConfig.deleted);
        }

        private bool isNewNotice { set; get; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                CustomMessageBox.Error(this, "标题不能为空");
            }
            if (string.IsNullOrEmpty(tbContent.Text))
            {
                CustomMessageBox.Error(this, "内容不能为空");
            }
            FengNiao.GMTools.Database.Model.tbl_notice_config noticeConfig = null;
            if (isNewNotice)
            {
                noticeConfig = new FengNiao.GMTools.Database.Model.tbl_notice_config();
                noticeConfig.server_id = CurrentServerData.fld_server_id;
                noticeConfig.createtime = DateTime.Now;
                noticeConfig.type = 1;
            }
            else
            {
                noticeConfig = CurrentNoticeConfig;
            }
            noticeConfig.title = tbTitle.Text;

            byte[] bytes = Encoding.UTF8.GetBytes(tbContent.Text);
            if (bytes.Length > 4096)
            {
                CustomMessageBox.Error(this, "公告内容过长");
                return;
            }
            string strContent = EncodeString(tbContent);
            bytes = Encoding.UTF8.GetBytes(strContent);
            strContent = Encoding.UTF8.GetString(bytes);
            //strContent = strContent.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");

            int interval = 15;
            if (!int.TryParse(tbInterval.Text, out interval))
            {
                CustomMessageBox.Error(this, "请输入正确的广播间隔");
                return;
            }
            noticeConfig.interval = interval;

            noticeConfig.content = strContent;
            noticeConfig.rtfcontent = tbContent.Rtf;
            noticeConfig.image = tbImage.Text;
            DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            DateTime stoptime = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss"));
            if (DateTime.Compare(starttime, stoptime) > -1)
            {
                CustomMessageBox.Error(this, "公告结束时间必须大于开始时间");
                return;
            }

            noticeConfig.starttime = starttime;
            noticeConfig.stoptime = stoptime;
            noticeConfig.deleted = cbIsOpen.Checked ? 0 : 1;

            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<FengNiao.GMTools.Database.Model.tbl_notice_config>(noticeConfig);

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Notice_Config, isNewNotice ? HttpMethodType.Add : HttpMethodType.Update);
            strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, SaveActivityCallback);

        }


        private string EncodeString(RichTextBox textbox)
        {
            string strContent = string.Empty;
            string strColor = string.Empty;
            for (int i = 0; i < textbox.Text.Length; i++)
            {
                char c = textbox.Text[i];
                textbox.SelectionStart = i;
                textbox.SelectionLength = 1;
                Color selectedColor = textbox.SelectionBackColor;
                string strR = selectedColor.R.ToString("x2");
                string strG = selectedColor.G.ToString("x2");
                string strB = selectedColor.B.ToString("x2");
                string tempColor = "[" + strR + strG + strB + "]";
                if (!strColor.Equals(tempColor))
                {
                    strContent = strContent + tempColor;
                    strColor = tempColor;
                }
                strContent = strContent + c.ToString();
            }

            return strContent;
        }


        private void SaveActivityCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, "配置公告成功");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("配置公告失败\r\n{0}", requestResultModel.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
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
                tbContent.SelectionBackColor = colorDialog.Color;
            }
        }

    }
}
