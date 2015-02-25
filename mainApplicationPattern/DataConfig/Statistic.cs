using System;
using mainApplicationPattern.Helper;


namespace mainApplicationPattern.DataConfig
{
    class Statistic
    {
        public static int SourceCount { get { return Config.SourceList.Count; } }
        public static int ProxyCount { get { return Config.ProxyList.Count; } }

        public static int GoodCount { get; set; }
        public static int BadCount { get; set; }
        public static int ErrorsCount { get; set; }
        public static int PPS { get; set; }
        public static int StepCount { get; set; }

        public static void Dispose()
        {
            GoodCount = 0;
            BadCount = 0;
            ErrorsCount = 0;
            StepCount = 0;
            SourceHelper._sourceIndex = 0;
            SourceHelper._proxyIndex = 0;
        }
    }
}
