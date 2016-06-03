using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FengNiao.GMTools.Database.Model;
using CommLib.BdPush;

namespace GameToolsHttpService
{
    public class BaiduPushNotice
    {
        //private static  tbl_baidupush model = new tbl_baidupush();
        private static string apikey = string.Empty;
        private static string secretKey = string.Empty;
        private static string title = string.Empty;
        private static string context = string.Empty;
        private static DateTime startdate = new DateTime();
        private static DateTime stopdate = new DateTime();
        private static DateTime pushtime = new DateTime();

        public static void reloadInfo(tbl_baidupush model)
        {
            //model = _model;
            //apikey = model.apiKey;
            //secretKey = model.secretKey;
            title = model.tile;
            context = model.context;
            startdate = (DateTime)model.startime;
            stopdate = (DateTime)model.stoptime;
            pushtime = (DateTime)model.pushtime;
        }

        public static void reloadInfo()
        {
            FengNiao.GMTools.Database.DAL.tbl_baidupush modelDAL = new FengNiao.GMTools.Database.DAL.tbl_baidupush();
            tbl_baidupush model = new tbl_baidupush();
            model = modelDAL.GetModel(1);

            apikey = model.apiKey;
            secretKey = model.secretKey;
            title = model.tile;
            context = model.context;
            startdate = (DateTime)model.startime;
            stopdate = (DateTime)model.stoptime;
            pushtime = (DateTime)model.pushtime;

        }

        public static void PushBaiduNotice()
        {
            while (true)
            {
                if (DateTime.Compare(startdate, DateTime.Now) < 0 && DateTime.Compare(stopdate, DateTime.Now) > 0)
                {
                    if (DateTime.Now.Hour == pushtime.Hour)
                        if (DateTime.Now.Minute == pushtime.Minute)
                        {
                            Notice_Android_Mod mod = new Notice_Android_Mod(title, context, "2");
                            string messsage = Newtonsoft.Json.JsonConvert.SerializeObject(mod);
                            Push_All_Mod pmod = new Push_All_Mod(apikey, messsage, (int)Baidu_Helper.Message_Type.Notice);
                            Push_All push = new Push_All(secretKey, pmod);
                            string result = push.PushMessage();
                        }
                }
                System.Threading.Thread.Sleep(60000);
            }
        }
    }
}