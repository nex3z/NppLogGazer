using System;
using System.Windows.Forms;

namespace NppLogGazer.PatternTracer.View
{
    public partial class FrmResult : Form, IResultView
    {
        public FrmResult()
        {
            InitializeComponent();
        }

        public void ShowResult(string result)
        {
            this.Show();
            rtxtResult.Text = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtResult.Text);
        }

    }
}
