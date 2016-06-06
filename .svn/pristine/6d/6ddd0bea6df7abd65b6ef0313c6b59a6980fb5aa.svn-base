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

namespace GameToolsClient
{
    public partial class ActivityManager : BaseForm
    {
        public ActivityManager()
        {
            InitializeComponent();
            this.Text = "活动管理";
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

        private FengNiao.GMTools.Database.Model.tbl_server CurrentServer;

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

        private void btnNew_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            ActivityDetails frmActivityDetails = new ActivityDetails(serverData);
            if (frmActivityDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetList();
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            GetList();
        }

        private void GetList()
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            InitList(serverData);
        }

        private void InitList(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity_Config, HttpMethodType.GetList);
            List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();
            requestParameters.Add(new HttpInterfaceSqlParameter("server_id", serverData.fld_server_id, SqlCompareType.Equal));
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
            CurrentServer = serverData;
            btnQuery.Enabled = false;
        }


        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_activity_config> dataList)
        {   
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_activity_config data in dataList)
            {
                string activityName = string.Empty;
                FengNiao.GMTools.Database.Model.tbl_activity activity = GetActivityData(data.id);
                if (activity != null)
                {
                    activityName = activity.name.Trim();
                }
                else
                {
                    activityName = "未找到该活动原数据";
                }
                int rowIndex = gvDataList.Rows.Add(data.record_id, data.id, activityName, data.isopen == 1 ? "开启" : "未开启", data.starttime, data.stoptime);
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[7].Value = Guid.NewGuid();
            }
        }




        private void GetListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_activity_config> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_activity_config>(requestResult.Content);
                        InitList(dataList);
                    }
                    else
                    {
                        CurrentServer = null;
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                    }
                }
                catch
                {
                    CurrentServer = null;
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CurrentServer = null;
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnQuery.Enabled = true;
        }

        private void InitActivityList()
        {
            if (GlobalObject.ActivityList != null)
            {
                return;
            }
            btnQuery.Enabled = false;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetActivityListCallback);
        }

        private void GetActivityListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_activity> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_activity>(requestResult.Content);
                        GlobalObject.ActivityList = dataList;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("初始化活动原数据失败\r\n{0}", requestResult.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnQuery.Enabled = true;
        }


        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                FengNiao.GMTools.Database.Model.tbl_activity_config data = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_activity_config;
                if (data != null)
                {
                    ActivityDetails frmActivityDetails = new ActivityDetails(CurrentServer, data, GetActivityData(data.id));
                    if (frmActivityDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        GetList();
                    }
                }
            }
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

        private void ActivityManager_Load(object sender, EventArgs e)
        {
            InitActivityList();
            RefreshLayout();
        }

        private FengNiao.GMTools.Database.Model.tbl_activity GetActivityData(int id)
        {
            FengNiao.GMTools.Database.Model.tbl_activity activity = null;
            for (int i = 0; i < GlobalObject.ActivityList.Count; i++)
            {
                if (GlobalObject.ActivityList[i].id == id)
                {
                    return GlobalObject.ActivityList[i];
                }
            }
            return activity;
        }

        private void btnImportAll_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity_Config,  HttpMethodType.AddAll);
            strArgs = string.Format("{0}&ServerID={1}", strArgs, serverData.fld_server_id);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, ImportAllActivityCallback);
        }

        private void ImportAllActivityCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        string strResultMessage = string.Empty;
                        for (int i = 0; i < resultModelList.Count; i++)
                        {
                            strResultMessage += resultModelList[i].Content + "\r\n";
                        }
                        ImportActivityResult frmImportActivityResult = new ImportActivityResult();
                        frmImportActivityResult.ResultMessage = strResultMessage;
                        frmImportActivityResult.ShowDialog();
                        GetList();
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("导入活动失败\r\n{0}", requestResultModel.Content));
                    }
                }
                catch
                {
                    CustomMessageBox.Error(this, "服务器返回的数据无效");
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }
    }
}
