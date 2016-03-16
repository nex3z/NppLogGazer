using System;
using System.Collections.Generic;
using System.Text;
using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.View.Event;

namespace NppLogGazer.QuickSearch
{
    public interface IQuickSearchView
    {
        event EventHandler<SearchEventArgs> PerformSearch;

        event EventHandler<AddKeywordEventArgs> AddKeyword;
        event EventHandler<RemoveKeywordAtEventArgs> RemoveKeywordAt;

        void ShowMessage(string message);
    }
}
