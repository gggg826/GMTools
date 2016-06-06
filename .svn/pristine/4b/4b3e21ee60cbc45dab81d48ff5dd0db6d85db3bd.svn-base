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
    public partial class SucessionRewardsManager : FengNiao.GameTools.Util.BaseForm
    {
        private FengNiao.GMTools.Database.Model.tbl_server CurrentServer;

        public SucessionRewardsManager()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.btnSave.Enabled = false;
        }



        //选择服务器
        //--------------------------------------------------------------------------------------------//

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

        //--------------------------------------------------------------------------------------------//





        //查询
        //--------------------------------------------------------------------------------------------//

        #region
        private void btnQuery_Click(object sender, EventArgs e)
        {

            this.btnSave.Enabled = true;
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
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.SuccessRewards_Config, HttpMethodType.GetList);
            List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();
            requestParameters.Add(new HttpInterfaceSqlParameter("serverID", serverData.fld_server_id, SqlCompareType.Equal));
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
                        List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> datalist = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>(requestResult.Content);
                        InitList(datalist);
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

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.record_id, data.date, data.kindReward, data.rewardName1, data.rewardCount1,
                                                   data.rewardName2, data.rewardCount2, data.rewardName3, data.rewardCount3,
                                                   data.rewardName4, data.rewardCount4);
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[12].Value = Guid.NewGuid();

            }
            for (int i = 0; i < gvDataList.RowCount; i++)
            {
                gvDataList.Rows[i].Cells[1].ReadOnly = true;
            }
        }

        #endregion


        //--------------------------------------------------------------------------------------------//







        //新加
        //--------------------------------------------------------------------------------------------//
        #region
        private void btnNew_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            SucessionRewardDetail frmLoginRewardDetail = new SucessionRewardDetail(serverData, this);
            if (frmLoginRewardDetail.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetList();
            }
        }

        public void AddRow(FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config config)
        {
            gvDataList.Rows.Add(config.record_id,
                                config.date,
                                config.kindReward,
                                config.rewardName1,
                                config.rewardCount1,
                                config.rewardName2,
                                config.rewardCount2,
                                config.rewardName3,
                                config.rewardCount3,
                                config.rewardName4,
                                config.rewardCount4);
            gvDataList.Rows[gvDataList.RowCount-1].Tag = config;
        }

        public bool isCanAdd(FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config config)
        {
            for (int i = 0; i < gvDataList.RowCount;i++ )
            {
                FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config temp = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config;
                //if (gvDataList.Rows[i].Cells[1].Value.ToString() == date)
                if(temp == config)
                    return false;
            }
            return true;
        }
        #endregion

        //--------------------------------------------------------------------------------------------//




        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 11)
            {
                FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config data = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config;
                if (data != null)
                {
                    SucessionRewardDetail frmLoginRewardDetail = new SucessionRewardDetail(CurrentServer, data,this);
                    if (frmLoginRewardDetail.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        GetList();
                    }
                }
            }
            else if (e.RowIndex > -1 && e.ColumnIndex == 13)
            {
                gvDataList.Rows.Remove(gvDataList.Rows[e.RowIndex]);
            }

        }

        private void gvDataList_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                if (gvDataList.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection == System.Windows.Forms.SortOrder.Ascending)
                    this.order = System.Windows.Forms.SortOrder.Ascending;
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string strErrorMsg = string.Empty;
            object server_id = null;
            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> dataList = new List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>();
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
                int date = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    date = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                int kind = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    kind = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                int reward1 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    reward1 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                int count1 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    count1 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int reward2 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    reward2 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int count2 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    count2 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                int reward3 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    reward3 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int count3 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    count3 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int reward4 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    reward4 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                cellIndex++;
                int count4 = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    count4 = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                //string guid = gvDataList.Rows[i].Cells[12].Value.ToString();

                if (gvDataList.Rows[i].Tag == null)
                {
                    FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config data = new FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config();
                    data.date = date;
                    data.kindReward = kind;
                    data.rewardName1 = reward1;
                    data.rewardCount1 = count1;
                    data.rewardName2 = reward2;
                    data.rewardCount2 = count2;
                    data.rewardCount3 = count3;
                    data.rewardName3 = reward3;
                    data.rewardName4 = reward4;
                    data.rewardCount4 = count4;
                    data.serverID = CurrentServer.fld_server_id;
                    server_id = data.serverID;
                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);;
                }
                else
                {
                    FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config data = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config;
                    data.record_id = record_id;
                    server_id = data.serverID;
                    data.serverID = CurrentServer.fld_server_id;

                    dataList.Add(data);
                    operationTypes.Add(OperationType.Update);
                    //guidList.Add(guid);
                }
            }
            if (isError)
            {
                CustomMessageBox.Error(this, "保存失败，请根据提示检查数据");
            }
            else
            {
                //if (dataList.Count == operationTypes.Count && dataList.Count == guidList.Count)
                {
                    gvDataList.Visible = true;
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        gvDataList.Rows[i].Tag = dataList[i];
                        server_id = dataList[i].serverID;
                    }

                    List<FengNiao.GMTools.Database.Model.tbl_server> serverList = new List<FengNiao.GMTools.Database.Model.tbl_server>();
                    serverList.Add(CurrentServer);




                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.SuccessRewards_Config, HttpMethodType.Update);
                    string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>>(dataList);
                    string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
                    //string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
                    string strServer = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(CurrentServer.fld_server_id.ToString());
                    strArgs = string.Format("{0}&Model={1}&OperationType={2}&server={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strServer);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
                }
            }
        
        }

        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
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

        private void applytoothers_Click(object sender, EventArgs e)
        {
            AsyncToOtherServers frmAsyncToOtherServers = new AsyncToOtherServers(CurrentServer);
            if(frmAsyncToOtherServers.ShowDialog() == DialogResult.OK)
            {
                CopyConfigToOthers(frmAsyncToOtherServers);
            }
        }

        private void CopyConfigToOthers(AsyncToOtherServers async)
        {
            List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> otherList = new List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>();
            foreach (FengNiao.GMTools.Database.Model.tbl_server other in async.serverList)
            {
                otherList.Clear();
                string strServerid = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(other.fld_server_id.ToString());
                string strServerIP = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(other.fld_server_ip.ToString());
                
                for (int i = 0; i < gvDataList.RowCount; i++)
                {
                    FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config config = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config;
                    config.serverID = other.fld_server_id;
                    otherList.Add(config);
                }
                string strArgs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config>>(otherList);
                    string strMoudle = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.SuccessRewards_Config, HttpMethodType.Add);
                    strArgs = string.Format("{0}&Model={1}&serverid={2}&serverip={3}", strMoudle, strArgs, strServerid, strServerIP);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetCopyCallBack);
                
            }
        }

        private void GetCopyCallBack(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, requestResultModel.Content + "保存完毕");
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
