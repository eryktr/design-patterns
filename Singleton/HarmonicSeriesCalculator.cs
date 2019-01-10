using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Singleton
{
    class HarmonicSeriesCalculator
    {
        private int _boundary = 0;
        private int _counter = 1;
        private decimal _sum = 0;
        private Stopwatch _stopwatch;
        private Logger _logger;



        public HarmonicSeriesCalculator(int boundary)
        {
            _boundary = boundary;
            _logger = Logger.Instance();
        }

        public void Execute()
        {
            StartTimer();
            Calculate();
            StopTimer();
            Log();
        }

        private void StartTimer()
        {
            _stopwatch = Stopwatch.StartNew();
        }

        private void StopTimer()
        {
            _stopwatch.Stop();
        }

        private void Calculate()
        {
            while (_counter <= _boundary) _sum += 1.0m / (_counter++);
        }

        private void Log()
        {
            var time = _stopwatch.Elapsed;
            var minutes = time.Minutes;
            var seconds = time.Seconds;
            var millis = time.Milliseconds;
            var message = $"Calculated terms: {_boundary}. Result: {_sum}. Execution time: {minutes} minutes {seconds} seconds {millis} miliseconds";
            _logger.Log(message);
        }
    }
}
