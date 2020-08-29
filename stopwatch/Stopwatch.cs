using System;

namespace stopwatch
{
    public class Stopwatch
    {
        private DateTime? StartTime;

        public Stopwatch()
        {
            StartTime = null;
        }

        public void Start()
        {
            if (IsRunning())
                throw new NullReferenceException("Stopwatch is already running.");

            StartTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!IsRunning())
                throw new NullReferenceException("Stopwatch is not running.");

            var duration = DateTime.Now - (DateTime)StartTime;
            StartTime = null;
            return duration;
        }

        private bool IsRunning() =>
            StartTime != null;
    }
}
