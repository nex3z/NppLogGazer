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
        }
    }
}
