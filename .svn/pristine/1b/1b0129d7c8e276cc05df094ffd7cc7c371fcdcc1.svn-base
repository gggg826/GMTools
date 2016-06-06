using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;
using System.Text;


namespace GameToolsHttpService
{
    public class SucessionConfigModule : ProcessRequestBase
    {
        public SucessionConfigModule(string tableName)
            : base(tableName)
        {
        }
        public override string Add(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strModel = context.Request["Model"];
            string strServerid = context.Request["serverid"];
            string strServerip = context.Request["serverip"];
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            string serverid = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<string>(strServerid);
            string serverip = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<string>(strServerip);

            try
            {
                List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> configModels = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>(strModel);

                FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config loginrewardsConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config();

                loginrewardsConfigBLL.DeleteByServer(int.Parse(serverid));
                if (configModels != null)
                {
                    foreach (FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config item in configModels)
                        loginrewardsConfigBLL.Add(item);

                }
                requestResult.IsSuccess = true;
                requestResult.Content = serverid;


                try
                {
                    string serverIP = serverip;
                    if (!string.IsNullOrEmpty(serverIP))
                    {

                        string strArgs = "cmd=reload_sucessreward";
                        if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
                        {
                            serverIP = serverIP.ToUpper().Replace("HTTP://", "");
                        }
                        byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
                        string strContent = Encoding.UTF8.GetString(bytes);
                    }
                }
                catch
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "活动已生效，但未能成功通知游戏服务器" + "(" + serverid + ")";
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "(" + serverid + ")";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);

        }


        public override string Update(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strModel = context.Request["Model"];
            string strServer = context.Request["server"];
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {

                List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> newConfigList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>>(strModel);
                //List<FengNiao.GMTools.Database.Model.tbl_server> currentServer = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_server>(strServer);
                string server_id = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<string>(strServer);
                FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config ConfigConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config();
                int server = int.Parse(server_id);
                ConfigConfigBLL.DeleteByServer(server);

                if (newConfigList.Count != 0)
                {
                    foreach (FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config configModel in newConfigList)
                    {
                        ConfigConfigBLL.Add(configModel);
                    }
                }


                requestResult.IsSuccess = true;
                requestResult.Content = "";
                try
                {
                    FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
                    List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id="+server);
                    if (serverList.Count > 0)
                    {
                        string serverIP = serverList[0].fld_server_ip;
                        if (!string.IsNullOrEmpty(serverIP))
                        {

                            string strArgs = "cmd=reload_sucessreward";
                            if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
                            {
                                serverIP = serverIP.ToUpper().Replace("HTTP://", "");
                            }
                            byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
                            string strContent = Encoding.UTF8.GetString(bytes);
                        }
                    }
                }
                catch
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "活动已生效，但未能成功通知游戏服务器";
                }

            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }






        
        //public override string Update(HttpContext context)
        //{
        //    ResultModel requestResult = new ResultModel();
        //    string strModel = context.Request["Model"];

        //    if (!base.CheckUserSession(context))
        //    {
        //        requestResult.IsSuccess = false;
        //        requestResult.Content = "请登陆后操作";
        //        return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        //    }
        //    try
        //    {
        //        FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config configModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>(strModel);
        //        if (configModel != null)
        //        {
        //            FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config activityConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config();
        //            if (activityConfigBLL.Update(configModel))
        //            {
        //                requestResult.IsSuccess = true;
        //                requestResult.Content = "";
        //                try
        //                {
        //                    FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
        //                    List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id=" + configModel.serverID.ToString());
        //                    if (serverList.Count > 0)
        //                    {
        //                        string serverIP = serverList[0].fld_server_ip;
        //                        if (!string.IsNullOrEmpty(serverIP))
        //                        {

        //                            string strArgs = "cmd=reload_sucessionreward";
        //                            if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
        //                            {
        //                                serverIP = serverIP.ToUpper().Replace("HTTP://", "");
        //                            }
        //                            byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
        //                            string strContent = Encoding.UTF8.GetString(bytes);
        //                        }
        //                    }
        //                }
        //                catch
        //                {
        //                    requestResult.IsSuccess = false;
        //                    requestResult.Content = "活动已生效，但未能成功通知游戏服务器";
        //                }
        //            }
        //        }
        //    }
        //    catch
        //    {
        //        requestResult.IsSuccess = false;
        //        requestResult.Content = "系统错误";
        //    }
        //    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        //}
    }
}