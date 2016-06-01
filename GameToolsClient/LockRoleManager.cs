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
    #region
    public partial class LockRoleManager : BaseForm
    {

        public LockRoleManager()
        {
            InitializeComponent();
            this.Text = "封停账号管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            // loadingControl.Dock = DockStyle.Fill;
            this.Image = Properties.Resources.TK_2icon;
        }

        FengNiao.GMTools.Database.Model.tbl_server CurrentServerData;


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshLayout();
        }


        private void RefreshLayout()
        {
            if (this.IsHandleCreated && gvDataList.IsHandleCreated)
            {
                panelParent.Left = base.ClientBounds.X;
                panelParent.Top = base.ClientBounds.Y;
                panelParent.Width = base.ClientBounds.Width;
                panelParent.Height = base.ClientBounds.Height;
            }
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            LockRoleSender frmLockRoleSender = new LockRoleSender();
            frmLockRoleSender.ShowDialog();
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }

            Dictionary<string, string> paramters = new Dictionary<string, string>();
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.Transfer);
            paramters.Add("cmd", "locklist");
            List<string> IDList = new List<string>();
            IDList.Add(serverData.fld_server_id.ToString());
            string strServerIDs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(IDList);
            string strParameters = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<Dictionary<string, string>>(paramters);
            strArgs = string.Format("{0}&ServerID={1}&Paramters={2}", strArgs, strServerIDs, strParameters);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, QueryCallback);
                CurrentServerData = serverData;
                btnQuery.Enabled = false;
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
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
                            FillLockList(resultModelList[0].Content);
                        }
                        else
                        {
                            CustomMessageBox.Error(this, "获取封停账号列表失败\r\n系统错误");
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "获取封停账号列表失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("获取封停账号列表失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnQuery.Enabled = true;
        }


        private void FillLockList(string strContent)
        {
            JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(strContent);
            int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
            if (errorcode == 0)
            {
                gvDataList.Rows.Clear();
                JArray lockRoleInfoList = FengNiao.GameTools.Json.Serialize.GetJsonObject<JArray>(contentObj, "result");
                for (int i = 0; i < lockRoleInfoList.Count; i++)
                {
                    JObject lockRoleInfo = lockRoleInfoList[i] as JObject;
                    bool lockdevice = FengNiao.GameTools.Json.Serialize.GetJsonObject<bool>(lockRoleInfo, "lockdevice");
                    string locktime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(lockRoleInfo, "locktime");
                    int locktype = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(lockRoleInfo, "locktype");
                    string reason = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(lockRoleInfo, "reason");
                    string roleid = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(lockRoleInfo, "roleid");
                    string rolename = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(lockRoleInfo, "rolename");
                    string unlocktime = FengNiao.GameTools.Json.Serialize.GetJsonObject<string>(lockRoleInfo, "unlocktime");
                    gvDataList.Rows.Add(0,
                        locktime,
                        lockdevice ? "锁定" : "不锁定",
                        locktype == 0 ? "锁定账号" : locktype == 1 ? "禁言" : "未知",
                        reason,
                        roleid,
                        rolename,
                        unlocktime);
                }
            }
            else
            {
                CustomMessageBox.Error(this, string.Format("获取封停账号列表失败\r\nerrorcode{1}", errorcode));
            }
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 8)
                {
                    if (gvDataList.Rows[e.RowIndex].Cells[5].Value != null && CurrentServerData != null)
                    {
                        string strRoleID = gvDataList.Rows[e.RowIndex].Cells[5].Value.ToString();
                        LockRoleSender frmLockRoleSender = new LockRoleSender(CurrentServerData, strRoleID);
                        frmLockRoleSender.ShowDialog();
                    }
                }
            }
        }

    }
    #endregion
}
