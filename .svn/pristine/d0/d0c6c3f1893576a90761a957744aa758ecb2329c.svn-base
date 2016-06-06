using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;
using FengNiao.GameToolsCommon;

namespace GameToolsHttpService
{
    public class UserModule : ProcessRequestBase
    {
        public UserModule(string tableName)
            : base(tableName)
        {
        }

        public virtual string Login(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strUser = context.Request["user"];
            string strPassword = context.Request["password"];
            string strWhere = string.Empty;
            try
            {
                if (string.IsNullOrEmpty(strUser) || string.IsNullOrEmpty(strPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户名或密码不能为空";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                if (!DataCheck.CheckDataIsvalid(strUser))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "非法操作";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }

                if (!DataCheck.CheckDataIsvalid(strPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "非法操作";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                strWhere = string.Format("user_name='{0}' and password='{1}'", strUser, FengNiao.GameToolsCommon.MD5.GetMD5String(strPassword));
                FengNiao.GMTools.Database.BLL.tbl_user userDAL = new FengNiao.GMTools.Database.BLL.tbl_user();
                List<FengNiao.GMTools.Database.Model.tbl_user> users = userDAL.GetModelList(strWhere);
                if (users.Count > 0)
                {
                    FengNiao.GMTools.Database.Model.tbl_user user = users[0];
                    if (user.is_enabled!= null && user.is_enabled == 1)
                    {
                        string strUserKey = FengNiao.GameToolsCommon.MD5.GetMD5String(Guid.NewGuid().ToString());
                        LoginUserModel loginUserModel = new LoginUserModel();
                        loginUserModel.UserID = user.user_id;
                        loginUserModel.UserName = user.user_name;
                        loginUserModel.LoginTime = DateTime.Now;
                        loginUserModel.UserKey = strUserKey;
                        int authority = 0;
                        if (user.authority != null)
                        {
                            authority = user.authority.Value;
                        }
                        loginUserModel.Authority = (uint)authority;
                        UserSession.AddUserSession(user.user_id.ToString(), strUserKey);
                        requestResult.IsSuccess = true;
                        requestResult.Content = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<LoginUserModel>(loginUserModel);
                    }
                    else
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = "该用户已被禁止登陆";
                    }
                }
                else
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户名或者密码错误";
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }
            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }


        public virtual string ChangePassword(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strUserID = context.Request["userID"];
            string strPassword = context.Request["oldPassword"];
            string strNewPassword = context.Request["newPassword"];
            string strWhere = string.Empty;
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {
                if (string.IsNullOrEmpty(strUserID))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户ID不能为空";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                if (string.IsNullOrEmpty(strPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户旧不能为空";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                if (string.IsNullOrEmpty(strNewPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户新密码不能为空";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }
                if (!DataCheck.CheckDataIsvalid(strUserID))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "非法操作";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }

                if (!DataCheck.CheckDataIsvalid(strPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "非法操作";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }

                if (!DataCheck.CheckDataIsvalid(strNewPassword))
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "非法操作";
                    return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
                }

                int userID = -1;
                if (int.TryParse(strUserID,out userID))
                {
                    FengNiao.GMTools.Database.BLL.tbl_user userDAL = new FengNiao.GMTools.Database.BLL.tbl_user();
                    FengNiao.GMTools.Database.Model.tbl_user model = userDAL.GetModel(userID);
                    if (model != null)
                    {
                        string strOldMD5Passsword = FengNiao.GameToolsCommon.MD5.GetMD5String(strPassword);
                        if (model.password == strOldMD5Passsword)
                        {
                            string strNewMD5Password = FengNiao.GameToolsCommon.MD5.GetMD5String(strNewPassword);
                            model.password = strNewMD5Password;
                            if (userDAL.Update(model))
                            {
                                requestResult.IsSuccess = true;
                                requestResult.Content = "修改成功";
                            }
                        }
                        else
                        {
                            requestResult.IsSuccess = false;
                            requestResult.Content = "旧密码错误";
                        }
                    }
                    else
                    {
                        requestResult.IsSuccess = false;
                        requestResult.Content = "不存在该用户";
                    }
                }
                else
                {
                    requestResult.IsSuccess = false;
                    requestResult.Content = "用户ID无效";
                }
            }
            catch
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "系统错误";
            }

            return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
        }


        public virtual string Quit(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            try
            {
                DeleteSession(context);
                requestResult.IsSuccess = true;
                requestResult.Content = "退出成功";
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