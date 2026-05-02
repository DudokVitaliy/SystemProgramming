using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelMathApp
{
    internal class Program
    {
        static long factorial = 1;

        static void Task1_Factorial(int n)
        {
            Parallel.For(1, n + 1, i =>
            {
                lock ("f")
                {
                    factorial *= i;
                }
            });

            Console.WriteLine($"Factorial: {factorial}");
        }
        static void Task2_Digits(int number)
        {
            int sum = 0;
            int count = 0;

            Parallel.Invoke(
                () =>
                {
                    int temp = number;
                    while (temp > 0)
                    {
                        sum += temp % 10;
                        temp /= 10;
                    }
                },
                () =>
                {
                    int temp = number;
                    while (temp > 0)
                    {
                        count++;
                        temp /= 10;
                    }
                }
            );

            Console.WriteLine($"Digits: {count}");
            Console.WriteLine($"Sum: {sum}");
        }
        static void Task3_Table(int from, int to)
        {
            string path = "table.txt";
            File.WriteAllText(path, "");

            Parallel.For(from, to + 1, i =>
            {
                for (int j = 1; j <= 10; j++)
                {
                    string line = $"{i} * {j} = {i * j}\n";

                    lock ("file")
                    {
                        File.AppendAllText(path, line);
                    }
                }
            });

            Console.WriteLine("Table saved to file");
        }
        static void Task4_ListFactorials(int[] numbers)
        {
            Parallel.ForEach(numbers, n =>
            {
                long fact = 1;

                for (int i = 1; i <= n; i++)
                    fact *= i;

                Console.WriteLine($"{n}! = {fact}");
            });
        }
        static void Task5_PLINQ(int[] numbers)
        {
            var sum = numbers.AsParallel().Sum();
            var max = numbers.AsParallel().Max();
            var min = numbers.AsParallel().Min();

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
        static void Main(string[] args)
        {
            Task1_Factorial(5);

            Task2_Digits(12345);

            Task3_Table(5, 8);

            int[] arr = { 3, 4, 5, 6 };

            Task4_ListFactorials(arr);

            Task5_PLINQ(arr);

            Console.ReadLine();
        }
    }
}
