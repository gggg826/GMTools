using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameToolsCommon;
using System.Text;

namespace GameToolsHttpService
{
    public class CheckChatModule:ProcessRequestBase
    {
        public CheckChatModule(string tableName) : base(tableName)
        {

        }

        public override string Add(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string server_ip = context.Request["ServerIP"];


            try
            {
                //string serverIP = "10.0.11.26:8080";
                string serverIP = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<string>(server_ip);
                if (!string.IsNullOrEmpty(serverIP))
                {
                    string strArgs = "cmd=chat_history";
                    if (serverIP.ToUpper().IndexOf("HTTP://") != -1)
                    {
                        serverIP = serverIP.ToUpper().Replace("HTTP://", "");
                    }
                    byte[] bytes = CustomWebRequest.Request(string.Format("http://{0}/gm", serverIP), strArgs, Encoding.UTF8);
                    string strContent = Encoding.UTF8.GetString(bytes);
                    requestResult.IsSuccess = true;
                    requestResult.Content = strContent;
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "获取记录失败！";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }
    }
}