using NppLogGazer.PatternTracer.Model;
using NppLogGazer.PatternTracer.View.Event;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NppLogGazer.PatternTracer.View
{
    public partial class FrmResult : Form, IResultView
    {
        public event EventHandler<ResultFilterChangedEventArgs> ResultFilterChanged;

        public FrmResult()
        {
            InitializeComponent();
        }

        public void ShowResult(string result)
        {
            rtxtResult.Text = result;
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (rtxtResult.Text != "")
                Clipboard.SetText(rtxtResult.Text);
        }

        private void chkCompleteMatch_CheckedChanged(object sender, EventArgs e)
        {
            if (ResultFilterChanged != null)
            {
                ResultFilterChangedEventArgs args = new ResultFilterChangedEventArgs(chkCompleteMatch.Checked);
                ResultFilterChanged(null, args);
            }
        }
    }
}
