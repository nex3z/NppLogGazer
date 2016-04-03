using NppLogGazer.PatternExtractor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class UpdatePatternAtEventArgs : EventArgs
    {
        public int Position { get; set; }
        public PatternModel Pattern { get; set; }

        public UpdatePatternAtEventArgs(int position, PatternModel pattern)
        {
            this.Position = position;
            this.Pattern = pattern;
        }
    }
}
