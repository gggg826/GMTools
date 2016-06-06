using System;
using System.Collections.Generic;
using System.Web;
using System.Reflection;
using GameToolsCommon;
using FengNiao.GameToolsCommon;
using System.Text;

namespace GameToolsHttpService
{
    public class ProcessRequestBase
    {
        public ProcessRequestBase(string tableName)
        {
            TableName = tableName;
        }
        public string TableName { set; get; }
        public virtual string Add(HttpContext context)
        {
            return "";
        }

        public virtual string Update(HttpContext context)
        {

            string strModel = context.Request["Model"];
            byte[] modelBytes = Encoding.UTF8.GetBytes(strModel);
            strModel = Encoding.UTF8.GetString(modelBytes);
            string strOperationType = context.Request["OperationType"];
            string strGuid = context.Request["guid"];
            ResultModel requestResult = new ResultModel();
            if (!CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            List<OperateResultModel> resultModelList = new List<OperateResultModel>();
            try
            {
                //创建bll对象开始
                Assembly asmb = typeof(FengNiao.GMTools.Database.BLL.tbl_server).Assembly;
                string bllType = "FengNiao.GMTools.Database.BLL." + TableName;
                string modelType = "FengNiao.GMTools.Database.Model." + TableName;
                object bll = Activator.CreateInstance(asmb.GetType(bllType));
                //实例化bll对象结束

                //序列化开始
                asmb = typeof(FengNiao.GMTools.Database.Model.tbl_server).Assembly;
                Type serializeType = typeof(FengNiao.GameTools.Json.Serialize);
                MethodInfo convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
                convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(Type.GetType(modelType + "," + asmb.FullName));
                object modelListObj = convertObjectToJsonList.Invoke(null, new object[] { strModel });
                /*
                convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
                convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(typeof(string));
                object guidListObj = convertObjectToJsonList.Invoke(null, new object[] { strGuid });


                convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
                convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(typeof(OperationType));
                object operationTypeListObj = convertObjectToJsonList.Invoke(null, new object[] { strOperationType });
                */

                List<OperationType> operationTypeList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperationType>(strOperationType);
                List<string> guidList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<string>(strGuid);

                //序列化结束



                //获取长度
                int modelLength = (int)modelListObj.GetType().GetProperty("Count").GetValue(modelListObj, null);
                int guidLength = guidList.Count /*(int)guidListObj.GetType().GetProperty("Count").GetValue(guidListObj, null)*/;
                int operationTypeLength = operationTypeList.Count/*(int)operationTypeListObj.GetType().GetProperty("Count").GetValue(operationTypeListObj, null)*/;

                if (operationTypeList != null && guidList != null && modelLength == guidLength && modelLength == operationTypeLength)
                {
                    for (int i = 0; i < modelLength; i++)
                    {
                        PropertyInfo modelProperty = modelListObj.GetType().GetProperty("Item");
                        object modelObj = modelProperty.GetValue(modelListObj, new object[] { i });
                        if (!DataCheck.CheckObjectIsvalid(modelObj))
                        {
                            requestResult.Content = "非法操作";
                            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                        }
                    }
                    for (int i = 0; i < modelLength; i++)
                    {
                        OperateResultModel result = new OperateResultModel();
                        result.IsSuccess = false;
                        result.Guid = guidList[i];
                        OperationType operationType = operationTypeList[i];
                        PropertyInfo modelProperty = modelListObj.GetType().GetProperty("Item");
                        object modelObj = modelProperty.GetValue(modelListObj, new object[] { i });
                        if (operationType == OperationType.Add)
                        {
                            try
                            {
                                MethodInfo method = bll.GetType().GetMethod("Add");
                                object[] param = new object[] { modelObj };
                                object invokeResult = method.Invoke(bll, param);
                                if ((bool)invokeResult)
                                {
                                    result.IsSuccess = true;
                                    result.Content = "新增成功";
                                }
                            }
                            catch
                            {
                                result.IsSuccess = false;
                                result.Content = "新增失败";
                            }
                        }
                        else if (operationType == OperationType.Update)
                        {
                            try
                            {
                                MethodInfo method = bll.GetType().GetMethod("Update");
                                object[] param = new object[] { modelObj };
                                object invokeResult = method.Invoke(bll, param);
                                if ((bool)invokeResult)
                                {
                                    result.IsSuccess = true;
                                    result.Content = "更新成功";
                                }
                            }
                            catch
                            {
                                result.IsSuccess = false;
                                result.Content = "更新失败";
                            }
                        }
                        resultModelList.Add(result);
                    }
                }
                requestResult.IsSuccess = true;
                requestResult.Content = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperateResultModel>>(resultModelList);
            }
            catch
            {
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }




        public virtual string Remove(HttpContext context)
        {
            return "";
            //string strModel = context.Request["Model"];
            //byte[] modelBytes = Encoding.UTF8.GetBytes(strModel);
            //strModel = Encoding.UTF8.GetString(modelBytes);
            //string strOperationType = context.Request["OperationType"];
            //string strGuid = context.Request["guid"];
            //ResultModel requestResult = new ResultModel();
            //if (!CheckUserSession(context))
            //{
            //    requestResult.IsSuccess = false;
            //    requestResult.Content = "请登陆后操作";
            //    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            //}
            //List<OperateResultModel> resultModelList = new List<OperateResultModel>();
            //try
            //{
            //    //创建bll对象开始
            //    Assembly asmb = typeof(FengNiao.GMTools.Database.BLL.tbl_server).Assembly;
            //    string bllType = "FengNiao.GMTools.Database.BLL." + TableName;
            //    string modelType = "FengNiao.GMTools.Database.Model." + TableName;
            //    object bll = Activator.CreateInstance(asmb.GetType(bllType));
            //    //实例化bll对象结束

            //    //序列化开始
            //    asmb = typeof(FengNiao.GMTools.Database.Model.tbl_server).Assembly;
            //    Type serializeType = typeof(FengNiao.GameTools.Json.Serialize);
            //    MethodInfo convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
            //    convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(Type.GetType(modelType + "," + asmb.FullName));
            //    object modelListObj = convertObjectToJsonList.Invoke(null, new object[] { strModel });
            //    /*
            //    convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
            //    convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(typeof(string));
            //    object guidListObj = convertObjectToJsonList.Invoke(null, new object[] { strGuid });


            //    convertObjectToJsonList = serializeType.GetMethod("ConvertJsonToObjectList");
            //    convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(typeof(OperationType));
            //    object operationTypeListObj = convertObjectToJsonList.Invoke(null, new object[] { strOperationType });
            //    */

            //    List<OperationType> operationTypeList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperationType>(strOperationType);
            //    List<string> guidList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<string>(strGuid);

            //    //序列化结束



            //    //获取长度
            //    int modelLength = (int)modelListObj.GetType().GetProperty("Count").GetValue(modelListObj, null);
            //    int guidLength = guidList.Count /*(int)guidListObj.GetType().GetProperty("Count").GetValue(guidListObj, null)*/;
            //    int operationTypeLength = operationTypeList.Count/*(int)operationTypeListObj.GetType().GetProperty("Count").GetValue(operationTypeListObj, null)*/;

            //    if (operationTypeList != null && guidList != null && modelLength == guidLength && modelLength == operationTypeLength)
            //    {
            //        for (int i = 0; i < modelLength; i++)
            //        {
            //            PropertyInfo modelProperty = modelListObj.GetType().GetProperty("Item");
            //            object modelObj = modelProperty.GetValue(modelListObj, new object[] { i });
            //            if (!DataCheck.CheckObjectIsvalid(modelObj))
            //            {
            //                requestResult.Content = "非法操作";
            //                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            //            }
            //        }
            //        for (int i = 0; i < modelLength; i++)
            //        {
            //            OperateResultModel result = new OperateResultModel();
            //            result.IsSuccess = false;
            //            result.Guid = guidList[i];
            //            OperationType operationType = operationTypeList[i];
            //            PropertyInfo modelProperty = modelListObj.GetType().GetProperty("Item");
            //            object modelObj = modelProperty.GetValue(modelListObj, new object[] { i });
            //            if (operationType == OperationType.Add)
            //            {
            //                try
            //                {
            //                    MethodInfo method = bll.GetType().GetMethod("Add");
            //                    object[] param = new object[] { modelObj };
            //                    object invokeResult = method.Invoke(bll, param);
            //                    if ((bool)invokeResult)
            //                    {
            //                        result.IsSuccess = true;
            //                        result.Content = "新增成功";
            //                    }
            //                }
            //                catch
            //                {
            //                    result.IsSuccess = false;
            //                    result.Content = "新增失败";
            //                }
            //            }
            //            else if (operationType == OperationType.Rmove)
            //            {
            //                try
            //                {
            //                    MethodInfo method = bll.GetType().GetMethod("Rmove");
            //                    object[] param = new object[] { modelObj };
            //                    object invokeResult = method.Invoke(bll, param);
            //                    if ((bool)invokeResult)
            //                    {
            //                        result.IsSuccess = true;
            //                        result.Content = "更新成功";
            //                    }
            //                }
            //                catch
            //                {
            //                    result.IsSuccess = false;
            //                    result.Content = "更新失败";
            //                }
            //            }
            //            resultModelList.Add(result);
            //        }
            //    }
            //    requestResult.IsSuccess = true;
            //    requestResult.Content = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperateResultModel>>(resultModelList);
            //}
            //catch
            //{
            //    requestResult.Content = "系统错误";
            //}
            //return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }

        public virtual string GetModel(HttpContext context)
        {
            return "";
        }

        public virtual string GetList(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            if (!CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            string strParameters = context.Request["Parameter"];
            string strCurrentPage = context.Request["CurrentPage"];
            string strPageCount = context.Request["PageCount"];
            string strLimt = string.Empty;
            int iCurrentPage = -1;
            int iPageCount = -1;
            if (!string.IsNullOrEmpty(strCurrentPage) && !string.IsNullOrEmpty(strCurrentPage))
            {
                if (!int.TryParse(strCurrentPage, out iCurrentPage) || !int.TryParse(strPageCount, out iPageCount))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "参数无效";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                strLimt = string.Format(" limit {0},{1}", (iCurrentPage - 1) * iPageCount, iPageCount);
            }
            string strWhere = string.Empty;
            Assembly asmb = typeof(FengNiao.GMTools.Database.BLL.tbl_server).Assembly;
            string dalType = "FengNiao.GMTools.Database.BLL." + TableName;
            string modelType = "FengNiao.GMTools.Database.Model." + TableName;

            try
            {
                if (!string.IsNullOrEmpty(strParameters))
                {
                    List<HttpInterfaceSqlParameter> parameterList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<HttpInterfaceSqlParameter>(strParameters);
                    string strResult = string.Empty;

                    if (!GenParameter(modelType, parameterList, ref strResult))
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = strResult;
                        return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                    }
                    strWhere = strResult;
                }
                object dal = Activator.CreateInstance(asmb.GetType(dalType));
                MethodInfo method = dal.GetType().GetMethod("GetModelList");
                object[] param = new object[] { strWhere + strLimt };
                object listData = method.Invoke(dal, param);
                asmb = typeof(FengNiao.GMTools.Database.Model.tbl_server).Assembly;
                Type serializeType = typeof(FengNiao.GameTools.Json.Serialize);
                MethodInfo convertObjectToJsonList = serializeType.GetMethod("ConvertObjectToJsonList");
                convertObjectToJsonList = convertObjectToJsonList.MakeGenericMethod(Type.GetType("System.Collections.Generic.List`1[[" + modelType + "," + asmb.FullName + "]]"));
                string strJsonData = convertObjectToJsonList.Invoke(null, new object[] { listData }).ToString();
                requestResult.IsSuccess = true;
                requestResult.Content = strJsonData;
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }



        public virtual string GetCount(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            if (!CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            string strParameters = context.Request["Parameter"];
            string strWhere = string.Empty;
            Assembly asmb = typeof(FengNiao.GMTools.Database.BLL.tbl_server).Assembly;
            string dalType = "FengNiao.GMTools.Database.BLL." + TableName;
            string modelType = "FengNiao.GMTools.Database.Model." + TableName;

            try
            {
                if (!string.IsNullOrEmpty(strParameters))
                {
                    List<HttpInterfaceSqlParameter> parameterList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<HttpInterfaceSqlParameter>(strParameters);
                    string strResult = string.Empty;

                    if (!GenParameter(modelType, parameterList, ref strResult))
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = strResult;
                        return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                    }
                    strWhere = strResult;
                }
                object dal = Activator.CreateInstance(asmb.GetType(dalType));
                MethodInfo method = dal.GetType().GetMethod("GetRecordCount");
                object[] param = new object[] { strWhere };
                object recordCountObj = method.Invoke(dal, param);
                if (recordCountObj != null)
                {
                    int recordCount = (int)recordCountObj;
                    requestResult.IsSuccess = true;
                    requestResult.Content = recordCount.ToString();
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }

        public virtual bool GenParameter(string modelType, List<HttpInterfaceSqlParameter> parameterList, ref string strResult)
        {
            string strWhere = string.Empty;
            Assembly asmb = typeof(FengNiao.GMTools.Database.Model.tbl_server).Assembly;
            object modelObj = Activator.CreateInstance(asmb.GetType(modelType));
            if (modelObj != null)
            {
                PropertyInfo[] propertyInfos = modelObj.GetType().GetProperties();

                foreach (HttpInterfaceSqlParameter parameter in parameterList)
                {
                    if (!DataCheck.CheckObjectIsvalid(parameter, "Value"))
                    {
                        strResult = "非法操作";
                        return false;
                    }
                }
                foreach (HttpInterfaceSqlParameter parameter in parameterList)
                {
                    bool existsParamter = false;
                    for (int i = 0; i < propertyInfos.Length; i++)
                    {
                        PropertyInfo info = propertyInfos[i];
                        if (info.Name.Equals(parameter.Name.Trim('`')))
                        {
                            existsParamter = true;
                        }
                    }
                    if (!existsParamter)
                    {
                        strResult = string.Format("不存在{0}参数", parameter.Name);
                        return false;
                    }
                    strWhere = string.Format("{0} {1} and", strWhere, parameter.ToString());
                }
                if (!string.IsNullOrEmpty(strWhere))
                {
                    strWhere = strWhere.Substring(0, strWhere.Length - 3);
                    strResult = strWhere;
                    return true;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        public virtual bool CheckUserSession(HttpContext context)
        {
            string strSessionID = context.Request["SessionID"];
            string strUserKey = context.Request["UserKey"];
            return UserSession.CheckUserSession(strSessionID, strUserKey);

        }

        public virtual void DeleteSession(HttpContext context)
        {
            string strSessionID = context.Request["SessionID"];
            UserSession.DeleteSession(strSessionID);
        }


        public virtual string Success(HttpContext context)
        {
            return "result:'1'";
        }


        public virtual string Error(HttpContext context)
        {
            return "result:'0'";
        }
    }
}