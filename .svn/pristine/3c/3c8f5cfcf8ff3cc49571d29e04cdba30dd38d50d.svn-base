using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengNiao.GMTools.Database.Model
{
    public class ChatMessage
    {
        private string time;
        public string Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }


        private string kind;
        public string Kind
        {
            get
            {
                return kind;
            }

            set
            {
                kind = value;
            }
        }


        private string playerName;
        public string PlayerName
        {
            get
            {
                return playerName;
            }

            set
            {
                playerName = value;
            }
        }


        private string message;
        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        
        private string server_id;

        public string Server_id
        {
            get
            {
                return server_id;
            }

            set
            {
                server_id = value;
            }
        }


        public ChatMessage(string strMessage)
        {
            string str = strMessage.Replace('[',',');
            str = str.Replace(']', ',');

            if (string.IsNullOrEmpty(strMessage)) return;
            string[] strArr = str.Split(',');


            time = strArr[0];
            kind = strArr[1];
            playerName = strArr[2];
            server_id = strArr[3].Substring(0, strArr[3].IndexOf('-'));
            message = strMessage.Substring(strMessage.LastIndexOf(':')+1);
        }
    }
}
