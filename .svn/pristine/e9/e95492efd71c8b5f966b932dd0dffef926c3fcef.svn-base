using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using System.Net;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class FirstRechargeManager : BaseForm
    {
        public FirstRechargeManager()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private FengNiao.GMTools.Database.Model.tbl_server CurrentServer;
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
        private void FirstRechargeManager_Load(object sender, EventArgs e)
        {
            InitFirstRechargeList();
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
        private void InitFirstRechargeList()
        {
            if (GlobalObject.ActivityList != null)
            {
                return;
            }
            btnQuery.Enabled = false;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.First_Recharge, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetFirstRechargeListCallback);
        }

        private void GetFirstRechargeListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_first_recharge>(requestResult.Content);
                        GlobalObject.FirstRechargeList = dataList;
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
        private void InitList(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.FirstRecharge_Config, HttpMethodType.GetList);
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
                        List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>(requestResult.Content);

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
        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_first_recharge_config data in dataList)
            {
                string activityName = string.Empty;
                string chanel = string.Empty;
                FengNiao.GMTools.Database.Model.tbl_first_recharge activity = GetFirstRechargeData(data.id);
                if (activity != null)
                {
                    activityName = activity.name.Trim();
                    chanel = activity.channel.Trim();
                }
                else
                {
                    activityName = "未找到该活动原数据";
                }
                int rowIndex = gvDataList.Rows.Add(data.record_id, data.id, activityName);
                //int rowIndex = gvDataList.Rows.Add(data.record_id, data.id, activityName, data.isopen == 1 ? "开启" : "未开启", data.starttime, data.stoptime);
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[4].Value = Guid.NewGuid();
            }
        }
        private FengNiao.GMTools.Database.Model.tbl_first_recharge GetFirstRechargeData(string id)
        {
            FengNiao.GMTools.Database.Model.tbl_first_recharge first_recharge = null;
            for (int i = 0; i < GlobalObject.FirstRechargeList.Count; i++)
            {
                if (GlobalObject.FirstRechargeList[i].itemid.ToString() == id)
                {
                    return GlobalObject.FirstRechargeList[i];
                }
            }
            return first_recharge;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            FirstRechargeDetails frmActivityDetails = new FirstRechargeDetails(serverData);
            if (frmActivityDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetList();
            }
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





        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 5)
            {
                gvDataList.Rows.Remove(gvDataList.Rows[e.RowIndex]);

                //FengNiao.GMTools.Database.Model.tbl_first_recharge_config rewardConfig =  gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_first_recharge_config;
                ////int record_id = int.Parse(gvDataList.Rows[e.RowIndex].Cells[1].Value.ToString());
                //string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>(rewardConfig);
                //string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.FirstRecharge_Config, HttpMethodType.Remove);
                //strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
                //CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetDeletCallback);
            }
        }
        private void GetDeletCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        //List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>(requestResult.Content);

                        InitList(CurrentServer);
                    }
                    else
                    {
                        CurrentServer = null;
                        CustomMessageBox.Error(this, string.Format("删除数据失败\r\n{0}", requestResult.Content));
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
        }









        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string strErrorMsg = string.Empty;
            object server_id = null;
            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config> dataList = new List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>();
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
               

                int cellIndex = 0;
                int record_id = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    record_id = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                string itemid =null;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    itemid = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                }


                string guid = gvDataList.Rows[i].Cells[4].Value.ToString();

                if (gvDataList.Rows[i].Tag == null)
                {
                    FengNiao.GMTools.Database.Model.tbl_first_recharge_config data = new FengNiao.GMTools.Database.Model.tbl_first_recharge_config();
                    data.id = itemid;
                    server_id = data.server_id;
                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);

                    //string activityName = string.Empty;
                    //FengNiao.GMTools.Database.Model.tbl_first_recharge activity = new FengNiao.GMTools.Database.Model.tbl_first_recharge();
                    //List<FengNiao.GMTools.Database.Model.tbl_first_recharge> dataList = new List<FengNiao.GMTools.Database.Model.tbl_first_recharge>();
                    //activityName = gvDataList.Rows[i].Cells[2].Value.ToString();


                    operationTypes.Add(OperationType.Add);


                    guidList.Add(guid);
                }
                else
                {
                    FengNiao.GMTools.Database.Model.tbl_first_recharge_config data = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_first_recharge_config;
                    data.record_id = record_id;
                    //data.serverid = serverid;
                    server_id = data.server_id;
                    data.id = itemid;

                    dataList.Add(data);
                    operationTypes.Add(OperationType.Update);
                    guidList.Add(guid);
                }
            }
            if (isError)
            {
                CustomMessageBox.Error(this, "保存失败，请根据提示检查数据");
            }
            else
            {
                
                //if (dataList.Count == operationTypes.Count)
                if (dataList.Count == operationTypes.Count && dataList.Count == guidList.Count)
                {
                    gvDataList.Visible = true;
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        gvDataList.Rows[i].Tag = dataList[i];
                        server_id = dataList[i].server_id;
                    }

                    List<FengNiao.GMTools.Database.Model.tbl_server> serverList = new List<FengNiao.GMTools.Database.Model.tbl_server>();
                    serverList.Add(CurrentServer);




                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.FirstRecharge_Config, HttpMethodType.Update);
                    string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>>(dataList);
                    string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
                    string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
                    //string strServer = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_server>>(serverList);
                    string strServer = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(CurrentServer.fld_server_id.ToString());
                    strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}&&server={4}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids, strServer);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
                }
            }
        }
        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {

            //loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        //List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        //foreach (OperateResultModel resultModel in resultModelList)
                        //{
                        //    //int rowIndex = GetRowIndexByGuid(resultModel.Guid);
                        //    //if (rowIndex != -1)
                        //    //{
                        //        if (resultModel.IsSuccess)
                        //        {
                        //            dataGridViewX1.Rows[rowIndex].Cells[1].Style.BackColor = successColor;
                        //        }
                        //        else
                        //        {
                        //            dataGridViewX1.Rows[rowIndex].Tag = null;
                        //            dataGridViewX1.Rows[rowIndex].Cells[1].Style.BackColor = errorColor;
                        //            dataGridViewX1.Rows[rowIndex].Cells[1].ErrorText = resultModel.Content;
                        //        }
                        //    //}
                        //}
                        CustomMessageBox.Info(this, "保存完毕");
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("保存失败\r\n{0}", requestResultModel.Content));
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
