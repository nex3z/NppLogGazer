using NppLogGazer.PatternTracer.Model;
using System.Collections.Generic;
namespace NppLogGazer.PatternTracer.View
{
    public interface IResultView
    {
        void ShowResult(List<ResultModel> resultList);
    }
}
