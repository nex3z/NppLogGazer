using NppQuickSearchPanel;
using System;
using System.Collections.Generic;
using System.Text;


namespace NppLogGazer.proto
{
    class Search
    {
        public static int[] searchPattern(String[] keywords)
        {
            int[] result = new int[keywords.Length]; 
            using (Scintilla sci = new Scintilla())
            {
                for (int i = 0; i < keywords.Length; i++)
                {
                    int pos = sci.SearchForward(keywords[i].ToString(), false, false, false);
                    
                    if (pos != -1)
                    {
                        result[i] = pos;
                    }
                    else
                    {
                        i = 0;
                    }
                }
            }
            return result;
        }
    }
}
