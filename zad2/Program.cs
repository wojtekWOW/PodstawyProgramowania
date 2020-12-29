using System;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 2

            int a;
            int[] tab1 = new int[10];        
        
            for (int j = 0; j < 10; j++)
            { 
                tab1[j] = 9-j;
            Console.WriteLine(" tablica o indeksie " +j + " to " + tab1[j]);
            }
        }
    }
}
