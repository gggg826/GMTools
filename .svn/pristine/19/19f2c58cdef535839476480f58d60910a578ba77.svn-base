using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FengNiao.GameTools.Util;
using FengNiao.GameToolsCommon;
using GameToolsCommon;
using System.Net;

namespace GameToolsClient
{
    public partial class ActivityDetails : BaseForm
    {
        FengNiao.GMTools.Database.Model.tbl_server CurrentServerData;
        FengNiao.GMTools.Database.Model.tbl_activity_config CurrentActivityConfig;
        public ActivityDetails(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            InitializeComponent();
            CurrentServerData = serverData;
            this.Text = "新活动";
            this.lbTitle.Text = "新活动";
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
            isNewActivity = true;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            dtStartDate.Value = DateTime.Now;
            dtStartTime.Value = DateTime.Now;
            dtStopDate.Value = DateTime.Now;
            dtStopTime.Value = DateTime.Now;
            CurrentServerData = serverData;
        }


        public ActivityDetails(FengNiao.GMTools.Database.Model.tbl_server serverData, FengNiao.GMTools.Database.Model.tbl_activity_config activityConfig, FengNiao.GMTools.Database.Model.tbl_activity activety)
            : this(serverData)
        {
            CurrentActivityConfig = activityConfig;
            this.Text = "活动编辑";
            this.lbTitle.Text = "活动编辑";
            isNewActivity = false;
            tbServer.Enabled = false;
            tbActivity.Enabled = false;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            if (activety != null)
            {
                tbActivity.Text = activety.name + "(" + activityConfig.id.ToString() + ")";
            }
            else
            {
                tbActivity.Text = activityConfig.id.ToString();
            }
            dtStartDate.Value = activityConfig.starttime.Value;
            dtStartTime.Value = activityConfig.starttime.Value;
            dtStopDate.Value = activityConfig.stoptime.Value;
            dtStopTime.Value = activityConfig.stoptime.Value;
            cbIsOpen.Checked = Convert.ToBoolean(activityConfig.isopen);
        }

        private bool isNewActivity { set; get; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //FengNiao.GMTools.Database.Model.tbl_activity activity = tbActivity.Tag as FengNiao.GMTools.Database.Model.tbl_activity;
            //if (activity == null)
            //{
            //    CustomMessageBox.Error(this, "没有选择活动");
            //    return;
            //}
            //DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            //DateTime stoptime = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss"));
            //if (DateTime.Compare(starttime, stoptime) > -1)
            //{
            //    CustomMessageBox.Error(this, "活动结束时间必须大于开始时间");
            //    return;
            //}

            FengNiao.GMTools.Database.Model.tbl_activity_config activityConfig = null;
            if (isNewActivity)
            {
                FengNiao.GMTools.Database.Model.tbl_activity activity = tbActivity.Tag as FengNiao.GMTools.Database.Model.tbl_activity;
                if (activity == null)
                {
                    CustomMessageBox.Error(this, "没有选择活动");
                    return;
                }
                activityConfig = new FengNiao.GMTools.Database.Model.tbl_activity_config();
                activityConfig.id = activity.id;
                activityConfig.server_id = CurrentServerData.fld_server_id;
            }
            else
            {
                activityConfig = CurrentActivityConfig;
            }

            DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            DateTime stoptime = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss"));
            if (DateTime.Compare(starttime, stoptime) > -1)
            {
                CustomMessageBox.Error(this, "活动结束时间必须大于开始时间");
                return;
            }


            activityConfig.isopen = Convert.ToInt32(cbIsOpen.Checked);
            activityConfig.starttime = starttime;
            activityConfig.stoptime = stoptime;

            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<FengNiao.GMTools.Database.Model.tbl_activity_config>(activityConfig);

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity_Config, isNewActivity ? HttpMethodType.Add : HttpMethodType.Update);
            strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, SaveActivityCallback);
        }


        private void SaveActivityCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, "配置活动成功");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("配置活动失败\r\n{0}", requestResultModel.Content));
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

        private void tbActivity_ButtonCustomClick(object sender, EventArgs e)
        {
            ActivityImport frmActivityImport = new ActivityImport();
            frmActivityImport.IsSelector = true;
            if (frmActivityImport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbActivity.Text = frmActivityImport.SelectedActivity.name +"(" +  frmActivityImport.SelectedActivity.id.ToString() +")";
                tbActivity.Tag = frmActivityImport.SelectedActivity;
            }
        }


    }
}
