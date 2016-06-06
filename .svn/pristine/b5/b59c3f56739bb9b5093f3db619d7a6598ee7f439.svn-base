using System;
using System.Collections.Generic;
using System.Text;
using FengNiao.GameToolsCommon;
using System.Windows.Forms;
using System.Xml;
using FengNiao.GameTools.Util;
using GameToolsCommon;

namespace GameToolsClient
{
    public class DataEnableModel
    {
        public string DisplayName { set; get; }
        public int State { set; get; }
    }

    public class DeviceTypeModel
    {
        public DeviceTypeModel(string displayName, string deviceType)
        {
            this.DisplayName = displayName;
            this.DeviceType = deviceType;
        }
        public string DisplayName { set; get; }
        public string DeviceType { set; get; }
    }

    public enum DetailsType
    {
        New,
        Edit
    }

    public class ServerInfoData
    {
        public string Title { set; get; }
        public string HttpInterface { set; get; }
    }

    public class DirectoryInfoData
    {
        public string Title { set; get; }
        public string DestinationDirectory { set; get; }
    }

    public class GlobalObject
    {
        static GlobalObject()
        {
            DeviceTypeList = new List<DeviceTypeModel>();
            DeviceTypeList.Add(new DeviceTypeModel("苹果", "ios"));
            DeviceTypeList.Add(new DeviceTypeModel("安卓", "android"));
            DeviceTypeList.Add(new DeviceTypeModel("PC端", "pc"));
            DeviceTypeList.Add(new DeviceTypeModel("MAC", "mac"));
            DeviceTypeList.Add(new DeviceTypeModel("Windows Phone 8", "wp8"));
            DeviceTypeList.Add(new DeviceTypeModel("Windows Phone 10", "wp10"));
        }
        public static List<ServerInfoData> HttpServerDataList = new List<ServerInfoData>();
        public static List<DirectoryInfoData> DirectoryDataList = new List<DirectoryInfoData>();
        public static string HttpServerIP = "http://localhost:252851/GameInterface.ashx";
        public static List<FengNiao.GMTools.Database.Model.tbl_package> PackageList;
        public static List<FengNiao.GMTools.Database.Model.tbl_server_group> ServerGroupList;
        public static List<FengNiao.GMTools.Database.Model.tbl_server> ServerList;
        public static List<FengNiao.GMTools.Database.Model.tbl_notice> NoticeList;
        public static List<FengNiao.GMTools.Database.Model.tbl_first_recharge> FirstRechargeList;
        public static List<FengNiao.GMTools.Database.Model.tbl_testerdevice> TesterDeviceList;
        public static List<FengNiao.GMTools.Database.Model.tbl_package_upgrade> PackageUpgradeList;
        public static List<FengNiao.GMTools.Database.Model.tbl_resource_upgrade> ResourceUpgradeList;
        public static List<FengNiao.GMTools.Database.Model.tbl_item> ItemList;
        public static List<FengNiao.GMTools.Database.Model.tbl_activity> ActivityList;
        public static List<FengNiao.GMTools.Database.Model.tbl_gift_package> GiftPackageList;
        public static List<FengNiao.GMTools.Database.Model.tbl_user> UserList;
        public static List<FengNiao.GMTools.Database.Model.tbl_login_rewards_config> LoginRewardList;
        public static List<FengNiao.GMTools.Database.Model.tbl_counts_config> CountsList;
        public static List<FengNiao.GMTools.Database.Model.tbl_proto_cout> ProtoList;
        public static List<FengNiao.GMTools.Database.Model.tbl_activity_config> ActivityConfigList;
        public static List<DeviceTypeModel> DeviceTypeList;
        public static Login frmLogin;

        public static int DefalutItemCount = 1;
        public static int PasswrodLength = 6;

        public static LoginUserModel CurrentLoginUserModel;


        private static Dictionary<int, string> _recommends;

        public static Dictionary<int, string> Recommends
        {
            get
            {
                if (_recommends == null)
                {
                    XmlConfig xmlConfig = new XmlConfig(Runpath.AppPath + "system.config");
                    XmlNodeList nodes = xmlConfig.GetXmlNodes("config", "recommend");
                    _recommends = new Dictionary<int, string>();
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        _recommends.Add(int.Parse(nodes[i].Attributes["id"].InnerText), nodes[i].InnerText);
                    }
                }
                return _recommends;
            }
            set
            {
                _recommends = value;
            }
        }

        public static Dictionary<int, string> GetRecommends()
        {
            _recommends = new Dictionary<int, string>();
            foreach (FengNiao.GMTools.Database.Model.tbl_activity_config item in ActivityConfigList)
            {
                string name = string.Empty;
                foreach (FengNiao.GMTools.Database.Model.tbl_activity activity in ActivityList)
	            {
		            if(item.id == activity.id)
                    {
                        name = activity.name;
                        break;
                    }
	            }
                _recommends.Add(item.id, name);
            }
            return _recommends;
        }

        private static Dictionary<int, string> _recommendRanks;

        public static Dictionary<int, string> RecommendRanks
        {
            get
            {
                if (_recommendRanks == null)
                {
                    XmlConfig xmlConfig = new XmlConfig(Runpath.AppPath + "system.config");
                    XmlNodeList nodes = xmlConfig.GetXmlNodes("config", "recommendRank");
                    _recommendRanks = new Dictionary<int, string>();
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        _recommendRanks.Add(int.Parse(nodes[i].Attributes["id"].InnerText), nodes[i].InnerText);
                    }
                }
                return _recommendRanks;
            }
        }

        private static Dictionary<int, string> _quickList;

        public static Dictionary<int, string> QuickList
        {
            get
            {
                if (_quickList == null)
                {
                    XmlConfig xmlConfig = new XmlConfig(Runpath.AppPath + "system.config");
                    XmlNodeList nodes = xmlConfig.GetXmlNodes("config", "quickui");
                    _quickList = new Dictionary<int, string>();
                    for (int i = 0; i < nodes.Count; i++)
                    {
                        _quickList.Add(int.Parse(nodes[i].Attributes["id"].InnerText), nodes[i].InnerText);
                    }
                }
                return _quickList;
            }
        }

        public static string GetModuleAndMethodArgs(HttpModuleType moduleType, HttpMethodType methodType)
        {
            string strArgs = string.Format("Module={0}&Method={1}", (int)moduleType, (int)methodType);
            if (GlobalObject.CurrentLoginUserModel != null)
            {
                strArgs = string.Format("{0}&SessionID={1}&UserKey={2}", strArgs, GlobalObject.CurrentLoginUserModel.UserID, GlobalObject.CurrentLoginUserModel.UserKey);
            }
            return strArgs;
        }




        public static DataGridViewComboBoxCell GetCommonCell(string str1, string str2)
        {
            DataGridViewComboBoxCell enabledColumn = new DataGridViewComboBoxCell();
            DataEnableModel normal = new DataEnableModel();
            normal.DisplayName = str1;
            normal.State = 0;
            enabledColumn.Items.Add(normal);
            DataEnableModel disble = new DataEnableModel();
            disble.DisplayName = str2;
            disble.State = 1;
            enabledColumn.Items.Add(disble);
            enabledColumn.DisplayMember = "DisplayName";
            enabledColumn.ValueMember = "State";
            return enabledColumn;
        }


        public static DataGridViewComboBoxCell GetServerGroupCell()
        {
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            if (ServerGroupList != null)
            {
                for (int i = 0; i < ServerGroupList.Count; i++)
                {
                    cell.Items.Add(ServerGroupList[i]);
                }
                cell.DisplayMember = "fld_group_name";
                cell.ValueMember = "fld_group_id";
            }
            return cell;
        }


        public static DataGridViewComboBoxCell GetDeviceTypeCell()
        {
            DataGridViewComboBoxCell cell = new DataGridViewComboBoxCell();
            for (int i = 0; i < DeviceTypeList.Count; i++)
            {
                cell.Items.Add(DeviceTypeList[i]);
            }
            cell.DisplayMember = "DisplayName";
            cell.ValueMember = "DeviceType";
            return cell;
        }

        public static bool IsExistsServerGroup(int groupID)
        {
            if (ServerGroupList != null)
            {
                for (int i = 0; i < ServerGroupList.Count; i++)
                {
                    if (ServerGroupList[i].fld_group_id == groupID)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


        public static FengNiao.GMTools.Database.Model.tbl_item GetGiftPackageItem(int itemID)
        {
            foreach (FengNiao.GMTools.Database.Model.tbl_item item in GlobalObject.ItemList)
            {
                if (item.item_id == itemID)
                {
                    return item;
                }
            }
            return null;
        }

        public static string GetAuthorityText(uint authority)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(GetBitValue(authority, 1) ? "礼包管理," : "");
            sb.Append(GetBitValue(authority, 2) ? "礼包码管理," : "");
            sb.Append(GetBitValue(authority, 3) ? "服务器配置," : "");
            sb.Append(GetBitValue(authority, 4) ? "物品导入," : "");
            sb.Append(GetBitValue(authority, 12) ? "活动导入" : "");
            sb.Append(GetBitValue(authority, 6) ? "用户管理," : "");
            sb.Append(GetBitValue(authority, 5) ? "游戏广播," : "");
            sb.Append(GetBitValue(authority, 7) ? "角色查询," : "");
            sb.Append(GetBitValue(authority, 8) ? "邮件发送," : "");
            sb.Append(GetBitValue(authority, 9) ? "游戏公告," : "");
            sb.Append(GetBitValue(authority, 10) ? "账号封停" : "");
            sb.Append(GetBitValue(authority, 11) ? "活动管理" : "");
            sb.Append(GetBitValue(authority, 12) ? "Loading界面管理" : "");
            string strAuthority = sb.ToString();
            if (!string.IsNullOrEmpty(strAuthority))
            {
                strAuthority = strAuthority.Substring(0, strAuthority.Length - 1);
            }
            return strAuthority.ToString();
        }

        public static void SetBitValue(ref uint val, bool bval, int pos)
        {
            uint mask = bval ? 0x00000001u : 0x00000000u;
            mask = mask << (pos - 1);
            val = val | mask;
        }

        public static bool GetBitValue(uint val, int pos)
        {
            uint mask = 0x00000001u;
            mask = mask << (pos - 1);
            uint tVal = val & mask;
            tVal = tVal >> (pos - 1);
            bool bVal = Convert.ToBoolean(tVal);
            return bVal;
        }

        public static string GetMd5Hash(string pathName)
        {
            string StrResult = string.Empty;
            string StrHashData = string.Empty;
            byte[] ArrbytHashValue = null;

            System.IO.FileStream OFileStream = null;
            System.Security.Cryptography.MD5CryptoServiceProvider MD5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            try
            {
                OFileStream = new System.IO.FileStream(pathName.Replace("\"", ""), System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.ReadWrite);
                ArrbytHashValue = MD5Hasher.ComputeHash(OFileStream);
                OFileStream.Close();

                //由以连字符分隔的十六进制对构成的String，其中每一对表示value 中对应的元素；例如“F-2C-4A”
                StrHashData = System.BitConverter.ToString(ArrbytHashValue);
                StrHashData = StrHashData.Replace("-", "");
                StrResult = StrHashData;
            }
            catch (System.Exception ex)
            {

            }
            return StrResult;
        }
    }
}
