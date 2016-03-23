using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NppLogGazer.QuickSearch.Repository
{
    interface IKeywordRepository
    {
        void Load(string path);
        void Save(string path);

        BindingList<KeywordModel> KeywordList { get; set; }
        void Add(KeywordModel item);
        void InsertToFront(KeywordModel item);
        KeywordModel GetItemAt(int positoin);
        void RemoveItemAt(int position);
        void SwapItemAt(int first, int second);
        void RemoveDuplicated();
    }
}
