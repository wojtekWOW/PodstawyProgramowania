using System;
using System.Diagnostics;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int n = 0;
            Console.WriteLine("Podaj liczbe:");
            n = int.Parse(Console.ReadLine());

            int d = 0;
            watch.Start();
            for (int i = 1; i <= n; i++)
            {
                int a = n % i;
                if (a == 0)
                    d += 1;
            }
            if (d == 2)
                Console.WriteLine("Liczba jest pierwsza");
            else
                Console.WriteLine("Liczba nie jest pierwsza");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            //Polecenie 7 szybsze

            int nn = 0;
            Console.WriteLine("Podaj liczbe:");
            nn = int.Parse(Console.ReadLine());

            int dd = 0;
            watch.Restart();
            for (int i = 2; i < Math.Sqrt(nn); i++)
            {
                int aa = nn % i;
                if (aa == 0)
                    dd += 1;
                if (dd == 1)
                {
                    Console.WriteLine("Liczba nie jest pierwsza");
                    break;
                }
            }
            if (dd == 0)
                Console.WriteLine("Liczba jest pierwsza");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
            
        }
    }
}
