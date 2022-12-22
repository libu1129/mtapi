using System;

namespace MtApi5
{
    public class Mt5LockTicksEventArgs : EventArgs
    {
        public Mt5LockTicksEventArgs(string symbol)
        {
            Symbol = symbol;
        }

        public string Symbol { get; }
    }
}