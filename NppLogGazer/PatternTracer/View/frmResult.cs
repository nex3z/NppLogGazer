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
            txtResult.Text = result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }

        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                txtResult.SelectAll();
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
