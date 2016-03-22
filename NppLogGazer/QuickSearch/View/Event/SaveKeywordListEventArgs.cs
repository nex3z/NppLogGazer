using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class SaveKeywordListEventArgs : EventArgs
    {
        public string Path { get; set; }

        public SaveKeywordListEventArgs(string path)
        {
            this.Path = path;
        }
    }
}
