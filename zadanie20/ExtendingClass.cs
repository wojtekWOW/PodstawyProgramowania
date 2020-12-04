using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie20
{
    public static class ExtendingClass
    {
        public static void DisplayArray(this int[] array, int arrayLength)
        {
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
        public static void CheckSorted(this int[] array, int arrayLength)
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
        public static int[] GnomSort(this int[] array, int arrayLength)
        {
            int p1 = 0;
            int tempp1 = 0;
            while (p1 < arrayLength - 1)
            {
                if (array[p1] > array[p1 + 1])
                {
                    GnomeSort.SwapItems(ref p1, ref tempp1, ref array);
                    GnomeSort.MoveLeft(ref p1);
                }
                else
                    GnomeSort.MoveRight(ref p1);
            }
            return array;
        }
        public static int[] EvenSort(this int[] array, int arrayLength)
        {
            int p1 = 0;
            int tempp1 = 0;
            while (p1 < arrayLength - 1)
            {
                if (array[p1] % 2 == 0 && array[p1 + 1] % 2 == 1)
                {
                    GnomeSort.SwapItems(ref p1, ref tempp1, ref array);
                    GnomeSort.MoveLeft(ref p1);
                }
                else
                    GnomeSort.MoveRight(ref p1);
            }
            return array;
        }

    }
}
