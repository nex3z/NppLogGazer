using NppLogGazer.PatternExtractor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class SearchPatternEventArgs : EventArgs
    {
        public PatternModel Pattern { get; set; }
        public bool MatchWord { get; set; }
        public bool MatchCase { get; set; }
        public bool WrapSearch { get; set; }

        public SearchPatternEventArgs(PatternModel pattern, bool matchWord, bool matchCase, bool wrapSearch)
        {
            this.Pattern = pattern;
            this.MatchWord = matchWord;
            this.MatchCase = matchCase;
            this.WrapSearch = wrapSearch;
        }
    }
}
