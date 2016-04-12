using System;

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
