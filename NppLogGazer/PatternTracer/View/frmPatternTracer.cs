using NppLogGazer.PatternTracer.View;
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
        public frmPatternTracer()
        {
            InitializeComponent();
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        private void toolStripBtnSearch_Click(object sender, EventArgs e)
        {
       
        }
    }
}
