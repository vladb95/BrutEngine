using System;
using System.Windows.Forms;
using mainApplicationPattern.UI.Forms;

namespace mainApplicationPattern
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(UI.UserInterFace.MainForm=new MainForm());
        }
    }
}
