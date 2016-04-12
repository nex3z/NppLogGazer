using System;

namespace NppLogGazer.QuickSearch.Repository
{
    class SavePatternListException : Exception
    {
        public SavePatternListException()
        {
        }

        public SavePatternListException(string message) : base(message)
        {
        }
    }
}
