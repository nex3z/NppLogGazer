using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class LaunchNppSearchDialogEventArgs : EventArgs
    {
        public KeywordModel Keyword { get; set; }

        public LaunchNppSearchDialogEventArgs(KeywordModel keyword)
        {
            this.Keyword = keyword;
        }
    }
}
