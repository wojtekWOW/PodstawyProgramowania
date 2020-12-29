using System;

namespace zad2
{
    class Program
    {
        static double Log(int x,int p)
        {
            return Math.Log10(x) / Math.Log10(p);
        }
        static void Main(string[] args)
        {
            Console.Write("Podaj podstawe logarytmu:");
            int a= int.Parse(Console.ReadLine());

            //a
            for (int i = 16; i <= 256; i += 16)
            {
                Console.WriteLine($"Log o podstawie {a} liczby {i} wynosi: {Math.Log10(i) / Math.Log10(a)}");
            }
            Console.WriteLine();
            //b
            for (int i =16; i <=256; i+=16)
            {                
                Console.WriteLine($"Log o podstawie {a} liczby {i} wynosi: {Log(i, a)}");
            }
            Console.WriteLine();
            //c
            for (int i = 16; i <= 256; i += 16)
            {
                Console.WriteLine($"Log o podstawie {a} liczby {i} wynosi: {i.Log(a)}");
            }
        }
        
        
    }
}
