using NppLogGazer.QuickSearch.Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace NppLogGazer.QuickSearch.Presenter
{
    class KeywordBindingList : BindingList<KeywordModel>
    {
        private List<KeywordModel> unfilteredList = new List<KeywordModel>();
        private string filterValue = null;

        public KeywordBindingList(List<KeywordModel> keywords) : base(keywords)
        {
        }

        public KeywordBindingList() : base()
        {
        }

        public bool FilterEnabled
        {
            get
            {
                return filterValue != null;
            }
        }

        public string Filter
        {
            get { return filterValue; }

            set
            {
                if (filterValue == null)
                {
                    // Save current list to unfilteredList before applying any filter
                    unfilteredList.Clear();
                    unfilteredList.AddRange(this.Items);
                }

                if (filterValue != value)
                {
                    RaiseListChangedEvents = false;

                    if (value == null)
                    {
                        // Cancel filter, restore original list
                        this.ClearItems();
                        foreach (KeywordModel keyword in unfilteredList)
                        {
                            base.Add(keyword);
                        }
                        filterValue = value;
                    }
                    else
                    {
                        filterValue = value;
                        ApplyFilter();
                    }

                    RaiseListChangedEvents = true;
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                }
            }
        }

        private void ApplyFilter()
        {
            List<KeywordModel> results = unfilteredList.Where(m => m.KeywordText.ToLower().Contains(filterValue.ToLower()) == true).ToList();
            this.ClearItems();
            if (results != null && results.Count > 0)
            {
                foreach (KeywordModel keyword in results)
                {
                    base.Add(keyword);
                }
            }
        }

        public void RemoveFilter()
        {
            if (Filter != null)
            {
                Filter = null;
            }
        }

        public void AddKeyword(KeywordModel keyword)
        {
            base.Insert(0, keyword);
            if (filterValue != null)
            {
                unfilteredList.Insert(0, keyword);
            }
        }

        public void RemoveKeywordAt(int index)
        {
            KeywordModel pending = base[index];
            base.RemoveAt(index);
            if (filterValue != null)
            {
                unfilteredList.Remove(pending);
            }
        }

        public void UpdateKeywordAt(int index, KeywordModel keyword)
        {
            KeywordModel pending = base[index];
            if (filterValue != null)
            {
                int pendingIndex = unfilteredList.IndexOf(pending);
                unfilteredList[pendingIndex] = keyword;
            }
            
            base.SetItem(index, keyword);
        }
    }
}
