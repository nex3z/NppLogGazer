using NppLogGazer.QuickSearch.Model;
using System.Collections.Generic;

namespace NppLogGazer.QuickSearch.Repository
{
    interface IKeywordRepository
    {
        List<KeywordModel> GetAll();
        void ReplaceAll(List<KeywordModel> keywords);
    }
}
