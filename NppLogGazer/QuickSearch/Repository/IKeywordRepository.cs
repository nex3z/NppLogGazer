using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.QuickSearch.Repository
{
    interface IKeywordRepository
    {
        void Load(string path);
        void Save(string path);
    }
}
