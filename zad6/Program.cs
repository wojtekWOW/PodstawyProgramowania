using System;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg liczb rozdzielonych przecinkami");
            string input = Console.ReadLine();           

            string[] stringNumbers = input.Split(',');            
            int[] intNumbers = new int[stringNumbers.Length];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                intNumbers[i] = int.Parse(stringNumbers[i]);
                Console.Write(intNumbers[i]+" ");
                Console.WriteLine(intNumbers[i] * intNumbers[i]);
            }
        }
    }
}
