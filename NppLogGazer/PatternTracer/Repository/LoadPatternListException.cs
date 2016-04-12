using System;

namespace NppLogGazer.QuickSearch.Repository
{
    class LoadPatternListException : Exception
    {
        public LoadPatternListException()
        {
        }

        public LoadPatternListException(string message) : base(message)
        {
        }
    }
}
