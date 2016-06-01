using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;

namespace GameToolsHttpService
{
    public class GiftCodeModule : ProcessRequestBase
    {
        public GiftCodeModule(string tableName)
            : base(tableName)
        {
        }

        public override string Add(HttpContext context)
        {
            ResultModel requestResult = new ResultModel();
            string strGiftCodeCount = context.Request["GiftCodeCount"];
            string strGiftPackageID = context.Request["GiftPackageID"];
            string strChannel = context.Request["Channel"];
            string strStartTime = context.Request["StartTime"];
            string strExpiretimeTime = context.Request["ExpiretimeTime"];
            string strMultiUse = context.Request["MultiUse"];
            if (!base.CheckUserSession(context))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "请登陆后操作";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            int iGiftCodeCount = -1;
            if (!int.TryParse(strGiftCodeCount, out iGiftCodeCount))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            if (iGiftCodeCount < 1)
            {
                iGiftCodeCount = 1;
            }
            int iGiftPackageID = -1;
            if (!int.TryParse(strGiftPackageID, out iGiftPackageID))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            DateTime starttime = DateTime.Now;
            DateTime expiretime = DateTime.Now;
            if (!DateTime.TryParse(strStartTime, out starttime))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            if (!DateTime.TryParse(strExpiretimeTime, out expiretime))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }

            if (DateTime.Compare(starttime, expiretime) > -1)
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "过期时间必须大于生效时间";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            int multiuse = 0;
            if (!int.TryParse(strMultiUse, out multiuse))
            {
                requestResult.IsSuccess = false;
                requestResult.Content = "参数无效";
                return FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<ResultModel>(requestResult);
            }
            try
            {
                List<string> giftCodes = new List<string>();
                FengNiao.GMTools.Database.BLL.tbl_gift_code giftCodeBLL = new FengNiao.GMTools.Database.BLL.tbl_gift_code();
                for (int i = 0; i < iGiftCodeCount; i++)
                {
                    string strGiftCode = ((uint)(FengNiao.GameToolsCommon.MD5.GetMD5String(DateTime.Now.ToString() + Guid.NewGuid().ToString()).GetHashCode())).ToString();
                    FengNiao.GMTools.Database.Model.tbl_gift_code giftCodeModel = new FengNiao.GMTools.Database.Model.tbl_gift_code();
                    giftCodeModel.fld_gift_code = strGiftCode;
                    giftCodeModel.fld_gift_package = iGiftPackageID;
                    giftCodeModel.fld_channel = strChannel;
                    giftCodeModel.fld_createtime = DateTime.Now;
                    giftCodeModel.fld_starttime = starttime;
                    giftCodeModel.fld_expiretime = expiretime;
                    giftCodeModel.fld_multi_use = multiuse;
                    try
                    {
                        if (giftCodeBLL.Add(giftCodeModel))
                        {
                            giftCodes.Add(strGiftCode);
                        }
                    }
                    catch
                    {
                    }
                }
                requestResult.IsSuccess = true;
                requestResult.Content = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<List<string>>(giftCodes); ;
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