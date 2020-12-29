using System;
using System.Diagnostics;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch;
            watch = new Stopwatch();

            //Polecenie 1 Stworzenie tablicy   //polecenie 1,2,3
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
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            //Sortowanie bombelkowe
            watch.Start();
            int tempj;
            for (int i = 0; i <= arrayLength - 2; i++)
            {
                for (int j = 0; j <= arrayLength - 2; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        tempj = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tempj;
                    }
                }
            }

            //Wyswietlenie posortowanej tablicy
            for (int i = 0; i < arrayLength; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            watch.Stop();
            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();



            //Sprawdzenie czy niemalejace

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
        }
    }
}
