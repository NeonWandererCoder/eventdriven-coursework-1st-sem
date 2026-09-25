using System;
using System.Threading;

public class MyThreadClass
{
    public static void Thread1()
    {
        // loops 3 times (Process = 0 to 2), matching the expected output in Figure 2
        for (int loopCount = 0; loopCount <= 2; loopCount++)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);

            // suspend the current thread for 0.5 seconds
            Thread.Sleep(500);
        }
    }

    public static void Thread2()
    {
        // loops 6 times (Process = 0 to 5)
        for (int loopCount = 0; loopCount <= 5; loopCount++)
        {
            Thread thread = Thread.CurrentThread;
            Console.WriteLine("Name of Thread: " + thread.Name + " Process = " + loopCount);

            // suspend the current thread for 1.5 seconds
            Thread.Sleep(1500);
        }
    }
}