using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using GameToolsCommon;
using System.Net;
using FengNiao.GameToolsCommon;

namespace GameToolsClient
{
    public partial class ItemManager : BaseForm
    {
        public ItemManager()
        {
            InitializeComponent();
            this.Text = "物品管理";
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


        private void InitList()
        {
            loadingControl1.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Item, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_item> dataList)
        {

            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_item data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.item_record_id, data.item_id, data.name, data.describe,Guid.NewGuid());
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
                        List<FengNiao.GMTools.Database.Model.tbl_item> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_item>(requestResult.Content);
                        GlobalObject.ItemList = dataList;
                        InitList(GlobalObject.ItemList);
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


        List<FengNiao.GMTools.Database.Model.tbl_item> items = null;
        private void btnImport_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gvDataList.Rows.Clear();
                string fileName = ofd.FileName;
                items = ExcelHelper.ExcelHelper.GetItemTable(fileName, "item");
                if (items == null)
                {
                    CustomMessageBox.Error(this, "请确认物品数据表有效");
                }
                for (int i = 0; i < items.Count; i++)
                {
                    int index = gvDataList.Rows.Add(0, items[i].item_id, items[i].name, items[i].describe, Guid.NewGuid());
                    gvDataList.Rows[i].Tag = items[i];
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (items == null)
            {
                CustomMessageBox.Error(this, "没有物品可导入");
                return;
            }
            List<string> guidList = new List<string>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                guidList.Add(gvDataList.Rows[i].Cells[4].Value.ToString());
            }
            if (guidList.Count == items.Count)
            {
                loadingControl1.Visible = true;
                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Item, HttpMethodType.Update);
                string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_item>>(items);
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

        private void ItemManager_Load(object sender, EventArgs e)
        {
 
            InitList();
        }
    }
}
