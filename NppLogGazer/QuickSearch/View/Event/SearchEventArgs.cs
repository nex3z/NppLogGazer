using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class SearchEventArgs : EventArgs
    {
        public KeywordModel Keyword { get; set; }

        public bool MatchWord { get; set; }
        public bool MatchCase { get; set; }
        public bool WrapSearch { get; set; }
    }
}
