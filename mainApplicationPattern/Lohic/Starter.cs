using mainApplicationPattern.DataConfig;
using mainApplicationPattern.Helper;
using xNet.Net;

namespace mainApplicationPattern.Lohic
{
    class Starter
    {
        private void StartBrute()
        {
            try
            {
                
                var accountSpliter = SourceHelper.GetSourceLine(Config.NormalizateBase).Split(';', ':');
                Checker(accountSpliter[0], accountSpliter[1]);
                lock (Config.Locker)
                {
                    Statistic.PPS++;
                    Config.ProBarHelper.InvokePb(++Statistic.StepCount);
                }
                
            }
            catch
            {
                lock (Config.Locker)
                    Statistic.ErrorsCount++;
            }
            if (Config.WorkFlag)
                StartBrute();
        }

        private void Checker(string login, string pass)
        {
            var proxy = "";
            try
            {
                using (var request = new HttpRequest())
                {
                    request.UserAgent = HttpHelper.RandomUserAgent();
                    request.Cookies = new CookieDictionary();
                    if (Config.TypeOfProxy != 0)
                    {
                        request.Proxy = SourceHelper.GetProxy();
                        proxy = request.Proxy.Host + ":" + request.Proxy.Port;
                    }
                    var response = request.Post("", "").ToString();
                    if (response.Contains(""))
                    {
                        lock (Config.Locker)
                        {
                            Statistic.GoodCount++;
                            IoHelper.WriteLine(login + ";" + pass, "good.txt");
                            Config.InterFaceHelper.AddTextToElement(login + ";" + pass);
                        }
                    }
                    else
                    {
                        lock (Config.Locker)
                            Statistic.BadCount++;

                    }
                }
            }
            catch
            {
                lock (Config.Locker)
                    Statistic.ErrorsCount++;
                SourceHelper.DestroyLineInList(proxy);
                Checker(login, pass);
            }
        }
        public void Start()
        {
            StartBrute();
        }
    }
}
