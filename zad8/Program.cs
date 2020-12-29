using System;
using System.Diagnostics;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int nn, mm;
            Console.WriteLine("Podaj zakres w którym program ma znaleźć wszystkie liczby pierwsze:");
            Console.Write("Od: ");
            nn = int.Parse(Console.ReadLine());
            Console.Write("do: ");
            mm = int.Parse(Console.ReadLine());

            watch.Start();
            for (int j = nn; j <= mm; j++)
            {
                int d = 0;
                for (int i = 1; i <= j; i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d++;

                }
                if (d == 2)
                    Console.Write(j + " ");
            }

            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);



            //Polecenie 8b

            int ii, jj, n, range;
            int[] array = new int[60000];
            Console.WriteLine("Podaj zakres w którym program ma znaleźć wszystkie liczby pierwsze:");
            Console.Write("Od: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("do: ");
            range = int.Parse(Console.ReadLine());

            watch.Restart();
            for (ii = 1; ii <= range; ii++)
                array[ii] = ii;


            for (ii = 2; ii <= Math.Floor(Math.Sqrt(range)); ii++)
            {
                if (array[ii] != 0)
                {
                    jj = ii + ii;
                    while (jj <= range)
                    {
                        array[jj] = 0;
                        jj += ii;
                    }
                }
            }
            for (ii = n; ii <= range; ii++)
                if (array[ii] != 0)
                    Console.Write(ii + " ");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
