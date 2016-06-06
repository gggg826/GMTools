using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using System.Text.RegularExpressions;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class MailManager : BaseForm
    {
        public MailManager()
        {
            InitializeComponent();
            this.Text = "邮件管理";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = true;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.TopMostBox = false;
            // loadingControl.Dock = DockStyle.Fill;
            this.Image = Properties.Resources.TK_2icon;
            tbCurrentPage.GotFocus += new EventHandler(tbCurrentPage_GotFocus);
            tbCurrentPage.LostFocus += new EventHandler(tbCurrentPage_LostFocus);

            cbMailType.Items.Add("个人邮件");
            cbMailType.Items.Add("系统邮件");
            cbMailType.Text = "个人邮件";
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
            dtStartFromDate.LockUpdateChecked = false;
            dtStartToDate.LockUpdateChecked = false;
            dtStopFromDate.LockUpdateChecked = false;
            dtStopToDate.LockUpdateChecked = false;
            dtCreateFromDate.LockUpdateChecked = false;
            dtCreateToDate.LockUpdateChecked = false;

            dtStartFromTime.Enabled = false;
            dtStartToTime.Enabled = false;
            dtStopFromTime.Enabled = false;
            dtStopToTime.Enabled = false;
            dtCreateFromTime.Enabled = false;
            dtCreateToTime.Enabled = false;

            dtMinDateLeft.LockUpdateChecked = false;
            dtMinTimeLeft.Enabled = false;
            dtMinDateRight.LockUpdateChecked = false;
            dtMinTimeRight.Enabled = false;
            dtMaxDateLeft.LockUpdateChecked = false;
            dtMaxTimeLeft.Enabled = false;
            dtMaxDateRight.LockUpdateChecked = false;
            dtMaxDateRight.Enabled = false;
        }


        private int RecordCount;
        private int PageCount;
        private int PageSize = 20;
        private int CurrentPage = 1;
        private List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();



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
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Mail, HttpMethodType.GetCount);
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
            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Mail, HttpMethodType.GetList);
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

        private void InitList(List<FengNiao.GMTools.Database.Model.tbl_mail> dataList)
        {
            gvDataList.Rows.Clear();
            tbCurrentPage.Text = string.Format("{0}/{1}", CurrentPage, PageCount);
            foreach (FengNiao.GMTools.Database.Model.tbl_mail data in dataList)
            {
                string strItems = data.items;
                if (!string.IsNullOrEmpty(strItems))
                {
                    if (strItems.Substring(strItems.Length - 1, 1).Equals("|"))
                    {
                        strItems = strItems.Substring(0, strItems.Length - 1);
                    }
                }
                int rowIndex = gvDataList.Rows.Add(data.id,
                    data.mail_type == 2 ? "个人邮件" : "系统邮件",
                    data.mail_id,
                    data.server_id,
                    data.role_id,
                    data.optype == 1 ? "删除" : "不删除",
                    data.title,
                    data.content,
                    data.retention,
                    data.starttime,
                    data.stoptime,
                    strItems,
                    data.craetetime,
                    data.channel,
                    data.minversion,
                    data.maxversion,
                    data.minlevel,
                    data.maxlevel,
                    data.mindatetime,
                    data.maxdatetime
                    );
                gvDataList.Rows[rowIndex].Tag = data;
                gvDataList.Rows[rowIndex].Cells[21].Value = Guid.NewGuid();
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
                        List<FengNiao.GMTools.Database.Model.tbl_mail> dataList = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_mail>(requestResult.Content);
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






        private void btnNew_Click(object sender, EventArgs e)
        {
            MailSender frmMailSender = new MailSender();
            frmMailSender.ShowDialog();
        }


        private void InitPageSize()
        {
            Match match = Regex.Match(cbPageCount.Text, "\\d+");
            if (match.Success)
            {
                PageSize = int.Parse(match.Value.ToString());
            }
        }

        private void tbMailID_ButtonCustomClick(object sender, EventArgs e)
        {
            tbMailID.Text = "";
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

        private void tbServerID_ButtonCustom2Click(object sender, EventArgs e)
        {
            tbServerID.Text = "";
            tbServerID.Tag = null;
        }

        private void tbRoleID_ButtonCustomClick(object sender, EventArgs e)
        {
            QueryRole queryRoleInfo = new QueryRole(null);
            if (queryRoleInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbRoleID.Text = queryRoleInfo.SelectedRoleID;
            }
        }

        private void tbRoleID_ButtonCustom2Click(object sender, EventArgs e)
        {
            tbRoleID.Text = "";
        }

        private void tbTitle_ButtonCustomClick(object sender, EventArgs e)
        {
            tbTitle.Text = "";
        }

        private void tbContent_ButtonCustomClick(object sender, EventArgs e)
        {
            tbContent.Text = "";
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewItem frmViewItem = new ViewItem();
            if (frmViewItem.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                List<FengNiao.GMTools.Database.Model.tbl_item> selectedItems = frmViewItem.SelectedItems;
                dataItemList.Rows.Clear();
                for (int i = 0; i < selectedItems.Count; i++)
                {
                    int index = dataItemList.Rows.Add(selectedItems[i].item_record_id, selectedItems[i].name, 0);
                    dataItemList.Rows[index].Tag = selectedItems[i];
                }
            }
        }

        private void dtStartFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtStartFromTime.Enabled = dtStartFromDate.LockUpdateChecked;
        }

        private void dtStartToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtStartToTime.Enabled = dtStartToDate.LockUpdateChecked;
        }

        private void dtStopFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtStopFromTime.Enabled = dtStopFromDate.LockUpdateChecked;
        }

        private void dtStopToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtStopToTime.Enabled = dtStopToDate.LockUpdateChecked;
        }

        private void dtCreateFromDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtCreateFromTime.Enabled = dtCreateFromDate.LockUpdateChecked;
        }

        private void dtCreateToDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtCreateToTime.Enabled = dtCreateToDate.LockUpdateChecked;
        }



        private void Mail_Load(object sender, EventArgs e)
        {
            RefreshLayout();
            InitCount();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
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

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurrentPage = PageCount;
            InitList();
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

        void tbCurrentPage_GotFocus(object sender, EventArgs e)
        {
            //tbCurrentPage.Text = string.Format("{0}", CurrentPage);
            tbCurrentPage.Text = "";
        }

        void tbCurrentPage_LostFocus(object sender, EventArgs e)
        {
            tbCurrentPage.Text = string.Format("{0}/{1}", CurrentPage, PageCount);
        }



        private void btnQuery_Click(object sender, EventArgs e)
        {
            CurrentPage = 1;
            requestParameters.Clear();
            if (cbMailType.Text.Equals("个人邮件"))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("mail_type", 2, SqlCompareType.Equal));
            }
            else if (cbMailType.Text.Equals("系统邮件"))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("mail_type", 1, SqlCompareType.Equal));
            }

            if (!string.IsNullOrEmpty(tbMailID.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("mail_id", tbMailID.Text, SqlCompareType.Equal));
            }
            if (tbServerID.Tag is FengNiao.GMTools.Database.Model.tbl_server)
            {
                FengNiao.GMTools.Database.Model.tbl_server server = tbServerID.Tag as FengNiao.GMTools.Database.Model.tbl_server;
                requestParameters.Add(new HttpInterfaceSqlParameter("server_id", server.fld_server_id, SqlCompareType.Equal));
            }
            if (!string.IsNullOrEmpty(tbRoleID.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("role_id", tbRoleID.Text, SqlCompareType.Equal));
            }
            if (!string.IsNullOrEmpty(tbTitle.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("title", tbTitle.Text, cbTitle.Checked ? SqlCompareType.Like : SqlCompareType.Equal));
            }
            if (!string.IsNullOrEmpty(tbContent.Text))
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("title", tbContent.Text, cbContent.Checked ? SqlCompareType.Like : SqlCompareType.Equal));
            }

            for (int i = 0; i < dataItemList.Rows.Count; i++)
            {
                FengNiao.GMTools.Database.Model.tbl_item item = dataItemList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_item;
                if (item != null)
                {

                    string itemID = item.item_id.ToString();
                    int count = 0;
                    if (dataItemList.Rows[i].Cells[2].Value != null)
                    {
                        int.TryParse(dataItemList.Rows[i].Cells[2].Value.ToString(), out count);
                    }
                    string strItem = string.Format("ItemID:{0}|", itemID);
                    if (count > 0)
                    {
                        strItem += string.Format("ItemCount:{0}|", count);
                    }
                    requestParameters.Add(new HttpInterfaceSqlParameter("items", strItem, SqlCompareType.Like));
                }
            }



            if (dtStartFromDate.LockUpdateChecked && !dtStartToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("starttime", dtStartFromDate.Value.ToString("yyyy-MM-dd") + " " + dtStartFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtStartFromDate.LockUpdateChecked && dtStartToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("starttime", dtStartToDate.Value.ToString("yyyy-MM-dd") + " " + dtStartToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtStartFromDate.LockUpdateChecked && dtStartToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("starttime", dtStartFromDate.Value.ToString("yyyy-MM-dd") + " " + dtStartFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("starttime", dtStartToDate.Value.ToString("yyyy-MM-dd") + " " + dtStartToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }


            if (dtStopFromDate.LockUpdateChecked && !dtStopToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("stoptime", dtStopFromDate.Value.ToString("yyyy-MM-dd") + " " + dtStopFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtStopFromDate.LockUpdateChecked && dtStopToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("stoptime", dtStopToDate.Value.ToString("yyyy-MM-dd") + " " + dtStopToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtStopFromDate.LockUpdateChecked && dtStopToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("stoptime", dtStopFromDate.Value.ToString("yyyy-MM-dd") + " " + dtStopFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("stoptime", dtStopToDate.Value.ToString("yyyy-MM-dd") + " " + dtStopToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }


            if (dtCreateFromDate.LockUpdateChecked && !dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("craetetime", dtCreateFromDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (!dtCreateFromDate.LockUpdateChecked && dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("craetetime", dtCreateToDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateToTime.Value.ToString("HH:mm:ss"), SqlCompareType.Equal));
            }
            else if (dtCreateFromDate.LockUpdateChecked && dtCreateToDate.LockUpdateChecked)
            {
                requestParameters.Add(new HttpInterfaceSqlParameter("craetetime", dtCreateFromDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateFromTime.Value.ToString("HH:mm:ss"), SqlCompareType.MoreThanAndEqual));
                requestParameters.Add(new HttpInterfaceSqlParameter("craetetime", dtCreateToDate.Value.ToString("yyyy-MM-dd") + " " + dtCreateToTime.Value.ToString("HH:mm:ss"), SqlCompareType.LessThanAndEqual));
            }

            //todo 新增各种限制的查询

            InitPageSize();
            InitCount();

        }

        private void dataItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 3)
                {
                    dataItemList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InitCount();
        }

        private void dtMinDateLeft_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMinTimeLeft.Enabled = dtMinDateLeft.LockUpdateChecked;
        }

        private void dtMinDateRight_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMinTimeRight.Enabled = dtMinDateRight.LockUpdateChecked;
        }

        private void dtMaxDateLeft_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMaxTimeLeft.Enabled = dtMaxDateLeft.LockUpdateChecked;
        }

        private void dtMaxDateRight_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMaxTimeRight.Enabled = dtMinDateRight.LockUpdateChecked;
        }
    }
}
