using System;
using System.Collections.Generic;
using System.Text;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using Newtonsoft.Json.Linq;
using System.Xml;
namespace Test
{
    class Program
    {
        void JustTest()
        {
          
        }
        
        static void Main(string[] args)
        {
            byte[] bytes = CustomWebRequest.Request("http://192.168.2.58:8080/gm", "cmd=locklist", Encoding.UTF8);
            string strContent = Encoding.UTF8.GetString(bytes);

            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(strContent);
            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
            JArray resultObj = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(contentObj, "result");
            int bunkerlv = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "bunkerlv");
            string channel = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "channel");
            string createtime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "createtime");
            string deviceid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "deviceid");
            int diamond = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "diamond");
            int gold = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "gold");
            string logintime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "logintime");
            string logoutime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "logoutime");
            JArray mercenarys = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(resultObj, "mercenarys");
            for (int i = 0; i < mercenarys.Count; i++)
            {
                JObject mercenaryObj = mercenarys[i] as JObject;
                int level = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "level");
                int star = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "star");
                int stdid = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "stdid");
            }
            string phone = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "phone");
            string platform_userid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "platform_userid");
            string role_name = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "role_name");
            string roleid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "roleid");
            int stamina = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "stamina");
            string userid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "userid");
            int vip_lv = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "vip_lv");
            JArray weapons = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(resultObj, "weapons");
            for (int i = 0; i < weapons.Count; i++)
            {
                JObject weaponObj = weapons[i] as JObject;
                int level = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "level");
                int star = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "star");
                int stdid = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "stdid");
            }
            Console.Read();

        }
    }
}
