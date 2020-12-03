using System;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {            
            int n, m;

            Console.WriteLine("Podaj dla jakiego zakresu liczb obliczyc silnie.");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            for (int i = n; i <= m; i++)
            {
                Console.WriteLine(i + "! = " + i.silnia2());  
            }
        }
    }
}
