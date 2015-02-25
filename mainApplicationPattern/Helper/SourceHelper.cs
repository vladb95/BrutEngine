using mainApplicationPattern.DataConfig;
using xNet.Net;

namespace mainApplicationPattern.Helper
{
    class SourceHelper
    {
        #region ProxyHelper

        public static int _proxyIndex;

        public static ProxyClient GetProxy()
        {
            if (_proxyIndex >= Statistic.ProxyCount)
                _proxyIndex = 0;
            switch (Config.TypeOfProxy)
            {
                case 1:
                    return HttpProxyClient.Parse(Config.ProxyList[_proxyIndex++].ToString());
                case 2:
                    return Socks4ProxyClient.Parse(Config.ProxyList[_proxyIndex++].ToString());
                case 3:
                    return Socks5ProxyClient.Parse(Config.ProxyList[_proxyIndex++].ToString());
            }
            return HttpProxyClient.Parse("");
        }

        public static void DestroyLineInList(string line)
        {
            try
            {
                Config.ProxyList.Remove(line);
                if(Statistic.ProxyCount<=1)
                    Config.ProxyList.AddRange(Config.ProxyBufferList);
            }
            finally { }
        }

        #endregion

        #region SourceHelper

        public static int _sourceIndex;

        public static string GetSourceLine(bool normalize=false)
        {
            if (_sourceIndex >= Statistic.SourceCount)
            {
                Config.WorkFlag = false;
                return "";
            }
            if(normalize)
                return NormalLine(Config.SourceList[_sourceIndex++].ToString());
            return Config.SourceList[_sourceIndex++].ToString();
        }

        static string NormalLine(string line)
        {
            var array = line.Split(';', ':');
            if (array[0].Contains("@"))
            {
                var login = array[0].Split('@')[0];
                return login + ";" + array[1];
            }
            return line;
        }
        #endregion
    }
}
