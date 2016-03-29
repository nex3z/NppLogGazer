using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.View.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View
{
    public interface IPatternTracerView
    {
        event EventHandler<AddPatternEventArgs> AddPattern;
        event EventHandler<RemovePatternAtEventArgs> RemovePatternAt;

        void Bind(BindingList<PatternModel> patternList);
        void ShowMessage(string message);
    }
}
