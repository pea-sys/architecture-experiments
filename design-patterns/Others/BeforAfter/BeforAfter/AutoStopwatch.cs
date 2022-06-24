using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforAfter
{
    internal class AutoStopwatch : IDisposable
    {
        private readonly string _message;
        private readonly Stopwatch _stopwatch;
        private bool _disposed;

        public AutoStopwatch(string message) =>
            ( _message, _stopwatch) = (message, Stopwatch.StartNew());

        public void Dispose()
        {
            if (_disposed)
            {
                return;
            }

            Console.WriteLine(_stopwatch.ElapsedMilliseconds.ToString());

            _disposed = true;
        }
    }
}
