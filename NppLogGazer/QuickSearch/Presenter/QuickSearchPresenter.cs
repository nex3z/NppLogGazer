using NppLogGazer.QuickSearch.Model;
using NppLogGazer.QuickSearch.Repository;
using NppLogGazer.QuickSearch.View.Event;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Linq;

namespace NppLogGazer.QuickSearch.Presenter
{
    class QuickSearchPresenter
    {
        private IQuickSearchView view;
        private IKeywordRepository repository;

        private BindingList<KeywordModel> keywords;

        public QuickSearchPresenter(IQuickSearchView view, IKeywordRepository repository)
        {
            this.view = view;
            this.repository = repository;

            keywords = new BindingList<KeywordModel>(repository.GetAll());
            view.Bind(keywords);

            WireUpEvents();
        }

        private void WireUpEvents()
        {
            view.PerformSearch += performSearch;
            view.AddKeyword += AddKeyword;
            view.RemoveKeywordAt += RemoveKeywordAt;
            view.SwapKeywordPosition += SwapKeywordAt;
            view.RemoveDuplicates += RemoveDuplicates;
            view.SaveKeywordList += SaveKeywordList;
            view.OpenKeywordList += OpenKeywordList;
            view.OnSelectedKeywordChanged += OnSelectedKeywordChanged;
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
            keywords.RemoveAt(args.Position);
        }

        private void SwapKeywordAt(Object sender, SwapPositionEventArgs args)
        {
            if (args.Src >= 0 && args.Src < keywords.Count && args.Dest >= 0 && args.Dest < keywords.Count)
            {
                KeywordModel tmp = keywords[args.Src];
                keywords[args.Src] = keywords[args.Dest];
                keywords[args.Dest] = tmp;
            }
            view.SelectKeywordAt(args.Dest);
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
                //repository.ReplaceAll(new FileInfo(args.Path));
            }
            catch(SaveKeyworkListException ex)
            {
                view.ShowMessage(ex.Message);
            }
        }

        private void OpenKeywordList(Object sender, OpenKeywordListEventArgs args)
        {
            try
            {
                //repository.Load(args.Path);
            }
            catch(LoadKeywordListException ex)
            {
                view.ShowMessage(ex.Message);
            }
            //view.Bind(repository.KeywordList);
        }

        private void OnSelectedKeywordChanged(Object sender, OnSelectedKeywordChangedEventArgs args)
        {
            if (args.SelectedIndex >= 0 && args.SelectedIndex < keywords.Count)
            {
                view.RenderKeyword(keywords[args.SelectedIndex]);
            }
        }

        private void performSearch(Object sender, SearchEventArgs args)
        {
        }
    }
}
