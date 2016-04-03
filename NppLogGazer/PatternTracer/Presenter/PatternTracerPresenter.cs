using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.Repository;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
using NppLogGazer.QuickSearch.Repository;
using NppPluginNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            view.Bind(patterns);

            WireUpEvents();
            SetupInitialView();
        }

        private void WireUpEvents() 
        {
            view.AddPattern += AddPattern;
            view.RemovePatternAt += RemovePatternAt;
            view.UpdatePatternAt += UpdatePatternAt;
            view.SavePatternList += SavePatternList;
            view.OpenPatternList += OpenPatternList;
            view.OnPluginClosing += OnPluginClosing;
            view.OnSelectedPatternChanged += OnSelectedPatternChanged;
            view.ClearPatternInput += ClearPatternInput;
            view.PluginVisibleChanged += PluginVisibleChanged;
            view.SwapPatternPosition += SwapPatternAt;
        }

        private void SetupInitialView()
        {
            view.SetMatchWord(PatternTracerSettings.Configs.matchWord);
            view.SetMatchCase(PatternTracerSettings.Configs.matchCase);
            view.SetWrapSearch(PatternTracerSettings.Configs.wrapSearch);

            if (patterns.Count != 0)
            {
                view.SelectPatternAt(0);
                view.RenderPattern(patterns[0]);
            }

            // view.ShowStatusMessage(Properties.Resources.quick_search_status_initial_message, Color.Black);
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

        private void UpdatePatternAt(Object sender, UpdatePatternAtEventArgs args)
        {
            if (args.Position >= 0 && args.Position < patterns.Count)
            {
                patterns[args.Position] = args.Pattern;
            }
        }

        private void SwapPatternAt(Object sender, SwapPatternPositionEventArgs args)
        {
            if (args.Src >= 0 && args.Src < patterns.Count && args.Dest >= 0 && args.Dest < patterns.Count)
            {
                PatternModel tmp = patterns[args.Src];
                patterns[args.Src] = patterns[args.Dest];
                patterns[args.Dest] = tmp;
                view.SelectPatternAt(args.Dest);
            }
        }

        private void ClearPatternInput(Object sender, EventArgs args)
        {
            view.SetPatternInput("");
        }

        private void OnSelectedPatternChanged(Object sender, OnSelectedPatternChangedEventArgs args)
        {
             if (args.SelectedIndex >= 0 && args.SelectedIndex < patterns.Count)
             {
                 view.RenderPattern(patterns[args.SelectedIndex]);
             }
        }

        private void SavePatternList(Object sender, SavePaternListEventArgs args)
        {
            try
            {
                IPatternRepository tempRepo = new PatternRepository(new FileInfo(args.Path));
                tempRepo.ReplaceAll(patterns.ToList());
            }
            catch (SaveKeyworkListException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OpenPatternList(Object sender, OpenPatternListEventArgs args)
        {
            try
            {
                IPatternRepository tempRepo = new PatternRepository(new FileInfo(args.Path));
                patterns = new BindingList<PatternModel>(tempRepo.GetAll());
                view.Bind(patterns);
            }
            catch (LoadKeywordListException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OnPluginClosing(Object sender, OnClosingEventArgs args)
        {
            PatternTracerSettings.Configs.matchCase = args.MatchCaseStatus;
            PatternTracerSettings.Configs.matchWord = args.MatchWordStatus;
            PatternTracerSettings.Configs.wrapSearch = args.WrapSearchStatus;

            repository.ReplaceAll(patterns.ToList());
        }

        private void PluginVisibleChanged(Object sender, VisibleChangedEventArgs args)
        {
            if (!args.Visible)
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK, PluginBase._funcItems.Items[Main.GetPatternTracerDlgId()]._cmdID, 0);
            }
        }
    }
}
