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
    public partial class ActivityImport : BaseForm
    {
        public ActivityImport()
        {
            InitializeComponent();
            this.Text = "活动导入";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.Image = Properties.Resources.TK_2icon;
            this.TitleAlign = TitleAlignment.Left;
            loadingControl1.Dock = DockStyle.Fill;
            loadingControl1.Visible = false;
        }


        public bool IsSelector
        {
            set
            {
                this.Height = 517;
                this.panelParent.Height = 470;
                this.gvDataList.Columns[4].Visible = true;
            }
        }


        public FengNiao.GMTools.Database.Model.tbl_activity SelectedActivity;

        private void InitList()
        {
            loadingControl1.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_activity> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_activity data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.record_id, data.id, data.name, Guid.NewGuid());
                gvDataList.Rows[rowIndex].Tag = data;
            }
        }

        private void GetListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            loadingControl1.Visible = false;
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
                        InitList(GlobalObject.ActivityList);
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



        List<FengNiao.GMTools.Database.Model.tbl_activity> activitys;
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gvDataList.Rows.Clear();
                string fileName = ofd.FileName;
                activitys = ExcelHelper.ExcelHelper.GetActivityTable(fileName, "promotion");
                if (activitys == null)
                {
                    CustomMessageBox.Error(this, "请确认活动数据表有效");
                }
                for (int i = 0; i < activitys.Count; i++)
                {
                    int index = gvDataList.Rows.Add(0, activitys[i].id, activitys[i].name,Guid.NewGuid());
                    gvDataList.Rows[i].Tag = activitys[i];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (activitys == null)
            {
                CustomMessageBox.Error(this, "没有活动可导入");
                return;
            }
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                guidList.Add(gvDataList.Rows[i].Cells[3].Value.ToString());
            }
            if (guidList.Count == activitys.Count)
            {
                loadingControl1.Visible = true;
                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity, HttpMethodType.Update);
                string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_activity>>(activitys);
                string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
                strArgs = string.Format("{0}&Model={1}&guid={2}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strGuids);
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
            }
            else
            {
                CustomMessageBox.Error(this, "物品数量有错误");
            }
        }

        private void UpdateCallback(object sender, UploadDataCompletedEventArgs e)
        {
            loadingControl1.Visible = false;
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
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

        private void ActivityImport_Load(object sender, EventArgs e)
        {
            InitList();
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 4)
            {
                FengNiao.GMTools.Database.Model.tbl_activity data = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_activity;
                if (data != null)
                {
                    SelectedActivity = data;
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
        }
    }
}
