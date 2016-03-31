using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View
{
    public class OnClosingEventArgs : EventArgs
    {
        public bool MatchWordStatus { get; set; }
        public bool MatchCaseStatus { get; set; }
        public bool WrapSearchStatus { get; set; }

        public OnClosingEventArgs(bool matchWordStatus, bool matchCaseStatus, bool wrapSearchStatus)
        {
            this.MatchWordStatus = matchWordStatus;
            this.MatchCaseStatus = matchCaseStatus;
            this.WrapSearchStatus = wrapSearchStatus;
        }
    }
}
