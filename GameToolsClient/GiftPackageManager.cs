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
    public partial class GiftPackageManager : BaseForm
    {
        public GiftPackageManager()
        {
            InitializeComponent();
            this.Text = "礼包管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.Image = Properties.Resources.TK_2icon;

            loadingControl.Dock = DockStyle.Fill;
        }

        private bool isPackageSelector = false;
        public bool IsPackageSelector
        {
            set
            {
                isPackageSelector = value;
                if (value)
                {
                    btnNew.Visible = false;
                    btnRefresh.Visible = false;
                    gvDataList.Columns[16].Visible = false;
                    gvDataList.Columns[19].Visible = true;
                    for (int i = 0; i < gvDataList.Columns.Count - 1; i++)
                    {
                        gvDataList.Columns[i].ReadOnly = true;
                    }
                }
            }
            get { return isPackageSelector; }
        }
        public FengNiao.GMTools.Database.Model.tbl_gift_package SelectedPackage;

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

        private void GiftPackage_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitList();
        }

        private void InitList()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.GiftPackage, HttpMethodType.GetList);
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_gift_package> dataList)
        {

            gvDataList.Rows.Clear();
            foreach (FengNiao.GMTools.Database.Model.tbl_gift_package data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.fld_id,
                                                    (data.fld_lock_device == 1 ? "是" : "否"),
                                                    data.fld_title,
                                                    data.fld_content,
                                                    data.fld_itemid1 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid1.Value), data.fld_itemcount1),
                                                    data.fld_itemid2 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid2.Value), data.fld_itemcount2),
                                                    data.fld_itemid3 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid3.Value), data.fld_itemcount3),
                                                     data.fld_itemid4 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid4.Value), data.fld_itemcount4),
                                                     data.fld_itemid5 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid5.Value), data.fld_itemcount5),
                                                     data.fld_itemid6 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid6.Value), data.fld_itemcount6),
                                                     data.fld_itemid7 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid7.Value), data.fld_itemcount7),
                                                     data.fld_itemid8 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid8.Value), data.fld_itemcount8),
                                                     data.fld_itemid9 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid9.Value), data.fld_itemcount9),
                                                     data.fld_itemid10 == null ? "无物品" : string.Format("{0}*{1}", GetItemName(data.fld_itemid10.Value), data.fld_itemcount10),
                                                     data.fld_lastupdate,
                                                     (data.fld_deleted == 1 ? "否" : "是")
                                                    );
                gvDataList.Rows[rowIndex].Tag = data;
            }
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
                        List<FengNiao.GMTools.Database.Model.tbl_gift_package> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_gift_package>(requestResult.Content);
                        GlobalObject.GiftPackageList = dataList;
                        if (GlobalObject.ItemList != null)
                        {
                            InitList(GlobalObject.GiftPackageList);
                        }
                        else
                        {
                            loadingControl.Visible = true;
                            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Item, HttpMethodType.GetList);
                            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetItemListCallback);
                        }
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

        private void GetItemListCallback(object sender, UploadDataCompletedEventArgs e)
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
                        List<FengNiao.GMTools.Database.Model.tbl_item> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_item>(requestResult.Content);
                        GlobalObject.ItemList = dataList;
                        InitList(GlobalObject.GiftPackageList);
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


        private string GetItemName(int itemID)
        {
            foreach (FengNiao.GMTools.Database.Model.tbl_item item in GlobalObject.ItemList)
            {
                if (item.item_id == itemID)
                {
                    return item.name;
                }
            }
            return string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GiftPackageDetails frmGiftPackageDetails = new GiftPackageDetails();
            frmGiftPackageDetails.GiftPackageDetailsType = DetailsType.New;
            if (frmGiftPackageDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.InitList();
            }
        }

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > (gvDataList.RowCount - 1) || e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 16)
            {
                FengNiao.GMTools.Database.Model.tbl_gift_package packageItem = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_gift_package;
                if (packageItem != null)
                {
                    GiftPackageDetails frmGiftPackageDetails = new GiftPackageDetails(packageItem);
                    if (frmGiftPackageDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        this.InitList();
                    }
                }
            }
            else if (e.ColumnIndex == 19)
            {
                SelectedPackage = gvDataList.Rows[e.RowIndex].Tag as FengNiao.GMTools.Database.Model.tbl_gift_package;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
