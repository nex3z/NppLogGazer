using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class UpdateKeywordAtEventArgs : EventArgs
    {
        public int Position { get; set; }
        public KeywordModel Keyword { get; set; }

        public UpdateKeywordAtEventArgs(int position, KeywordModel keyword)
        {
            this.Position = position;
            this.Keyword = keyword;
        }
    }
}
