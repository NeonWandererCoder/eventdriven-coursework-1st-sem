using System;
using System.Threading;

public class MyThreadClass
{
    public static void Thread1()
    {
        // loop from 0 to 5 (6 total prints), matching the expected output in Figure 2
        for (int loopCount = 0; loopCount <= 5; loopCount++)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);

            // suspend the current thread for 1.5 seconds before the next loop
            Thread.Sleep(1500);
        }
    }
}