using System;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polcenie 4
            
            int a;
            int[,] tab1 = new int[4,6];
            for (int i =0; i<4; i++)
            {
                for (int j=0; j<6; j++)
                {
                    Random liczba = new Random();
                    a = liczba.Next(100, 1000);
                    tab1[i, j] = a;
                    Console.Write(tab1[i, j] + " ");
                }
                Console.WriteLine();
            }            
        }
    }
}
