using System;
using System.Diagnostics;

namespace W32RegActionParser
{
    public class StopwatchController
    {
        private Stopwatch stopWatch = new Stopwatch();
        public string Text;

        public void Start()
        {
            Text = String.Empty;
            stopWatch = new Stopwatch();
            stopWatch = Stopwatch.StartNew();
        }

        public void Stop()
        {
            stopWatch.Stop();
            TimeSpan time = stopWatch.Elapsed;
            Text = time.ToString(@"mm\:ss\:ff");
        }
    }
}
