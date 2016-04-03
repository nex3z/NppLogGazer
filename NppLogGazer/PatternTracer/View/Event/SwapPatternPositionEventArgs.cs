using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class SwapPatternPositionEventArgs : EventArgs
    {
        public int Src { get; set; }
        public int Dest { get; set; }

        public SwapPatternPositionEventArgs(int src, int dest)
        {
            this.Src = src;
            this.Dest = dest;
        }
    }
}
