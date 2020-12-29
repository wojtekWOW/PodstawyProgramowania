using System;
using System.Diagnostics;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();

            //Polecenie 4,1 Stworzenie tablicy   
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

            //Wyświetlenie nie posortowanej tablicy
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write(array[i]+" ");
            //}
            //Console.WriteLine();

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

            //Polecenie 4,2 Sortowanie bombelkowe usprawnienie 1,2,3

            watch.Start();
            int tempj, tempk;
            for (; ; )
            {
                int l = 0;
                int r = arrayLength - 1;
                bool zamiana = false;
                for (int j = l; j <= r; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempj = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempj;
                        zamiana = true;
                    }
                    r = r - 1;
                    for (int k = r; k >= 1; k--)
                    {
                        if (array[k] > array[k + 1])
                        {
                            tempk = array[k];
                            array[k] = array[k + 1];
                            array[k + 1] = tempk;
                            zamiana = true;
                        }
                        l = l + 1;
                    }
                }
                if (!zamiana)
                    break;
            }

            //wyswietlenie posortowanej tablicy
            for (int i = 0; i < arrayLength; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            watch.Stop();

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

            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine(); ;
        }
    }
}
