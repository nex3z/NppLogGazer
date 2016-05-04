using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NppLogGazer.Common.Repository
{
    interface IRepository<T>
    {
        List<T> GetAll();
        List<T> GetFrom(FileInfo file);
        void SaveAll(List<T> data);
        void SaveAs(List<T> data, FileInfo file);
    }
}
