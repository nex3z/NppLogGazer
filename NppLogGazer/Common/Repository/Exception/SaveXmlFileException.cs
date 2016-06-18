using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository.Exception
{
    public class SaveXmlFileException : SaveDataException
    {
        public SaveXmlFileException()
        {
        }

        public SaveXmlFileException(string message) : base(message)
        {
        }
    }
}
