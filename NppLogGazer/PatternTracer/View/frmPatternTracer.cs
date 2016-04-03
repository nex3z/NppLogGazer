using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NppLogGazer
{
    public partial class frmPatternTracer : Form, IPatternTracerView
    {
        public event EventHandler<AddPatternEventArgs> AddPattern;
        public event EventHandler<RemovePatternAtEventArgs> RemovePatternAt;
        public event EventHandler<UpdatePatternAtEventArgs> UpdatePatternAt;
        public event EventHandler<SavePaternListEventArgs> SavePatternList;
        public event EventHandler<OpenPatternListEventArgs> OpenPatternList;
        public event EventHandler<OnClosingEventArgs> OnPluginClosing;
        public event EventHandler<OnSelectedPatternChangedEventArgs> OnSelectedPatternChanged;
        public event EventHandler ClearPatternInput;
        public event EventHandler<VisibleChangedEventArgs> PluginVisibleChanged;
        public event EventHandler<SwapPatternPositionEventArgs> SwapPatternPosition;

        public frmPatternTracer()
        {
            InitializeComponent();
        }

        public void Bind(BindingList<PatternModel> patternList)
        {
            lstPattern.DataSource = patternList;
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void SelectPatternAt(int position)
        {
            if (position >= 0 && position < lstPattern.Items.Count)
                lstPattern.SelectedIndex = position;
        }

        public void RenderPattern(PatternModel pattern)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string keyword in pattern.PatternText) 
                sb.AppendLine(keyword);

            txtPatternInput.Text = sb.ToString();

            toolBtnRegExp.Checked = pattern.Type == PatternType.RegExp ? true : false;
        }

        public void SetMatchWord(bool matchWord)
        {
            toolBtnMatchWord.Checked = matchWord;
        }

        public void SetMatchCase(bool matchCase)
        {
            toolBtnMatchCase.Checked = matchCase;
        }

        public void SetWrapSearch(bool wrapSearch)
        {
            toolBtnWrapSearch.Checked = wrapSearch;
        }

        public void SetPatternInput(string pattern)
        {
            txtPatternInput.Text = pattern;
        }

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
       
        }

        private void toolBtnAddPattern_Click(object sender, EventArgs e)
        {
            if (AddPattern != null)
            {
                AddPattern(null, new AddPatternEventArgs(GetPattern()));
            }
        }

        private List<string> GetPatternText()
        {
            List<string> patternText = new List<string>();
            foreach (string line in txtPatternInput.Lines)
            {
                patternText.Add(line);
            }
            return patternText;
        }

        private void toolBtnDeletePattern_Click(object sender, EventArgs e)
        {
            if (RemovePatternAt != null)
            {
                RemovePatternAt(null, new RemovePatternAtEventArgs(lstPattern.SelectedIndex));
            }
        }

        private void toolBtnSavePatternList_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDlg = new SaveFileDialog();
            saveFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDlg.ShowDialog() == DialogResult.OK && SavePatternList != null)
            {
                SavePatternList(null, new SavePaternListEventArgs(saveFileDlg.FileName));
            }

        }

        private void toolBtnOpenPatternList_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (openFileDlg.ShowDialog() == DialogResult.OK && OpenPatternList != null)
            {
                OpenPatternList(null, new OpenPatternListEventArgs(openFileDlg.FileName));
            }

        }

        private void frmPatternTracer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OnPluginClosing != null)
            {
                OnPluginClosing(null, new OnClosingEventArgs(toolBtnMatchWord.Checked, toolBtnMatchCase.Checked, toolBtnWrapSearch.Checked));
            }
        }

        private void lstPattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedPatternChanged != null)
            {
                OnSelectedPatternChanged(null, new OnSelectedPatternChangedEventArgs(lstPattern.SelectedIndex));
            }
        }

        private void toolBtnClearPatternInput_Click(object sender, EventArgs e)
        {
            if (ClearPatternInput != null)
            {
                ClearPatternInput(null, EventArgs.Empty);
            }
        }

        private void frmPatternTracer_VisibleChanged(object sender, EventArgs e)
        {
            if (PluginVisibleChanged != null)
            {
                PluginVisibleChanged(null, new VisibleChangedEventArgs(this.Visible));
            }
        }

        private void toolBtnMoveUp_Click(object sender, EventArgs e)
        {
            int selectedIdx = lstPattern.SelectedIndex;
            if (selectedIdx > 0 && SwapPatternPosition != null)
            {
                SwapPatternPosition(null, new SwapPatternPositionEventArgs(selectedIdx, selectedIdx - 1));
            }

        }

        private void toolBtnMoveDown_Click(object sender, EventArgs e)
        {
            int selectedIdx = lstPattern.SelectedIndex;
            if (selectedIdx >= 0 && selectedIdx <= lstPattern.Items.Count && SwapPatternPosition != null)
            {
                SwapPatternPosition(null, new SwapPatternPositionEventArgs(selectedIdx, selectedIdx + 1));
            }

        }

        private void toolBtnReplace_Click(object sender, EventArgs e)
        {
            if (UpdatePatternAt != null)
            {
                UpdatePatternAtEventArgs args = new UpdatePatternAtEventArgs(lstPattern.SelectedIndex, GetPattern());
                UpdatePatternAt(null, args);
            }
        }

        private PatternModel GetPattern()
        {
            List<string> patternText = GetPatternText();
            PatternType type = toolBtnRegExp.Checked == true ? PatternType.RegExp : PatternType.Normal;
            PatternModel pattern = new PatternModel(patternText, type);

            return pattern;
        }

    }
}
