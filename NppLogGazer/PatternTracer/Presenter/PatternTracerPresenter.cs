using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.Repository;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
using NppLogGazer.QuickSearch.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.Presenter
{
    class PatternTracerPresenter
    {
        private IPatternTracerView view;
        private IPatternRepository repository;

        private BindingList<PatternModel> patterns;

        public PatternTracerPresenter(IPatternTracerView view, IPatternRepository repository)
        {
            this.view = view;
            this.repository = repository;

            try
            {
                patterns = new BindingList<PatternModel>(repository.GetAll());
            }
            catch (LoadPatternListException ex)
            {
                view.ShowMessage(ex.Message);
                patterns = new BindingList<PatternModel>();
            }

            WireUpEvents();
            view.Bind(patterns);
        }

        private void WireUpEvents() 
        {
            view.AddPattern += AddPattern;
            view.RemovePatternAt += RemovePatternAt;
        }

        private void AddPattern(Object sender, AddPatternEventArgs args) 
        {
            if (args.Pattern != null)
            {
                patterns.Add(args.Pattern);
            }
        }
        
        private void RemovePatternAt(Object sender, RemovePatternAtEventArgs args)
        {
            if (args.Position >= 0 && args.Position < patterns.Count)
            {
                patterns.RemoveAt(args.Position);
            }
        }
    }
}
