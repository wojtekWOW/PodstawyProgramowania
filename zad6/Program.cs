using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 6

            int a;
            int[,] tab3 = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random liczba = new Random();
                    a = liczba.Next(0, 1000);
                    tab3[i, j] = a;
                    if (tab3[i, j] < 10)
                    {
                        Console.Write("  " + tab3[i, j] + " ");
                    }
                    else if ((tab3[i, j] >= 10) && (tab3[i, j] < 100))
                    {
                        Console.Write(" " + tab3[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(tab3[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
