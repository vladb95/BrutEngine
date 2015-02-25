using System;
using System.Windows.Forms;
using mainApplicationPattern.DataConfig;

namespace mainApplicationPattern.Helper
{
    class UiHelper
    {
        private TextBox _box;
        private ProgressBar _bar;
        public int MaxValue { get { return Statistic.SourceCount; } }
        public UiHelper(TextBox box)
        {
            _box = box;
        }

        public UiHelper(ProgressBar bar)
        {
            _bar = bar;
        }

        #region TextBox
        delegate void AddListItem(String str);
        AddListItem myDelegate;
        void AddListItemMethod(String str)
        {
            _box.Text += str + "\r\n";
            _box.SelectionStart = _box.Text.Length;
            _box.ScrollToCaret();
        }

        public void AddTextToElement(string textToAdd)
        {
            myDelegate = AddListItemMethod;
            _box.Invoke(myDelegate, new object[] { textToAdd });
        }
        #endregion

        #region ProgressBar

        delegate void ProgressBarDelegate(int val);
        ProgressBarDelegate  myPb;

        void PbDel(int val)
        {
            _bar.Value = val*100/MaxValue;
        }

        public void InvokePb(int values)
        {
            object val = values;
            myPb = PbDel;
            _bar.Invoke(myPb,val);
        }
        #endregion
    }
}
