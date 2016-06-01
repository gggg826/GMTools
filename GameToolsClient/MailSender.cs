using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using GameToolsCommon;
using FengNiao.GameToolsCommon;
using System.Net;
using FengNiao.GMTools.Database.Model;
using Newtonsoft.Json.Linq;

namespace GameToolsClient
{
    public partial class MailSender : BaseForm
    {
        public MailSender()
        {
            InitializeComponent();
            this.Text = "发送邮件";
            this.BackColor = Color.White;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.IsAcceptResize = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.TopMostBox = false;
            this.IsShowCaptionImage = false;
            this.IsShowCaptionText = false;
            this.IsTitleSplitLine = false;
            this.Image = Properties.Resources.TK_2icon;
            cbMailType.Items.Add("个人邮件");
            cbMailType.Items.Add("系统邮件");
            cbOptype.Items.Add("读后删除");
            cbOptype.Items.Add("读后不删除");
            cbMailType.Text = "个人邮件";
            cbOptype.Text = "读后删除";
            ChangeMailType();
            dtStartDate.Value = DateTime.Now;
            dtStartTime.Value = DateTime.Now;
            dtStopDate.Value = DateTime.Now;
            dtStopTime.Value = DateTime.Now;
            dtMinDate.Value = DateTime.Now;
            dtMinTime.Value = DateTime.Now;
            dtMaxDate.Value = DateTime.Now;
            dtMaxTime.Value = DateTime.Now;
            dtMinDate.LockUpdateChecked = false;
            dtMinTime.Enabled = false;
            dtMaxDate.LockUpdateChecked = false;
            dtMaxTime.Enabled = false;
        }

        private void MailSender_DoubleClick(object sender, EventArgs e)
        {

        }

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

        private void tbRoleID_ButtonCustomClick(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }

            QueryRole queryRoleInfo = new QueryRole(serverData);
            if (queryRoleInfo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(tbRoleID.Text))
                {
                    tbRoleID.Text += ",";
                }
                tbRoleID.Text += queryRoleInfo.SelectedRoleID;
            }
        }

        private void cbMailType_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeMailType();
        }

        private void ChangeMailType()
        {
            if (cbMailType.Text.Equals("个人邮件"))
            {
                dtStartDate.Enabled = false;
                dtStartTime.Enabled = false;
                dtStopDate.Enabled = false;
                dtStopTime.Enabled = false;
                tbRoleID.Enabled = true;

                tbChannel.Enabled = false;
                tbMinVersion.Enabled = false;
                tbMaxVersion.Enabled = false;
                tbMinLevel.Enabled = false;
                tbMaxLevel.Enabled = false;
                dtMinDate.Enabled = false;
                dtMinTime.Enabled = false;
                dtMaxDate.Enabled = false;
                dtMaxTime.Enabled = false;
            }
            else if (cbMailType.Text.Equals("系统邮件"))
            {
                dtStartDate.Enabled = true;
                dtStartTime.Enabled = true;
                dtStopDate.Enabled = true;
                dtStopTime.Enabled = true;
                tbRoleID.Enabled = false;

                tbChannel.Enabled = true;
                tbMinVersion.Enabled = true;
                tbMaxVersion.Enabled = true;
                tbMinLevel.Enabled = true;
                tbMaxLevel.Enabled = true;
                dtMinDate.Enabled = true;
                dtMinDate.LockUpdateChecked = false;
                dtMinTime.Enabled = false;
                dtMaxDate.Enabled = true;
                dtMaxDate.LockUpdateChecked = false;
                dtMaxTime.Enabled = false;
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            MailModel mailModel = new MailModel();
            StringBuilder strArgs = new StringBuilder(GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Transfer, HttpMethodType.SendMail));
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;
            string strStartTime = string.Empty;
            string strStopTime = string.Empty;
            string strMinDateTime = string.Empty;
            string strMaxDateTime = string.Empty;
            if (serverData == null)
            {
                CustomMessageBox.Error(this, "没有选择服务器");
                return;
            }
            if (cbMailType.Text.Equals("个人邮件"))
            {
                if (string.IsNullOrEmpty(tbRoleID.Text))
                {
                    CustomMessageBox.Error(this, "角色ID不能为空");
                    return;
                }
                strArgs.AppendFormat("&RoleID={0}", tbRoleID.Text);
            }
            else if (cbMailType.Text.Equals("系统邮件"))
            {
                strStartTime = dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss");
                strStopTime = dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss");

                DateTime dt1 = DateTime.Now;
                DateTime dt2 = DateTime.Now;
                if (!DateTime.TryParse(strStartTime, out dt1))
                {
                    CustomMessageBox.Error(this, "开始生效时间无效");
                    return;
                }

                if (!DateTime.TryParse(strStopTime, out dt2))
                {
                    CustomMessageBox.Error(this, "生效结束时间无效");
                    return;
                }
                if (DateTime.Compare(dt1, dt2) > -1)
                {
                    CustomMessageBox.Error(this, "生效结束时间必须大于开始生效时间");
                    return;
                }

                if (!string.IsNullOrEmpty(tbChannel.Text.Trim()))
                {
                    var package = tbChannel.Tag as tbl_package;
                    if (package != null)
                    {
                        //strArgs.AppendFormat("&Channel={0}", package.fld_package_number);
                        mailModel.channel = package.fld_package_number;
                    }
                }

                if (!string.IsNullOrEmpty(tbMinVersion.Text.Trim()) && !string.IsNullOrEmpty(tbMaxVersion.Text.Trim()))
                {
                    //strArgs.AppendFormat("&MinVersion={0}&MaxVersion={1}", tbMinVersion.Text.Trim(), tbMaxVersion.Text.Trim());
                    mailModel.minversion = tbMinVersion.Text.Trim();
                    mailModel.maxversion = tbMaxVersion.Text.Trim();
                }
                else if (!string.IsNullOrEmpty(tbMinVersion.Text.Trim()) || !string.IsNullOrEmpty(tbMaxVersion.Text.Trim()))
                {
                    CustomMessageBox.Error(this, "最低最高版本需要成对输入");
                    return;
                }

                if (!string.IsNullOrEmpty(tbMinLevel.Text.Trim()) && !string.IsNullOrEmpty(tbMaxLevel.Text.Trim()))
                {
                    int minLevel;
                    int maxLevel;
                    if (int.TryParse(tbMinLevel.Text.Trim(), out minLevel) && int.TryParse(tbMaxLevel.Text.Trim(), out maxLevel))
                    {
                        //strArgs.AppendFormat("&MinLevel={0}&MaxLevel={1}", minLevel, maxLevel);
                        mailModel.minlevel = minLevel;
                        mailModel.maxlevel = maxLevel;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, "输入的等级无效");
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(tbMinLevel.Text.Trim()) || !string.IsNullOrEmpty(tbMaxLevel.Text.Trim()))
                {
                    CustomMessageBox.Error(this, "最低最高等级需要成对输入");
                    return;
                }

                if (dtMinDate.LockUpdateChecked && dtMaxDate.LockUpdateChecked)
                {
                    strMinDateTime = dtMinDate.Value.ToString("yyyy-MM-dd") + " " + dtMinTime.Value.ToString("HH:mm:ss");
                    strMaxDateTime = dtMaxDate.Value.ToString("yyyy-MM-dd") + " " + dtMaxTime.Value.ToString("HH:mm:ss");

                    DateTime dtMin = DateTime.Now;
                    DateTime dtMax = DateTime.Now;
                    if (!DateTime.TryParse(strMinDateTime, out dtMin))
                    {
                        CustomMessageBox.Error(this, "最小时间无效");
                        return;
                    }

                    if (!DateTime.TryParse(strMaxDateTime, out dtMax))
                    {
                        CustomMessageBox.Error(this, "最大时间无效");
                        return;
                    }
                    if (DateTime.Compare(dtMin, dtMax) > -1)
                    {
                        CustomMessageBox.Error(this, "最大时间必须大于最小时间");
                        return;
                    }

                    mailModel.mindatetime = strMinDateTime;
                    mailModel.maxdatetime = strMaxDateTime;
                }
                else if (dtMinDate.LockUpdateChecked || dtMaxDate.LockUpdateChecked)
                {
                    CustomMessageBox.Error(this, "最大最小时间需要成对输入");
                    return;
                }
            }
            if (string.IsNullOrEmpty(tbTitle.Text))
            {
                CustomMessageBox.Error(this, "邮件标题不能为空");
                return;
            }
            if (string.IsNullOrEmpty(tbContent.Text))
            {
                CustomMessageBox.Error(this, "邮件内容不能为空");
                return;
            }

            List<ItemModel> itemModelList = new List<ItemModel>();
            for (int i = 0; i < gvDataList.Rows.Count; i++)
            {
                FengNiao.GMTools.Database.Model.tbl_item item = gvDataList.Rows[i].Tag as FengNiao.GMTools.Database.Model.tbl_item;
                if (item != null)
                {
                    int itemCount = -1;
                    if (gvDataList.Rows[i].Cells[3].Value == null)
                    {
                        gvDataList.Rows[i].Cells[3].ErrorText = "道具数量无效";
                        CustomMessageBox.Error(this, "道具数量无效");
                        return;
                    }
                    if (!int.TryParse(gvDataList.Rows[i].Cells[3].Value.ToString(), out itemCount))
                    {
                        gvDataList.Rows[i].Cells[3].ErrorText = "道具数量无效";
                        CustomMessageBox.Error(this, "道具数量无效");
                        return;
                    }
                    itemModelList.Add(new ItemModel(item.item_id, itemCount));
                }
            }

            mailModel.optype = cbOptype.Text.Equals("读后删除") ? 1 : 2;
            mailModel.title = tbTitle.Text;
            mailModel.content = tbContent.Text;
            mailModel.retention = IIRetention.Value;
            mailModel.starttime = strStartTime;
            mailModel.stoptime = strStopTime;
            mailModel.items = itemModelList;

            string strEmailData = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<MailModel>(mailModel);
            strArgs.AppendFormat("&ServerID={0}&EmailData={1}", serverData.fld_server_id, strEmailData);
            try
            {
                CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs.ToString(), Encoding.UTF8, SendCallback);
                btnSend.Enabled = false;
            }
            catch
            {
                CustomMessageBox.Error(this, "地址无效");
            }
        }


        private void SendCallback(object sender, UploadDataCompletedEventArgs e)
        {

            if (e.Error == null)
            {
                string strContent = Encoding.UTF8.GetString(e.Result);
                ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                if (requestResult.IsSuccess)
                {
                    try
                    {
                        JObject contentObj = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject(requestResult.Content);
                        int errorcode = FengNiao.GameTools.Json.Serialize.GetJsonObject<int>(contentObj, "errorcode");
                        if (errorcode == 0)
                        {
                            CustomMessageBox.Info(this, "发送成功");
                        }
                        else
                        {
                            CustomMessageBox.Error(this, string.Format("\t发送失败，errorcode{0}", errorcode));
                        }
                    }
                    catch
                    {
                        CustomMessageBox.Error(this, "发送失败\r\n系统错误");
                    }
                }
                else
                {
                    CustomMessageBox.Error(this, string.Format("发送失败\r\n{0}", requestResult.Content));
                }
            }
            else
            {
                CustomMessageBox.Error(this, "连接服务器异常，请确认是否已经联网");
            }
            btnSend.Enabled = true;
        }

        Dictionary<int, int> ItemCountCache = new Dictionary<int, int>();

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

        private void gvDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == 4)
                {
                    gvDataList.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void MailSender_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtMinDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMinTime.Enabled = dtMinDate.LockUpdateChecked;
        }

        private void dtMaxDate_LockUpdateChanged(object sender, EventArgs e)
        {
            dtMaxTime.Enabled = dtMaxDate.LockUpdateChecked;
        }
    }
}
