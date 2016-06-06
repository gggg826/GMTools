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
    public partial class ViewItem : BaseForm
    {
        public List<FengNiao.GMTools.Database.Model.tbl_item> SelectedItems = new List<FengNiao.GMTools.Database.Model.tbl_item>();
        public ViewItem()
        {
            InitializeComponent();
            this.Text = "物品选择";
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

        bool isInitList = false;
        string FilterContent = string.Empty;

        private void InitList()
        {
            if (GlobalObject.ItemList == null)
            {
                loadingControl1.Visible = true;
                string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Item, HttpMethodType.GetList);
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
            }
            else
            {
                InitList(GlobalObject.ItemList);
            }
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_item> dataList)
        {
            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_item data in dataList)
            {
                bool isSelected = IsSelectedItem(data);
                if (string.IsNullOrEmpty(FilterContent))
                {
                    int rowIndex = gvDataList.Rows.Add(data.item_record_id, isSelected, data.item_id, data.name, data.describe, Guid.NewGuid());
                }
                else
                {

                    if (isSelected || data.item_id.ToString().IndexOf(FilterContent) != -1 || data.name.IndexOf(FilterContent) != -1)
                    {
                        int rowIndex = gvDataList.Rows.Add(data.item_record_id, isSelected, data.item_id, data.name, data.describe, Guid.NewGuid());
                    }
                }
            }
            isInitList = true;
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

        private bool IsSelectedItem(FengNiao.GMTools.Database.Model.tbl_item item)
        {
            if (SelectedItems == null)
            {
                return false;
            }
            for (int i = 0; i < SelectedItems.Count; i++)
            {
                if (item.item_id == SelectedItems[i].item_id)
                {
                    return true;
                }
            }
            return false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterContent = tbFilter.Text;
            SelectedItems = GetSelectedItem();
            InitList();
        }

        private void ViewItem_Load(object sender, EventArgs e)
        {
            InitList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedItems = GetSelectedItem();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void gvDataList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int selectedCount = GetSelectedCount();
            if (selectedCount == 11)
            {
                gvDataList.Rows[e.RowIndex].Cells[1].Value = false;
                CustomMessageBox.Error(this, "1个礼包只能选择10件物品");
            }
        }

        private List<FengNiao.GMTools.Database.Model.tbl_item> GetSelectedItem()
        {
            List<FengNiao.GMTools.Database.Model.tbl_item> selectedItems = new List<FengNiao.GMTools.Database.Model.tbl_item>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                bool isSelected = false;
                if (gvDataList.Rows[i].Cells[1].Value != null && bool.TryParse(gvDataList.Rows[i].Cells[1].Value.ToString(), out isSelected))
                {
                    if (isSelected)
                    {
                        int id = int.Parse(gvDataList.Rows[i].Cells[0].Value.ToString());
                        int itemID = int.Parse(gvDataList.Rows[i].Cells[2].Value.ToString());
                        string name = gvDataList.Rows[i].Cells[3].Value.ToString();
                        string desc = gvDataList.Rows[i].Cells[4].Value.ToString();
                        FengNiao.GMTools.Database.Model.tbl_item selectedItem = new FengNiao.GMTools.Database.Model.tbl_item();
                        selectedItem.item_record_id = id;
                        selectedItem.item_id = itemID;
                        selectedItem.name = name;
                        selectedItem.describe = desc;
                        selectedItems.Add(selectedItem);
                    }
                }
            }
            return selectedItems;
        }


        private int GetSelectedCount()
        {
            int count = 0;
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                bool isSelected = false;
                if (gvDataList.Rows[i].Cells[1].Value != null && bool.TryParse(gvDataList.Rows[i].Cells[1].Value.ToString(), out isSelected))
                {
                    if (isSelected)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
