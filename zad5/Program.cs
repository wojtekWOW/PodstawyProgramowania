using System;
using System.Linq;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polecenie 5
            
            int a, sum = 0;
            int[,] tab1 = new int[4, 6];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Random liczba = new Random();
                    a = liczba.Next(100, 1000);
                    tab1[i, j] = a;
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //5.1
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                     sum += tab1[i, j];
                }
            }
            Console.WriteLine("suma liczb w tablicy = " + sum);
            Console.WriteLine();

            //5,2
            int max = tab1.Cast<int>().Max();
            Console.WriteLine("Najwieksza liczba w tablicy = " + max);

            //5,3          
            for (int i = 0; i < 4; i++) 
                {
                for (int j = 0; j < 6; j++) 
                    {
                    if (tab1[i, j] == max)
                    {
                        Console.WriteLine("Indeks najwiekszej liczby to i: {0}, j: {1}", i, j);
                    }
                }
            }
            Console.WriteLine();

            //5,4
            int min = tab1.Cast<int>().Min();
            Console.WriteLine("Najmniejsza liczba w tablicy = " + min);

            //5,5
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tab1[i, j] == min)
                    {
                        Console.WriteLine("Indeks najmniejszej liczby to i: {0}, j: {1}", i, j);
                    }
                }
            }
            Console.WriteLine();

            //5,6
            int[,] tab2 = new int[6, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tab2[j, i] = tab1[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < 6; j++) 
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(tab2[j, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();            
        }
    }
}
