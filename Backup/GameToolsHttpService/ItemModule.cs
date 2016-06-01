using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;

namespace GameToolsHttpService
{
    public class ItemModule : ProcessRequestBase
    {
        public ItemModule(string tableName)
            : base(tableName)
        {
        }
        public override string Update(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            requestResult.IsSuccess = false;

            string strModel = context.Request["Model"];
            string strGuid = context.Request["guid"];
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }

            if (strModel.Equals(""))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
            }
            else
            {
                List<OperateResultModel> resultModelList = new List<OperateResultModel>();
                FengNiao.GMTools.Database.DAL.tbl_item itemDAL = new FengNiao.GMTools.Database.DAL.tbl_item();
                try
                {
                    itemDAL.Clear();
                    List<FengNiao.GMTools.Database.Model.tbl_item> items = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_item>(strModel);
                    List<string> guidList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<string>(strGuid);
                    for (int i = 0; i < items.Count; i++)
                    {
                        OperateResultModel result = new OperateResultModel();
                        try
                        {
                            if (itemDAL.Add(items[i]))
                            {
                                result.IsSuccess = true;
                                result.Guid = guidList[i];
                                resultModelList.Add(result);
                            }
                            else
                            {
                                result.IsSuccess = false;
                                result.Content = "保存失败";
                                result.Guid = guidList[i];
                            }
                            requestResult.IsSuccess = true;
                            requestResult.Content = "保存成功";
                        }
                        catch
                        {
                            result.IsSuccess = false;
                            result.Content = "保存失败,系统错误";
                            result.Guid = guidList[i];
                        }
                    }
                }
                catch
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "系统错误";
                }
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }
    }
}