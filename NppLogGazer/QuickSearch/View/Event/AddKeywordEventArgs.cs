using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class AddKeywordEventArgs : EventArgs
    {
        public KeywordModel Keyword { get; set; }

        public AddKeywordEventArgs()
        {
            Keyword = new KeywordModel();
        }
    }
}
