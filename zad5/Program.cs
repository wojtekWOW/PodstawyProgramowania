using System;
using System.Diagnostics;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            decimal[] fib = new decimal[100];
            fib[0] = 1;
            fib[1] = 1;
            int n;

            Console.WriteLine("Podaj który element (max 99) ciągu fibonacciego chcesz wyznaczyć:");

            n = int.Parse(Console.ReadLine());

            watch.Start();
            for (int i = 2; i < n; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }
            Console.WriteLine($" {n}ty element ciągu fibonacciego to: {fib[n-1]}");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
