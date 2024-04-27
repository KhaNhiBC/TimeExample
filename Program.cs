using System.Diagnostics;
using System.Timers;
using System.Threading;
internal class Program
{
private static System.Timers.Timer timer;

    private static void Main(string[] args)
    {
        timer = new System.Timers.Timer();
        timer.Interval = 1000;
        timer.Elapsed += OntimerEvent;
        timer.AutoReset = true;
        timer.Enabled = true;

        Console.WriteLine("nhap 1 phim bat ky");
        Console.ReadLine();

    }
    private static void OntimerEvent(object source, System.Timers.ElapsedEventArgs e)
    {
        Console.WriteLine("The elapsed event was raised at {0}",e.SignalTime);
    }
    


/*class TimerExample
{
    static void Main()
    {
        // Create an AutoResetEvent to signal the timeout threshold in the
        // timer callback has been reached.
        var autoEvent = new AutoResetEvent(false);
        
        var statusChecker = new StatusChecker(10);

        // Create a timer that invokes CheckStatus after one second, 
        // and every 1/4 second thereafter.
        Console.WriteLine("{0:h:mm:ss.fff} Creating timer.\n", 
                          DateTime.Now);
        var stateTimer = new Timer(statusChecker.CheckStatus, 
                                   autoEvent, 1000, 250);

        // When autoEvent signals, change the period to every half second.
        autoEvent.WaitOne();
        stateTimer.Change(0, 500);
        Console.WriteLine("\nChanging period to .5 seconds.\n");

        // When autoEvent signals the second time, dispose of the timer.
        autoEvent.WaitOne();
        stateTimer.Dispose();
        Console.WriteLine("\nDestroying timer.");
    }
}

class StatusChecker
{
    private int invokeCount;
    private int  maxCount;

    public StatusChecker(int count)
    {
        invokeCount  = 0;
        maxCount = count;
    }

    // This method is called by the timer delegate.
    public void CheckStatus(Object stateInfo)
    {
        AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
        Console.WriteLine("{0} Checking status {1,2}.", 
            DateTime.Now.ToString("h:mm:ss.fff"), 
            (++invokeCount).ToString());

        if(invokeCount == maxCount)
        {
            // Reset the counter and signal the waiting thread.
            invokeCount = 0;
            autoEvent.Set();
        }
    }
}*/
}