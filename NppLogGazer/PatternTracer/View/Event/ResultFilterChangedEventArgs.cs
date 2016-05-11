using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class ResultFilterChangedEventArgs : EventArgs
    {
        public int MatchCountThreshold { get; set; }
        public bool CompleteMatch { get; set; }

        public ResultFilterChangedEventArgs(int matchCountThreshold)
        {
            this.MatchCountThreshold = matchCountThreshold;
        }

        public ResultFilterChangedEventArgs(bool completeMatch)
        {
            this.CompleteMatch = completeMatch;
        }
    }
}
