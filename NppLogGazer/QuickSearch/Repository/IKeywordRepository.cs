using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace NppLogGazer.QuickSearch.Repository
{
    interface IKeywordRepository
    {
        IList<KeywordModel> GetAll();
        void ReplaceAll(IList<KeywordModel> keywords);
    }
}
