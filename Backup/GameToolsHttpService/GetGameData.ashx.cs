using System;
using System.Collections.Generic;
using System.Web;
using GameToolsCommon;

namespace GameToolsHttpService
{
    /// <summary>
    /// GetGameData 的摘要说明
    /// </summary>
    public class GetGameData : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string strServerID = context.Request["serverid"];
            string strCmd = context.Request["cmd"];
            if (!DataCheck.CheckDataIsvalid(strServerID))
            {
                context.Response.Write("");
            }
            switch (strCmd)
            {
                case "activity":
                    FengNiao.GMTools.Database.BLL.tbl_activity_config activityConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_activity_config();
                    List<FengNiao.GMTools.Database.Model.tbl_activity_config> configs = activityConfigBLL.GetModelList("server_id = " + strServerID);
                    ActivityArray activity = new ActivityArray();
                    for (int i = 0; i < configs.Count; i++)
                    {
                        ActivityModel activityModel = new ActivityModel();
                        activityModel.id = configs[i].id;
                        activityModel.isopen = Convert.ToBoolean(configs[i].isopen);
                        activityModel.starttime = configs[i].starttime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        activityModel.stoptime = configs[i].stoptime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        activity.Add(activityModel);
                    }
                    string strActivity = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<ActivityArray>(activity);
                    context.Response.Write(strActivity);
                    break;
                case "recommend":
                    FengNiao.GMTools.Database.BLL.tbl_recommend recommendBLL = new FengNiao.GMTools.Database.BLL.tbl_recommend();
                    List<FengNiao.GMTools.Database.Model.tbl_recommend> recommends = recommendBLL.GetModelList("server_id = " + strServerID);
                    RecommendArray recommend = new RecommendArray();
                    for (int i = 0; i < recommends.Count; i++)
                    {
                        RecommendModel recommendModel = new RecommendModel();
                        recommendModel.id = recommends[i].id;
                        recommendModel.isopen = Convert.ToBoolean(recommends[i].isopen);
                        recommendModel.starttime = recommends[i].starttime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        recommendModel.stoptime = recommends[i].stoptime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        recommendModel.rank = recommends[i].rank.Value;
                        recommendModel.queue = recommends[i].queue.Value;
                        recommend.Add(recommendModel);
                    }
                    string strRecommend = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<RecommendArray>(recommend);
                    context.Response.Write(strRecommend);
                    break;
                case "notice":
                    FengNiao.GMTools.Database.BLL.tbl_notice_config noticeConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_notice_config();
                    List<FengNiao.GMTools.Database.Model.tbl_notice_config> notices = noticeConfigBLL.GetModelList("server_id = " + strServerID + " and deleted = 0");
                    NoticeArray notice = new NoticeArray();
                    for (int i = 0; i < notices.Count; i++)
                    {
                        NoticeModel noticeModel = new NoticeModel();
                        noticeModel.id = notices[i].id;
                        noticeModel.title = notices[i].title;
                        noticeModel.content = notices[i].content;
                        noticeModel.starttime = notices[i].starttime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        noticeModel.stoptime = notices[i].stoptime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                        noticeModel.image = notices[i].image;
                        noticeModel.type = notices[i].type;
                        noticeModel.interval = notices[i].interval;
                        notice.Add(noticeModel);
                    }
                    string strNotice = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<NoticeArray>(notice);
                    context.Response.Write(strNotice);
                    break;
                case "first_recharge":
                    FengNiao.GMTools.Database.BLL.tbl_first_recharge_config first_recharge_configBLL = new FengNiao.GMTools.Database.BLL.tbl_first_recharge_config();
                    List<FengNiao.GMTools.Database.Model.tbl_first_recharge_config> first_recharges = first_recharge_configBLL.GetModelList("server_id = " + strServerID);
                    FirstRechargeArray recharges = new FirstRechargeArray();
                    FengNiao.GMTools.Database.BLL.tbl_first_recharge tbl_first_rechargeBLL = new FengNiao.GMTools.Database.BLL.tbl_first_recharge();
                    for (int i = 0; i < first_recharges.Count; i++)
                    {
                        string iddd = "1";

                        List<FengNiao.GMTools.Database.Model.tbl_first_recharge> rechargeslist = tbl_first_rechargeBLL.GetModelList("itemid = " + first_recharges[i].id);
                        for (int j = 0; j < rechargeslist.Count; j++)
                        {
                            FirstRechargeModel firstRechargeModel = new FirstRechargeModel();
                            firstRechargeModel.id = rechargeslist[j].itemid.ToString();
                            firstRechargeModel.index = rechargeslist[j].index;
                            firstRechargeModel.name = rechargeslist[j].name;
                            firstRechargeModel.dec = rechargeslist[j].dec;
                            firstRechargeModel.icon = rechargeslist[j].icon;
                            firstRechargeModel.RMBprice = rechargeslist[j].RMBprice;
                            firstRechargeModel.IsOnlyOnce = rechargeslist[j].IsOnlyOnce;
                            firstRechargeModel.diamonds = rechargeslist[j].diamonds;
                            firstRechargeModel.giveDiamonds = rechargeslist[j].giveDiamonds;
                            firstRechargeModel.normalGiveDiamonds = rechargeslist[j].normalGiveDiamonds;
                            firstRechargeModel.activeGiveDiamonds = rechargeslist[j].activeGiveDiamonds;
                            firstRechargeModel.activeStartTime = rechargeslist[j].activeStartTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            firstRechargeModel.activeEndTime = rechargeslist[j].activeEndTime.Value.ToString("yyyy-MM-dd HH:mm:ss");
                            firstRechargeModel.isWeekCard = rechargeslist[j].isWeekCard;
                            firstRechargeModel.isMonthCard = rechargeslist[j].isMonthCard;
                            firstRechargeModel.channel = rechargeslist[j].channel;
                            firstRechargeModel.sellStatc = rechargeslist[j].sellStatc;
                            firstRechargeModel.FirstRechargeItem1 = rechargeslist[j].FirstRechargeItem1;
                            firstRechargeModel.Num1 = rechargeslist[j].Num1;
                            firstRechargeModel.FirstRechargeItem2 = rechargeslist[j].FirstRechargeItem2;
                            firstRechargeModel.Num2 = rechargeslist[j].Num2;
                            firstRechargeModel.FirstRechargeItem3 = rechargeslist[j].FirstRechargeItem3;
                            firstRechargeModel.Num3 = rechargeslist[j].Num3;
                            firstRechargeModel.FirstRechargeItem4 = rechargeslist[j].FirstRechargeItem4;
                            firstRechargeModel.Num4 = rechargeslist[j].Num4;
                            firstRechargeModel.FirstRechargeItem5 = rechargeslist[j].FirstRechargeItem5;
                            firstRechargeModel.Num5 = rechargeslist[j].Num5;
                            firstRechargeModel.FirstRechargeItem6 = rechargeslist[j].FirstRechargeItem6;
                            firstRechargeModel.Num6 = rechargeslist[j].Num6;
                            recharges.Add(firstRechargeModel);
                        }
                    }
                    string strfirst_recharges = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<FirstRechargeArray>(recharges);
                    context.Response.Write(strfirst_recharges);
                    break;
                case "loginreward":
                    FengNiao.GMTools.Database.BLL.tbl_login_rewards_config loginrewardConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_login_rewards_config();
                    List<FengNiao.GMTools.Database.Model.tbl_login_rewards_config> loginrewards = loginrewardConfigBLL.GetModelList("serverID = " + strServerID);
                    LoginRewardlArray loginreward = new LoginRewardlArray();
                    for (int i = 0; i < loginrewards.Count; i++)
                    {
                        LoginRewardModel loginrewardModel = new LoginRewardModel();
                        loginrewardModel.date = loginrewards[i].date;
                        loginrewardModel.kindReward = loginrewards[i].kindReward;
                        loginrewardModel.rewardName1 = loginrewards[i].rewardName1;
                        loginrewardModel.rewardCount1 = loginrewards[i].rewardCount1;
                        loginrewardModel.rewardName2 = loginrewards[i].rewardName2;
                        loginrewardModel.rewardCount2 = loginrewards[i].rewardCount2;
                        loginrewardModel.rewardName3 = loginrewards[i].rewardName3;
                        loginrewardModel.rewardCount3 = loginrewards[i].rewardCount3;
                        loginrewardModel.rewardName4 = loginrewards[i].rewardName4;
                        loginrewardModel.rewardCount4 = loginrewards[i].rewardCount4;

                        loginreward.Add(loginrewardModel);
                    }
                    string strloginreward = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<LoginRewardlArray>(loginreward);
                    context.Response.Write(strloginreward);
                    break;
                case "sucessreward":
                    FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config sucessConfigBLL = new FengNiao.GMTools.Database.BLL.tbl_sucession_rewards_config();
                    List<FengNiao.GMTools.Database.Model.tbl_sucession_rewards_config> rewards = sucessConfigBLL.GetModelList("serverID = " + strServerID);
                    SucessRewardlArray sucessreward = new SucessRewardlArray();
                    for (int i = 0; i < rewards.Count; i++)
                    {
                        SucessRewardModel sucessrewardModel = new SucessRewardModel();
                        sucessrewardModel.date = rewards[i].date;
                        sucessrewardModel.kindReward = rewards[i].kindReward;
                        sucessrewardModel.rewardName1 = rewards[i].rewardName1;
                        sucessrewardModel.rewardCount1 = rewards[i].rewardCount1;
                        sucessrewardModel.rewardName2 = rewards[i].rewardName2;
                        sucessrewardModel.rewardCount2 = rewards[i].rewardCount2;
                        sucessrewardModel.rewardName3 = rewards[i].rewardName3;
                        sucessrewardModel.rewardCount3 = rewards[i].rewardCount3;
                        sucessrewardModel.rewardName4 = rewards[i].rewardName4;
                        sucessrewardModel.rewardCount4 = rewards[i].rewardCount4;


                        sucessreward.Add(sucessrewardModel);
                    }
                    string sucessinreward = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<SucessRewardlArray>(sucessreward);
                    context.Response.Write(sucessinreward);
                    break;
                case "channelpackage":

                    FengNiao.GMTools.Database.BLL.tbl_package chanelpackageBLL = new FengNiao.GMTools.Database.BLL.tbl_package();
                    FengNiao.GMTools.Database.Model.tbl_package package = new FengNiao.GMTools.Database.Model.tbl_package();
                    List<FengNiao.GMTools.Database.Model.tbl_package> packages = chanelpackageBLL.GetAllModel();
                    //while (chanelpackageBLL.Exists(++record_id))
                    //{
                    //    package = chanelpackageBLL.GetModel(record_id);
                    //    packages.Add(package);
                    //}


                    List<ChanelPackageModel> listChanelPackage = new List<ChanelPackageModel>();
                    //List<FengNiao.GMTools.Database.Model.tbl_package> packages = GetAllPackageData();
                    for (int i = 0; i < packages.Count; i++)
                    {
                        ChanelPackageModel chanelpackageModel = new ChanelPackageModel();
                        chanelpackageModel.package_id = packages[i].fld_package_number;
                        chanelpackageModel.package_name = packages[i].fld_package_name;
                        chanelpackageModel.channel_id = packages[i].fld_chanelnum;

                        listChanelPackage.Add(chanelpackageModel);
                    }
                    string chanelPackage = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<ChanelPackageModel>>(listChanelPackage);
                    context.Response.Write(chanelPackage);
                    break;
                case "activity_task":
                    FengNiao.GMTools.Database.BLL.tbl_counts_config coutsBLL = new FengNiao.GMTools.Database.BLL.tbl_counts_config();
                    FengNiao.GMTools.Database.Model.tbl_counts_config count = new FengNiao.GMTools.Database.Model.tbl_counts_config();
                    List<FengNiao.GMTools.Database.Model.tbl_counts_config> counts = coutsBLL.GetModelList("serverID = " + strServerID);
                    List<CountsFunctionModel> listCounts = new List<CountsFunctionModel>();
                    for (int i = 0; i < counts.Count; i++)
                    {
                        CountsFunctionModel countModel = new CountsFunctionModel();
                        countModel.id = counts[i].record_id;
                        countModel.activity_id = counts[i].item_id;
                        countModel.max_counts = counts[i].count;
                        countModel.describes = counts[i].dec;
                        countModel.kindofreward = counts[i].kindofrewards;

                        reward reward1 = new reward();
                        reward1.item_id = counts[i].reward1;
                        reward1.item_count = counts[i].count1;

                        reward reward2 = new reward();
                        reward2.item_id = counts[i].reward2;
                        reward2.item_count = counts[i].count2;

                        reward reward3 = new reward();
                        reward3.item_id = counts[i].reward3;
                        reward3.item_count = counts[i].count3;

                        reward reward4 = new reward();
                        reward4.item_id = counts[i].reward4;
                        reward4.item_count = counts[i].count4;

                        countModel.Add(reward1, reward2, reward3, reward4);


                        listCounts.Add(countModel);
                    }
                    string countsFunction = FengNiao.GameTools.Json.Serialize.ConvertObjectToJsonList<List<CountsFunctionModel>>(listCounts);
                    context.Response.Write(countsFunction);
                    break;
            }
        }

        public bool IsReusable
        {   
            get
            {
                return true;
            }
        }
    }
}