using System;
using System.Diagnostics;

namespace zadanie14
{    
    class Program
    {
        /// <summary>
        /// //Oblicza liczbe ciagu fibonacciego w petli
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static double fib(int f)
        {
            double n1 = 0, n2 = 1, temp_n1 = 0;
            for (int i = 0; i <= f - 2; i++)
            {
                temp_n1 = n1;
                n1 = n2;
                n2 = temp_n1 + n2;
            }
            return n2;
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
