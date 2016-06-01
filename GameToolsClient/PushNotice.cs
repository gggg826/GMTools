using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class PushNotice : FengNiao.GameTools.Util.BaseForm
    {
        public PushNotice()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.tbTitle.Text = "亲！到了领取体力的时间了";
            this.tbContext.Text = "点击登录游戏领取";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(this.tbTitle.Text == null)
            {
                CustomMessageBox.Error(this, "请输入标题");
                return;
            }
            if(this.tbContext.Text == null)
            {
                CustomMessageBox.Error(this, "请输入通知的内容");
                return;
            }

            string strTitle = this.tbTitle.Text;
            string strContext = this.tbContext.Text;

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.PushNotice, HttpMethodType.Add);
            strArgs = string.Format("{0}&Title={1}&Context={2}", strArgs, strTitle, strContext);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetPushCallback);
        }

        private void GetPushCallback(object sender, UploadDataCompletedEventArgs e)
        {
            //CustomMessageBox.Info(this, e.Result.ToString());
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, requestResultModel.Content);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("{0}", requestResultModel.Content));
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
    }
}
