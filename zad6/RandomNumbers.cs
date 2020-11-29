using System;

namespace zad6
{
    public class RandomNumbers
    {
        public int value;
        public int DrawnValue;
        public int r=0;

        /// <summary>
        /// Sprawdza czy liczby są wzglednie pierwsze
        /// </summary>
        /// <param name="rand1"></param>
        /// <param name="rand2"></param>
        /// <param name="p"></param>
        public static void CheckRelativePrime(ref int a, ref int b, ref int p)
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

        /// <summary>
        /// Losuje losowe liczby i sprwdza czy są względnie pierwsze
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public static void DrawRandomNumbers(int n, int m, ref RandomNumbers rand1, ref RandomNumbers rand2, 
                                             ref Counters drawingLoop, ref Counters insideLoop)
        {            
            int l = 0;
            while (l != 1)
            {
                drawingLoop.counter++;

                Random liczba1 = new Random();
                rand1.value = liczba1.Next(n, m);

                Random liczba2 = new Random();
                rand2.value = liczba2.Next(n, m);

                rand1.DrawnValue = rand1.value;
                rand2.DrawnValue = rand2.value;

                RandomNumbers.CheckRelativePrime(ref rand1.value, ref rand2.value, ref insideLoop.counter);

                l = rand1.value;
            }            
        }
    }    
    
    public class Counters
    {
        public int counter = 0;
    }
}
