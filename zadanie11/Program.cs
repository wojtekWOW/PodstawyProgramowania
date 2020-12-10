using System;
using System.Threading;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
            Nullable <int> a=null;
            Nullable <int> b = null;
            for (; ;)
            {                
                char x = '\n';
                bool parse = char.TryParse(Console.ReadLine(), out x);

                if (x == '?')
                    DisplayMenu();
                else if (Char.IsDigit(x) && (!(a.HasValue)))                    
                    a = int.Parse(x.ToString()); 
                else if (Char.IsDigit(x) && (a.HasValue)&& !(b.HasValue))
                    b = int.Parse(x.ToString());
                else if (Char.IsDigit(x) && (a.HasValue) && (b.HasValue))
                {
                    a = int.Parse(x.ToString());
                    b = null;
                }

                else if (x == '+')
                {
                    if ((a.HasValue) && (b.HasValue))
                    {
                        Console.WriteLine(Sum(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (x == '-')
                {
                    if (a.HasValue && b.HasValue)
                    {
                        Console.WriteLine(Substract(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (x == '*')
                {
                    if (a.HasValue && b.HasValue)
                    {
                        Console.WriteLine(Multiply(a, b));
                        ClearConsole();
                    }
                    else
                        Console.WriteLine("Podaj liczbę");
                }

                else if (x == 'x')
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
            return (int)a+(int)b;
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
