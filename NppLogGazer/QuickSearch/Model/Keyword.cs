using System;
using System.Collections.Generic;
using System.Text;

namespace NppLogGazer.QuickSearch.Model
{
    public enum KeywordType { Normal, RegExp };

    [Serializable]
    class Keyword
    {
        public string KeywordText { get; set; }
        public KeywordType Type { get; set; }

        public Keyword() { }

        public Keyword(string keyword, KeywordType type)
        {
            this.KeywordText = keyword;
            this.Type = type;
        }

        public override string ToString()
        {
            return KeywordText;
        }

        public bool Equals(Keyword other)
        {
            if ((this.KeywordText == other.KeywordText) && (this.Type == other.Type))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            int hashKeywords = this.KeywordText.GetHashCode();
            int hashType = this.Type.GetHashCode();
            return hashKeywords ^ hashType;
        }
    }
}
