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
    public partial class NoticeConfigManager : BaseForm
    {
        public NoticeConfigManager()
        {
            InitializeComponent();
            this.Text = "游戏公告管理";
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
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Notice_Config, HttpMethodType.GetList);
            List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();
            requestParameters.Add(new HttpInterfaceSqlParameter("server_id", serverData.fld_server_id, SqlCompareType.Equal));
            requestParameters.Add(new HttpInterfaceSqlParameter("`type`", 0, SqlCompareType.Equal));
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
            CurrentServer = serverData;
            btnQuery.Enabled = false;
        }


        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_notice_config> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_notice_config data in dataList)
            {
                string strContent = string.Empty;
                strContent = System.Text.RegularExpressions.Regex.Replace(data.content, "\\[[0-9a-f]+\\]", "");
                int rowIndex = gvDataList.Rows.Add(data.id, data.title, strContent, data.starttime, data.stoptime, data.deleted == 0 ? "启用" : "未启用");
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
                        List<FengNiao.GMTools.Database.Model.tbl_notice_config> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_notice_config>(requestResult.Content);
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

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                FengNiao.GMTools.Database.Model.tbl_notice_config data = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_notice_config;
                if (data != null)
                {
                    NoticeConfigDetails frmNoticeConfigDetails = new NoticeConfigDetails(CurrentServer, data);
                    if (frmNoticeConfigDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        GetList();
                    }
                }
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
            NoticeConfigDetails frmNoticeConfigDetails = new NoticeConfigDetails(serverData);
            if (frmNoticeConfigDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GetList();
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

        private void NoticeConfigManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
        }
    }
}
