// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
// provide two methods: Start and Stop. We call the start method first, and the stop method next.
// Then we ask the stopwatch about the duration between start and stop. Duration should be a
// value in TimeSpan. Display the duration on the console.
// We should also be able to use a stopwatch multiple times. So we may start and stop it and then
// start and stop it again. Make sure the duration value each time is calculated properly.
// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
// start time). So the class should throw an InvalidOperationException if its started twice.

using Microsoft.VisualBasic;

namespace StopWatch
{
	 class StopWatch
	{
		private DateTime _startTime;
		private DateTime _endTime;
		private bool _running;

		public void Start()
		{
			if (_running)
				throw new InvalidOperationException("Stopwatch is already running.");
			
			_startTime = DateTime.Now;
			_running = true;
			Console.WriteLine("Stopwatch started.");
		}

		public void Stop()
		{
			if (!_running)
				throw new InvalidOperationException("Stopwatch is not running.");
			
			_endTime = DateTime.Now;
			_running = false;
			Console.WriteLine("Stopwatch stopped.");
		}

		public TimeSpan Duration
		{
			get
			{
				if (_running)
					throw new InvalidOperationException("Stopwatch is still running.");
				
				return _endTime - _startTime;
			}
		}
	}
}