using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class OnSelectedPatternChangedEventArgs : EventArgs
    {
        public int SelectedIndex { get; set; }

        public OnSelectedPatternChangedEventArgs(int selectedIndex)
        {
            this.SelectedIndex = selectedIndex;
        }
    }
}
