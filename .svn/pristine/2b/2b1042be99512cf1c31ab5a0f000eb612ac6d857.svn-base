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
    public partial class FirstRechargeDetails : FengNiao.GameTools.Util.BaseForm
    {
        FengNiao.GMTools.Database.Model.tbl_server CurrentServerData;
        FengNiao.GMTools.Database.Model.tbl_first_recharge_config CurrentFirstRechargeConfig;
        public FirstRechargeDetails(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            InitializeComponent();
            CurrentServerData = serverData;
            this.Text = "新的首次充值";
            this.lbTitle.Text = "新的首次充值";
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
            isNewFirstRecharge = true;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            dtStartDate.Value = DateTime.Now;
            dtStartTime.Value = DateTime.Now;
            dtStopDate.Value = DateTime.Now;
            dtStopTime.Value = DateTime.Now;
            CurrentServerData = serverData;
        }


        public FirstRechargeDetails(FengNiao.GMTools.Database.Model.tbl_server serverData, FengNiao.GMTools.Database.Model.tbl_first_recharge_config FirstRechargeConfig, FengNiao.GMTools.Database.Model.tbl_first_recharge first_recharge)
            : this(serverData)
        {
            CurrentFirstRechargeConfig = FirstRechargeConfig;
            this.Text = "首次充值编辑";
            this.lbTitle.Text = "首次充值编辑";
            isNewFirstRecharge = false;
            tbServer.Enabled = false;
            tbActivity.Enabled = false;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            if (first_recharge != null)
            {
                tbActivity.Text = first_recharge.name + "(" + first_recharge.itemid.ToString() + ")";
            }
            else
            {
                tbActivity.Text = first_recharge.itemid.ToString();
            }
            dtStartDate.Value = FirstRechargeConfig.starttime.Value;
            dtStartTime.Value = FirstRechargeConfig.starttime.Value;
            dtStopDate.Value = FirstRechargeConfig.stoptime.Value;
            dtStopTime.Value = FirstRechargeConfig.stoptime.Value;
            cbIsOpen.Checked = Convert.ToBoolean(FirstRechargeConfig.isopen);
        }

        private bool isNewFirstRecharge { set; get; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            FengNiao.GMTools.Database.Model.tbl_first_recharge_config first_rechargeConfig = null;
            if (isNewFirstRecharge)
            {
                FengNiao.GMTools.Database.Model.tbl_first_recharge first_recharge = tbActivity.Tag as FengNiao.GMTools.Database.Model.tbl_first_recharge;
                if (first_recharge == null)
                {
                    CustomMessageBox.Error(this, "没有选择充值");
                    return;
                }
                first_rechargeConfig = new FengNiao.GMTools.Database.Model.tbl_first_recharge_config();
                first_rechargeConfig.id = first_recharge.itemid.ToString();
                first_rechargeConfig.server_id = CurrentServerData.fld_server_id;
            }
            else
            {
                first_rechargeConfig = CurrentFirstRechargeConfig;
            }

            DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            DateTime stoptime = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss"));
            if (DateTime.Compare(starttime, stoptime) > -1)
            {
                CustomMessageBox.Error(this, "首次充值结束时间必须大于开始时间");
                return;
            }


            first_rechargeConfig.isopen = Convert.ToInt32(cbIsOpen.Checked);
            first_rechargeConfig.starttime = starttime;
            first_rechargeConfig.stoptime = stoptime;

            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<FengNiao.GMTools.Database.Model.tbl_first_recharge_config>(first_rechargeConfig);

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.FirstRecharge_Config, isNewFirstRecharge ? HttpMethodType.Add : HttpMethodType.Update);
            strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, SaveFirstRechargeCallback);
        }


        private void SaveFirstRechargeCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, "配置首次充值成功");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("配置首次充值失败\r\n{0}", requestResultModel.Content));
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
            FirstRechargeImport frmActivityImport = new FirstRechargeImport();
            frmActivityImport.IsSelector = true;
            if (frmActivityImport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tbActivity.Text = frmActivityImport.SelectedActivity.name +"(" +  frmActivityImport.SelectedActivity.itemid.ToString() +")";
                tbActivity.Tag = frmActivityImport.SelectedActivity;
            }
        }
    }
}
