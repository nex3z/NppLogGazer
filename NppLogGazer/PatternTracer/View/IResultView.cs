using NppLogGazer.PatternTracer.Model;
using NppLogGazer.PatternTracer.View.Event;
using System;
using System.Collections.Generic;
namespace NppLogGazer.PatternTracer.View
{
    public interface IResultView
    {
        event EventHandler<ResultFilterChangedEventArgs> ResultFilterChanged;

        void ShowResult(string result);
    }
}
