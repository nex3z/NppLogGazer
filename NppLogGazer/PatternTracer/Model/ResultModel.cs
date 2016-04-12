using System.Collections.Generic;

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
