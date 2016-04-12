using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.View.Event;
using System;
using System.ComponentModel;

namespace NppLogGazer.PatternTracer.View
{
    public interface IPatternTracerView
    {
        event EventHandler<AddPatternEventArgs> AddPattern;
        event EventHandler<RemovePatternAtEventArgs> RemovePatternAt;
        event EventHandler<UpdatePatternAtEventArgs> UpdatePatternAt;
        event EventHandler<SavePaternListEventArgs> SavePatternList;
        event EventHandler<OpenPatternListEventArgs> OpenPatternList;
        event EventHandler<OnClosingEventArgs> OnPluginClosing;
        event EventHandler<OnSelectedPatternChangedEventArgs> OnSelectedPatternChanged;
        event EventHandler ClearPatternInput;
        event EventHandler<VisibleChangedEventArgs> PluginVisibleChanged;
        event EventHandler<SwapPatternPositionEventArgs> SwapPatternPosition;
        event EventHandler<SearchPatternEventArgs> SearchPattern;

        void Bind(BindingList<PatternModel> patternList);
        void ShowMessage(string message);
        void SelectPatternAt(int position);
        void RenderPattern(PatternModel pattern);
        void SetMatchWord(bool matchWord);
        void SetMatchCase(bool matchCase);
        void SetWrapSearch(bool wrapSearch);
        void SetPatternInput(string pattern);
    }
}
