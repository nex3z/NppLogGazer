using NppLogGazer.QuickSearch;
using NppLogGazer.QuickSearch.Model;
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

        public event EventHandler<AddKeywordEventArgs> AddKeyword;
        public event EventHandler<RemoveKeywordAtEventArgs> RemoveKeywordAt;

        public frmQuickSearch()
        {
            InitializeComponent();
        }

        public void Bind(BindingList<KeywordModel> keywordList)
        {
            lstKeywords.DataSource = keywordList;
        }

        public void ShowMessage(string message) 
        {
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

        private void toolBtnAdd_Click(object sender, EventArgs e)
        {
            if (AddKeyword != null)
            {
                AddKeywordEventArgs args = new AddKeywordEventArgs();
                args.Keyword.KeywordText = txtKeyword.Text;
                args.Keyword.Type = chkRegExp.Checked ? KeywordType.RegExp : KeywordType.Normal;
                AddKeyword(null, args);
            }
        }

        private void toolBtnRemove_Click(object sender, EventArgs e)
        {
            if (RemoveKeywordAt != null)
            {
                RemoveKeywordAtEventArgs args = new RemoveKeywordAtEventArgs();
                args.Position = lstKeywords.SelectedIndex;
                RemoveKeywordAt(null, args);
            }
        }

    }
}
