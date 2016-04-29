using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.View.Event;
using System;
using System.ComponentModel;
using System.Drawing;

namespace NppLogGazer.QuickSearch
{
    public interface IQuickSearchView
    {
        event EventHandler<AddKeywordEventArgs> AddKeyword;
        event EventHandler<RemoveKeywordAtEventArgs> RemoveKeywordAt;
        event EventHandler<SwapPositionEventArgs> SwapKeywordPosition;
        event EventHandler RemoveDuplicates;
        event EventHandler<SaveKeywordListEventArgs> SaveKeywordList;
        event EventHandler<OpenKeywordListEventArgs> OpenKeywordList;
        event EventHandler<OnSelectedKeywordChangedEventArgs> OnSelectedKeywordChanged;
        event EventHandler<OnClosingEventArgs> OnPluginClosing;
        event EventHandler<OnKeywordSelectedEventArgs> OnKeywordSelected;
        event EventHandler<VisibleChangedEventArgs> PluginVisibleChanged;
        event EventHandler<UpdateKeywordAtEventArgs> UpdateKeywordAt;
        event EventHandler<LaunchNppSearchDialogEventArgs> LaunchNppSearchDialog;

        void Bind(BindingList<KeywordModel> keywordList);
        void ShowMessage(string message);
        void SelectKeywordAt(int position);
        bool RequireConfirm(string title, string message);
        void RenderKeyword(KeywordModel keyword);
        void ShowStatusMessage(string message, Color color);
        void SetMatchWord(bool matchWord);
        void SetMatchCase(bool matchCase);
        void SetWrapSearch(bool wrapSearch);
    }
}
