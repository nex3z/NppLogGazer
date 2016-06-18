using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository
{
    public abstract class LoadDataException : System.Exception
    {
        public LoadDataException()
        {
        }

        public LoadDataException(string message) : base(message)
        {
        }

        public abstract string BackupInfo
        {
            get;
        }
    }
}
