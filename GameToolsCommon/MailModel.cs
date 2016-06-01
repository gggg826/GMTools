using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsCommon
{
    public class ItemModel
    {
        public ItemModel(int itemID, int count)
        {
            this.itemid = itemID;
            this.count = count;
        }
        public int itemid { set; get; }
        public int count { set; get; }
    }
    public class MailModel
    {
        public long emailid { set; get; }
        public int optype { set; get; }
        public string title { set; get; }
        public string content { set; get; }
        public int retention { set; get; }
        public string starttime { set; get; }
        public string stoptime { set; get; }
        public List<ItemModel> items { set; get; }
        public string channel { set; get; }
        public string minversion { get; set; }
        public string maxversion { get; set; }
        public int? minlevel { get; set; }
        public int? maxlevel { get; set; }
        public string mindatetime { get; set; }
        public string maxdatetime { get; set; }
    }
}
