using System;
using System.Diagnostics;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int i, j, n, start;
            int[] array = new int[60000];
            Console.WriteLine("Podaj ile liczb pierwszych mam znaleźć :");
            n = int.Parse(Console.ReadLine());
            Console.Write("Od jakiej liczby mam zacząć szukać?: ");
            start = int.Parse(Console.ReadLine());

            watch.Start();

            int countt = 0;
            for (j = start; ; j++)
            {
                int d = 0;
                for (i = 2; i <= Math.Floor(Math.Sqrt(j)); i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                    if (d == 1)
                        break;
                }
                if (d == 0)
                {
                    array[countt] = j;
                    countt++;
                }
                if (countt == n)
                    break;
            }

            for (i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
