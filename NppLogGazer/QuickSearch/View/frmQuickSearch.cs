using NppLogGazer.QuickSearch;
using NppLogGazer.QuickSearch.Presenter;
using NppLogGazer.QuickSearch.View.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NppLogGazer
{
    public partial class frmQuickSearch : Form, IQuickSearchView
    {
        public event EventHandler<SearchEventArgs> PerformSearch;
        private QuickSearchPresenter presenter;

        public frmQuickSearch()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message) {
            MessageBox.Show(message);
        }

        private void lstKeywords_MouseDown(object sender, MouseEventArgs e)
        {
            int index = lstKeywords.IndexFromPoint(e.X, e.Y);
            if (PerformSearch != null)
            {
                PerformSearch(null, new SearchEventArgs());
            }
        }

    }
}
