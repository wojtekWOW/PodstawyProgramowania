using System;
using System.Diagnostics;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int n, m;
            Console.WriteLine("Podaj zakres w którym program ma policzyc wszystkie liczby pierwsze:");
            Console.Write("Od: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("do: ");
            m = int.Parse(Console.ReadLine());

            watch.Start();
            int count = 0;
            for (int j = n; j <= m; j++)
            {
                int d = 0;
                for (int i = 1; i <= j; i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                }
                if (d == 2)
                    count++;
            }
            Console.WriteLine($"W zakresie od {n} do {m} jest {count} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            //Polecenie9b

            int nn, mm;
            Console.WriteLine("Podaj zakres w którym program ma policzyc wszystkie liczby pierwsze:");
            Console.Write("Od: ");
            nn = int.Parse(Console.ReadLine());
            Console.Write("do: ");
            mm = int.Parse(Console.ReadLine());

            watch.Restart();
            int countt = 0;
            for (int j = nn; j <= mm; j++)
            {
                int d = 0;
                for (int i = 2; i <= Math.Floor(Math.Sqrt(j)); i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                    if (d == 1)
                        break;
                }
                if (d == 0)
                    countt++;
            }
            Console.WriteLine($"W zakresie od {nn} do {mm} jest {countt} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
