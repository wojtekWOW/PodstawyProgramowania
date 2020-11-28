using System;

namespace zad9zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;

            Console.WriteLine("Podaj dla jakiego zakresu liczb obliczyc silnie.");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Zadanie 9, silnia liczona iteracyjnie:");
            for (int i=n; i <= m; i++)
            {                
                Console.WriteLine(i + "! = " + Silnia.silnia1(i));                
            }
            Console.WriteLine();

            Console.WriteLine("Zadanie 10, silnia liczona rekurencyjnie:");
            for (int i = n; i <= m; i++)
            {                              
                Console.WriteLine(i + "! = " + Silnia.silnia2(i));
            }
        }        
    }
}
