using System;
using System.Globalization;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            #region 1
            //Polecenie 1a Euklides odejmowanie

            /*
            int a, b, A, B;
            
            Console.WriteLine("Podaj dwie liczby:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            

            A = a;
            B = b;
            
            
            while (a!=b)
            {
                
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine($"NWD liczb {A} i {B} to {a}");
            
            
            
            Console.WriteLine();
            

            //Polecenie 1b Euklides reszta z dzielenia
            
            int q, w, r, Q, W;

            Console.WriteLine("Podaj dwie liczby:");
            q = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());

            
            Q = q;
            W = w;

            
            while (w != 0)
            {
                r = q % w;
                q = w;
                w = r;
            }
            Console.WriteLine($"NWD liczb {Q} i {W} to {q}");
            
            
            */

            //Polecenie 3a i 4 Liczby wzglednie pierwsze n-random
            /*
            
            */
            #endregion

            


            //Polecenie 7

            /*
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
                if (d==2)
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
            */


            //Polecenie 8

           
            

            //Polecenie 9
            /*
            
            */

            //Polecenie 11
            /*
            int i, j, n, start;
            int[] array = new int[60000];
            Console.WriteLine("Podaj ile liczba pierwszych mam znaleźć :");
            n = int.Parse(Console.ReadLine());
            Console.Write("Od jakiej liczby mam zacząćszukać?: ");
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
            */
        }
    }
}
