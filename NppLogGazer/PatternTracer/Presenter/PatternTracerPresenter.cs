﻿using NppLogGazer.Common.Repository;
using NppLogGazer.Common.Scintilla;
using NppLogGazer.Common.Utility;
using NppLogGazer.PatternExtractor.Model;
using NppLogGazer.PatternTracer.Model;
using NppLogGazer.PatternTracer.View;
using NppLogGazer.PatternTracer.View.Event;
using NppPluginNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;

namespace NppLogGazer.PatternTracer.Presenter
{
    class PatternTracerPresenter
    {
        private IPatternTracerView view;
        private IRepository<PatternModel> repository;

        private BindingList<PatternModel> patterns;

        public PatternTracerPresenter(IPatternTracerView view, IRepository<PatternModel> repository)
        {
            this.view = view;
            this.repository = repository;

            LoadPatternsFromDefaultStore();
            WireUpEvents();
            SetupInitialView();
        }

        private void LoadPatternsFromDefaultStore()
        {
            try
            {
                patterns = new BindingList<PatternModel>(repository.GetAll());
            }
            catch (LoadDataException ex)
            {
                string message = ExceptionMessageUtility.BuildLoadDataExceptionMessage(ex);
                view.ShowMessage(message);
                patterns = new BindingList<PatternModel>();
            }
            view.Bind(patterns);
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
            view.SearchPattern += SearchPattern;
        }

        private void SetupInitialView()
        {
            view.SetMatchWord(PatternTracerSettings.Instance.Configs.MatchWord);
            view.SetMatchCase(PatternTracerSettings.Instance.Configs.MatchCase);
            view.SetWrapSearch(PatternTracerSettings.Instance.Configs.WrapSearch);

            if (patterns.Count != 0)
            {
                view.SelectPatternAt(0);
                view.RenderPattern(patterns[0]);
            }
        }

        private void SearchPattern(Object sender, SearchPatternEventArgs args)
        {
            List<ResultModel> results = PerformSearchFull(args.Pattern, args.MatchWord, args.MatchCase);
            ShowResult(results, args.Pattern);
        }

        private void AddPattern(Object sender, AddPatternEventArgs args)
        {
            if (args.Pattern != null && args.Pattern.PatternText.Count != 0)
            {
                patterns.Insert(0, args.Pattern);
                view.SelectPatternAt(0);
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
                repository.SaveAs(patterns.ToList(), new FileInfo(args.Path));
            }
            catch (SaveDataException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OpenPatternList(Object sender, OpenPatternListEventArgs args)
        {
            try
            {
                patterns = new BindingList<PatternModel>(repository.GetFrom(new FileInfo(args.Path)));
                view.Bind(patterns);
            }
            catch (LoadDataException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OnPluginClosing(Object sender, OnClosingEventArgs args)
        {
            PatternTracerSettings.Instance.Configs.MatchCase = args.MatchCaseStatus;
            PatternTracerSettings.Instance.Configs.MatchWord = args.MatchWordStatus;
            PatternTracerSettings.Instance.Configs.WrapSearch = args.WrapSearchStatus;

            repository.SaveAll(patterns.ToList());
        }

        private void PluginVisibleChanged(Object sender, VisibleChangedEventArgs args)
        {
            if (!args.Visible)
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK, PluginBase._funcItems.Items[Main.GetPatternTracerDlgId()]._cmdID, 0);
            }
        }

        private List<ResultModel> PerformSearchFull(PatternModel pattern, bool matchWord, bool matchCase)
        {
            int keywordNum = pattern.PatternText.Count;
            List<ResultModel> results = new List<ResultModel>();
            List<LineInfoModel> positions = new List<LineInfoModel>();

            using (Scintilla sci = new Scintilla())
            {
                for (int keywordIdx = 0; keywordIdx < keywordNum; keywordIdx++)
                {
                    sci.SetCurrentPos(0);
                    sci.SetAnchor(0);

                    string keyword = pattern.PatternText[keywordIdx].ToString();
                    bool isRegExp = pattern.Type == PatternType.RegExp;
                    if (keyword == "")
                    {
                        keyword = @"^\s*\n";
                        isRegExp = true;
                    }

                    int pos = sci.SearchForwardSilent(keyword, isRegExp, matchWord, matchCase);
                    while (pos != -1)
                    {
                        positions.Add(new LineInfoModel(pos, keywordIdx));
                        pos = sci.SearchForwardSilent(keyword, isRegExp, matchWord, matchCase);
                    }
                }
                
                positions = positions.OrderBy(o => o.Position).ToList();

                ResultModel resultModel = new ResultModel(pattern.PatternText.Count);
                int lastKeywordIdx = -1;
                foreach (LineInfoModel line in positions)
                {
                    int lineNum = sci.GetLineFromPosition(line.Position);
                    line.LineNumber = lineNum + 1;
                    string text = sci.GetLine(lineNum);
                    line.LineText = text;
                    if (line.KeywordId <= lastKeywordIdx)
                    {
                        results.Add(resultModel);
                        resultModel = new ResultModel(pattern.PatternText.Count);
                    }
                    lastKeywordIdx = line.KeywordId;
                    resultModel.Result.Add(line);
                    resultModel.MatchCount++;
                }
                if (resultModel.Result.Count != 0) results.Add(resultModel);
            }

            return results;
        }

        private void ShowResult(List<ResultModel> result, PatternModel pattern)
        {
            IResultView resultFrm = new FrmResult();
            SearchResultPresenter resultPresenter = new SearchResultPresenter(resultFrm);
            resultPresenter.RenderResult(result, pattern);
        }
    }
}
