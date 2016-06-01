using System;
using System.Collections.Generic;
using System.Web;

namespace GameToolsHttpService
{
    public class TimeOut
    {
        private readonly int timeOutInterval = 1000;

        public long lastTicks;

        public long elapsedTicks;

        public TimeOut()
        {
            lastTicks = DateTime.Now.Ticks;
        }

        public bool IsTimeOut()
        {
            elapsedTicks = DateTime.Now.Ticks - lastTicks;

            TimeSpan span = new TimeSpan(elapsedTicks);

            double diff = span.TotalSeconds;

            if (diff > timeOutInterval)
                return true;
            else
                return false;
        }
    }
}