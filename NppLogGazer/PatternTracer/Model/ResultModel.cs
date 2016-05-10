using System.Collections.Generic;

namespace NppLogGazer.PatternTracer.Model
{
    public class ResultModel
    {
        public List<LineInfoModel> Result { get; set; }
        public int KeywordCount { get; set; }
        public int MatchCount { get; set; }
        public ResultModel()
        {
            this.Result = new List<LineInfoModel>();
            this.KeywordCount = 0;
            this.MatchCount = 0;
        }

        public ResultModel(int keywordCount)
            : this()
        {
            this.KeywordCount = keywordCount;
        }
    }
}
