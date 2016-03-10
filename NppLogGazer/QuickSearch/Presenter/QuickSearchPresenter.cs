using NppLogGazer.QuickSearch.View.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.QuickSearch.Presenter
{
    class QuickSearchPresenter
    {
        private IQuickSearchView view;

        public QuickSearchPresenter(IQuickSearchView view)
        {
            this.view = view;
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
