using System;
using System.Diagnostics;

namespace zad7
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

            #region Wyswietlenie tablicy
            //Wyswietlenie tablicy
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            #endregion

            #region Sprawdzenie czy nie malejące
            //Sprawdzenie czy nie malejace
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] > array[i + 1])
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

            watch.Start();
            #region Sortowanie przez wybieranie
            int tempi;
            for (int n = 0; n <= arrayLength - 2; n++)
            {
                for (int i = n + 1; i <= arrayLength - 1; i++)
                {
                    if (array[i] < array[n])
                    {
                        tempi = array[i];
                        array[i] = array[n];
                        array[n] = tempi;
                    }
                }
            }
            #endregion
            watch.Stop();

            # region wyswietlenie posortowanej tablicy
            //for (int i = 0; i < arrayLength; i++)
            //    Console.Write(array[i] + " ");
            //Console.WriteLine();
            #endregion

            #region Sprawdzenie czy nie malejace
            for (int i = 0; i < arrayLength - 1; i++)
            {
                if (array[i] > array[i + 1])
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
