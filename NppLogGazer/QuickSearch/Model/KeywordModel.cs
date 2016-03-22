using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NppLogGazer.QuickSearch.Model
{
    public enum KeywordType { Normal, RegExp };

    public class KeywordModel : IEquatable<KeywordModel>
    {
        public string KeywordText { get; set; }

        public KeywordType Type { get; set; }

        public KeywordModel() { }

        public KeywordModel(string keyword, KeywordType type)
        {
            this.KeywordText = keyword;
            this.Type = type;
        }

        public override string ToString()
        {
            return KeywordText;
        }

        public bool Equals(KeywordModel other)
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
