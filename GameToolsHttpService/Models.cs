using System;
using System.Collections.Generic;
using System.Web;

namespace GameToolsHttpService
{
    public class ActivityModel
    {
        public int id { set; get; }
        public bool isopen { set; get; }
        public string starttime { set; get; }
        public string stoptime { set; get; }
    }

    public class ActivityArray
    {
        public ActivityArray()
        {
            activity = new List<ActivityModel>();
        }
        public List<ActivityModel> activity { set; get; }

        public void Add(ActivityModel model)
        {
            activity.Add(model);
        }
    }

    public class RecommendModel
    {
        public int id { set; get; }
        public bool isopen { set; get; }
        public string starttime { set; get; }
        public string stoptime { set; get; }
        public int rank { set; get; }
        public int queue { set; get; }
    }

    public class RecommendArray
    {
        public RecommendArray()
        {
            recommend = new List<RecommendModel>();
        }
        public List<RecommendModel> recommend { set; get; }

        public void Add(RecommendModel model)
        {
            recommend.Add(model);
        }
    }


    public class NoticeModel
    {
        public int id { set; get; }
        public string title { set; get; }
        public string content { set; get; }
        public string starttime { set; get; }
        public string stoptime { set; get; }
        public string image { set; get; }
        public int type { get; set; }
        public int? interval { get; set; }
    }

    public class NoticeArray
    {
        public NoticeArray()
        {
            notice = new List<NoticeModel>();
        }

        public List<NoticeModel> notice { set; get; }

        public void Add(NoticeModel model)
        {
            notice.Add(model);
        }
    }

    public class FirstRechargeModel 
    {
        public string id { set; get; }
        public int index { set; get; }
        public string name { set; get; }
        public string dec { set; get; }
        public int icon { set; get; }
        public int RMBprice { set; get; }
        public int IsOnlyOnce { set; get; }
        public int diamonds { set; get; }
        public int giveDiamonds { set; get; }
        public int normalGiveDiamonds { set; get; }
        public int activeGiveDiamonds { set; get; }
        public string activeStartTime { set; get; }
        public string activeEndTime { set; get; }
        public int isWeekCard { set; get; }
        public int isMonthCard { set; get; }
        public string channel { set; get; }
        public int sellStatc { set; get; }
        public int FirstRechargeItem1 { set; get; }
        public int Num1 { set; get; }
        public int FirstRechargeItem2 { set; get; }
        public int Num2 { set; get; }
        public int FirstRechargeItem3 { set; get; }
        public int Num3 { set; get; }
        public int FirstRechargeItem4 { set; get; }
        public int Num4 { set; get; }
        public int FirstRechargeItem5 { set; get; }
        public int Num5 { set; get; }
        public int FirstRechargeItem6 { set; get; }
        public int Num6 { set; get; }

    }
    public class FirstRechargeArray
    {
        public FirstRechargeArray()
        {
            firstrecharge = new List<FirstRechargeModel>();
        }

        public List<FirstRechargeModel> firstrecharge { set; get; }

        public void Add(FirstRechargeModel model)
        {
            firstrecharge.Add(model);
        }
    }

    public class LoginRewardModel
    {
        public int date { set; get; }
        public int kindReward { set; get; }
        public int rewardName1 { set; get; }
        public int rewardCount1 { set; get; }
        public int rewardName2 { set; get; }
        public int rewardCount2 { set; get; }
        public int rewardName3 { set; get; }
        public int rewardCount3 { set; get; }
        public int rewardName4 { set; get; }
        public int rewardCount4 { set; get; }
    }

    public class LoginRewardlArray
    {
        public LoginRewardlArray()
        {
            loginreward= new List<LoginRewardModel>();
        }

        public List<LoginRewardModel> loginreward { set; get; }

        public void Add(LoginRewardModel model)
        {
            loginreward.Add(model);
        }
    }

    public class SucessRewardModel
    {
        public int date { set; get; }
        public int kindReward { set; get; }
        public int rewardName1 { set; get; }
        public int rewardCount1 { set; get; }
        public int rewardName2 { set; get; }
        public int rewardCount2 { set; get; }
        public int rewardName3 { set; get; }
        public int rewardCount3 { set; get; }
        public int rewardName4 { set; get; }
        public int rewardCount4 { set; get; }
    }

    public class SucessRewardlArray
    {
        public SucessRewardlArray()
        {
            sucessreward = new List<SucessRewardModel>();
        }

        public List<SucessRewardModel> sucessreward { set; get; }

        public void Add(SucessRewardModel model)
        {
            sucessreward.Add(model);
        }
    }

    public class ChanelPackageModel
    {
        public string package_name { set; get; }
        public string package_id { set; get; }
        public string channel_id { set; get; }

    }

    public class ChanelPackageArray
    {
        public ChanelPackageArray()
        {
            chanelPackage = new List<ChanelPackageModel>();
        }

        public List<ChanelPackageModel> chanelPackage { set; get; }

        public void Add(ChanelPackageModel model)
        {
            chanelPackage.Add(model);
        }
    }

    public class CountsFunctionModel
    {
        public int id{set;get;}
        public int activity_id{set;get;}
        public int max_counts{set;get;}
        public string describes { set; get; }
        public int kindofreward { set; get; }
        public List<reward> rewards = new List<reward>();

        public void Add(reward reward1, reward reward2, reward reward3, reward reward4)
        {
            rewards.Add(reward1);
            rewards.Add(reward2);
            rewards.Add(reward3);
            rewards.Add(reward4);
        }
    }

    //public class CountsFunctionArray
    //{
    //    public CountsFunctionArray()
    //    {
    //        countsFuncion = new List<CountsFunctionModel>();
    //    }

    //    public List<CountsFunctionModel> countsFuncion { set; get; }

    //    public void Add(CountsFunctionModel model)
    //    {
    //        countsFuncion.Add(model);
    //    }
    //}


    public class reward
    {
        public int item_id{set;get;}
        public int item_count { set; get; }
    }
}