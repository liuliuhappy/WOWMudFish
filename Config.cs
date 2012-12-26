using System;
using System.Collections.Generic;
using System.Text;

namespace MudFish
{
    /// <summary>
    /// 配置类
    /// </summary>
   public class Config
    {
       private int _IntervalTime;
        private int _WndSwitchTime;
        private int[] _WOWPids;

        public int IntervalTime
        {
            get { return _IntervalTime; }
            set { _IntervalTime = value; }
        }

        public int WndSwitchTime
        {
            get { return _WndSwitchTime; }
            set { _WndSwitchTime = value; }
        }
        public int[] WOWPids {
            get { return _WOWPids; }
            set { _WOWPids = value; }
        }
    }
}
