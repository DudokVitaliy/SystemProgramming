using System;
using System.Threading;

class Program
{
    static void Main()
    {
        FibonacciCounter counter = new FibonacciCounter();

        Thread t1 = new Thread(() => counter.Next(1));
        Thread t2 = new Thread(() => counter.Next(2));
        Thread t3 = new Thread(() => counter.Next(3));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("\nFINISHED");
        Console.ReadLine();
    }
}