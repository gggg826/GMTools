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
    public partial class ServerGroupManager : BaseForm
    {
        public ServerGroupManager()
        {
            InitializeComponent();
            this.Text = "服务器分组管理";
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

        private void ServerGroupManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitList();
        }

        private void InitList()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Server_Group, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }


        private void GetListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            loadingControl.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_server_group> PackageList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_server_group>(requestResult.Content);
                        GlobalObject.ServerGroupList = PackageList;
                        InitList(GlobalObject.ServerGroupList);
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

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_server_group> list)
        {

            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_server_group data in list)
            {
                int rowIndex = gvDataList.Rows.Add(data.fld_record_id, data.fld_group_name, data.fld_group_id, data.fld_create_time, data.fld_modif_time);
                gvDataList.Rows[rowIndex].Cells[5] = GlobalObject.GetCommonCell("启用", "禁用");
                gvDataList.Rows[rowIndex].Cells[5].Value = data.fld_deleted;
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[7].Value = Guid.NewGuid();
            }
        }

        private void gvDataList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            gvDataList.Rows[e.RowIndex].Cells[5] = GlobalObject.GetCommonCell("启用", "禁用");
            gvDataList.Rows[e.RowIndex].Cells[5].Value = 1;
            gvDataList.Rows[e.RowIndex].Cells[7].Value = Guid.NewGuid();
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
            if (e.ColumnIndex == 6)
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
        }
        Color errorColor = Color.DarkGray;
        Color successColor = Color.GreenYellow;
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isError = false;
            string strErrorMsg = string.Empty;

            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_server_group> dataList = new List<FengNiao.GMTools.Database.Model.tbl_server_group>();
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string groupName = string.Empty;
                int cellIndex = 1;
                strErrorMsg = "分组名无效";
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null)
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                else
                {
                    groupName = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                    if (string.IsNullOrEmpty(groupName))
                    {
                        isError = true;
                        gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                    }
                }
                cellIndex = 2;
                strErrorMsg = "分组ID无效";
                string groupID = string.Empty;
                if (gvDataList.Rows[i].Cells[cellIndex].Value == null)
                {
                    isError = true;
                    gvDataList.Rows[i].DefaultCellStyle.BackColor = errorColor;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                else
                {
                    groupID = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                    if (string.IsNullOrEmpty(groupID))
                    {
                        isError = true;
                        gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                    }
                }
                int iGroupID = -1;
                if (!int.TryParse(groupID, out iGroupID))
                {
                    isError = true;
                    gvDataList.Rows[i].Cells[cellIndex].ErrorText = strErrorMsg;
                }
                cellIndex = 5;
                int isDelete = int.Parse(gvDataList.Rows[i].Cells[cellIndex].Value.ToString());
                cellIndex = 7;
                string guid = gvDataList.Rows[i].Cells[cellIndex].Value.ToString();
                if (gvDataList.Rows[i].Tag == null)
                {
                    FengNiao.GMTools.Database.Model.tbl_server_group data = new FengNiao.GMTools.Database.Model.tbl_server_group();
                    data.fld_group_name = groupName;
                    data.fld_group_id = iGroupID;
                    data.fld_create_time = DateTime.Now;
                    data.fld_modif_time = DateTime.Now;
                    data.fld_deleted = isDelete;
                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);
                    guidList.Add(guid);
                }
                else
                {
                    FengNiao.GMTools.Database.Model.tbl_server_group data = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_server_group;
                    data.fld_group_name = groupName;
                    data.fld_group_id = iGroupID;
                    data.fld_modif_time = DateTime.Now;
                    data.fld_deleted = isDelete;
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

                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Server_Group, HttpMethodType.Update);
                    string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_server_group>>(dataList);
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
                if (gvDataList.Rows[i].Cells[7].Value.ToString().Equals(guid))
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
