using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository
{
    public abstract class SaveDataException : System.Exception
    {
        public SaveDataException()
        {
        }

        public SaveDataException(string message) : base(message)
        {
        }
    }
}
