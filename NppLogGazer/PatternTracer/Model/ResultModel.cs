using System.Collections.Generic;

namespace NppLogGazer.PatternTracer.Model
{
    public class ResultModel
    {
        public List<LineInfoModel> Result { get; set; }

        public ResultModel()
        {
            this.Result = new List<LineInfoModel>();
        }
    }
}
