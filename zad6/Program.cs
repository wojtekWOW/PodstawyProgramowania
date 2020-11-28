using System;

namespace zad6
{
    class Program
    {   
        /// <summary>
        /// Losuje losowe liczby i sprwdza czy są względnie pierwsze
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public static void DrawRandomNumbers(int n, int m)
        {
            RandomNumbers rand1 = new RandomNumbers();
            RandomNumbers rand2 = new RandomNumbers();
            Counters drawingLoop = new Counters();
            Counters insideLoop = new Counters();
            int l=0;
            while (l != 1)
            {
                drawingLoop.counter++;

                Random liczba1 = new Random();
                rand1.value = liczba1.Next(n, m);

                Random liczba2 = new Random();
                rand2.value = liczba2.Next(n, m);

                rand1.DrawnValue = rand1.value;
                rand2.DrawnValue = rand2.value;
                               
                CheckRelativePrime(rand1.value, rand2.value,insideLoop.counter);
                
                //int r;                
                //while (rand2.value != 0)
                //{
                //    r = rand1.value % rand2.value;
                //    rand1.value = rand2.value;
                //    rand2.value = r;
                //    insideLoop.counter++;
                //}

                l = rand1.value;
            }
            Console.WriteLine($"NWD liczb {rand1.DrawnValue} i {rand2.DrawnValue} to {rand1.value}");
            Console.WriteLine($"Petla wewnętrzna wykonala sie  {insideLoop.counter} razy");
            Console.WriteLine($"Petla losująca liczbę wykonala sie  {drawingLoop.counter} razy");
        }
        
        /// <summary>
        /// Sprawdza czy liczby są wzglednie pierwsze
        /// </summary>
        /// <param name="rand1"></param>
        /// <param name="rand2"></param>
        /// <param name="p"></param>
        public static void CheckRelativePrime(int a, int b, int p)
        {
            int r;
            p = 0;
            while (b != 0)
            {                
                r = a % b;
                a = b;
                b = r;
                p++;
            }
        }
        
        static void Main(string[] args)
        {            
            int n,m;            

            Console.WriteLine("Podaj zakres liczb:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            
            DrawRandomNumbers(n,m); 
        }               
    }
}
