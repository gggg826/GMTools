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
    public partial class LockRoleSender : BaseForm
    {
        public LockRoleSender()
        {
            InitializeComponent();
            this.Text = "账号封停";
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
            dtUnlockDate.Value = DateTime.Now;
            dtUnlockTime.Value = DateTime.Now;
        }

        public LockRoleSender(FengNiao.GMTools.Database.Model.tbl_server serverData, string roleID)
            : this()
        {
            this.SelectedServerData = serverData;
            this.SelectedRoleID = roleID;
            IsUnlockRole = true;
        }


        private FengNiao.GMTools.Database.Model.tbl_server SelectedServerData;
        private string SelectedRoleID;

        private bool isUnlockRole;
        public bool IsUnlockRole
        {
            set
            {
                isUnlockRole = value;
                tbServer.ButtonCustom.Visible = false;
                tbServer.Tag = SelectedServerData;
                tbServer.Text = SelectedServerData.fld_server_name;
                tbRoleID.ButtonCustom.Visible = false;
                tbRoleID.Text = SelectedRoleID;
                tbRoleID.ReadOnly = true;
                btnLock.Enabled = false;
                btnLockChat.Enabled = false;
                btnKickout.Enabled = false;
                dtUnlockDate.Enabled = false;
                dtUnlockTime.Enabled = false;
                tbReason.Enabled = false;
                cbLockDevice.Enabled = false;
            }
        }

        private void UpdateControlEnabled(bool value)
        {
            btnLock.Enabled = value;
            btnUnlock.Enabled = value;
            btnKickout.Enabled = value;
            tbServer.Enabled = value;
            tbRoleID.Enabled = value;
        }

        private void tbServer_ButtonCustomClick(object sender, EventArgs e)
        {
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.IsSelector = true;
            if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbServer.Text = frmServerManager.SelectedServer.fld_server_name;
                tbServer.Tag = frmServerManager.SelectedServer;
            }
        }

        private void tbRoleID_ButtonCustomClick(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }

            QueryRole queryRoleInfo = new QueryRole(serverData);
            if (queryRoleInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbRoleID.Text = queryRoleInfo.SelectedRoleID;
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            LockRole(0);
        }


        private void btnLockChat_Click(object sender, EventArgs e)
        {
            LockRole(1);
        }

        string strLockType = string.Empty;
        private void LockRole(int lockType)
        {
            strLockType = string.Empty;
            if (lockType == 0)
            {
                strLockType = "账号封停";
            }
            else if (lockType == 1)
            {
                strLockType = "禁言";
            }

            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            if (string.IsNullOrEmpty(tbRoleID.Text))
            {
                CustomMessageBox.Error(this, "角色ID不能为空");
                return;
            }

            string startUnlockTime = dtUnlockDate.Value.ToString("yyyy-MM-dd") + " " + dtUnlockTime.Value.ToString("HH:mm:ss");

            DateTime dt1 = DateTime.Now;

            if (!DateTime.TryParse(startUnlockTime, out dt1))
            {
                CustomMessageBox.Error(this, "解封时间无效");
                return;
            }

            if (DateTime.Compare(DateTime.Now, dt1) > -1)
            {
                CustomMessageBox.Error(this, "解封时间必须大于当前时间");
                return;
            }
            string strReason = tbReason.Text;
            if (string.IsNullOrEmpty(strReason))
            {
                CustomMessageBox.Error(this, "必须对" + strLockType + "进行说明");
                return;
            }

            bool isLockDevice = cbLockDevice.Checked;
            Dictionary<string, string> paramters = new Dictionary<string, string>();
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
            paramters.Add("cmd", "lockrole");
            paramters.Add("roleid", tbRoleID.Text);
            paramters.Add("lockdevice", isLockDevice ? "1" : "0");
            paramters.Add("unlocktime", startUnlockTime);
            paramters.Add("reason", strReason);
            paramters.Add("locktype", lockType.ToString());
            List<string> IDList = new List<string>();
            IDList.Add(serverData.fld_server_id.ToString());
            string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(IDList);
            string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
            strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, LockCallback);
                UpdateControlEnabled(false);
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
        }


        private void LockCallback(object sender, UploadDataCompletedEventArgs e)
        {
            bool isEnabled = true;
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
                            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(resultModelList[0].Content);
                            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                            if (errorcode == 0)
                            {
                                CustomMessageBox.Info(this, string.Format("{0}成功", strLockType));
                            }
                            else
                            {
                                CustomMessageBox.Error(this, string.Format("{0}失败\r\nerrorcode{1}", strLockType, errorcode));
                            }
                        }
                        else
                        {
                            CustomMessageBox.Error(this, string.Format("{0}失败\r\n系统错误", strLockType));
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, string.Format("{0}失败\r\n系统错误", strLockType));
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("{0}失败\r\n{1}", strLockType, requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            UpdateControlEnabled(isEnabled);
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            if (string.IsNullOrEmpty(tbRoleID.Text))
            {
                CustomMessageBox.Error(this, "角色ID不能为空");
                return;
            }

            Dictionary<string, string> paramters = new Dictionary<string, string>();
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
            paramters.Add("cmd", "unlockrole");
            paramters.Add("roleid", tbRoleID.Text);
            List<string> IDList = new List<string>();
            IDList.Add(serverData.fld_server_id.ToString());
            string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(IDList);
            string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
            strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UnlockCallback);
                UpdateControlEnabled(false);
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
        }


        private void UnlockCallback(object sender, UploadDataCompletedEventArgs e)
        {
            bool isEnabled = true;
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
                            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(resultModelList[0].Content);
                            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                            if (errorcode == 0)
                            {
                                CustomMessageBox.Info(this, "已经解封");
                                if (SelectedServerData != null)
                                {
                                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                                }
                            }
                            else
                            {
                                CustomMessageBox.Error(this, string.Format("解封失败\r\nerrorcode{1}", errorcode));
                            }
                        }
                        else
                        {
                            CustomMessageBox.Error(this, "解封失败\r\n系统错误");
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "解封失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("解封失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            UpdateControlEnabled(isEnabled);
        }

        private void btnKickout_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            if (string.IsNullOrEmpty(tbRoleID.Text))
            {
                CustomMessageBox.Error(this, "角色ID不能为空");
                return;
            }
            KickoutRole(serverData.fld_server_id.ToString(), tbRoleID.Text);
        }

        private void KickoutRole(string serverID, string roleID)
        {
            Dictionary<string, string> paramters = new Dictionary<string, string>();
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
            paramters.Add("cmd", "kickrole");
            paramters.Add("roleid", roleID);
            List<string> IDList = new List<string>();
            IDList.Add(serverID);
            string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(IDList);
            string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
            strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, KickoutCallback);
                UpdateControlEnabled(false);
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
        }


        private void KickoutCallback(object sender, UploadDataCompletedEventArgs e)
        {
            bool isEnabled = true;
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
                            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(resultModelList[0].Content);
                            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                            if (errorcode == 0)
                            {
                                CustomMessageBox.Info(this, "已经踢出");
                            }
                            else
                            {
                                CustomMessageBox.Error(this, string.Format("踢出失败\r\nerrorcode{1}", errorcode));
                            }
                        }
                        else
                        {
                            CustomMessageBox.Error(this, "踢出失败\r\n系统错误");
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "踢出失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("踢出失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            UpdateControlEnabled(isEnabled);
        }



    }
}
