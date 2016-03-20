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
        public event EventHandler<SwapPositionEventArgs> SwapKeywordPosition;
        public event EventHandler RemoveDuplicates;

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

        public bool RequireConfirm(string title, string message)
        {
            DialogResult MsgBoxResult = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);

            if (MsgBoxResult == DialogResult.Yes)
                return true;
            else
                return false;

        }

        public void SelectKeywordAt(int position)
        {
            if (position >= 0 && position < lstKeywords.Items.Count)
                lstKeywords.SelectedIndex = position;
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

        private void toolBtnMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIdx = lstKeywords.SelectedIndex;
            if (selectedIdx > 0 && SwapKeywordPosition != null)
            {
                SwapKeywordPosition(null, new SwapPositionEventArgs(selectedIdx, selectedIdx - 1));
            }
        }

        private void toolBtnMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIdx = lstKeywords.SelectedIndex;
            if (selectedIdx >= 0 && selectedIdx <= lstKeywords.Items.Count && SwapKeywordPosition != null)
            {
                SwapKeywordPosition(null, new SwapPositionEventArgs(selectedIdx, selectedIdx + 1));
            }
        }

        private void toolBtnRemoveDuplicate_Click(object sender, EventArgs e)
        {
            if (RemoveDuplicates != null)
            {
                RemoveDuplicates(null, EventArgs.Empty);
            }
        }

    }
}
