using System;
using System.Diagnostics;
using System.Linq;

namespace zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();

            #region Stworzenie tablicy   
            int arrayLength;
            Console.WriteLine("Podaj rozmiar tablicy:");
            arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];
            int randomNumber;

            for (int i = 0; i < arrayLength; i++)
            {
                Random number = new Random();
                randomNumber = number.Next(0, 4 * arrayLength);
                array[i] = randomNumber;
            }
            #endregion
            #region Wypisanie tablicy nie posortowanej
            //Wypisanie tablicy nie posortowanej
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            #endregion
            #region Sprawdzenie czy nie malejace
            //Sprawdzenie czy nie malejace
            //for (int i = 0; i < arrayLength - 1; i++)
            //{
            //    if (array[i] > array[i + 1])
            //    {
            //        Console.WriteLine("Porządek liczb nie jest niemalejący ");
            //        break;
            //    }
            //    else if (i == arrayLength - 2)
            //    {
            //        Console.WriteLine("Porządek liczb jest niemalejący ");
            //    }
            //}
            #endregion

            watch.Start();
            int k = array.Max()-array.Min();
            
            int[] count = new int[array.Max() +1];

            for (int i = 0; i < array.Length; i++)
            {                
                int value = array[i];
                count[value]++;
            }

            for (int i = 1; i <= array.Max(); i++)
            {
                count[i] += count[i - 1];
            }

            int[] sorted = new int[array.Max()];
                        
            for (int i = array.Length - 1; i >= 0; --i)
                    sorted[--count[array[i]]] = array[i];
            
            watch.Stop();

            //wyswietlenie posortowanej tablicy
            for (int i = 0; i < array.Length; i++)
                Console.Write(sorted[i] + " ");
            Console.WriteLine();

            #region Sprawdzenie czy nie malejace
            //Sprawdzenie czy nie malejace
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (sorted[i] > sorted[i + 1])
                {
                    Console.WriteLine("Porządek liczb nie jest niemalejący ");
                    break;
                }
                else if (i == arrayLength - 2)
                {
                    Console.WriteLine("Porządek liczb jest niemalejący ");
                }
            }
            #endregion

            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();
        }
    }
}
