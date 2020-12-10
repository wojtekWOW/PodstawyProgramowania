using System;
using System.Threading;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            Nullable<int> a = null;
            Nullable<int> b = null;

            ConsoleKeyInfo cki;

            for (; ; )
            {
                cki = Console.ReadKey();
                              
                int key;
                bool parse = int.TryParse(cki.Key.ToString(), out key);

                if (cki.Key == ConsoleKey.Oem2)
                    DisplayMenu();
                else if ((parse==true) && (!(a.HasValue)))
                    a = key;
                else if ((parse == true) && (a.HasValue))
                    b = key;
                else if (cki.Key == ConsoleKey.Add)
                {
                    if ((a.HasValue) && (b.HasValue))
                    {
                        Console.WriteLine(Sum(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (cki.Key == ConsoleKey.Subtract)
                {
                    if (a.HasValue && b.HasValue)
                    {
                        Console.WriteLine(Substract(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (cki.Key == ConsoleKey.Multiply)
                {
                    if (a.HasValue && b.HasValue)
                    {
                        Console.WriteLine(Multiply(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (cki.Key == ConsoleKey.Escape)
                    break;
            }
        }
        /// <summary>
        /// Wait 2 seconds and clear console after displaying results.
        /// </summary>
        private static void ClearConsole()
        {
            Thread.Sleep(3000);
            Console.Clear();
        }

        private static int Multiply(int? a, int? b)
        {
            return (int)a * (int)b;
        }

        private static int Substract(int? a, int? b)
        {
            return (int)a - (int)b;
        }

        private static int Sum(int? a, int? b)
        {
            return (int)a + (int)b;
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("------------");
            Console.WriteLine("    Menu    ");
            Console.WriteLine("------------");
            Console.WriteLine("? - wyświetl menu");
            Console.WriteLine("a(liczba) - wczytaj pierwszą liczbę");
            Console.WriteLine("b(liczba) - wczytaj drugą liczbę");
            Console.WriteLine("+ - dodaj liczby");
            Console.WriteLine("- - odejmij liczby");
            Console.WriteLine("* - pomnóż liczby");
            Console.WriteLine("x - zakończ program");
        }
    }
}
