using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;
using Newtonsoft.Json.Linq;
using System.IO;

namespace GameToolsClient
{
    public partial class BroadcastChat : BaseForm
    {
        public BroadcastChat()
        {
            InitializeComponent();
            this.Text = "游戏公告广播";
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
            cbType.Items.Add("聊天公告");
            cbType.Items.Add("跑马灯公告");
            cbType.Text = "聊天公告";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbContent.Text))
            {
                CustomMessageBox.Error(this, "公告内容不能为空");
                return;
            }
            if (gvDataList.Rows.Count == 0)
            {
                if (CustomMessageBox.Confirm(this, "目前是发送的全服广播，请谨慎操作，是否要继续？") == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
            }

            List<string> serverIDs = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                serverIDs.Add(gvDataList.Rows[i].Cells[0].Value.ToString());
            }
            Dictionary<string, string> paramters = new Dictionary<string, string>();
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
            switch (cbType.Text)
            {
                case "聊天公告":
                    paramters.Add("cmd", "broadcast_chat");
                    break;
                case "跑马灯公告":
                    paramters.Add("cmd", "broadcast_horseracelamp");
                    break;
            }

            byte[] bytes = Encoding.UTF8.GetBytes(tbContent.Text);
            if (bytes.Length > 512)
            {
                CustomMessageBox.Error(this, "公告内容过长");
                return;
            }
            string strContent = EncodeString(tbContent);
            bytes = Encoding.UTF8.GetBytes(strContent);
            strContent = Encoding.UTF8.GetString(bytes);
            strContent = strContent.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
            paramters.Add("text", strContent);
            string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(serverIDs);
            string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
            strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, SendCallback);
                btnSend.Enabled = false;
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
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


        private void SendCallback(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    try
                    {
                        string strResult = string.Empty;
                        List<OperateResultModel> resultModeList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResult.Content);
                        for (int i = 0; i < resultModeList.Count; i++)
                        {
                            if (resultModeList[i].IsSuccess)
                            {
                                JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(resultModeList[i].Content);
                                int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                                if (errorcode == 0)
                                {
                                    strResult += "服务器 - " + resultModeList[i].Guid + "\t发送成功\r\n";
                                }
                                else
                                {
                                    strResult += "服务器 - " + resultModeList[i].Guid + string.Format("\t发送失败，errorcode{0}\r\n", errorcode);
                                }
                            }
                            else
                            {
                                strResult += "服务器 - " + resultModeList[i].Guid + "\t发送失败\r\n";
                            }
                        }
                        CustomMessageBox.Info(this, strResult);
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "发送失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("发送失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnSend.Enabled = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.IsSelector = true;
            if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < gvDataList.Rows.Count; i++)
                {
                    if (gvDataList.Rows[i].Cells[0].Value.ToString().Equals(frmServerManager.SelectedServer.fld_server_id.ToString()))
                    {
                        return;
                    }
                }
                int index = gvDataList.Rows.Add(frmServerManager.SelectedServer.fld_server_id, frmServerManager.SelectedServer.fld_server_name);
                gvDataList.Rows[index].Cells[3].Value = Guid.NewGuid().ToString();
                gvDataList.Rows[index].Tag = frmServerManager.SelectedServer;
            }
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (gvDataList.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                gvDataList.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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


        private void tbContent_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    }
}
