using System.Collections;
using System.IO;
using System.Windows.Forms;
using mainApplicationPattern.DataConfig;

namespace mainApplicationPattern.Helper
{
    class IoHelper
    {
        public static void WriteLine(string lineToWrite, string nameOfFile)
        {
            try
            {
                if (!LineExist(lineToWrite, nameOfFile))
                {
                    using (var stream = new StreamWriter(nameOfFile, true))
                    {
                        stream.WriteLine(lineToWrite);
                        stream.Close();
                    }
                }
            }
            catch
            {
                lock (Config.Locker)
                    Statistic.ErrorsCount++;
            }
        }

        public static void WriteBlock(ArrayList block, string nameOfFile)
        {
            try
            {
                using (var stream = new StreamWriter(nameOfFile))
                {
                    foreach (var s in block)
                    {
                        stream.WriteLine(s);
                    }
                }
            }
            catch { }
        }

        static bool LineExist(string line, string nameOfFile)
        {
            try
            {
                var list = new ArrayList();
                list.AddRange(File.ReadAllLines(nameOfFile));
                return list.Contains(line);
            }
            catch
            {
                return false;
            }
        }

        public static void OpenFileDialog(ref ArrayList paramList, string title = "Open file....")
        {
            try
            {
                using (var openFile = new OpenFileDialog())
                {
                    openFile.Title = title;
                    openFile.Filter = "*.txt|*.txt";
                    openFile.ShowDialog();
                    if (openFile.FileName != "")
                    {
                        paramList.Clear();
                        paramList.AddRange(File.ReadAllLines(openFile.FileName));
                    }
                }
            }
            catch
            {
                lock (Config.Locker)
                    Statistic.ErrorsCount++;
            }
        }
    }
}
