using System;
using System.Diagnostics;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();

            //Polecenie 9,1 Stworzenie tablicy   
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

            //Wypisanie tablicy nie posortowanej
            //for (int i = 0; i < arrayLength; i++)
            //{
            //    Console.Write(array[i] + " ");
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

            watch.Start();
            //Polecenie 9,2 Sortowanie bogosort
            bool ready;
            int temp;
            int randomIndex;

            for (; ; )
            {
                ready = true;
                for (int i = 0; i < arrayLength - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        ready = false;
                        break;
                    }
                }
                if (ready) break;
                for (int i = arrayLength - 1; i >= 0; i--)
                {
                    Random number = new Random();
                    randomIndex = number.Next(0, arrayLength - 1);

                    temp = array[i];
                    array[i] = array[randomIndex];
                    array[randomIndex] = temp;
                }
            }
            watch.Stop();

            //wyswietlenie posortowanej tablicy
            //for (int i = 0; i < arrayLength; i++)
            //    Console.Write(array[i] + " ");
            //Console.WriteLine();

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
            Console.WriteLine();
        }
    }
}
