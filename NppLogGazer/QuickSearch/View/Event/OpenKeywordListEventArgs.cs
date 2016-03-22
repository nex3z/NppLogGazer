using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class OpenKeywordListEventArgs : EventArgs
    {
        public string Path { get; set; }

        public OpenKeywordListEventArgs(string path)
        {
            this.Path = path;
        }
    }
}
