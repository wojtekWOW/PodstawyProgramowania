using System;
using System.Diagnostics;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            int m;
            int rand3;
            int Rand3 = 0;
            int re;
            int jo = 0;
            int pe = 0;
            int el = 0;
            
            Console.WriteLine("Podaj liczbe:");
            m = int.Parse(Console.ReadLine());

            watch.Start(); 
            int M = m;
            while (el != 1)
            {
                pe++;
                Random liczba = new Random();
                rand3 = liczba.Next(m, 60000);

                         
               
                Rand3 = rand3;
                                
                while (rand3 != 0)
                {
                    re = m % rand3;
                    m = rand3;
                    rand3 = re;

                    jo++;
                }
                el = m;
            }

            Console.WriteLine($"NWD liczb {M} i {Rand3} to {m}");
            Console.WriteLine($"Petla wewnętrzna wykonala sie  {jo} razy");
            Console.WriteLine($"Petla losująca liczbę wykonala sie  {pe} razy");

            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);

            Console.WriteLine();
            
            //Polecenie 3b Liczby wzglednie pierwsze random-random
            
            int n;
            int rand1=0;
            int rand2;
            int Rand1 = 0;
            int Rand2 = 0;
            int r;
            int j = 0;
            int p = 0;
            int l = 0;

            Console.WriteLine("Podaj liczbe:");
            n = int.Parse(Console.ReadLine());

            watch.Restart();
            while (l != 1)
            {
                p++;
                Random liczba1 = new Random();
                rand1 = liczba1.Next(n, 60000);

                Random liczba2 = new Random();
                rand2 = liczba2.Next(n, 60000);

                

                Rand1 = rand1;
                Rand2 = rand2;

                while (rand2 != 0)
                {
                    r = rand1 % rand2;
                    rand1 = rand2;
                    rand2 = r;

                    j++;
                }
                l = rand1;
            }

            Console.WriteLine($"NWD liczb {Rand1} i {Rand2} to {rand1}");
            Console.WriteLine($"Petla wewnętrzna wykonala sie  {j} razy");
            Console.WriteLine($"Petla losująca liczbę wykonala sie  {p} razy");

            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
        }
    }
}
