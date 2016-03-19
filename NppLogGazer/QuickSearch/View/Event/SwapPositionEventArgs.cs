using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class SwapPositionEventArgs : EventArgs
    {
        public int Src { get; set; }
        public int Dest { get; set; }

        public SwapPositionEventArgs(int src, int dest)
        {
            this.Src = src;
            this.Dest = dest;
        }
    }
}
