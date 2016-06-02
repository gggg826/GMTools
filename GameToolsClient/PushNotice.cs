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
            this.dtStartDate.Value = DateTime.Now.Date;
            this.dtStopDate.Value = DateTime.Now.Date;
            this.dtStartTime.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_baidupush model = new FengNiao.GMTools.Database.Model.tbl_baidupush();
            //if(this.tbTitle.Text == null)
            //{
            //    CustomMessageBox.Error(this, "请输入标题");
            //    return;
            //}
            model.tile = this.tbTitle.Text;

            if(this.tbContext.Text == null)
            {
                CustomMessageBox.Error(this, "请输入通知的内容");
                return;
            }
            model.context = this.tbContext.Text;

            DateTime startdate = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd"));
            DateTime stopdate = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd"));
            if (DateTime.Compare(startdate, stopdate) > -1)
            {
                CustomMessageBox.Error(this, "活动结束时间必须大于开始时间");
                return;
            }
            model.startime = startdate;
            model.stoptime = stopdate;

            DateTime sendTime = DateTime.Parse(dtStartTime.Value.ToString("HH:mm:ss"));

            model.pushtime = sendTime;

            model.record_id = 1;
            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson(model);

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.PushNotice, HttpMethodType.Add);
            strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
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
                        CustomMessageBox.Info(this, "保存成功");
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
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
