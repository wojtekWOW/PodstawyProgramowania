using System;
using System.Diagnostics;

namespace zadanie12i13
{
    class Program
    {
        /// <summary>
        /// Oblicza ciąg fibonacciego w sposób rekurencyjny
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Liczba fib</returns>
        public static long fib(int n) 
        {            
            if (n == 1 || n == 2) return 1;
            else return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            for (int i = 2; i <= 50; i++)
            {
                watch.Restart();
                Console.Write($"{i} liczba ciagu fib to: {fib(i)}, obliczono w czasie: ");
                watch.Stop();
                Console.WriteLine(watch.Elapsed);
            }
        }
    }
}
