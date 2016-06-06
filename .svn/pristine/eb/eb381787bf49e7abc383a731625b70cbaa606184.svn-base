using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Text;
using System.Web;
using System.Windows.Forms;
using FengNiao.GameTools.Json;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using FengNiao.GMTools.Database.Model;
using GameToolsClient.Properties;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class ResourceUpgradeManager : BaseForm
    {
        public ResourceUpgradeManager()
        {
            InitializeComponent();
            Text = "资源更新管理";
            BackColor = Color.White;
            StartPosition = FormStartPosition.CenterScreen;
            IsAcceptResize = true;
            MaximizeBox = true;
            MinimizeBox = true;
            TopMostBox = false;
            loadingControl.Dock = DockStyle.Fill;
            Image = Resources.TK_2icon;
            btnSave.Image = Resources.document_save_3;
            btnNew.Image = Resources.user_new;
            btnRefresh.Image = Resources.view_refresh_3;
        }

        public enum ResourceManagerType
        {
            ResourceManager,
            DepotAdManager,
        }

        private ResourceManagerType _managerType;

        public ResourceManagerType ManagerType
        {
            get { return _managerType; }
            set
            {
                _managerType = value;
                switch (value)
                {
                    case ResourceManagerType.ResourceManager:
                        Text = "资源更新管理";
                        IsAdManager = false;
                        gvDataList.Columns[3].ReadOnly = false;
                        break;
                    case ResourceManagerType.DepotAdManager:
                        Text = "大厅广告管理";
                        IsAdManager = true;
                        gvDataList.Columns[3].ReadOnly = true;
                        break;
                    default:
                        break;
                }
            }
        }

        protected bool IsAdManager = false;

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RefreshLayout();
        }

        private void RefreshLayout()
        {
            if (IsHandleCreated && gvDataList.IsHandleCreated)
            {
                panelParent.Left = ClientBounds.X;
                panelParent.Top = ClientBounds.Y;
                panelParent.Width = ClientBounds.Width;
                panelParent.Height = ClientBounds.Height;
            }
        }

        private void ResourceUpgradeManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitList();
        }


        private void InitList()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Resource_Upgrade, HttpMethodType.GetList);
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
                    ResultModel requestResult = Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<tbl_resource_upgrade> dataList = Serialize.ConvertJsonToObjectList<tbl_resource_upgrade>(requestResult.Content);
                        GlobalObject.ResourceUpgradeList = dataList;
                        InitList(GlobalObject.ResourceUpgradeList);
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

        private void InitList(List<tbl_resource_upgrade> list)
        {
            gvDataList.Rows.Clear();
            foreach (tbl_resource_upgrade data in list)
            {
                int rowIndex = gvDataList.Rows.Add(data.fld_recordid, data.fld_package_name, data.fld_version, data.fld_resource_type, data.fld_url_ver, data.fld_url, data.fld_test_url_ver, data.fld_test_url, data.fld_Description);
                //gvDataList.Rows[rowIndex].Cells[6].Value = data.fld_Description;
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[10].Value = Guid.NewGuid();
                if (IsAdManager)
                {
                    if (gvDataList.Rows[rowIndex].Cells[3].Value.ToString() != "notice")
                    {
                        gvDataList.Rows[rowIndex].Visible = false;
                    }
                }
            }
        }


        private void gvDataList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //gvDataList.Rows[e.RowIndex].Cells[3] = GlobalObject.GetCommonCell("正式版本", "测试版本");
            //gvDataList.Rows[e.RowIndex].Cells[4] = GlobalObject.GetCommonCell("否", "是");
            gvDataList.Rows[e.RowIndex].Cells[10].Value = Guid.NewGuid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int index = gvDataList.Rows.Add();
            if (IsAdManager)
            {
                gvDataList.Rows[index].Cells[3].Value = "notice";
            }
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (gvDataList.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 9)
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
            List<tbl_resource_upgrade> dataList = new List<tbl_resource_upgrade>();
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                string packageName;
                isError |= CheckAndGetData(i, 1, "包名无效", out packageName, false);
                string version;
                isError |= CheckAndGetData(i, 2, "版本无效", out version, false);
                string resourceType;
                isError |= CheckAndGetData(i, 3, "资源类型无效", out resourceType, false);
                string urlVer;
                isError |= CheckAndGetData(i, 4, "资源版本无效", out urlVer, false);
                string url;
                isError |= CheckAndGetData(i, 5, "资源路径无效", out url, false);
                string testUrlVer;
                isError |= CheckAndGetData(i, 6, "测试资源版本无效", out testUrlVer, false);
                string testUrl;
                isError |= CheckAndGetData(i, 7, "测试资源路径无效", out testUrl, false);
                string description;
                isError |= CheckAndGetData(i, 8, "描述无效", out description, true);

                string guid;
                isError |= CheckAndGetData(i, 10, "gui无效", out guid, true);

                if (gvDataList.Rows[i].Tag == null)
                {
                    tbl_resource_upgrade data = new tbl_resource_upgrade();
                    data.fld_package_name = packageName;
                    data.fld_version = version;
                    data.fld_resource_type = resourceType;
                    data.fld_url_ver = urlVer;
                    data.fld_url = url;
                    data.fld_test_url_ver = testUrlVer;
                    data.fld_test_url = testUrl;
                    data.fld_Description = description;
                    dataList.Add(data);
                    operationTypes.Add(OperationType.Add);
                    guidList.Add(guid);
                }
                else
                {
                    tbl_resource_upgrade data = gvDataList.Rows[i].Tag as tbl_resource_upgrade;
                    data.fld_package_name = packageName;
                    data.fld_version = version;
                    data.fld_resource_type = resourceType;
                    data.fld_url_ver = urlVer;
                    data.fld_url = url;
                    data.fld_test_url_ver = testUrlVer;
                    data.fld_test_url = testUrl;
                    data.fld_Description = description;
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

                    string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Resource_Upgrade, HttpMethodType.Update);
                    string strModel = Serialize.ConvertObjectToJsonList(dataList);
                    string strOperationTypes = Serialize.ConvertObjectToJsonList(operationTypes);
                    string strGuids = Serialize.ConvertObjectToJsonList(guidList);

                    strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}", strArgs, HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids);
                    CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
                }
            }
        }

        private bool CheckAndGetData(int rowIndex, int cellIndex, string errorMsg, out string data, bool canNull)
        {
            bool isError = false;
            data = string.Empty;
            if (gvDataList.Rows[rowIndex].Cells[cellIndex].Value == null)
            {
                isError = true;
                gvDataList.Rows[rowIndex].DefaultCellStyle.BackColor = errorColor;
                gvDataList.Rows[rowIndex].Cells[cellIndex].ErrorText = errorMsg;
            }
            else
            {
                data = gvDataList.Rows[rowIndex].Cells[cellIndex].Value.ToString();
                if (!canNull && string.IsNullOrEmpty(data))
                {
                    isError = true;
                    gvDataList.Rows[rowIndex].Cells[cellIndex].ErrorText = errorMsg;
                }
            }
            return isError;
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
                    ResultModel requestResultModel = Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        List<OperateResultModel> resultModelList = Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
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
                if (gvDataList.Rows[i].Cells[8].Value.ToString().Equals(guid))
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
