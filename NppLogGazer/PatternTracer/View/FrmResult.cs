using NppLogGazer.PatternTracer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NppLogGazer.PatternTracer.View
{
    public partial class FrmResult : Form, IResultView
    {

        private List<ResultModel> result;

        public FrmResult()
        {
            InitializeComponent();
        }

        public void ShowResult(List<ResultModel> resultList)
        {
            this.result = resultList;
            this.Show();
            rtxtResult.Text = FormatResult(resultList, 0);
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
            if (chkCompleteMatch.Checked)
            {
                rtxtResult.Text = FormatResult(this.result, this.result[0].KeywordCount);
            }
            else
            {
                rtxtResult.Text = FormatResult(this.result, 0);
            }
        }

        private string FormatResult(List<ResultModel> resultList, int matchCountThreshold)
        {
            if (resultList.Count == 0)
            {
                return Properties.Resources.pattern_tracer_status_not_found;
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultList.Count; i++)
            {
                if (resultList[i].MatchCount < matchCountThreshold)
                {
                    continue;
                }

                // sb.AppendLine("KeywordCount = " + resultList[i].KeywordCount + ", MatchCount = " + resultList[i].MatchCount);
                foreach (LineInfoModel entry in resultList[i].Result)
                {
                    sb.AppendLine("Line " + entry.LineNumber + ": " + entry.LineText);
                }
                if (i != (resultList.Count - 1)) sb.AppendLine();
            }
            return sb.ToString();
        }

    }
}
