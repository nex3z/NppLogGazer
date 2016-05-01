namespace NppLogGazer.PatternTracer
{
    public class LineInfoModel
    {
        public int Position { get; set; }
        public int LineNumber { get; set; }
        public string LineText { get; set; }
        public int KeywordId { get; set; }

        public LineInfoModel(int position, int lineNumber, string lineText)
        {
            this.Position = position;
            this.LineNumber = lineNumber;
            this.LineText = lineText;
            this.KeywordId = -1;
        }

        public LineInfoModel(int position, int keywordId)
        {
            this.Position = position;
            this.KeywordId = keywordId;
        }
    }
}
