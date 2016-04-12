using System;

namespace NppLogGazer.QuickSearch.Repository
{
    class SaveKeyworkListException : Exception
    {
        public SaveKeyworkListException()
        {
        }

        public SaveKeyworkListException(string message) : base(message)
        {
        }
    }
}
