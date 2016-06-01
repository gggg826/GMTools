using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;
using Newtonsoft.Json.Linq;

namespace GameToolsClient
{
    public partial class QueryRole : BaseForm
    {
        string strCurrentRoleInfo = string.Empty;
        public QueryRole()
        {
            InitializeComponent();
            this.Text = "角色查询";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Image = Properties.Resources.TK_2icon;
        }

        FengNiao.GMTools.Database.Model.tbl_server ServerData;
        public QueryRole(FengNiao.GMTools.Database.Model.tbl_server serverData)
            : this()
        {
            this.ServerData = serverData;
            IsSelector = true;
        }

        private bool isSelector;
        public bool IsSelector
        {
            set
            {
                isSelector = value;
                if (value)
                {
                    this.Height = 103;
                    if (this.ServerData != null)
                    {
                        tbServer.Text = ServerData.fld_server_name;
                        tbServer.Tag = ServerData;
                        tbServer.ButtonCustom.Visible = false;
                    }
                }
            }
        }

        public string SelectedRoleID = string.Empty;

        private void QeuryRole_Load(object sender, EventArgs e)
        {

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRoleID.Text) && string.IsNullOrEmpty(tbRoleName.Text) && string.IsNullOrEmpty(tbUserID.Text))
            {
                CustomMessageBox.Error(this, "角色ID，角色名称，用户ID必须有一项不为空");
                return;
            }
            if (tbServer.Tag == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            strCurrentRoleInfo = string.Empty;
            FengNiao.GMTools.Database.Model.tbl_server data = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (data != null)
            {
                Dictionary<string, string> paramters = new Dictionary<string, string>();
                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
                paramters.Add("cmd", "queryrole");
                strCurrentRoleInfo = "ServerID:" + data.fld_server_id + "\t";
                if (!string.IsNullOrEmpty(tbRoleID.Text))
                {
                    paramters.Add("roleid", tbRoleID.Text);
                    strCurrentRoleInfo += "RoleID:" + tbRoleID.Text;
                }
                if (!string.IsNullOrEmpty(tbRoleName.Text))
                {
                    paramters.Add("rolename", tbRoleName.Text);
                    strCurrentRoleInfo += "RoleName:" + tbRoleName.Text;
                }
                if (!string.IsNullOrEmpty(tbUserID.Text))
                {
                    paramters.Add("userid", tbUserID.Text);
                    strCurrentRoleInfo += "UserID:" + tbUserID.Text;
                }
                List<string> IDList = new List<string>();
                IDList.Add(data.fld_server_id.ToString());
                string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(IDList);
                string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
                strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
                try
                {
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, QueryCallback);
                    btnQuery.Enabled = false;
                }
                catch
                {
                    CustomMessageBox.Error(this, "地址无效");
                }
            }
        }

        private void QueryCallback(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    try
                    {
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResult.Content);
                        if (resultModelList.Count > 0 && resultModelList[0].IsSuccess)
                        {
                            QueryRoleSuccess(resultModelList[0].Content);
                        }
                        else
                        {
                            CustomMessageBox.Error(this, "查询失败\r\n系统错误");
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "查询失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("查询失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnQuery.Enabled = true;
        }

        private void QueryRoleSuccess(string strContent)
        {
            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(strContent);
            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
            if (errorcode == 0)
            {
                JObject resultObj = FengNiao.GameTools.Json.Serialize.GetJsonObject<JObject>(contentObj, "result");
                int bunkerlv = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "bunkerlv");
                string channel = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "channel");
                string createtime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "createtime");
                string deviceid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "deviceid");
                int diamond = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "diamond");
                int gold = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "gold");
                string logintime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "logintime");
                string logoutime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "logoutime");
                JArray mercenarys = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(resultObj, "mercenarys");
                string strMercenarys = string.Empty;
                for (int i = 0; i < mercenarys.Count; i++)
                {
                    JObject mercenaryObj = mercenarys[i] as JObject;
                    int level = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "level");
                    int star = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "star");
                    int stdid = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(mercenaryObj, "stdid");
                    strMercenarys += "\t佣兵" + (i + 1) + " - 等级:" + level + "\t星:" + star + "\tID:" + stdid + "\r\n";
                }
                string phone = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "phone");
                string platform_userid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "platform_userid");
                string role_name = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "role_name");
                string roleid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "roleid");
                int stamina = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "stamina");
                string userid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(resultObj, "userid");
                int vip_lv = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(resultObj, "vip_lv");
                JArray weapons = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(resultObj, "weapons");
                string strWeapons = string.Empty;
                for (int i = 0; i < weapons.Count; i++)
                {
                    JObject weaponObj = weapons[i] as JObject;
                    int level = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "level");
                    int star = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "star");
                    int stdid = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(weaponObj, "stdid");
                    strWeapons += "\t武器" + (i + 1) + " - 等级:" + level + "\t星:" + star + "\tID:" + stdid + "\r\n";
                }
                if (isSelector)
                {
                    SelectedRoleID = roleid;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    return;
                }
                tbRoleInfo.AppendText("账号id:" + userid + "\r\n");
                tbRoleInfo.AppendText("角色id:" + roleid + "\r\n");
                tbRoleInfo.AppendText("角色名:" + role_name + "\r\n");
                tbRoleInfo.AppendText("渠道:" + channel + "\r\n");
                tbRoleInfo.AppendText("平台账户ID:" + platform_userid + "\r\n");
                tbRoleInfo.AppendText("vip等级:" + vip_lv + "\r\n");
                tbRoleInfo.AppendText("钻石:" + diamond + "\r\n");
                tbRoleInfo.AppendText("金币:" + gold + "\r\n");
                tbRoleInfo.AppendText("体力:" + stamina + "\r\n");
                tbRoleInfo.AppendText("\r\n\r\n");
                tbRoleInfo.AppendText("堡垒等级:" + bunkerlv + "\r\n");
                tbRoleInfo.AppendText("佣兵:" + (string.IsNullOrEmpty(strMercenarys) ? "无" : "") + "\r\n");
                if (!string.IsNullOrEmpty(strMercenarys))
                {
                    tbRoleInfo.AppendText(strMercenarys);
                }
                tbRoleInfo.AppendText("\r\n\r\n");

                tbRoleInfo.AppendText("武器:" + (string.IsNullOrEmpty(strWeapons) ? "无" : "") + "\r\n");
                if (!string.IsNullOrEmpty(strWeapons))
                {
                    tbRoleInfo.AppendText(strWeapons);
                }
                tbRoleInfo.AppendText("\r\n\r\n");

                tbRoleInfo.AppendText("手机型号:" + phone + "\r\n");
                tbRoleInfo.AppendText("设备号:" + deviceid + "\r\n");
                tbRoleInfo.AppendText("角色创建时间:" + createtime + "\r\n");
                tbRoleInfo.AppendText("最后登录时间:" + logintime + "\r\n");
                tbRoleInfo.AppendText("最后下线时间:" + logoutime + "\r\n");
            }
            else
            {
                string strErrorInfo = string.Format("没有查到   {0}   的数据,errorcode{1}\r\n", strCurrentRoleInfo, errorcode);
                if (isSelector)
                {
                    CustomMessageBox.Error(this, strErrorInfo);
                }
                tbRoleInfo.AppendText(strErrorInfo);
            }
            tbRoleInfo.AppendText("--------------------------------------------------------------------------\r\n\r\n\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbRoleInfo.Text = "";
        }

        private void tbServer_ButtonCustomClick(object sender, EventArgs e)
        {
            if (!isSelector || this.ServerData == null)
            {
                ServerManager frmServerManager = new ServerManager();
                frmServerManager.IsSelector = true;
                if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    tbServer.Text = frmServerManager.SelectedServer.fld_server_name;
                    tbServer.Tag = frmServerManager.SelectedServer;
                }
            }
        }
    }
}
