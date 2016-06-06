using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.Net;
using FengNiao.GameToolsCommon;
using DevComponents.DotNetBar;
using GameToolsCommon;
namespace GameToolsClient
{
    public partial class CountManagers : FengNiao.GameTools.Util.BaseForm
    {


        Dictionary<int, string> CountsModleDir = new Dictionary<int, string>();
        FengNiao.GMTools.Database.Model.tbl_server CurrentServer = new FengNiao.GMTools.Database.Model.tbl_server();
        //bool isGetCountsDir = false;

        public CountManagers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.lbSaving.BringToFront();
            this.lbSaving.Visible = false;
            SetButtonStatus(false);
        }




        //选择服务器
        //====================================================================================================================
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
        //====================================================================================================================




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

        #endregion


        //--------------------------------------------------------------------------------------------//






        //初始化
        //====================================================================================================================
        #region
        private void CountManagers_Load(object sender, EventArgs e)
        {
            InitModleDir();
        }


        //初始化CountsModleDir字典
        private void InitModleDir()
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.ProtoCount, HttpMethodType.GetList);

            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetCountModelCallBack);
        }


        //初始化CountsModleDir字典
        private void GetCountModelCallBack(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_proto_cout> list = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_proto_cout>(requestResult.Content);
                        foreach (FengNiao.GMTools.Database.Model.tbl_proto_cout item in list)
                        {
                            CountsModleDir.Add(item.proteo_id, item.button_name);
                        }
                        GlobalObject.ProtoList = list;

                        InitComboBoxColumn();
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
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


        //初始化DataGridView
        private void InitList(FengNiao.GMTools.Database.Model.tbl_server server)
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.CountsConfig, HttpMethodType.GetList);
            List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();
            requestParameters.Add(new HttpInterfaceSqlParameter("serverID", server.fld_server_id, SqlCompareType.Equal));
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
            CurrentServer = server;
            btnCustomQuery.Enabled = false;

        }


        //初始化DataGridView
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
                        List<FengNiao.GMTools.Database.Model.tbl_counts_config> list = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_counts_config>(requestResult.Content);
                        GlobalObject.CountsList = list;
                        InitList(GlobalObject.CountsList);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
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


        //初始化DataGridView
        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_counts_config> countList)
        {
            this.btnSave.Enabled = true;
            gvDataList.Rows.Clear();
            setDeleteButton(true);
            gvDataList.Columns[1].ReadOnly = true;
            //InitComboBoxColumn();
            foreach (FengNiao.GMTools.Database.Model.tbl_counts_config counts in countList)
            {
                string kind = string.Empty;
                if (counts.kindofrewards == 0)
                    kind = "全部领取";
                else if (counts.kindofrewards == 1)
                    kind = "四选一";

                string name = string.Empty;
                if (CountsModleDir.TryGetValue(counts.item_id, out name))
                {
                    int rowIndex = gvDataList.Rows.Add(name + "-" + counts.item_id, counts.record_id, counts.count, counts.dec, kind, counts.reward1, counts.count1, counts.reward2, counts.reward2, counts.reward3, counts.count3, counts.reward4, counts.count4);
                    //gvDataList.Rows[rowIndex].Cells[1].Value = name;
                }
                else
                {
                    CustomMessageBox.Error(this, "初始化数据失败");
                    return;
                }
                btnSave.Enabled = true;
                btnNew.Enabled = true;
            }
        }


        //初始化活动名称列
        private void InitComboBoxColumn()
        {
            DataGridViewComboBoxColumn colShow = new DataGridViewComboBoxColumn();
            colShow.Name = "item_name";
            colShow.HeaderText = "活动名称";
            colShow.Width = 200;
            foreach (var item in CountsModleDir)
            {
                colShow.Items.Add(item.Value + "-" + item.Key);
            }
            colShow.DisplayIndex = 0;
            gvDataList.Columns.Insert(0, colShow);


            DataGridViewComboBoxColumn kindShow = new DataGridViewComboBoxColumn();
            kindShow.Name = "kindofReward";
            kindShow.HeaderText = "奖励类型";
            kindShow.Width = 200;
            kindShow.Items.Add("全部领取");
            kindShow.Items.Add("四选一");
            gvDataList.Columns.Insert(4, kindShow);

        }

        #endregion
        //====================================================================================================================



        //添加活动按钮
        //====================================================================================================================
        private void btnNew_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            int index = gvDataList.Rows.Add();
            gvDataList.Rows[index].Cells[1].Value = GetNewRecordID();
        }
        //====================================================================================================================




        //保存活动按钮
        //====================================================================================================================
        private void btnSave_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }

            //if(!isCanSave())
            //{
            //    CustomMessageBox.Error(this, "请检查是否有重复的项目");
            //    return;
            //}


            //SetButtonStatus(false);

            bool isError = false;
            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_counts_config> dataList = new List<FengNiao.GMTools.Database.Model.tbl_counts_config>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                int cellIndex = 0;
                int item_name = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    string tempname = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                    item_name = int.Parse(tempname.Substring(tempname.LastIndexOf("-") + 1));
                }
                else
                {
                    CustomMessageBox.Error(this, "请选择活动ID");
                    return;
                }


                cellIndex++;
                int record_id = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    record_id = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }

                cellIndex++;
                int count = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    count = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                else
                {
                    CustomMessageBox.Error(this, "请填写目标数量");
                    return;
                }

                cellIndex++;
                string dec = string.Empty;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    dec = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                }
                else
                {
                    CustomMessageBox.Error(this, "请填写描述");
                    return;
                }

                cellIndex++;
                int kindofReward = 0;
                if (gvDataList.Rows[i].Cells[cellIndex].Value != null)
                {
                    if (gvDataList.Rows[i].Cells[cellIndex].Value.ToString() == "全部领取")
                        kindofReward = 0;
                    else if (gvDataList.Rows[i].Cells[cellIndex].Value.ToString() == "四选一")
                        kindofReward = 1;

                    //kindofReward = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                }
                else
                {
                    CustomMessageBox.Error(this, "请选择奖励类型");
                    return;
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

                int serverID = CurrentServer.fld_server_id;

                //int record_id = 0;
                //foreach (var item in GlobalObject.ProtoList)
                //{
                //    if (item.proteo_id == item_name)
                //    {
                //        record_id = item.record_id;
                //    }
                //}



                FengNiao.GMTools.Database.Model.tbl_counts_config data = new FengNiao.GMTools.Database.Model.tbl_counts_config();
                data.record_id = record_id;
                data.item_id = item_name;
                data.count = count;
                data.dec = dec;
                data.kindofrewards = kindofReward;
                data.reward1 = reward1;
                data.count1 = count1;
                data.reward2 = reward2;
                data.count2 = count2;
                data.reward3 = reward3;
                data.count3 = count3;
                data.reward4 = reward4;
                data.count4 = count4;
                data.serverID = CurrentServer.fld_server_id;
                dataList.Add(data);
            }
            if (isError)
            {
                CustomMessageBox.Error(this, "保存失败，请根据提示检查数据");
                SetButtonStatus(true);
            }
            else
            {
                //if (dataList.Count == operationTypes.Count)
                //{
                gvDataList.Visible = true;
                for (int i = 0; i < dataList.Count; i++)
                {
                    gvDataList.Rows[i].Tag = dataList[i];
                }

                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.CountsConfig, HttpMethodType.Update);
                string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_counts_config>>(dataList);
                string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
                string strServer = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(CurrentServer.fld_server_id.ToString());
                strArgs = string.Format("{0}&Model={1}&OperationType={2}&&server={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strServer);
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
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
                        SetButtonStatus(true);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("{0}", requestResultModel.Content));
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
        //====================================================================================================================




        //删除活动按钮
        //====================================================================================================================
        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 15)
            {
                gvDataList.Rows.Remove(gvDataList.Rows[e.RowIndex]);
            }
        }
        //====================================================================================================================





        //筛选查询
        //====================================================================================================================
        private void btnCustomQuery_click(object sender, EventArgs e)
        {
            InitGlobalObjectList();
            if (tbItemID.Text == null || tbItemID.Text.ToString() == "")
            {
                gvDataList.Rows.Clear();
                setDeleteButton(true);
                gvDataList.Columns[1].ReadOnly = true;
                foreach (FengNiao.GMTools.Database.Model.tbl_counts_config counts in GlobalObject.CountsList)
                {
                    if (counts.serverID != CurrentServer.fld_server_id)
                        continue;
                    string kind = string.Empty;
                    if (counts.kindofrewards == 0)
                        kind = "全部领取";
                    else if (counts.kindofrewards == 1)
                        kind = "四选一";

                    string name = string.Empty;
                    if (CountsModleDir.TryGetValue(counts.item_id, out name))
                    {
                        int rowIndex = gvDataList.Rows.Add(name + "-" + counts.item_id, counts.record_id, counts.count, counts.dec, kind, counts.reward1, counts.count1, counts.reward2, counts.reward2, counts.reward3, counts.count3, counts.reward4, counts.count4);
                    }
                    else
                    {
                        CustomMessageBox.Error(this, "初始化数据失败");

                        return;
                    }
                    btnSave.Enabled = true;
                }
            }
            else
            {
                btnSave.Enabled = false;
                int id = int.Parse(tbItemID.Text.ToString());
                gvDataList.Rows.Clear();
                setDeleteButton(false);
                gvDataList.Columns[1].ReadOnly = true;
                foreach (FengNiao.GMTools.Database.Model.tbl_counts_config counts in GlobalObject.CountsList)
                {
                    string kind = string.Empty;
                    if (counts.kindofrewards == 0)
                        kind = "全部领取";
                    else if (counts.kindofrewards == 1)
                        kind = "四选一";

                    if (counts.item_id == id)
                    {
                        string name = string.Empty;

                        if (CountsModleDir.TryGetValue(counts.item_id, out name))
                        {
                            int rowIndex = gvDataList.Rows.Add(name + "-" + counts.item_id, counts.record_id, counts.count, counts.dec, kind, counts.reward1, counts.count1, counts.reward2, counts.reward2, counts.reward3, counts.count3, counts.reward4, counts.count4);
                        }
                        else
                        {
                            CustomMessageBox.Error(this, "初始化数据失败，请检查ID");
                            return;
                        }
                    }
                }

            }
        }
        //====================================================================================================================




        //重新初始化GlobalObject.CountsList
        //====================================================================================================================
        #region
        private void InitGlobalObjectList()
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.CountsConfig, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetGlobalListCallback);
        }



        private void GetGlobalListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_counts_config> list = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_counts_config>(requestResult.Content);
                        GlobalObject.CountsList = list;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
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
        #endregion
        //====================================================================================================================






        //public void gvDataList_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e. == 2)
        //        return;

        //    if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
        //    {
        //        e.Handled = false;       //让操作生效
        //        int j = 0;
        //        int k = 0;
        //        bool flag = false;
        //        if (dgvTxt.Text.Length == 0)
        //        {
        //            if (e.KeyChar == '.')
        //            {
        //                e.Handled = true;             //让操作失效
        //            }
        //        }
        //        for (int i = 0; i < dgvTxt.Text.Length; i++)
        //        {
        //            if (dgvTxt.Text[i] == '.')
        //            {
        //                j++;
        //                flag = true;
        //            }
        //            if (flag)
        //            {
        //                if (char.IsNumber(dgvTxt.Text[i]) && e.KeyChar != (char)Keys.Back)
        //                {
        //                    k++;
        //                }
        //            }
        //            if (j >= 1)
        //            {
        //                if (e.KeyChar == '.')
        //                {
        //                    e.Handled = true;             //让操作失效
        //                }
        //            }
        //            if (k == 2)
        //            {
        //                if (char.IsNumber(dgvTxt.Text[i]) && e.KeyChar != (char)Keys.Back)
        //                {
        //                    if (dgvTxt.Text.Length - dgvTxt.SelectionStart < 3)
        //                    {
        //                        if (dgvTxt.SelectedText != dgvTxt.Text)
        //                        {
        //                            e.Handled = true;             ////让操作失效
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}



      
        private void applytoothers_Click(object sender, EventArgs e)
        {
            AsyncToOtherServers frmAsyncToOtherServers = new AsyncToOtherServers(CurrentServer);
            if (frmAsyncToOtherServers.ShowDialog() == DialogResult.OK)
            {
                CopyConfigToOthers(frmAsyncToOtherServers);
            }
        }

        private void CopyConfigToOthers(AsyncToOtherServers async)
        {
            List<FengNiao.GMTools.Database.Model.tbl_counts_config> otherList = new List<FengNiao.GMTools.Database.Model.tbl_counts_config>();

            foreach (FengNiao.GMTools.Database.Model.tbl_server other in async.serverList)
            {
                otherList.Clear();
                string strServerid = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(other.fld_server_id.ToString());
                string strServerIP = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<string>(other.fld_server_ip.ToString());
                for (int i = 0; i < gvDataList.RowCount; i++)
                {
                    FengNiao.GMTools.Database.Model.tbl_counts_config config = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_counts_config;
                    config.serverID = other.fld_server_id;
                    otherList.Add(config);
                }
                string strArgs = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_counts_config>>(otherList);
                string strMoudle = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.CountsConfig, HttpMethodType.Add);
                strArgs = string.Format("{0}&Model={1}&serverid={2}&serverip={3}", strMoudle, strArgs, strServerid, strServerIP);
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetCopyCallBack);
            }
            //CustomMessageBox.Info(this, "保存成功");

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



        private void SetButtonStatus(bool isTrue)
        {
            this.btnSave.Enabled = isTrue;
            this.btnNew.Enabled = isTrue;
            this.btnCustomQuery.Enabled = isTrue;
            this.applytoothers.Enabled = isTrue;
        }



        private bool isCanSave()
        {
            for (int i = 0; i < gvDataList.RowCount-1; i++)
            {
                for (int j = i + 1; j < gvDataList.RowCount; j++ )
                {
                    if (gvDataList.Rows[i].Cells[1].Value.ToString() == gvDataList.Rows[j].Cells[1].Value.ToString())
                        return false;
                }
            }
            return true;
        }

        private int GetNewRecordID()
        {
            int id = 0;
            if (gvDataList.RowCount == 1)
                return id;


            while (true)
            {
                bool isContance = false;
                for (int i = 0; i < gvDataList.RowCount-1; i++)
                {
                    if (int.Parse(gvDataList.Rows[i].Cells[1].Value.ToString()) == id)
                    {
                        isContance = true;
                    }
                }
                if (!isContance)
                    return id;
                id++;
            }
            return -1;
        }

        private void setDeleteButton(bool isShow)
        {
                gvDataList.Columns[15].Visible = isShow;
        }

    }
}
