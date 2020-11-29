using System;

namespace zadanie18
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
        private static void DisplayArray(int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        private static void CheckSorted(int arrayLength, int[] array)
        {
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    Console.WriteLine("Tablica nie jest posortowana ");
                    break;
                }
                else if (i == arrayLength - 2)
                {
                    Console.WriteLine("Tablica jest posortowana ");
                }
            }
        }
        private static void GnomSort(int arrayLength, int[] array)
        {
            int p1 = 0;
            int tempp1;
            while (p1 < arrayLength - 1)
                if (array[p1] > array[p1 + 1])
                {
                    tempp1 = array[p1];
                    array[p1] = array[p1 + 1];
                    array[p1 + 1] = tempp1;
                    if (p1 > 0)
                        p1--;
                }
                else
                    p1++;
        }
        static void Main(string[] args)
        {
            int array1Length;
            Console.WriteLine("Podaj rozmiar tablicy:");
            array1Length = int.Parse(Console.ReadLine());

            int[] array1 = CreateArray(array1Length);

            DisplayArray(array1Length, array1);
            CheckSorted(array1Length, array1);
            GnomSort(array1Length, array1);
            DisplayArray(array1Length, array1);
            CheckSorted(array1Length, array1);
        }
    }
}
