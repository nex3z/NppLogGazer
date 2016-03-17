using NppLogGazer.QuickSearch.Repository;
using NppLogGazer.QuickSearch.View.Event;
using System;
using System.Collections.Generic;
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
            wireUpEvents();
        }

        private void wireUpEvents()
        {
            view.PerformSearch += performSearch;
            view.AddKeyword += addKeyword;
            view.RemoveKeywordAt += removeKeywordAt;
        }

        private void addKeyword(Object sender, AddKeywordEventArgs args)
        {
            repository.Add(args.Keyword);
        }

        private void removeKeywordAt(Object sender, RemoveKeywordAtEventArgs args)
        {
        }

        private void performSearch(Object sender, SearchEventArgs args)
        {
        }
    }
}
