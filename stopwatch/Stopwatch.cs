using System;

namespace stopwatch
{
    public class Stopwatch
    {
        private DateTime? _startTime;
        private bool IsRunning
        {
            get { return _startTime != null; }
        }

        public Stopwatch()
        {
            _startTime = null;
        }

        public void Start()
        {
            if (IsRunning)
                throw new NullReferenceException("Stopwatch is already running.");

            _startTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!IsRunning)
                throw new NullReferenceException("Stopwatch is not running.");

            var duration = DateTime.Now - (DateTime)_startTime;
            _startTime = null;
            return duration;
        }
    }
}
