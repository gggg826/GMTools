using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using System.Reflection;
using System.Net;
using GameToolsCommon;

namespace GameToolsClient
{
    public partial class GiftPackageDetails : BaseForm
    {
        private DetailsType giftPackageDetailsType;
        public DetailsType GiftPackageDetailsType
        {
            set
            {
                giftPackageDetailsType = value;
                switch (value)
                {
                    case DetailsType.New:
                        this.Text = "添加礼包";
                        break;
                    case DetailsType.Edit:
                        this.Text = "编辑礼包";
                        break;
                }
            }
        }

        Dictionary<int, int> ItemCountCache = new Dictionary<int, int>();

        FengNiao.GMTools.Database.Model.tbl_gift_package giftPackageData = null;

        public GiftPackageDetails()
        {
            InitializeComponent();
            //this.Text = "添加礼包";
            this.TopMostBox = false;
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TitleAlign = TitleAlignment.Left;
            this.Image = Properties.Resources.TK_2icon;
        }

        public GiftPackageDetails(FengNiao.GMTools.Database.Model.tbl_gift_package giftPackage)
            : this()
        {
            giftPackageData = giftPackage;
            GiftPackageDetailsType = DetailsType.Edit;
            tbTitle.Text = giftPackageData.fld_title;
            tbContent.Text = giftPackageData.fld_content;
            tbDesc.Text = giftPackageData.fld_desc;
            cbEnabled.CheckValue = !Convert.ToBoolean(giftPackageData.fld_deleted);
            cbLock.CheckValue = Convert.ToBoolean(giftPackageData.fld_lock_device);
            for (int i = 0; i < 20; i++)
            {
                PropertyInfo itemIDPropertyInfo = giftPackageData.GetType().GetProperty(string.Format("fld_itemid{0}", (i + 1)));
                if (itemIDPropertyInfo != null)
                {
                    PropertyInfo itemCountPropertyInfo = giftPackageData.GetType().GetProperty(string.Format("fld_itemcount{0}", (i + 1)));
                    object itemIDObj = itemIDPropertyInfo.GetValue(giftPackageData, null);
                    object itemCountObj = itemCountPropertyInfo.GetValue(giftPackageData, null);
                    if (itemIDObj != null)
                    {
                        FengNiao.GMTools.Database.Model.tbl_item item = GlobalObject.GetGiftPackageItem((int)itemIDObj);
                        if (item != null)
                        {
                            int index = gvDataList.Rows.Add(item.item_record_id, i + 1, item.name, (int)itemCountObj);
                            gvDataList.Rows[index].Tag = item;
                        }
                        else
                        {
                            int index = gvDataList.Rows.Add(itemIDObj, i + 1, string.Format("未知物品:{0}", itemIDObj), (int)itemCountObj);
                            gvDataList.Rows[index].DefaultCellStyle.ForeColor = Color.Red;
                            gvDataList.Rows[index].Cells[1].ErrorText = "没有在物品表里找到该物品，建议将该物品删除";
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvDataList_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (gvDataList.Rows.Count == 11)
            {
                gvDataList.Rows[e.RowIndex].ReadOnly = true;
                gvDataList.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
            }
            else
            {
                //gvDataList.Rows[e.RowIndex].Cells[1].Value = gvDataList.Rows.Count;
                //gvDataList.Rows[e.RowIndex].Cells[3].Value = 1;
                //gvDataList.Rows[e.RowIndex].Cells[4].Value = GameToolsClient.Properties.Resources.delete;
            }
        }

        private void GiftPackageDetails_Load(object sender, EventArgs e)
        {
            //gvDataList.Rows.Clear();

        }

        private void gvDataList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (gvDataList.Rows[e.RowIndex].Cells[3].Value == null)
                {
                    gvDataList.Rows[e.RowIndex].Cells[3].ErrorText = "数量无效";
                    gvDataList.Rows[e.RowIndex].Cells[3].Value = 1;
                }
                if (System.Text.RegularExpressions.Regex.IsMatch(gvDataList.Rows[e.RowIndex].Cells[3].Value.ToString(), "[^0-9]"))
                {
                    gvDataList.Rows[e.RowIndex].Cells[3].ErrorText = "数量无效";
                    gvDataList.Rows[e.RowIndex].Cells[3].Value = 1;
                }
                else
                {
                    gvDataList.Rows[e.RowIndex].Cells[3].ErrorText = "";
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ItemCountCache.Clear();
            ViewItem frmViewItem = new ViewItem();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                FengNiao.GMTools.Database.Model.tbl_item item = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_item;
                if (item != null)
                {
                    int itemCount = -1;
                    if (gvDataList.Rows[i].Cells[3].Value == null)
                    {
                        continue;
                    }
                    if (!int.TryParse(gvDataList.Rows[i].Cells[3].Value.ToString(), out itemCount))
                    {
                        continue;
                    }
                    ItemCountCache.Add(item.item_id, itemCount);
                }
            }
            frmViewItem.SelectedItems = GetSelectedItems();
            if (frmViewItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<FengNiao.GMTools.Database.Model.tbl_item> selectedItems = frmViewItem.SelectedItems;
                gvDataList.Rows.Clear();
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    int index = gvDataList.Rows.Add(selectedItems[i].item_record_id, i + 1, selectedItems[i].name, GetItemCount(selectedItems[i]));
                    gvDataList.Rows[index].Tag = selectedItems[i];
                }
            }
        }

        private List<FengNiao.GMTools.Database.Model.tbl_item> GetSelectedItems()
        {
            List<FengNiao.GMTools.Database.Model.tbl_item> selectedItems = new List<FengNiao.GMTools.Database.Model.tbl_item>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                FengNiao.GMTools.Database.Model.tbl_item item = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_item;
                if (item != null)
                {
                    selectedItems.Add(item);
                }
            }
            return selectedItems;
        }

     
        private int GetItemCount(FengNiao.GMTools.Database.Model.tbl_item item)
        {
            foreach (int iKey in ItemCountCache.Keys)
            {
                if (iKey == item.item_id)
                {
                    return ItemCountCache[iKey];
                }
            }
            return GlobalObject.DefalutItemCount;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<OperationType> operationTypes = new List<OperationType>();
            List<FengNiao.GMTools.Database.Model.tbl_gift_package> dataList = new List<FengNiao.GMTools.Database.Model.tbl_gift_package>();
            List<string> guidList = new List<string>();
            FengNiao.GMTools.Database.Model.tbl_gift_package data = new FengNiao.GMTools.Database.Model.tbl_gift_package();
            string title = tbTitle.Text;
            if (string.IsNullOrEmpty(title))
            {
                CustomMessageBox.Error(this, "标题不能为空");
                return;
            }
            string content = tbContent.Text;
            if (string.IsNullOrEmpty(content))
            {
                CustomMessageBox.Error(this, "内容不能为空");
                return;
            }
            if (gvDataList.Rows.Count == 0)
            {
                CustomMessageBox.Error(this, "礼包最少要包含一件物品");
                return;
            }
            string desc = tbDesc.Text;
            if (string.IsNullOrEmpty(desc))
            {
                CustomMessageBox.Error(this, "描述不能为空");
                return;
            }
            data.fld_title = title;
            data.fld_content = content;
            data.fld_desc = desc;
            data.fld_deleted = Convert.ToInt16(!cbEnabled.Checked);
            data.fld_lock_device = Convert.ToInt16(cbLock.Checked);
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                FengNiao.GMTools.Database.Model.tbl_item item = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_item;

                PropertyInfo itemIDPropertyInfo = data.GetType().GetProperty(string.Format("fld_itemid{0}", (i + 1)));
                PropertyInfo itemCountPropertyInfo = data.GetType().GetProperty(string.Format("fld_itemcount{0}", (i + 1)));
                int itemCount = -1;
                if (gvDataList.Rows[i].Cells[3].Value != null && itemIDPropertyInfo != null && itemCountPropertyInfo != null && int.TryParse(gvDataList.Rows[i].Cells[3].Value.ToString(), out itemCount))
                {
                    if (item != null)
                    {
                        itemIDPropertyInfo.SetValue(data, item.item_id, null);
                        itemCountPropertyInfo.SetValue(data, itemCount, null);
                    }
                    else if (gvDataList.Rows[i].Cells[0].Value != null)
                    {
                        int itemID = -1;
                        if (int.TryParse(gvDataList.Rows[i].Cells[0].Value.ToString(), out itemID))
                        {
                            itemIDPropertyInfo.SetValue(data, itemID, null);
                            itemCountPropertyInfo.SetValue(data, itemCount, null);
                        }
                    }
                }
            }
            data.fld_lastupdate = DateTime.Now;
            if (giftPackageDetailsType == DetailsType.Edit)
            {
                data.fld_id = giftPackageData.fld_id;
                operationTypes.Add(OperationType.Update);
            }
            else if (giftPackageDetailsType == DetailsType.New)
            {
                operationTypes.Add(OperationType.Add);
            }
            dataList.Add(data);

            guidList.Add(Guid.NewGuid().ToString());
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.GiftPackage, HttpMethodType.Update);
            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<FengNiao.GMTools.Database.Model.tbl_gift_package>>(dataList);
            string strOperationTypes = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<OperationType>>(operationTypes);
            string strGuids = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<string>>(guidList);
            strArgs = string.Format("{0}&Model={1}&OperationType={2}&guid={3}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8), strOperationTypes, strGuids);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, UpdateCallback);
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
                        List<OperateResultModel> resultModelList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<OperateResultModel>(requestResultModel.Content);
                        CustomMessageBox.Info(this, "保存完毕");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
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
