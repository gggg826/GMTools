using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;
using CommLib.BdPush;

namespace GameToolsHttpService
{
    public class PushNoticeModule : ProcessRequestBase
    {
        public PushNoticeModule(string tableName)
            : base(tableName)
        {
        }

        //public override string Add(HttpContext context)
        //{
        //    ResultModel requestResult = new ResultModel();
        //    string strTitle = context.Request["Title"];
        //    string strContext = context.Request["Context"];
        //    if (!base.CheckUserSession(context))
        //    {
        //        requestResult.IsSuccess = false;
        //        requestResult.Content = "请登陆后操作";
        //        return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        //    }
        //    try
        //    {
        //        string apikKey = "Nl2KoA9ZPPusLn1PPC8wabbm";
        //        string secretKey = "ncByHPOYIZfC8wlAilWDV5QpxwRE9HKD";

        //        Notice_Android_Mod dam = new Notice_Android_Mod(strTitle, strContext, "2");
        //        //Notice_Android_Mod dam = new Notice_Android_Mod("交通事故", "王府井大街出现塞车，大家请绕路回家", "2");
        //        string json = Newtonsoft.Json.JsonConvert.SerializeObject(dam);
        //        Push_All_Mod pam = new Push_All_Mod(apikKey, json, (int)Baidu_Helper.Message_Type.Notice);
        //        Push_All pa = new Push_All(secretKey, pam);
        //        string result = pa.PushMessage();

        //        PushNoticeResultMod resultMod = Newtonsoft.Json.JsonConvert.DeserializeObject<PushNoticeResultMod>(result);

        //        requestResult.IsSuccess = true;
        //        requestResult.Content = result;

        //        //    //    try
        //        //    //    {
        //        //    //        string serverIP = serverip;
        //        //    //        if (!string.IsNullOrEmpty(serverIP))
        //        //    //        {
        //        //    //            string strArgs = "cmd=reload_activity_task";
        //        //    //            if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
        //        //    //            {
        //        //    //                serverIP = serverIP.ToUpper().Replace("HTTP://", "");
        //        //    //            }
        //        //    //            byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
        //        //    //            string strContent = Encoding.UTF8.GetString(bytes);
        //        //    //        }
        //        //    //    }
        //        //    //    catch
        //        //    //    {
        //        //    //        requestResult.IsSuccess = false;
        //        //    //        requestResult.Content = "活动已生效，但未能成功通知游戏服务器" + "(" + serverid + ")";
        //        //    //    }
        //    }
        //    catch
        //    {
        //        requestResult.IsSuccess = false;
        //        requestResult.Content = "系统错误";
        //    }
        //    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);

        ////}

        public override string Add(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strModel = context.Request["Model"];

            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {
                FengNiao.GMTools.Database.Model.tbl_baidupush configModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<FengNiao.GMTools.Database.Model.tbl_baidupush>(strModel);
                if (configModel != null)
                {
                    FengNiao.GMTools.Database.DAL.tbl_baidupush activityConfigDAL = new FengNiao.GMTools.Database.DAL.tbl_baidupush();
                    if (activityConfigDAL.Update(configModel))
                    {
                        BaiduPushNotice.reloadInfo(configModel);
                        requestResult.IsSuccess = true;
                        requestResult.Content = "";  
                    }
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }
    }



    class PushNoticeResultMod
    {
        public string request_id { get; set; }
        public ResponseParams response_params { set; get; }
    }
    class ResponseParams
    {
        public string msg_id { get; set; }
        public string send_time { get; set; }
    }
}