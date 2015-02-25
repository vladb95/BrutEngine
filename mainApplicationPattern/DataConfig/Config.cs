using System.Collections;
using mainApplicationPattern.Helper;

namespace mainApplicationPattern.DataConfig
{
    class Config
    {
// ReSharper disable InconsistentNaming
        private static readonly object _Locker = new object();
// ReSharper restore InconsistentNaming
        public static ArrayList SourceList = new ArrayList();
        public static ArrayList ProxyList = new ArrayList();
        public static ArrayList ProxyBufferList = new ArrayList();
        public static bool WorkFlag { get; set; }
        public static int ThreadsCount { get; set; }
        public static object Locker { get { return _Locker; } }
        public static int TypeOfProxy { get; set; }

        public static UiHelper InterFaceHelper;
        public static UiHelper ProBarHelper;
        public static bool NormalizateBase { get; set; }
    }
}
