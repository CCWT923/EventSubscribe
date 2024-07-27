using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventSubscribe
{
    internal class MyEventArgs:EventArgs
    {
        internal string Message { get; }
        internal long Timestamp { get; }

        internal MyEventArgs(string message)
        {
            Message = message;
            Timestamp = DateTime.Now.Ticks;
        }
    }
}
