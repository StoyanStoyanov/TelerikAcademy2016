namespace Ex08TimerUsingEvents
{
    using System;
    using System.Timers;

    public class TimerUsingEvents
    {
        public static void Main()
        {
            // Use an instance of System.Timers
            var timer = new Timer();

            // Hook up the Elapsed event for the timer.
            timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

            // Set the Interval to 2 seconds (2000 milliseconds).
            timer.Interval = 2000;

            // Enable the event
            timer.Enabled = true;

            // Set the  timer.Elapsed event to be repeated every Interval seconds, not only once, 
            // if set to false  the event is raised only once
            timer.AutoReset = true;

            // Keep the console alive until a key is pressed
            Console.WriteLine("Press the Enter key to exit the program.");
            Console.ReadLine();
        }

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);
        }
    }
}
