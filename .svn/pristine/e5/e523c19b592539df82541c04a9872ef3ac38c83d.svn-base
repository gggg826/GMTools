using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;
using System.Text;

namespace GameToolsHttpService
{
    public class ActivityConfigModule : ProcessRequestBase
    {
        public ActivityConfigModule(string tableName)
            : base(tableName)
        {
        }

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
                FengNiao.GMTools.Database.Model.tbl_activity_config configModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<FengNiao.GMTools.Database.Model.tbl_activity_config>(strModel);
                if (configModel != null)
                {
                    FengNiao.GMTools.Database.BLL.tbl_activity_config activityConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_activity_config();
                    List<FengNiao.GMTools.Database.Model.tbl_activity_config> configs = activityConfigBLL.GetModelList("server_id = " + configModel.server_id + " and id = " + configModel.id);
                    if (configs.Count == 0)
                    {
                        if (activityConfigBLL.Add(configModel))
                        {
                            requestResult.IsSuccess = true;
                            requestResult.Content = "";
                            try
                            {
                                FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
                                List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id=" + configModel.server_id.ToString());
                                if (serverList.Count > 0)
                                {
                                    string serverIP = serverList[0].fld_server_ip;
                                    if (!string.IsNullOrEmpty(serverIP))
                                    {

                                        string strArgs = "cmd=reload_activity";
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
                    }
                    else
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = "该服务器已经配置过该活动";
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

        public string AddAll(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strServerID = context.Request["ServerID"];
            int iServerID = -1;
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            if (!int.TryParse(strServerID, out iServerID))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数错误";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {
                FengNiao.GMTools.Database.BLL.tbl_activity activictyBLL = new FengNiao.GMTools.Database.BLL.tbl_activity();

                FengNiao.GMTools.Database.BLL.tbl_activity_config activityConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_activity_config();

                List<FengNiao.GMTools.Database.Model.tbl_activity> activictys = activictyBLL.GetModelList("");

                List<OperateResultModel> resultModelList = new List<OperateResultModel>();
                for (int i = 0; i < activictys.Count; i++)
                {
                    List<FengNiao.GMTools.Database.Model.tbl_activity_config> configs = activityConfigBLL.GetModelList("server_id = " + strServerID + " and id = " + activictys[i].id);
                    if (configs.Count == 0)
                    {
                        FengNiao.GMTools.Database.Model.tbl_activity_config configModel = new FengNiao.GMTools.Database.Model.tbl_activity_config();
                        configModel.id = activictys[i].id;
                        configModel.server_id = iServerID;
                        configModel.isopen = 0;
                        configModel.starttime = DateTime.Now;
                        configModel.stoptime = DateTime.Now.AddDays(1);
                        if (activityConfigBLL.Add(configModel))
                        {
                            OperateResultModel resultModel = new OperateResultModel();
                            resultModel.IsSuccess = true;
                            resultModel.Content = activictys[i].name.Trim() + "(" + activictys[i].id + ")" + "导入成功";
                            resultModelList.Add(resultModel);
                        }
                    }
                }
                requestResult.IsSuccess = true;
                requestResult.Content = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperateResultModel>>(resultModelList);
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);

        }

        public override string Update(HttpContext context)
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
                FengNiao.GMTools.Database.Model.tbl_activity_config configModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<FengNiao.GMTools.Database.Model.tbl_activity_config>(strModel);
                if (configModel != null)
                {
                    FengNiao.GMTools.Database.BLL.tbl_activity_config activityConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_activity_config();
                    if (activityConfigBLL.Update(configModel))
                    {
                        requestResult.IsSuccess = true;
                        requestResult.Content = "";
                        try
                        {
                            FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
                            List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id=" + configModel.server_id.ToString());
                            if (serverList.Count > 0)
                            {
                                string serverIP = serverList[0].fld_server_ip;
                                if (!string.IsNullOrEmpty(serverIP))
                                {

                                    string strArgs = "cmd=reload_activity";
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
}