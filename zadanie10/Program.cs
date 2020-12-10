using System;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            do
            {
                cki = Console.ReadKey();
                Console.WriteLine(cki.Key.ToString());
            }
            while (cki.Key != ConsoleKey.Escape);
        }
    }
}
