using NppLogGazer.Common.Repository;
using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.Presenter;
using NppLogGazer.QuickSearch.Repository;
using System;
using System.IO;
using System.Windows.Forms;

namespace NppLogGazer.QuickSearch
{
    class QuickSearchPanel
    {
        private static QuickSearchPanel instance = null;

        private IQuickSearchView view;
        private QuickSearchPresenter presenter;
        private IRepository<KeywordModel> repository;

        private QuickSearchPanel()
        {
            view = new FrmQuickSearch();
            repository = new KeywordRepository(new FileInfo(Main.GetDefaultKeywordListPath()));
            presenter = new QuickSearchPresenter(view, repository);
        }

        public static QuickSearchPanel Instance
        {
            get 
            { 
                return instance ?? (instance = new QuickSearchPanel());
            }
        }

        public Form Form
        {
            get
            {
                if (view is Form)
                    return view as Form;
                else
                    throw new InvalidCastException("View must also implement Form.");
            }
        }

    }
}
