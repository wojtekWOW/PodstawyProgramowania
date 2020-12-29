using System;
using System.Diagnostics;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();

            //Najprostrza wersja
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
                if (j == 1) continue;
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


            //Pominiecie 1 i N
            Console.WriteLine();
            Console.WriteLine("Pominiecie 1 i N");
            Console.Write("Od: ");
            

            watch.Restart();
            int count1 = 0;
            for (int j = n; j <= m; j++)
            {
                if (j == 1) continue;
                int d = 0;
                for (int i = 2; i < j; i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                }
                if (d == 0)
                    count1++;
            }
            Console.WriteLine($"W zakresie od {n} do {m} jest {count1} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            //Sprawdzenie do pierwszej wpadki
            Console.WriteLine();
            Console.WriteLine("Sprawdzenie do pierwszej wpadki");
            
            watch.Restart();
            int count2 = 0;
            for (int j = n; j <= m; j++)
            {
                if (j == 1) continue;
                int d = 0;
                for (int i = 2; i < j; i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                    if (d > 0)
                        break;
                }
                if (d == 0)
                    count2++;
            }
            Console.WriteLine($"W zakresie od {n} do {m} jest {count2} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            //Sprawdzenie do sqrt(n)

            Console.WriteLine();
            Console.WriteLine("Sprawdzenie do sqrt(n)");            

            watch.Restart();
            int count3 = 0;
            for (int j = n; j <= m; j++)
            {
                if (j == 1) continue;
                int d = 0;
                for (int i = 2; i <= Math.Floor(Math.Sqrt(j)); i++)
                {
                    int a = j % i;
                    if (a == 0)
                        d += 1;
                    if (d >0)
                        break;
                }
                if (d == 0)
                    count3++;
            }
            Console.WriteLine($"W zakresie od {n} do {m} jest {count3} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            //Sito Erastotenesa
            Console.WriteLine();
            Console.WriteLine("Sito Erastotenesa");
            watch.Restart();
            int  sito;
            int count4=0;
            int[] tablica = new int[100010];  

            //inicjuj tablice
            for (int i = 1; i <= m; i++) tablica[i] = i;

            //algorytm - sito eratostenesa
            for (int i = 2; i <= Math.Floor(Math.Sqrt(m)); i++)
            {
                if (tablica[i] != 0)
                {
                    sito = i + i;
                    while (sito <= m)
                    {
                        tablica[sito] = 0;
                        sito += i;
                    }
                }
            }

            //wypisz wynik
            Console.WriteLine("Liczby pierwsze z zakresu od 1 do " + m);
            for (int i = n; i <= m; i++)
            {
                if (i == 1) continue;
                if (tablica[i] != 0)
                    count4++;
            }

            Console.WriteLine($"W zakresie od {n} do {m} jest {count4} liczb pierwszych:");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
