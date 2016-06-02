using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.ComponentModel;

namespace GameToolsHttpService
{
    public class Global : System.Web.HttpApplication
    {
        private System.Threading.Thread checkUserSessionTh;
        private System.Threading.Thread pushBaiduNotice;
        protected void Application_Start(object sender, EventArgs e)
        {
            checkUserSessionTh = new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(checkUserSessionTh_DoWork));
            checkUserSessionTh.Start(null);

            pushBaiduNotice = new System.Threading.Thread(BaiduPushNotice.PushBaiduNotice);
            pushBaiduNotice.IsBackground = true;
            BaiduPushNotice.reloadInfo();
            pushBaiduNotice.Start();
        }

        void checkUserSessionTh_DoWork(object obj)
        {
            while (true)
            {
                UserSession.CheckAllUserSession();
                System.Threading.Thread.Sleep(3000);
            }
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            if (checkUserSessionTh != null)
            {
                checkUserSessionTh.Abort();
            }

            if (pushBaiduNotice != null)
            {
                pushBaiduNotice.Abort();
            }
        }
    }
}