using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
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
        public event EventHandler<SavePaternListEventArgs> SavePatternList;
        public event EventHandler<OpenPatternListEventArgs> OpenPatternList;

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

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
       
        }

        private void toolBtnAddPattern_Click(object sender, EventArgs e)
        {
            if (AddPattern != null)
            {
                List<string> patternText = GetPatternText();
                PatternType type = toolBtnRegExp.Checked == true ? PatternType.RegExp : PatternType.Normal;
                PatternModel pattern = new PatternModel(patternText, type);

                AddPattern(null, new AddPatternEventArgs(pattern));
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
    }
}
