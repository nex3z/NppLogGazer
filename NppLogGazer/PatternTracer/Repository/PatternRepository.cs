using NppLogGazer.Common.Repository;
using NppLogGazer.PatternExtractor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.Repository
{
    public class PatternRepository : XmlRepository<PatternModel>
    {
        public PatternRepository(FileInfo file)
            : base(file)
        {
        }
    }
}
