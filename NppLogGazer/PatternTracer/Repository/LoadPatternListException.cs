using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
