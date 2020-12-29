using System;
using System.Diagnostics;

namespace zad5i6
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();
            #region Stworzenie tablicy
            //Polecenie 5,1 Stworzenie tablicy   
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

            #region Wyswietelnie tablicy nieposortowanej
            //Wyświetlenie tablicy nieposortowanej
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
            //
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
            #region Sortowanie gnoma
            //Polecenie 5,2 Sortowanie gnoma

            int p = 0;
            int tempp;
            while (p < arrayLength - 1)
                if (array[p] > array[p + 1])
                {
                    tempp = array[p];
                    array[p] = array[p + 1];
                    array[p + 1] = tempp;
                    if (p > 0)
                        p--;
                }
                else
                    p++;
            #endregion
            watch.Stop();

            #region Wyswietlenie posortowanej tablicy
            //wyswietlenie posortowanej tablicy
            //for (int i = 0; i < arrayLength; i++)
            //    Console.Write(array[i] + " ");
            //Console.WriteLine();
            #endregion

            #region Sprawdzenie czy nie malejace
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

            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();

            //Polecenie 6 usprawniony gnom
            #region Stworzenie nowej tablicy

            //Polecenie 6,1 Stworzenie tablicy   
            int array1Length;
            Console.WriteLine("Podaj rozmiar tablicy:");
            array1Length = int.Parse(Console.ReadLine());

            int[] array1 = new int[array1Length];
            int randomNumber1;

            for (int i = 0; i < array1Length; i++)
            {
                Random number1 = new Random();
                randomNumber1 = number1.Next(0, 4 * array1Length);
                array1[i] = randomNumber1;
            }

            #endregion

            #region Wyświetlenie tablicy nieposortowanej
            //Wyświetlenie tablicy nieposortowanej
            //for (int i = 0; i < array1Length; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}
            //Console.WriteLine();
            //
            #endregion

            #region Sprawdzenie czy nie malejące
            ////Sprawdzenie czy nie malejace
            //for (int i = 0; i < array1Length - 1; i++)
            //{
            //    if (array1[i] > array[i + 1])
            //    {
            //        Console.WriteLine("Porządek liczb nie jest niemalejący ");
            //        break;
            //    }
            //    else if (i == array1Length - 2)
            //    {
            //        Console.WriteLine("Porządek liczb jest niemalejący ");
            //    }
            //}
            #endregion

            watch.Restart();
            #region Usprawnione sortowanie gnoma
            //Polecenie 6,2 Usprawnione sortowanie gnoma

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
            #endregion
            watch.Stop();

            #region Wyswietlenie tablicy posortowanej
            //wyswietlenie posortowanej tablicy
            //for (int i = 0; i < arrayLength; i++)
            //    Console.Write(array[i] + " ");
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

            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();
        }
    }
}
