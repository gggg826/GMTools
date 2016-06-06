using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.Reflection;
using System.Net;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Text.RegularExpressions;

namespace GameToolsClient
{
    public partial class GiftCodeManager : BaseForm
    {
        public GiftCodeManager()
        {
            InitializeComponent();
            this.Text = "礼包码管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            this.Image = Properties.Resources.TK_2icon;
            Init();
            //this.TitleAlign = TitleAlignment.Left;

            loadingControl.Visible = false;
        }


        private int RecordCount;
        private int PageCount;
        private int PageSize = 20;
        private int CurrentPage = 1;
        private List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();

        public void Init()
        {
            cbPageCount.Items.Add("每页显示1条");
            cbPageCount.Items.Add("每页显示10条");
            cbPageCount.Items.Add("每页显示20条");
            cbPageCount.Items.Add("每页显示30条");
            cbPageCount.Items.Add("每页显示50条");
            cbPageCount.Items.Add("每页显示70条");
            cbPageCount.Items.Add("每页显示100条");
            cbPageCount.Items.Add("每页显示150条");
            cbPageCount.Items.Add("每页显示200条");
            cbPageCount.Text = "每页显示50条";
            dtCreateFromDate.LockUpdateChecked = false;
            dtCreateToDate.LockUpdateChecked = false;
            dtExpiretimeFromDate.LockUpdateChecked = false;
            dtExpiretimeToDate.LockUpdateChecked = false;
            dtExchangeFromDate.LockUpdateChecked = false;
            dtExchangeToDate.LockUpdateChecked = false;
            dtCreateFromTime.Enabled = false;
            dtCreateToTime.Enabled = false;
            dtExpiretimeFromTime.Enabled = false;
            dtExpiretimeToTime.Enabled = false;
            dtExchangeFromTime.LockUpdateChecked = false;
            dtExchangeToTime.LockUpdateChecked = false;
            tbCurrentPage.GotFocus += new EventHandler(tbCurrentPage_GotFocus);
            tbCurrentPage.LostFocus += new EventHandler(tbCurrentPage_LostFocus);
            InitPageSize();
        }



        private void InitPageSize()
        {
            Match match = Regex.Match(cbPageCount.Text, "\\d+");
            if (match.Success)
            {
                PageSize = int.Parse(match.Value.ToString());
            }
        }

        private void ShowGiftPackage()
        {
            GiftPackageManager frmGiftPackageManager = new GiftPackageManager();
            frmGiftPackageManager.IsPackageSelector = true;
            if (frmGiftPackageManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbGiftPackage.Text = "";
                FengNiao.GMTools.Database.Model.tbl_gift_package giftPackageData = frmGiftPackageManager.SelectedPackage;
                if (giftPackageData != null)
                {
                    tbGiftPackage.AppendText("ID:" + giftPackageData.fld_id.ToString() + "\r\n");
                    tbGiftPackage.AppendText((giftPackageData.fld_lock_device == 1 ? "每个设备不可重复领取" : "每个设备可重复领取") + "\r\n");
                    if (giftPackageData.fld_title != null)
                    {
                        tbGiftPackage.AppendText("标题:" + giftPackageData.fld_title.ToString() + "\r\n");
                    }
                    if (giftPackageData.fld_content != null)
                    {
                        tbGiftPackage.AppendText("内容:" + giftPackageData.fld_content.ToString() + "\r\n");
                    }

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
                                string strItem = string.Empty;
                                FengNiao.GMTools.Database.Model.tbl_item item = GlobalObject.GetGiftPackageItem((int)itemIDObj);
                                if (item != null)
                                {
                                    strItem = string.Format("道具{0}_{1}_{2}*{3}", (i + 1), item.item_id, item.name, itemCountObj);
                                }
                                else
                                {
                                    strItem = string.Format("道具{0}_{1}_{2}*{3}", (i + 1), itemIDObj, "未知物品", itemCountObj);
                                }
                                if (!string.IsNullOrEmpty(strItem))
                                {
                                    tbGiftPackage.AppendText(strItem + "\r\n");
                                }
                            }
                        }
                    }

                    if (giftPackageData.fld_desc != null)
                    {
                        tbGiftPackage.AppendText("描述:" + giftPackageData.fld_desc.ToString() + "\r\n");
                    }
                    tbGiftPackage.AppendText(giftPackageData.fld_deleted == 0 ? "礼包已启用" : "礼包未启用");
                }
                tbGiftPackage.Tag = giftPackageData;
            }
        }

        private void tbGiftPackage_DoubleClick(object sender, EventArgs e)
        {
            ShowGiftPackage();
        }

        private void dtStartFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtCreateFromTime.Enabled = dtCreateFromDate.LockUpdateChecked;
        }

        private void dtStartToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtCreateToTime.Enabled = dtCreateToDate.LockUpdateChecked;
        }

        private void dtExpiretimeFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtExpiretimeFromTime.Enabled = dtExpiretimeFromDate.LockUpdateChecked;
        }

        private void dtExpiretimeToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtExpiretimeToTime.Enabled = dtExpiretimeToDate.LockUpdateChecked;
        }

        private void dtExchangeFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtExchangeFromTime.Enabled = dtExchangeFromDate.LockUpdateChecked;
        }

        private void dtExchangeToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtExchangeToTime.Enabled = dtExchangeToDate.LockUpdateChecked;
        }

        private void tbChannel_DoubleClick(object sender, EventArgs e)
        {
            PackageManager frmPackageManager = new PackageManager();
            frmPackageManager.IsSelector = true;
            if (frmPackageManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbChannel.Text = frmPackageManager.SelectedPackage.fld_declare;
                tbChannel.Tag = frmPackageManager.SelectedPackage;
            }
        }

        private void tbServerID_DoubleClick(object sender, EventArgs e)
        {
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.IsSelector = true;
            if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbServerID.Text = frmServerManager.SelectedServer.fld_server_name;
                tbServerID.Tag = frmServerManager.SelectedServer;
            }
        }

        private void tbGiftCode_ButtonCustomClick(object sender, EventArgs e)
        {
            tbGiftCode.Text = "";
        }

        private void btnClearGiftPackage_Click(object sender, EventArgs e)
        {
            tbGiftPackage.Tag = null;
            tbGiftPackage.Text = "";
        }

        private void tbChannel_ButtonCustomClick(object sender, EventArgs e)
        {
            PackageManager frmPackageManager = new PackageManager();
            frmPackageManager.IsSelector = true;
            if (frmPackageManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbChannel.Text = frmPackageManager.SelectedPackage.fld_declare;
                tbChannel.Tag = frmPackageManager.SelectedPackage;
            }
        }

        private void tbServerID_ButtonCustomClick(object sender, EventArgs e)
        {
            ServerManager frmServerManager = new ServerManager();
            frmServerManager.IsSelector = true;
            if (frmServerManager.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbServerID.Text = frmServerManager.SelectedServer.fld_server_name;
                tbServerID.Tag = frmServerManager.SelectedServer;
            }
        }

        private void tbRoleID_ButtonCustomClick(object sender, EventArgs e)
        {
            tbRoleID.Text = "";
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
                loadingControl.Left = base.ClientBounds.X;
                loadingControl.Top = base.ClientBounds.Y;
                loadingControl.Width = base.ClientBounds.Width;
                loadingControl.Height = base.ClientBounds.Height;
                panelPageControlSubParent.Left = (panelPageControlParent.Width - panelPageControlSubParent.Width) / 2;
            }
        }

        private void InitCount()
        {
            loadingControl.Visible = true;
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.GiftCode, HttpMethodType.GetCount);
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetCountCallback);
        }

        private void GetCountCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    if (int.TryParse(requestResult.Content, out RecordCount))
                    {
                        PageCount = RecordCount % PageSize > 0 ? RecordCount / PageSize + 1 : RecordCount / PageSize;
                        InitList();
                    }
                    else
                    {
                        loadingControl.Visible = false;
                        CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                    }
                }
                else
                {
                    loadingControl.Visible = false;
                    CustomMessageBox.Error(this, string.Format("获取数据失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                loadingControl.Visible = false;
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
        }

        private void InitList()
        {
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.GiftCode, HttpMethodType.GetList);
            strArgs = string.Format("{0}&CurrentPage={1}&PageCount={2}", strArgs, CurrentPage, PageSize);
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetListCallback);
            if (!loadingControl.Visible)
            {
                loadingControl.Visible = true;
            }
        }

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_gift_code> dataList)
        {
            gvDataList.Rows.Clear();
            tbCurrentPage.Text = string.Format("{0}/{1}", CurrentPage, PageCount);
            foreach (FengNiao.GMTools.Database.Model.tbl_gift_code data in dataList)
            {
                int rowIndex = gvDataList.Rows.Add(data.fld_gift_code, data.fld_gift_package, data.fld_createtime, data.fld_starttime, data.fld_expiretime, data.fld_channel, data.fld_exchange_svrid, data.fld_exchange_roleid, data.fld_exchange_time, data.fld_multi_use);
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[11].Value = Guid.NewGuid();
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
                        List<FengNiao.GMTools.Database.Model.tbl_gift_code> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_gift_code>(requestResult.Content);
                        InitList(dataList);
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

        private void GiftCodeManager_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitCount();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            InitList();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurrentPage = PageCount;
            InitList();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                InitList();
            }
            else
            {
                CustomMessageBox.Error(this, "已经到达第一页");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < PageCount)
            {
                CurrentPage++;
                InitList();
            }
            else
            {
                CustomMessageBox.Error(this, "已经到达最后一页");
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            requestParameters.Clear();
            if (!string.IsNullOrEmpty(tbGiftCode.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_gift_code", tbGiftCode.Text, cbGiftCode.Checked ? SqlCompareType.Like : SqlCompareType.Equal));
            }
            if (tbGiftPackage.Tag is FengNiao.GMTools.Database.Model.tbl_gift_package)
            {
                FengNiao.GMTools.Database.Model.tbl_gift_package package = tbGiftPackage.Tag as FengNiao.GMTools.Database.Model.tbl_gift_package;
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_gift_package", package.fld_id, SqlCompareType.Equal));
            }
            if (dtCreateFromDate.LockUpdateChecked && !dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_createtime", dtCreateFromDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtCreateFromDate.LockUpdateChecked && dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_createtime", dtCreateToDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtCreateFromDate.LockUpdateChecked && dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_createtime", dtCreateFromDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_createtime", dtCreateToDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }
            if (dtExpiretimeFromDate.LockUpdateChecked && !dtExpiretimeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_expiretime", dtExpiretimeFromDate.Value.ToString("yyyy-MM-dd") + " " + dtExpiretimeFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtExpiretimeFromDate.LockUpdateChecked && dtExpiretimeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_expiretime", dtExpiretimeToDate.Value.ToString("yyyy-MM-dd") + " " + dtExpiretimeToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtExpiretimeFromDate.LockUpdateChecked && dtExpiretimeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_expiretime", dtExpiretimeFromDate.Value.ToString("yyyy-MM-dd") + " " + dtExpiretimeFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_expiretime", dtExpiretimeToDate.Value.ToString("yyyy-MM-dd") + " " + dtExpiretimeToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }
            if (tbChannel.Tag is FengNiao.GMTools.Database.Model.tbl_package)
            {
                FengNiao.GMTools.Database.Model.tbl_package package = tbChannel.Tag as FengNiao.GMTools.Database.Model.tbl_package;
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_channel", package.fld_package_number, SqlCompareType.Equal));
            }
            if (tbServerID.Tag is FengNiao.GMTools.Database.Model.tbl_server)
            {
                FengNiao.GMTools.Database.Model.tbl_server server = tbServerID.Tag as FengNiao.GMTools.Database.Model.tbl_server;
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_svrid", server.fld_server_id, SqlCompareType.Equal));
            }
            if (!string.IsNullOrEmpty(tbRoleID.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_roleid", tbRoleID.Text, cbRoleID.Checked ? SqlCompareType.Like : SqlCompareType.Equal));
            }


            if (dtExchangeFromDate.LockUpdateChecked && !dtExchangeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_time", dtExchangeFromDate.Value.ToString("yyyy-MM-dd") + " " + dtExchangeFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtExchangeFromDate.LockUpdateChecked && dtExchangeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_time", dtExchangeToDate.Value.ToString("yyyy-MM-dd") + " " + dtExchangeToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtExchangeFromDate.LockUpdateChecked && dtExchangeToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_time", dtExchangeFromDate.Value.ToString("yyyy-MM-dd") + " " + dtExchangeFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_time", dtExchangeToDate.Value.ToString("yyyy-MM-dd") + " " + dtExchangeToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }
            if (cbIsExchange.Checked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_exchange_roleid", "", SqlCompareType.NotEqual));
            }
            if (cbMultiUse.Checked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("fld_multi_use", cbMultiUse.Checked ? 1 : 0, SqlCompareType.Equal));
            }
            InitPageSize();
            InitCount();
        }

        void tbCurrentPage_GotFocus(object sender, EventArgs e)
        {
            //tbCurrentPage.Text = string.Format("{0}", CurrentPage);
            tbCurrentPage.Text = "";
        }

        void tbCurrentPage_LostFocus(object sender, EventArgs e)
        {
            tbCurrentPage.Text = string.Format("{0}/{1}", CurrentPage, PageCount);
        }

        private void tbCurrentPage_ButtonCustomClick(object sender, EventArgs e)
        {
            string strCurrentPage = tbCurrentPage.Text;
            if (int.TryParse(strCurrentPage, out CurrentPage))
            {
                if (CurrentPage > PageCount)
                {
                    CurrentPage = PageCount;
                }
                if (CurrentPage < 1)
                {
                    CurrentPage = 1;
                }
                gvDataList.Focus();
                InitCount();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GiftCodeDetails frmGiftCodeDetails = new GiftCodeDetails();
            if (frmGiftCodeDetails.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InitCount();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitCount();
        }

        private void tbChannel_ButtonCustom2Click(object sender, EventArgs e)
        {
            tbChannel.Tag = null;
            tbChannel.Text = "";
        }

        private void tbServerID_ButtonCustom2Click(object sender, EventArgs e)
        {
            tbServerID.Tag = null;
            tbServerID.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ShowGiftPackage();
        }
    }
}
