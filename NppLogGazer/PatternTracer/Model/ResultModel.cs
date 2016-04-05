using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.Model
{
    public class ResultModel
    {
        public List<ResultEntryModel> Result { get; set; }

        public ResultModel()
        {
            this.Result = new List<ResultEntryModel>();
        }
    }
}
