using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
