using NppLogGazer.PatternExtractor.Model;
using System.Collections.Generic;

namespace NppLogGazer.PatternTracer.Repository
{
    interface IPatternRepository
    {
        List<PatternModel> GetAll();
        void ReplaceAll(List<PatternModel> patterns);
    }
}
