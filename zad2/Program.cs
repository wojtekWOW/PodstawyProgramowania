using System;
using System.Diagnostics;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            //Polecenie 1a Euklides odejmowanie

            
            int a, b, A, B;
            
            Console.WriteLine("Podaj dwie liczby:");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            watch.Start();

            A = a;
            B = b;
            
            int i =0;
            while (a!=b)
            {
                i++;
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            Console.WriteLine($"NWD liczb {A} i {B} to {a}");
            Console.WriteLine($"Petla wykonala sie  {i} razy");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();
            

            //Polecenie 1b Euklides reszta z dzielenia
            
            int q, w, r, Q, W;

            Console.WriteLine("Podaj dwie liczby:");
            q = int.Parse(Console.ReadLine());
            w = int.Parse(Console.ReadLine());

            watch.Restart();
            Q = q;
            W = w;

            int j =0;
            while (w != 0)
            {
                r = q % w;
                q = w;
                w = r;

                j++;
            }
            Console.WriteLine($"NWD liczb {Q} i {W} to {q}");
            Console.WriteLine($"Petla wykonala sie  {j} razy");
            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
            
        }
    }
}
