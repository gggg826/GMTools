using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;
using System.Text;
using Newtonsoft.Json.Linq;

namespace GameToolsHttpService
{
    public class GameModule : ProcessRequestBase
    {
        public GameModule(string tableName)
            : base(tableName)
        {

        }

        public virtual string Transfer(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            string strArgs = string.Empty;
            string strParamters = context.Request["Paramters"];
            string strServerIDs = context.Request["ServerID"];
            if (string.IsNullOrEmpty(strParamters))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            if (string.IsNullOrEmpty(strServerIDs))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {
                List<OperateResultModel> resultModelList = new List<OperateResultModel>();
                FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
                List<string> serverIDList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<string>(strServerIDs);
                Dictionary<string, string> serverIPs = new Dictionary<string, string>();
                if (serverIDList.Count > 0)
                {
                    for (int i = 0; i < serverIDList.Count; i++)
                    {
                        string strServerID = serverIDList[i];
                        try
                        {
                            List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id=" + strServerID);
                            if (serverList.Count > 0)
                            {
                                if (!serverIPs.ContainsKey(strServerID))
                                {
                                    serverIPs.Add(strServerID, serverList[0].fld_server_ip);
                                }
                            }
                        }
                        catch
                        {
                            OperateResultModel resultModel = new OperateResultModel();
                            resultModel.IsSuccess = false;
                            resultModel.Content = "系统错误";
                            resultModel.Guid = strServerID;
                            resultModelList.Add(resultModel);
                        }
                    }
                }
                else
                {
                    //全服服务器
                    List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("");
                    for (int i = 0; i < serverList.Count; i++)
                    {
                        serverIPs.Add(serverList[i].fld_server_id.ToString(), serverList[i].fld_server_ip);
                    }
                }

                foreach (string strServerKey in serverIPs.Keys)
                {
                    OperateResultModel resultModel = new OperateResultModel();
                    try
                    {
                        resultModel.Guid = strServerKey;
                        string serverIP = serverIPs[strServerKey];
                        if (!string.IsNullOrEmpty(serverIP))
                        {
                            Dictionary<string, string> paramters = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<Dictionary<string, string>>(strParamters);
                            foreach (string strKey in paramters.Keys)
                            {
                                strArgs += (strKey + "=" + paramters[strKey] + "&");
                            }
                            if (!string.IsNullOrEmpty(strArgs))
                            {
                                strArgs = strArgs.Substring(0, strArgs.Length - 1);
                            }
                            if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
                            {
                                serverIP = serverIP.ToUpper().Replace("HTTP://", "");
                            }
                            byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
                            string strContent = Encoding.UTF8.GetString(bytes);
                            resultModel.IsSuccess = true;
                            resultModel.Content = strContent;
                        }
                        else
                        {
                            resultModel.IsSuccess = false;
                            resultModel.Content = "未配置服务器地址";
                        }
                    }
                    catch
                    {
                        resultModel.IsSuccess = false;
                        resultModel.Content = "系统错误";
                    }
                    resultModelList.Add(resultModel);
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


        public virtual string SendMail(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }

            string strArgs = string.Empty;
            string strRoleID = context.Request["RoleID"];
            string strEmailData = context.Request["EmailData"];
            string strServerID = context.Request["ServerID"];
            if (string.IsNullOrEmpty(strServerID))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            if (string.IsNullOrEmpty(strEmailData))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }

            try
            {
                MailModel mailModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<MailModel>(strEmailData);

                FengNiao.GMTools.Database.BLL.tbl_server serverBLL = new FengNiao.GMTools.Database.BLL.tbl_server();
                List<FengNiao.GMTools.Database.Model.tbl_server> serverList = serverBLL.GetModelList("fld_server_id=" + strServerID);
                if (serverList.Count > 0)
                {
                    long mailID = BitConverter.ToInt64(Guid.NewGuid().ToByteArray(), 0);
                    mailModel.emailid = mailID;
                    strEmailData = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<MailModel>(mailModel);
                    string serverIP = serverList[0].fld_server_ip;
                    if (!string.IsNullOrEmpty(serverIP))
                    {

                        if (!string.IsNullOrEmpty(strRoleID))
                        {
                            strArgs += "cmd=sendemail&roleid=" + strRoleID + "&";
                        }
                        else
                        {
                            strArgs += "cmd=sendsysemail&";
                        }
                        strArgs += "emaildata=" + strEmailData;
                        if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
                        {
                            serverIP = serverIP.ToUpper().Replace("HTTP://", "");
                        }
                        byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
                        string strContent = Encoding.UTF8.GetString(bytes);
                        JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(strContent);
                        int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                        if (errorcode == 0)
                        {
                            //发送成功入库
                            FengNiao.GMTools.Database.DAL.tbl_mail mailDAL = new FengNiao.GMTools.Database.DAL.tbl_mail();
                            FengNiao.GMTools.Database.Model.tbl_mail mailDBModel = new FengNiao.GMTools.Database.Model.tbl_mail();
                            mailDBModel.server_id = int.Parse(strServerID);
                            mailDBModel.mail_id = mailModel.emailid;
                            mailDBModel.role_id = strRoleID;
                            mailDBModel.optype = mailModel.optype;
                            mailDBModel.mail_type = string.IsNullOrEmpty(strRoleID) ? 1 : 2;
                            mailDBModel.title = mailModel.title;
                            mailDBModel.content = mailModel.content;
                            mailDBModel.retention = mailModel.retention;
                            mailDBModel.craetetime = DateTime.Now;
                            DateTime startTime = DateTime.Now;
                            DateTime stopTime = DateTime.Now;
                            DateTime.TryParse(mailModel.starttime, out startTime);
                            DateTime.TryParse(mailModel.stoptime, out stopTime);
                            mailDBModel.starttime = startTime;
                            mailDBModel.stoptime = stopTime;

                            mailDBModel.channel = mailModel.channel;
                            mailDBModel.minversion = mailModel.minversion;
                            mailDBModel.maxversion = mailModel.maxversion;
                            mailDBModel.minlevel = mailModel.minlevel;
                            mailDBModel.maxlevel = mailModel.maxlevel;
                            if (!string.IsNullOrEmpty(mailModel.mindatetime) && !string.IsNullOrEmpty(mailModel.maxdatetime))
                            {
                                mailDBModel.mindatetime = DateTime.Parse(mailModel.mindatetime);
                                mailDBModel.maxdatetime = DateTime.Parse(mailModel.maxdatetime);
                            }

                            if (mailModel.items != null)
                            {
                                string strItems = string.Empty;
                                for (int i = 0; i < mailModel.items.Count; i++)
                                {
                                    strItems += "ItemID:" + mailModel.items[i].itemid + "|ItemCount:" + mailModel.items[i].count + "|";
                                }
                                mailDBModel.items = strItems;
                            }
                            try
                            {
                                mailDAL.Add(mailDBModel);
                                requestResult.IsSuccess = true;
                                requestResult.Content = strContent;
                            }
                            catch
                            {
                                requestResult.IsSuccess = true;
                                requestResult.Content = "发送成功，但入库失败";
                            }
                        }
                    }
                    else
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = "未配置服务器地址";
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