using System;
using System.Threading;
using System.Diagnostics;
namespace ThreadPooling
{
    //-----------------------------------------------------------------------------------------------
    // ØVELSE 0-1-2 BESVARELSE
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Stopwatch mywatch = new Stopwatch();
    //        Console.WriteLine("Thread Pool Execution");
    //        mywatch.Start();
    //        ProcessWithThreadPoolMethod();
    //        mywatch.Stop();
    //        Console.WriteLine("Time consumed by ProcessWithThreadPoolMethod is : " + mywatch.ElapsedTicks.ToString());
    //        mywatch.Reset();
    //        Console.WriteLine("Thread Execution");
    //        mywatch.Start();
    //        ProcessWithThreadMethod();
    //        mywatch.Stop();
    //        Console.WriteLine("Time consumed by ProcessWithThreadMethod is : " + mywatch.ElapsedTicks.ToString());
    //    }
    //    static void ProcessWithThreadPoolMethod()
    //    {
    //        for (int i = 0; i <= 10; i++)
    //        {
    //            ThreadPool.QueueUserWorkItem(Process);
    //        }
    //    }
    //    static void ProcessWithThreadMethod()
    //    {
    //        for (int i = 0; i <= 10; i++)
    //        {
    //            Thread obj = new Thread(Process);
    //            obj.Start();
    //        }
    //    }
    //    static void Process(object callback)
    //    {
    //        for (int i = 0; i < 100000; i++)
    //        {
    //            for (int j = 0; j < 100000; j++)
    //            {
    //            }
    //        }
    //    }
    //}
    // ØVELSE 1 svar:
    // Process metoden skal tage et object som parameter for det er krævet af ThreadPool.QueueUserWorkItem


    //ØVELSE 2 svar:
    // Umiddelbart sker der ikke rigtigt nogen ændring i mine tider

    //Svar med en tom Process metode
    /*
    Thread Pool Execution
    Time consumed by ProcessWithThreadPoolMethod is : 267930
    Thread Execution
    Time consumed by ProcessWithThreadMethod is : 1219250
    */

    //Svar med indhold i Process metoden
    /*
     Thread Pool Execution
    Time consumed by ProcessWithThreadPoolMethod is : 125726
    Thread Execution
    Time consumed by ProcessWithThreadMethod is : 1304149
    */
    // Tallene varierer dog for hver gang jeg kører programmet

    // Med det andet for loop i blev det meget tydeligt at ThreadPool er meget hurtigere
    //-----------------------------------------------------------------------------------------------


    //-----------------------------------------------------------------------------------------------
    // ØVELSE 3 svar:
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        ThreadPool.QueueUserWorkItem(Process);
    //        ThreadPool.QueueUserWorkItem(Process2);
    //        Console.Read();
    //    }

    //    static void Process(object callback)
    //    {
    //        Thread th = Thread.CurrentThread;

    //        Console.WriteLine("{0}: isAlive - {1}", th.ManagedThreadId, th.IsAlive);
    //        Console.WriteLine("{0}: IsBackground - {1}", th.ManagedThreadId, th.IsBackground);
    //        Console.WriteLine("{0}: Priority - {1}", th.ManagedThreadId, th.Priority);

    //    }
    //    static void Process2(object callback)
    //    {
    //        Thread th = Thread.CurrentThread;

    //        //th.Priority = ThreadPriority.Highest;
    //        Console.WriteLine("{0}: isAlive - {1}", th.ManagedThreadId, th.IsAlive);
    //        Console.WriteLine("{0}: IsBackground - {1}", th.ManagedThreadId, th.IsBackground);
    //        Console.WriteLine("{0}: Priority - {1}", th.ManagedThreadId, th.Priority);
    //    }
    //}
    //-----------------------------------------------------------------------------------------------

}