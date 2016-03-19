using System;
using System.Collections.Generic;
using System.Text;
using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.View.Event;
using System.ComponentModel;

namespace NppLogGazer.QuickSearch
{
    public interface IQuickSearchView
    {
        event EventHandler<SearchEventArgs> PerformSearch;

        event EventHandler<AddKeywordEventArgs> AddKeyword;
        event EventHandler<RemoveKeywordAtEventArgs> RemoveKeywordAt;
        event EventHandler<SwapPositionEventArgs> SwapKeywordPosition;

        void Bind(BindingList<KeywordModel> keywordList);
        void ShowMessage(string message);
        void SelectKeywordAt(int position);
    }
}
