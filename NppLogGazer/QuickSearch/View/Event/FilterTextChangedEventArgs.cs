using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class FilterTextChangedEventArgs : EventArgs
    {
        public string FilterText { get; set; }

        public FilterTextChangedEventArgs(string fitlerText)
        {
            this.FilterText = fitlerText;
        }
    }
}
