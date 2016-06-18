using NppLogGazer.Common.Repository;
using NppLogGazer.Common.Scintilla;
using NppLogGazer.Common.Utility;
using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.View.Event;
using NppPluginNET;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NppLogGazer.QuickSearch.Presenter
{
    class QuickSearchPresenter
    {
        private IQuickSearchView view;
        private IRepository<KeywordModel> repository;

        private BindingList<KeywordModel> keywords;
        private int lastSelectedIndex;

        public QuickSearchPresenter(IQuickSearchView view, IRepository<KeywordModel> repository)
        {
            this.view = view;
            this.repository = repository;

            LoadKeywordsFromDefaultStore();
            WireUpEvents();
            SetupInitialView();
        }

        private void LoadKeywordsFromDefaultStore()
        {
            try
            {
                keywords = new BindingList<KeywordModel>(repository.GetAll());
            }
            catch (LoadDataException ex)
            {
                string message = ExceptionMessageUtility.BuildLoadDataExceptionMessage(ex);
                view.ShowMessage(message);
                keywords = new BindingList<KeywordModel>();
            }
            view.Bind(keywords);
        }

        private void WireUpEvents()
        {
            view.AddKeyword += AddKeyword;
            view.RemoveKeywordAt += RemoveKeywordAt;
            view.UpdateKeywordAt += UpdateKeywordAt;
            view.SwapKeywordPosition += SwapKeywordAt;
            view.RemoveDuplicates += RemoveDuplicates;
            view.SaveKeywordList += SaveKeywordList;
            view.OpenKeywordList += OpenKeywordList;
            view.OnSelectedKeywordChanged += OnSelectedKeywordChanged;
            view.OnPluginClosing += OnClosing;
            view.OnKeywordSelected += OnKeywordSelected;
            view.PluginVisibleChanged += PluginVisibleChanged;
            view.LaunchNppSearchDialog += LaunchNppSearchDialog;
        }

        private void SetupInitialView()
        {
            view.SetMatchWord(QuickSearchSettings.Instance.Configs.MatchWord);
            view.SetMatchCase(QuickSearchSettings.Instance.Configs.MatchCase);
            view.SetWrapSearch(QuickSearchSettings.Instance.Configs.WrapSearch);

            if (keywords.Count != 0)
            {
                view.SelectKeywordAt(0);
                view.RenderKeyword(keywords[0]);
            }

            view.ShowStatusMessage(Properties.Resources.quick_search_status_initial_message, Color.Black);
        }

        private void AddKeyword(Object sender, AddKeywordEventArgs args)
        {
            if (args.Keyword != null && args.Keyword.KeywordText != "")
            {
                keywords.Insert(0, args.Keyword);
                view.SelectKeywordAt(0);
            }
        }

        private void RemoveKeywordAt(Object sender, RemoveKeywordAtEventArgs args)
        {
            if (args.Position >= 0 && args.Position < keywords.Count)
                keywords.RemoveAt(args.Position);
        }

        private void UpdateKeywordAt(Object sender, UpdateKeywordAtEventArgs args)
        {
            if (args.Position >= 0 && args.Position < keywords.Count)
            {
                keywords[args.Position] = args.Keyword;
            }
        }

        private void SwapKeywordAt(Object sender, SwapPositionEventArgs args)
        {
            if (args.Src >= 0 && args.Src < keywords.Count && args.Dest >= 0 && args.Dest < keywords.Count)
            {
                KeywordModel tmp = keywords[args.Src];
                keywords[args.Src] = keywords[args.Dest];
                keywords[args.Dest] = tmp;
                view.SelectKeywordAt(args.Dest);
            }
        }

        private void RemoveDuplicates(Object sender, EventArgs args)
        {
            if (view.RequireConfirm(Properties.Resources.remove_dup_dlg_title, 
                                    Properties.Resources.remove_dup_dlg_message))
            {
                keywords = new BindingList<KeywordModel>(keywords.Distinct().ToList());
                view.Bind(keywords);
            }
        }

        private void SaveKeywordList(Object sender, SaveKeywordListEventArgs args)
        {
            try
            {
                repository.SaveAs(keywords.ToList(), new FileInfo(args.Path));
            }
            catch(SaveDataException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OpenKeywordList(Object sender, OpenKeywordListEventArgs args)
        {
            try
            {
                keywords = new BindingList<KeywordModel>(repository.GetFrom(new FileInfo(args.Path)));
                view.Bind(keywords);
            }
            catch(LoadDataException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OnSelectedKeywordChanged(Object sender, OnSelectedKeywordChangedEventArgs args)
        {
            if (args.SelectedIndex >= 0 && args.SelectedIndex < keywords.Count)
            {
                view.RenderKeyword(keywords[args.SelectedIndex]);
            }
        }

        private void OnClosing(Object sender, OnClosingEventArgs args)
        {
            QuickSearchSettings.Instance.Configs.MatchCase = args.MatchCaseStatus;
            QuickSearchSettings.Instance.Configs.MatchWord = args.MatchWordStatus;
            QuickSearchSettings.Instance.Configs.WrapSearch = args.WrapSearchStatus;

            repository.SaveAll(keywords.ToList());
        }

        private void OnKeywordSelected(Object sender, OnKeywordSelectedEventArgs args)
        {
            int index = args.Index;
            if (index < 0 || index >= keywords.Count)
                return;

            bool isSelectedIndexChanged = false;
            if (index != lastSelectedIndex)
            {
                isSelectedIndexChanged = true;
                lastSelectedIndex = index;
                view.ShowStatusMessage(Properties.Resources.quick_search_status_initial_message, Color.Black);
            }

            KeywordModel keyword = keywords[index];
            if (args.Mouse == OnKeywordSelectedEventArgs.MouseButton.Left)
            {
                if (args.Key == OnKeywordSelectedEventArgs.KeyboardButton.Ctrl)
                {
                    LaunchNppSearchDialogWithKeyword(keyword);
                }
                else if (args.Key == OnKeywordSelectedEventArgs.KeyboardButton.Shift)
                {
                    ShowSearchingIndication();
                    using (Scintilla sci = new Scintilla())
                    {
                        int pos = sci.SearchBackward(keyword.ToString(),
                            keyword.Type == KeywordType.RegExp, args.MatchWord, args.MatchCase, args.WrapSearch);
                        ShowSearchResult(sci, pos);
                    }
                } else if (args.Key == OnKeywordSelectedEventArgs.KeyboardButton.None)
                {
                    if (!isSelectedIndexChanged)
                    {
                        ShowSearchingIndication();
                        using (Scintilla sci = new Scintilla())
                        {
                            int pos = sci.SearchForward(keyword.ToString(),
                                keyword.Type == KeywordType.RegExp, args.MatchWord, args.MatchCase, args.WrapSearch);
                            ShowSearchResult(sci, pos);
                        }
                    }
                }
            }
        }

        private void ShowSearchingIndication()
        {
            view.ShowStatusMessage(Properties.Resources.quick_search_status_searching, Color.Black);
        }

        private void ShowSearchResult(Scintilla sci, int pos)
        {
            if (pos < 0)
            {
                view.ShowStatusMessage(Properties.Resources.quick_search_status_could_not_find, Color.Red);
            }
            else
            {
                int line = sci.GetLineFromPosition(pos) + 1;
                string message = Properties.Resources.quick_search_status_found_at_line + line + ".";
                view.ShowStatusMessage(message, Color.Green);
            }
        }

        private void LaunchNppSearchDialog(Object sender, LaunchNppSearchDialogEventArgs args)
        {
            LaunchNppSearchDialogWithKeyword(args.Keyword);
        }

        private void LaunchNppSearchDialogWithKeyword(KeywordModel keyword)
        {
            if (keyword != null) Clipboard.SetText(keyword.ToString());
            Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_MENUCOMMAND, 0, NppMenuCmd.IDM_SEARCH_FIND);
            if (keyword != null) SendKeys.SendWait("^{v}");
        }

        private void PluginVisibleChanged(Object sender, VisibleChangedEventArgs args)
        {
            if (!args.Visible)
            {
                Win32.SendMessage(PluginBase.nppData._nppHandle, NppMsg.NPPM_SETMENUITEMCHECK, PluginBase._funcItems.Items[Main.GetQuickSearchDlgId()]._cmdID, 0);
            }
        }
    }

}
