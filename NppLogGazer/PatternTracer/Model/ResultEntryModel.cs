namespace NppLogGazer.PatternTracer
{
    public class ResultEntryModel
    {
        public int Position { get; set; }
        public int LineNumber { get; set; }
        public string LineText { get; set; }

        public ResultEntryModel(int position, int lineNumber, string lineText)
        {
            this.Position = position;
            this.LineNumber = lineNumber;
            this.LineText = lineText;
        }
    }
}
