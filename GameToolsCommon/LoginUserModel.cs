using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsCommon
{
    public class LoginUserModel
    {
        public int UserID { set; get; }
        public string UserName { set; get; }
        public DateTime LoginTime { set; get; }
        public string UserKey { set; get; }
        public uint Authority { set; get; }
    }
}
