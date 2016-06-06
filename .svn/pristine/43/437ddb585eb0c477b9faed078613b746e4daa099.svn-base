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
    public partial class ServerManager : BaseForm
    {
        public ServerManager()
        {
            InitializeComponent();
            this.Text = "服务器管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            loadingControl.Dock = DockStyle.Fill;
            this.Image = Properties.Resources.TK_2icon;
            btnSave.Image = Properties.Resources.document_save_3;
            btnNew.Image = Properties.Resources.user_new;
            btnRefresh.Image = Properties.Resources.view_refresh_3;
        }


        private bool isPackageSelector = false;
        public bool IsSelector
        {
            set
            {
                isPackageSelector = value;
                if (value)
                {
                    btnNew.Visible = false;
                    btnRefresh.Visible = false;
                    gvDataList.Columns[9].Visible = false;
                    gvDataList.Columns[10].Visible = false;
                    gvDataList.Columns[12].Visible = true;
                    for (int i = 0; i < gvDataList.Columns.Count - 1; i++)
                    {
                        gvDataList.Columns[i].ReadOnly = true;
                    }
                }
            }
            get { return isPackageSelector; }
        }

        public FengNiao.GMTools.Database.Model.tbl_server SelectedServer;

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

        private void InitList()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Server, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
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
                        List<FengNiao.GMTools.Database.Model.tbl_server> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_server>(requestResult.Content);
                        InitServerList(dataList, GlobalObject.ServerGroupList);
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

        private void GetServerGroupListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_server_group> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_server_group>(requestResult.Content);
                        InitServerList(GlobalObject.ServerList, dataList);
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


        private void InitServerList(List<FengNiao.GMTools.Database.Model.tbl_server> list, List<FengNiao.GMTools.Database.Model.tbl_server_group> groupList)
        {
            GlobalObject.ServerList = list;
            GlobalObject.ServerGroupList = groupList;
            if (groupList != null)
            {
                loadingControl.Visible = false;
                gvDataList.Rows.Clear();
                foreach (FengNiao.GMTools.Database.Model.tbl_server data in GlobalObject.ServerList)
                {
                    int rowIndex = gvDataList.Rows.Add(data.fld_record_id, data.fld_server_name, data.fld_server_id);
                    gvDataList.Rows[rowIndex].Cells[3] = GlobalObject.GetServerGroupCell();
                    if (GlobalObject.IsExistsServerGroup(data.fld_group_id))
                    {
                        gvDataList.Rows[rowIndex].Cells[3].Value = data.fld_group_id;
                    }
                    gvDataList.Rows[rowIndex].Cells[4].Value = data.fld_create_time;
                    gvDataList.Rows[rowIndex].Cells[5].Value = data.fld_modif_time;
                    gvDataList.Rows[rowIndex].Cells[6] = GlobalObject.GetCommonCell("否", "是");
                    gvDataList.Rows[rowIndex].Cells[6].Value = data.fld_recommend;
                    gvDataList.Rows[rowIndex].Cells[7] = GlobalObject.GetCommonCell("否", "是");
                    gvDataList.Rows[rowIndex].Cells[7].Value = data.fld_new;
                    gvDataList.Rows[rowIndex].Cells[8] = GlobalObject.GetCommonCell("启用", "禁用");
                    gvDataList.Rows[rowIndex].Cells[8].Value = data.fld_deleted;
                    gvDataList.Rows[rowIndex].Cells[9].Value = data.fld_server_ip;
                    gvDataList.Rows[rowIndex].Cells[11].Value = Guid.NewGuid();
                    gvDataList.Rows[rowIndex].Tag = data;
                }
            }
            else
            {
                loadingControl.Visible = true;
                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Server_Group, HttpMethodType.GetList);
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetServerGroupListCallback);
            }
        }

        private void ServerManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitList();
        }

        private void gvDataList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            gvDataList.Rows[e.RowIndex].Cells[3] = GlobalObject.GetServerGroupCell();
            gvDataList.Rows[e.RowIndex].Cells[6] = GlobalObject.GetCommonCell("否", "是");
            //gvDataList.Rows[e.RowIndex].Cells[6].Value = 1;
            gvDataList.Rows[e.RowIndex].Cells[7] = GlobalObject.GetCommonCell("否", "是");
            gvDataList.Rows[e.RowIndex].Cells[8] = GlobalObject.GetCommonCell("启用", "禁用");
            //gvDataList.Rows[e.RowIndex].Cells[8].Value = 1;
            gvDataList.Rows[e.RowIndex].Cells[11].Value = Guid.NewGuid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            gvDataList.Rows.Add();
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (gvDataList.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 10)
            {
                if (gvDataList.Rows[e.RowIndex].Tag != null)
                {
                    CustomMessageBox.Error(this, "不能删除已经生效的数据");
                    return;
                }
                if (DialogResult.Yes == CustomMessageBox.Confirm(this, "确定要删除记录么?"))
                {
                    gvDataList.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (e.ColumnIndex == 12)
            {
                SelectedServer = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_server;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
        Color errorColor = Color.DarkGray;
        Color successColor = Color.GreenYellow;

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string strErrorMsg = string.Empty;

            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_server> dataList = new List<FengNiao.GMTools.Database.Model.tbl_server>();
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string serverName = string.Empty;
                int cellIndex = 1;
                strErrorMsg = "服务器名称无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null)
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                else
                {
                    serverName = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                    if (string.IsNullOrEmpty(serverName))
                    {
                        isError = true;
                        gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                        gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                    }
                }
                cellIndex = 2;
                strErrorMsg = "服务器ID无效";
                string strServerID = string.Empty;
                int serverID = -1;
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null)
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                else
                {
                    strServerID = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                    if (string.IsNullOrEmpty(strServerID) || !int.TryParse(strServerID, out serverID))
                    {
                        isError = true;
                        gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                        gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                    }
                }
                cellIndex = 3;

                int serverGroupID = -1;
                strErrorMsg = "分组无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null || !int.TryParse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString(), out serverGroupID))
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }

                cellIndex = 6;
                int recommend = -1;
                strErrorMsg = "是否为推荐无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null || !int.TryParse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString(), out recommend))
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }

                cellIndex = 7;
                int newServer = -1;
                strErrorMsg = "是否为新服无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null || !int.TryParse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString(), out newServer))
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }


                cellIndex = 8;
                int isDelete = -1;
                strErrorMsg = "是否启用无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null || !int.TryParse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString(), out isDelete))
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                cellIndex = 9;
                strErrorMsg = "服务器地址无效";
                string strServerIP = string.Empty;
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null)
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                else
                {
                    strServerIP = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                }
                cellIndex = 11;
                string guid = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                if (gvDataList.Rows[i].Tag == null)
                {
                    FengNiao.GMTools.Database.Model.tbl_server data = new FengNiao.GMTools.Database.Model.tbl_server();
                    data.fld_server_name = serverName;
                    data.fld_server_id = serverID;
                    data.fld_group_id = serverGroupID;
                    data.fld_create_time = DateTime.Now;
                    data.fld_modif_time = DateTime.Now;
                    data.fld_recommend = recommend;
                    data.fld_new = newServer;
                    data.fld_deleted = isDelete;
                    data.fld_server_ip = strServerIP;
                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);
                    guidList.Add(guid);
                }
                else
                {
                    FengNiao.GMTools.Database.Model.tbl_server data = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_server;
                    data.fld_server_name = serverName;
                    data.fld_server_id = serverID;
                    data.fld_group_id = serverGroupID;
                    data.fld_modif_time = DateTime.Now;
                    data.fld_recommend = recommend;
                    data.fld_new = newServer;
                    data.fld_deleted = isDelete;
                    data.fld_server_ip = strServerIP;
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
                if (dataList.Count == operationTypes.Count && dataList.Count == guidList.Count)
                {
                    loadingControl.Visible = true;
                    for (int i = 0; i < dataList.Count; i++)
                    {
                        gvDataList.Rows[i].Tag = dataList[i];
                    }

                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Server, HttpMethodType.Update);
                    string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_server>>(dataList);
                    string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
                    string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
                    strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
                }
            }
        }



        private void gvDataList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gvDataList.Rows[e.RowIndex].Cells[1].Style.BackColor = Color.White;
            gvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "";
        }

        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {
            loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        foreach (OperateResultModel resultModel in resultModelList)
                        {
                            int rowIndex = GetRowIndexByGuid(resultModel.Guid);
                            if (rowIndex != -1)
                            {
                                if (resultModel.IsSuccess)
                                {
                                    gvDataList.Rows[rowIndex].Cells[1].Style.BackColor = successColor;
                                }
                                else
                                {
                                    gvDataList.Rows[rowIndex].Tag = null;
                                    gvDataList.Rows[rowIndex].Cells[1].Style.BackColor = errorColor;
                                    gvDataList.Rows[rowIndex].Cells[1].ErrorText = resultModel.Content;
                                }
                            }
                        }
                        CustomMessageBox.Info(this, "保存完毕");
                        InitList();
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

        private int GetRowIndexByGuid(string guid)
        {
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                if (gvDataList.Rows[i].Cells[10].Value.ToString().Equals(guid))
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitList();
        }
    }
}
