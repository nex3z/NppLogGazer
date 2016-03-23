using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.Repository
{
    class LoadKeywordListException : Exception
    {
        public LoadKeywordListException()
        {
        }

        public LoadKeywordListException(string message) : base(message)
        {
        }
    }
}
