using NppLogGazer.Common.Repository;
using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.Presenter;
using NppLogGazer.PatternTracer.Repository;
using NppLogGazer.PatternTracer.View;
using System;
using System.IO;
using System.Windows.Forms;

namespace NppLogGazer.PatternTracer
{
    class PatternTracerPanel
    {
        private static PatternTracerPanel instance = null;

        private IPatternTracerView view;
        private PatternTracerPresenter presenter;
        private IRepository<PatternModel> repository;

        private PatternTracerPanel()
        {
            view = new FrmPatternTracer();
            repository = new PatternRepository(new FileInfo(Main.GetDefaultPatternListPath()));
            presenter = new PatternTracerPresenter(view, repository);
        }

        public static PatternTracerPanel Instance
        {
            get 
            {
                return instance ?? (instance = new PatternTracerPanel());
            }
        }

        public Form Form
        {
            get
            {
                if (view is Form)
                    return view as Form;
                else
                    throw new InvalidCastException("View must also implement Form.");
            }
        }
    }
}
