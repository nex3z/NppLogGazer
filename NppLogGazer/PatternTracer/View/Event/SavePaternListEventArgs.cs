using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class SavePaternListEventArgs : EventArgs
    {
        public string Path { get; set; }

        public SavePaternListEventArgs(string path)
        {
            this.Path = path;
        }
    }
}
