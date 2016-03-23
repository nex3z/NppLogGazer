using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class OnSelectedKeywordChangedEventArgs : EventArgs
    {
        public int SelectedIndex { get; set; }

        public OnSelectedKeywordChangedEventArgs(int selectedIndex)
        {
            this.SelectedIndex = selectedIndex;
        }
    }
}
