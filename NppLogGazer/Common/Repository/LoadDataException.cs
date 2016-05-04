using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository
{
    class LoadDataException : Exception
    {
        public LoadDataException()
        {
        }

        public LoadDataException(string message) : base(message)
        {
        }
    }
}
