using System;
using System.Threading;

class FibonacciCounter
{
    public int n1 = 1;
    public int n2 = 1;
    public int evenCount = 0;

    private object lockObj = new object();

    public void Next(int threadId)
    {
        for (int i = 0; i < 10; i++)
        {
            Monitor.Enter(lockObj);

            try
            {
                int next = n1 + n2;

                n1 = n2;
                n2 = next;

                if (n2 % 2 == 0)
                    evenCount++;

                Console.WriteLine(
                    $"Thread {threadId} | " +
                    $"n1={n1}, n2={n2}, even={evenCount}"
                );
            }
            finally
            {
                Monitor.Exit(lockObj);
            }

            System.Threading.Thread.Sleep(100);
        }
    }
}