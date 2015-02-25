using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using mainApplicationPattern.DataConfig;
using mainApplicationPattern.Helper;
using mainApplicationPattern.Lohic;

namespace mainApplicationPattern.UI.Forms
{
    public partial class MainForm : Form
    {
        private Threads _threads;
        private int _i = 0;
        private DataBaseConnector _dbConnector;
        public MainForm()
        {
            InitializeComponent();
            Config.InterFaceHelper = new UiHelper(goodTBox);
            Config.ProBarHelper=new UiHelper(statusPBar);
            //_dbConnector = new DataBaseConnector
            //{
            //    Server = "sql-4.radyx.ru",
            //    UserID = "zsoft622",
            //    Password = "sx6szsd0uf",
            //    Database = "zsoft622"
            //};
            if (File.Exists("proxy.txt"))
            {
                Config.ProxyList.AddRange(File.ReadAllLines("proxy.txt"));
                proxyLbl.Text = Statistic.ProxyCount.ToString(CultureInfo.InvariantCulture);
            }
            //_dbConnector.InsertCommand("INSERT INTO myProgrammTable" +
            //        "VALUES (1,'Brute','111.25.123.44','ddssd44444','True')");
            //MessageBox.Show(_dbConnector.SelectCommand("select * from myProgrammTable").ToString());
        }

        private void GUI_Tick(object sender, EventArgs e)
        {
            goodLbl.Text = Statistic.GoodCount.ToString(CultureInfo.InvariantCulture);
            badLbl.Text = Statistic.BadCount.ToString(CultureInfo.InvariantCulture);
            errLbl.Text=Statistic.ErrorsCount.ToString(CultureInfo.InvariantCulture);
            goodProxyLbl.Text = Statistic.ProxyCount.ToString(CultureInfo.InvariantCulture);
            actThreadsLbl.Text = _threads.Alive().ToString(CultureInfo.InvariantCulture);
        }

        private void PPS_Tick(object sender, EventArgs e)
        {
            ppsLbl.Text = Statistic.PPS.ToString(CultureInfo.InvariantCulture);
            Statistic.PPS = 0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Statistic.Dispose();
            Config.ThreadsCount = (int) threadsNUD.Value;
            Config.TypeOfProxy = typeOfProxyCBOX.SelectedIndex;
            Config.ProxyBufferList.AddRange(Config.ProxyList);
            Config.WorkFlag = true;
            GUI.Enabled = true;
            PPS.Enabled = true;
            _threads = new Threads();
            var starterObject = new Starter();
            _threads.Run(starterObject.Start);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            PPS.Enabled = false;
            Config.WorkFlag = false;
            _threads.Abort();
        }

        private void sourceBtn_Click(object sender, EventArgs e)
        {
            IoHelper.OpenFileDialog(ref Config.SourceList);
            sourceLbl.Text=Statistic.SourceCount.ToString(CultureInfo.InvariantCulture);
        }

        private void proxyBtn_Click(object sender, EventArgs e)
        {
            Config.ProxyBufferList.Clear();
            IoHelper.OpenFileDialog(ref Config.ProxyList);
            proxyLbl.Text=Statistic.ProxyCount.ToString(CultureInfo.InvariantCulture);
            IoHelper.WriteBlock(Config.ProxyList,"proxy.txt");
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Config.NormalizateBase = checkBox1.Checked;
        }

        private void resetProxyBtn_Click(object sender, EventArgs e)
        {
            lock (Config.Locker)
            {
                Config.ProxyList.Clear();
                Config.ProxyList.AddRange(Config.ProxyBufferList);
            }
        }
    }
}
