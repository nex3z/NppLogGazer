using NppLogGazer.PatternExtractor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.Repository
{
    interface IPatternRepository
    {
        List<PatternModel> GetAll();
        void ReplaceAll(List<PatternModel> patterns);
    }
}
