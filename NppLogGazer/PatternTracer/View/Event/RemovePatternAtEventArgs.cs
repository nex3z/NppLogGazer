using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class RemovePatternAtEventArgs : EventArgs
    {
        public int Position { get; set; }

        public RemovePatternAtEventArgs(int position)
        {
            this.Position = position;
        }
    }
}
