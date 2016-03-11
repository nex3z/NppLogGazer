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
            wireUpEvents();
        }

        private void wireUpEvents()
        {
            view.PerformSearch += performSearch;
        }

        private void performSearch(Object sender, SearchEventArgs args)
        {
            view.ShowMessage("Delivered!");
        }
    }
}
