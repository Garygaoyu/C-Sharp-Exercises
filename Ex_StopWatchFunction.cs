using System;
using System.Threading;

namespace StopWatch
{
  class Program
  {
    static void Main(string[] atgs)
	{
	   var stopwatch = new StopWawtch();

	   for (var i = 0; i < 2; i++)
	   {
	     stopwatch.Start(); 
		 Thread.Sleep(1000);

		 stopwatch.Stop(); 

                Console.Writeline("Duration: " + stopwatch.GetInterval());
                Console.WriteLine("Press Enter to Start.");
                Console.ReadLine;
	 	}
	}	
  }

  public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private bool _running;

		public void Start()
        {
			if(_running)  // If the program is aready running, throw exception
                throw new InvalidOperationException("The stopwatch is running");           
       
            _startTime = DateTime.Now; //Update status
            _running = true;
            
        }

        public void Stop()
        {
            if (!_running)
            
             if (_running)  // If the program is not running, throw exception
                  throw new InvalidOperationException("The stopwatch is not running");

             _endTime = DateTime.Now; //Update status
             _running = false;
            
        }
    }

    public TimeSpan GetInterval()
    {
        return duration = _endTime - _startTime;  
    }

}