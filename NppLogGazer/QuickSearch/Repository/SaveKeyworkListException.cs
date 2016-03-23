using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
