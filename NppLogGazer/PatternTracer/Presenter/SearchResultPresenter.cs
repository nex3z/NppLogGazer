using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.Model;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.PatternTracer.Presenter
{
    class SearchResultPresenter
    {
        private IResultView view;
        private List<ResultModel> result;
        private PatternModel pattern;

        public SearchResultPresenter(IResultView resultView)
        {
            this.view = resultView;
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            view.ResultFilterChanged += ResultFilterChanged;
        }

        private void ResultFilterChanged(Object sender, ResultFilterChangedEventArgs args)
        {
            if (pattern != null && result != null)
            {
                string resultText = FormatResult(result, args.CompleteMatch ? pattern.PatternText.Count : 0);
                view.ShowResult(resultText);
            }
        }

        public void RenderResult(List<ResultModel> resultList, PatternModel pattern)
        {
            result = resultList;
            this.pattern = pattern;
            string resultText = FormatResult(resultList, pattern.PatternText.Count);
            view.ShowResult(resultText);
        }

        private string FormatResult(List<ResultModel> resultList, int matchCountThreshold)
        {
            if (resultList == null || resultList.Count == 0)
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
