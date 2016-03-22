using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.Repository;
using NppLogGazer.QuickSearch.View.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace NppLogGazer.QuickSearch.Presenter
{
    class QuickSearchPresenter
    {
        private IQuickSearchView view;
        private IKeywordRepository repository;

        public QuickSearchPresenter(IQuickSearchView view, IKeywordRepository repository)
        {
            this.view = view;
            this.repository = repository;

            view.Bind(repository.KeywordList);
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            view.PerformSearch += performSearch;
            view.AddKeyword += AddKeyword;
            view.RemoveKeywordAt += RemoveKeywordAt;
            view.SwapKeywordPosition += SwapKeywordAt;
            view.RemoveDuplicates += RemoveDuplicates;
            view.SaveKeywordList += SaveKeywordList;
            view.OpenKeywordList += OpenKeywordList;
        }

        private void AddKeyword(Object sender, AddKeywordEventArgs args)
        {
            if (args.Keyword != null && args.Keyword.KeywordText != "")
                repository.Add(args.Keyword);
        }

        private void RemoveKeywordAt(Object sender, RemoveKeywordAtEventArgs args)
        {
            repository.RemoveItemAt(args.Position);
        }

        private void SwapKeywordAt(Object sender, SwapPositionEventArgs args)
        {
            repository.SwapItemAt(args.Src, args.Dest);
            view.SelectKeywordAt(args.Dest);
        }

        private void RemoveDuplicates(Object sender, EventArgs args)
        {
            if (view.RequireConfirm(Properties.Resources.remove_dup_dlg_title, 
                                    Properties.Resources.remove_dup_dlg_message))
            {
                repository.RemoveDuplicated();
                view.Bind(repository.KeywordList);
            }
        }

        private void SaveKeywordList(Object sender, SaveKeywordListEventArgs args)
        {
            repository.Save(args.Path);
        }

        private void OpenKeywordList(Object sender, OpenKeywordListEventArgs args)
        {
            repository.Load(args.Path);
            view.Bind(repository.KeywordList);
        }

        private void performSearch(Object sender, SearchEventArgs args)
        {
        }
    }
}
