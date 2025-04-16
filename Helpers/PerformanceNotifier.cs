using Microsoft.JSInterop;
using System.Diagnostics;

namespace test1Blazor.Helpers
{
    public static class PerformanceNotifier
    {
        private static Stopwatch? _stopwatch;

        public static void StartTiming()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        [JSInvokable("NotifyUIUpdateComplete")]
        public static void NotifyUIUpdateComplete()
        {
            if (_stopwatch != null)
            {
                _stopwatch.Stop();
                Console.WriteLine($"Render time: {_stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
