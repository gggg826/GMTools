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
using FengNiao.GMTools.Database.Model;

namespace GameToolsClient
{
    public partial class SucessionRewardDetail : FengNiao.GameTools.Util.BaseForm
    {
        private bool isNewActivity = true;
        private tbl_server CurrentServerData;
        private SucessionRewardsManager mParent;


        public SucessionRewardDetail(tbl_server serverData, SucessionRewardsManager parent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            mParent = parent;
            isNewActivity = true;
            CurrentServerData = serverData;
            tbServer.Tag = serverData;
            tbServer.Text = serverData.fld_server_id.ToString();
            tbKind.SelectedIndex = 0;
            tbServer.Enabled = false;
            CurrentServerData = serverData;
        }

        public SucessionRewardDetail(tbl_server serverData, tbl_sucession_rewards_config loginReward, SucessionRewardsManager parent)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            isNewActivity = false;

            mParent = parent;
            tbServer.Tag = serverData;
            CurrentServerData = serverData;
            tbServer.Text = loginReward.serverID.ToString();
            tbServer.Enabled = false;
            tbKind.SelectedIndex = int.Parse(loginReward.kindReward.ToString());
            date.Text = loginReward.date.ToString();
            tbReward1.Text = loginReward.rewardName1.ToString();
            tbCount1.Text = loginReward.rewardCount1.ToString();
            tbReward2.Text = loginReward.rewardName2.ToString();
            tbCount2.Text = loginReward.rewardCount2.ToString();
            tbReward3.Text = loginReward.rewardName3.ToString();
            tbCount3.Text = loginReward.rewardCount3.ToString();
            tbCount4.Text = loginReward.rewardCount4.ToString();
            tbReward4.Text = loginReward.rewardName4.ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            tbl_sucession_rewards_config config = new tbl_sucession_rewards_config();
            int temp;
            if (int.TryParse(date.Text.ToString(), out temp))
                config.date = temp;
            if (int.TryParse(tbKind.Text.ToString(), out temp))
                config.kindReward = temp;
            int count = 0;
            if (int.TryParse(tbReward1.Text.ToString(), out temp) && !int.TryParse(tbCount1.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具1的数量不能为空");
                return;
            }
            if (!int.TryParse(tbReward1.Text.ToString(), out temp) && int.TryParse(tbCount1.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具1不能为空");
                return;
            }
            config.rewardName1 = temp;
            config.rewardCount1 = count;

            if (int.TryParse(tbReward2.Text.ToString(), out temp) && !int.TryParse(tbCount2.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具2的数量不能为空");
                return;
            }
            if (!int.TryParse(tbReward2.Text.ToString(), out temp) && int.TryParse(tbCount2.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具2不能为空");
                return;
            }
            config.rewardName2 = temp;
            config.rewardCount2 = count;

            if (int.TryParse(tbReward3.Text.ToString(), out temp) && !int.TryParse(tbCount3.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具3的数量不能为空");
                return;
            }
            if (!int.TryParse(tbReward3.Text.ToString(), out temp) && int.TryParse(tbCount3.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具3不能为空");
                return;
            }
            config.rewardName3 = temp;
            config.rewardCount3 = count;

            if (int.TryParse(tbReward4.Text.ToString(), out temp) && !int.TryParse(tbCount4.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具4的数量不能为空");
                return;
            }
            if (!int.TryParse(tbReward4.Text.ToString(), out temp) && int.TryParse(tbCount4.Text.ToString(), out count))
            {
                CustomMessageBox.Error(this, "奖励道具4不能为空");
                return;
            }
            config.rewardName4 = temp;
            config.rewardCount4 = count;
            config.serverID = CurrentServerData.fld_server_id;
            config.record_id = 0;

            if(mParent.isCanAdd(config))
            {
                mParent.AddRow(config);
                this.Close();
            }
            else
            {
                CustomMessageBox.Error(this, "已配置过此奖励");
            }
            
           
        }


        private void SaveCallback(object sender, UploadDataCompletedEventArgs e)
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

        private void buttonX1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void all_Check_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }
        }
    }
}
