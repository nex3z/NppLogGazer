using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository
{
    class SaveDataException : Exception
    {
        public SaveDataException()
        {
        }

        public SaveDataException(string message) : base(message)
        {
        }
    }
}
