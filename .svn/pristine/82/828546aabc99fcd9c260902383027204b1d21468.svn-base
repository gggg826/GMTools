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
    public partial class RecommendDetails : BaseForm
    {
        private const int DefaultQueue = 10;

        FengNiao.GMTools.Database.Model.tbl_server CurrentServerData;
        FengNiao.GMTools.Database.Model.tbl_recommend CurrendRecommend;
        public RecommendDetails(FengNiao.GMTools.Database.Model.tbl_server serverData)
        {
            InitializeComponent();
            CurrentServerData = serverData;
            this.Text = "新推荐";
            this.lbTitle.Text = "新推荐";
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


            //InitActivityList();
            cbIndex.DataSource = new BindingSource(GlobalObject.GetRecommends(), null);
            cbIndex.DisplayMember = "Value";
            cbIndex.ValueMember = "Key";

            cbRank.DataSource = new BindingSource(GlobalObject.RecommendRanks, null);
            cbRank.DisplayMember = "Value";
            cbRank.ValueMember = "Key";

            isNew = true;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            dtStartDate.Value = DateTime.Now;
            dtStartTime.Value = DateTime.Now;
            dtStopDate.Value = DateTime.Now.AddDays(7);
            dtStopTime.Value = DateTime.Now;
            CurrentServerData = serverData;
            tbQueue.Text = DefaultQueue.ToString();
        }


        public RecommendDetails(FengNiao.GMTools.Database.Model.tbl_server serverData, FengNiao.GMTools.Database.Model.tbl_recommend recommend)
            : this(serverData)
        {
            CurrendRecommend = recommend;
            this.Text = "推荐编辑";
            this.lbTitle.Text = "推荐编辑";
            isNew = false;
            tbServer.Enabled = false;
            cbIndex.Enabled = false;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_name;
            cbIndex.SelectedValue = recommend.id;
            dtStartDate.Value = recommend.starttime.Value;
            dtStartTime.Value = recommend.starttime.Value;
            dtStopDate.Value = recommend.stoptime.Value;
            dtStopTime.Value = recommend.stoptime.Value;
            cbIsOpen.Checked = Convert.ToBoolean(recommend.isopen);
            cbRank.SelectedValue = recommend.rank.Value;
            tbQueue.Text = recommend.queue.Value.ToString();
        }

        private bool isNew { set; get; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FengNiao.GMTools.Database.Model.tbl_recommend recommend = null;
            if (isNew)
            {
                recommend = new FengNiao.GMTools.Database.Model.tbl_recommend();
                recommend.id = (int)cbIndex.SelectedValue;
                recommend.server_id = CurrentServerData.fld_server_id;
            }
            else
            {
                recommend = CurrendRecommend;
            }

            DateTime starttime = DateTime.Parse(dtStartDate.Value.ToString("yyyy-MM-dd") + " " + dtStartTime.Value.ToString("HH:mm:ss"));
            DateTime stoptime = DateTime.Parse(dtStopDate.Value.ToString("yyyy-MM-dd") + " " + dtStopTime.Value.ToString("HH:mm:ss"));
            if (DateTime.Compare(starttime, stoptime) > -1)
            {
                CustomMessageBox.Error(this, "推荐结束时间必须大于开始时间");
                return;
            }


            recommend.isopen = Convert.ToInt32(cbIsOpen.Checked);
            recommend.starttime = starttime;
            recommend.stoptime = stoptime;
            recommend.rank = (int)cbRank.SelectedValue;
            recommend.queue = Convert.ToInt32(tbQueue.Text);

            string strModel = FengNiao.GameTools.Json.Serialize.ConvertObjectToJson<FengNiao.GMTools.Database.Model.tbl_recommend>(recommend);

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Recommend, isNew ? HttpMethodType.Add : HttpMethodType.Update);
            strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, SaveRecommendCallback);
        }


        private void SaveRecommendCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResultModel = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResultModel.IsSuccess)
                    {
                        CustomMessageBox.Info(this, "配置推荐成功");
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    }
                    else
                    {
                        CustomMessageBox.Error(this, string.Format("配置推荐失败\r\n{0}", requestResultModel.Content));
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
    


       







         //初始化GameObject.Recommad
        private void InitRecommadList()
        {
            FengNiao.GMTools.Database.Model.tbl_server serverData = tbServer.Tag as FengNiao.GMTools.Database.Model.tbl_server;

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity_Config, HttpMethodType.GetList);
            List<HttpInterfaceSqlParameter> requestParameters = new List<HttpInterfaceSqlParameter>();
            requestParameters.Add(new HttpInterfaceSqlParameter("server_id", serverData.fld_server_id, SqlCompareType.Equal));
            if (requestParameters.Count > 0)
            {
                string strParamter = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<HttpInterfaceSqlParameter>>(requestParameters);
                strArgs = string.Format("{0}&Parameter={1}", strArgs, strParamter);
            }
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetRecommendListCallback);
        }
        private void GetRecommendListCallback(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_activity_config> list = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_activity_config>(requestResult.Content);
                        GlobalObject.ActivityConfigList = list;
                        cbIndex.DataSource = new BindingSource(GlobalObject.GetRecommends(), null);
                        cbIndex.DisplayMember = "Value";
                        cbIndex.ValueMember = "Key";
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
        private void InitActivityList()
        {
            if (GlobalObject.ActivityList != null) return;

            string strArgs = GlobalObject.GetModuleAndMethodArgs(HttpModuleType.Activity, HttpMethodType.GetList);
            //strArgs = string.Format("{0}&Model={1}", strArgs, System.Web.HttpUtility.UrlEncode(strModel, Encoding.UTF8));
            CustomWebRequest.Request(GlobalObject.HttpServerIP, strArgs, Encoding.UTF8, GetActivityListCallBack);
        }
        private void GetActivityListCallBack(object sender, UploadDataCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                try
                {
                    string strContent = Encoding.UTF8.GetString(e.Result);
                    ResultModel requestResult = FengNiao.GameTools.Json.Serialize.ConvertJsonToObject<ResultModel>(strContent);
                    if (requestResult.IsSuccess)
                    {
                        List<FengNiao.GMTools.Database.Model.tbl_activity> list = FengNiao.GameTools.Json.Serialize.ConvertJsonToObjectList<FengNiao.GMTools.Database.Model.tbl_activity>(requestResult.Content);
                        GlobalObject.ActivityList = list;
                        InitRecommadList();
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

    }
    }

