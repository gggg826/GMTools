using System;
using System.Collections.Generic;
using System.Text;

namespace FengNiao.GameToolsCommon
{
    public enum HttpMethodType
    {
        Add = 1,
        GetList = 2,
        Remove = 3,
        Update = 4,
        GetModel = 5,
        GetCount = 6,
        Login = 7,
        ChangePassword = 8,
        Quit = 9,
        Testing = 10,
        Transfer = 11,
        SendMail = 12,
        AddAll = 13
        //CopyToOther = 14
    }


    public enum HttpModuleType
    {
        ListServer = 1,
        Notice = 2,
        Package = 3,
        Package_Server = 4,
        Package_Upgrade = 5,
        Resource_Upgrade = 6,
        Server = 7,
        Server_Group = 8,
        Template = 9,
        TesterDevice = 10,
        GiftCode = 11,
        GiftPackage = 12,
        Item = 13,
        User = 14,
        Tester = 15,
        Transfer = 16,
        Mail = 17,
        Activity = 18,
        Activity_Config = 19,
        Notice_Config = 20,
        Recommend = 21,
        First_Recharge= 22,
        FirstRecharge_Config = 23,
        LoginRewards_Config = 24,
        SuccessRewards_Config =25,
        CountsConfig = 26,
        ProtoCount = 27,
        PushNotice = 28
    }

    public enum OperationType
    {
        Add = 1,
        Update = 2,
        Rmove = 3
    }

    public enum SqlCompareType
    {
        //小于
        LessThan = 1,
        //等于
        Equal = 2,
        //大于
        MoreThan = 3,
        //小于等于
        LessThanAndEqual = 4,
        //大于等于
        MoreThanAndEqual = 5,
        /// <summary>
        /// 不等于
        /// </summary>
        NotEqual = 6,
        /// <summary>
        /// 模糊查找
        /// </summary>
        Like = 7
    }
}
