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
        public event EventHandler<SaveKeywordListEventArgs> SaveKeywordList;
        public event EventHandler<OpenKeywordListEventArgs> OpenKeywordList;
        public event EventHandler<OnSelectedKeywordChangedEventArgs> OnSelectedKeywordChanged;

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

        public void RenderKeyword(KeywordModel keyword)
        {
            txtKeyword.Text = keyword.KeywordText;
            chkRegExp.Checked = keyword.Type == KeywordType.RegExp;
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

        private void toolBtnSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDlg.ShowDialog() == DialogResult.OK && SaveKeywordList != null)
            {
                SaveKeywordList(null, new SaveKeywordListEventArgs(saveFileDlg.FileName));
            }
        }

        private void toolBtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (openFileDlg.ShowDialog() == DialogResult.OK && OpenKeywordList != null)
            {
                OpenKeywordList(null, new OpenKeywordListEventArgs(openFileDlg.FileName));
            }
        }

        private void lstKeywords_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedKeywordChanged != null)
            {
                OnSelectedKeywordChanged(null, new OnSelectedKeywordChangedEventArgs(lstKeywords.SelectedIndex));
            }
        }

        private void lstKeywords_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            e.DrawBackground();
            Graphics g = e.Graphics;

            // Hightlight selected item.
            g.FillRectangle(new SolidBrush(Color.White), e.Bounds);
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), e.Bounds);

            // Change font color according to KeywordsType.
            ListBox lb = (ListBox)sender;
            KeywordModel keyword = (KeywordModel)lb.Items[e.Index];
            if (keyword.Type == KeywordType.Normal)
                g.DrawString(keyword.ToString(), e.Font, new SolidBrush(Color.Black), new PointF(e.Bounds.X, e.Bounds.Y));
            else
                g.DrawString(keyword.ToString(), e.Font, new SolidBrush(Color.Blue), new PointF(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

    }
}
