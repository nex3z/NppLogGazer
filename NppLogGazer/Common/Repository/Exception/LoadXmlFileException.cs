using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository.Exception
{
    public class LoadXmlFileException : LoadDataException
    {
        private string backupFile = null;

        public override string BackupInfo
        { 
            get {
                return backupFile;
            } 
        }

        public LoadXmlFileException()
        {
        }

        public LoadXmlFileException(string message) : base(message)
        {
        }

        public LoadXmlFileException(string message, string backup) : base(message)
        {
            this.backupFile = backup;
        }
    }
}
