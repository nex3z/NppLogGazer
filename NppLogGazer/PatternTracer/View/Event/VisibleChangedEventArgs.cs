using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.PatternTracer.View.Event
{
    public class VisibleChangedEventArgs : EventArgs
    {
        public bool Visible { get; set; }

        public VisibleChangedEventArgs(bool isVisible)
        {
            this.Visible = isVisible;
        }
    }
}
