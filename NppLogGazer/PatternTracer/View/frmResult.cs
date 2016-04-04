using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NppLogGazer.PatternTracer.View
{
    public partial class frmResult : Form, IResultView
    {
        public frmResult()
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
    }
}
