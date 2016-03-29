using NppLogGazer.PatternExtractor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class AddPatternEventArgs : EventArgs
    {
        public PatternModel Pattern { get; set; }

        public AddPatternEventArgs()
        {
            Pattern = new PatternModel();
        }

        public AddPatternEventArgs(PatternModel pattern)
        {
            this.Pattern = pattern;
        }
    }
}
