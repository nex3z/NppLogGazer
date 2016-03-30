using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class OpenPatternListEventArgs : EventArgs
    {
        public string Path { get; set; }

        public OpenPatternListEventArgs(string path)
        {
            this.Path = path;
        }
    }
}
