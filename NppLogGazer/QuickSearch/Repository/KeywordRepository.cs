using NppLogGazer.Common.Repository;
using NppLogGazer.QuickSearch.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.Repository
{
    public class KeywordRepository : XmlRepository<KeywordModel>
    {
        public KeywordRepository(FileInfo file)
            : base(file)
        {
        }
    }
}
