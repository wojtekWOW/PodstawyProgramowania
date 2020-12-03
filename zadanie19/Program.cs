using System;

namespace zadanie19
{
    class Program
    {
        public static int[] CreateArray(int arrayLength)
        {
            int[] array1 = new int[arrayLength];
            int randomNumber1;
            for (int i = 0; i < arrayLength; i++)
            {
                Random number1 = new Random();
                randomNumber1 = number1.Next(0, 4 * arrayLength);
                array1[i] = randomNumber1;
            }
            return array1;
        }               
        
        static void Main(string[] args)
        {
            int array1Length;
            Console.WriteLine("Podaj rozmiar tablicy:");
            array1Length = int.Parse(Console.ReadLine());

            int[] array1 = CreateArray(array1Length);

            array1.DisplayArray(array1Length);
            array1.CheckSorted(array1Length);
            array1.GnomSort(array1Length);
            array1.DisplayArray(array1Length);
            array1.CheckSorted(array1Length);
        }
    }
}
