using NppLogGazer.PatternTracer.Repository;
using NppLogGazer.PatternTracer.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.Presenter
{
    class PatternTracerPresenter
    {
        private IPatternTracerView view;
        private IPatternRepository repository;

        public PatternTracerPresenter(IPatternTracerView view, IPatternRepository repository)
        {
            this.view = view;
            this.repository = repository;

            view.ShowMessage("123");
        }
    }
}
