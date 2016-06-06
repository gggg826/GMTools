using System;
using System.Collections.Generic;
using System.Web;
using System.Configuration;

namespace GameToolsHttpService
{
    public class UserSession
    {
        public string SessionID { set; get; }
        public string UserKey { set; get; }
        public DateTime LastOperationTime { set; get; }

        static UserSession()
        {
            SessionList = new Dictionary<string, UserSession>();
            SessionTimeout = int.Parse(ConfigurationManager.AppSettings["SessionTimeOut"]);
        }
        private static Dictionary<string, UserSession> SessionList;
        //一小时过期了
        public static int SessionTimeout = 3600;

        public static void AddUserSession(string sessionID, string userKey)
        {
            lock (SessionList)
            {
                UserSession userSession = new UserSession();
                userSession.SessionID = sessionID;
                userSession.UserKey = userKey;
                userSession.LastOperationTime = DateTime.Now;
                if (!SessionList.ContainsKey(sessionID))
                {
                    SessionList.Add(sessionID, userSession);
                }
                SessionList[sessionID] = userSession;
            }
        }

        public static bool CheckUserSession(string sessionID, string userKey)
        {
            if (string.IsNullOrEmpty(sessionID) || string.IsNullOrEmpty(userKey))
            {
                return false;
            }
            lock (SessionList)
            {
                if (SessionList.ContainsKey(sessionID))
                {
                    UserSession userSession = SessionList[sessionID];
                    if (userSession.UserKey.Equals(userKey))
                    {
                        TimeSpan ts = DateTime.Now - SessionList[sessionID].LastOperationTime;
                        if (ts.Seconds < SessionTimeout)
                        {
                            userSession.LastOperationTime = DateTime.Now;
                            return true;
                        }
                        else
                        {
                            SessionList.Remove(sessionID);
                            return false;
                        }
                    }
                }
                return false;
            }
        }

        public static void DeleteSession(string sessionID)
        {
            if (string.IsNullOrEmpty(sessionID))
            {
                return;
            }
            lock (SessionList)
            {
                SessionList.Remove(sessionID);
            }
        }

        public static void CheckAllUserSession()
        {
        next:
            lock (SessionList)
            {
                foreach (string sessionID in SessionList.Keys)
                {
                    UserSession userSession = SessionList[sessionID];
                    TimeSpan ts = DateTime.Now - SessionList[sessionID].LastOperationTime;
                    if (ts.Seconds > SessionTimeout)
                    {
                        SessionList.Remove(sessionID);
                        goto next;
                    }
                }
            }
        }
    }
}