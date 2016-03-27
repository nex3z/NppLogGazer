using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NppLogGazer.QuickSearch.View.Event
{
    public class OnKeywordSelectedEventArgs : EventArgs
    {
        public enum MouseButton { Left, Right, None };
        public enum KeyboardButton { Ctrl, Alt, Shift, None };

        public int Index { get; set; }
        public MouseButton Mouse { get; set; }
        public KeyboardButton Key { get; set; }

        public bool MatchWord { get; set; }
        public bool MatchCase { get; set; }
        public bool WrapSearch { get; set; }

        public OnKeywordSelectedEventArgs()
        {
            this.Index = -1;
            this.Mouse = MouseButton.None;
            this.Key = KeyboardButton.None;
        }
    }
}
