using System;
using System.Diagnostics;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polecenie 8 Usprawniony algorytm zliczania
            Stopwatch watch;
            watch = new Stopwatch();
            //Polecenie 8,1 Stworzenie tablicy   
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

            //Wypisanie tablicy nie posortowanej
            //for (int i = 0; i < array1Length; i++)
            //{
            //    Console.Write(array1[i] + " ");
            //}
            //Console.WriteLine();

            //Sprawdzenie czy nie malejace
            for (int i = 0; i < array1Length - 1; i++)
            {
                if (array1[i] > array1[i + 1])
                {
                    Console.WriteLine("Porządek liczb nie jest niemalejący ");
                    break;
                }
                else if (i == array1Length - 2)
                {
                    Console.WriteLine("Porządek liczb jest niemalejący ");
                }
            }

            //Polecenie 8,2 Sortowanie przez wybieranie ulepszone 
            watch.Restart();
            int tempj;
            int position;
            for (int n = 0; n < array1Length - 1; n++)
            {
                position = n;
                for (int i = n + 1; i < array1Length; i++) // zle w instrukcji
                {
                    if (array1[i] < array1[position])
                    {
                        tempj = array1[n];
                        array1[n] = array1[i];
                        array1[i] = tempj;

                    }
                }
            }
            watch.Stop();

            //wyswietlenie posortowanej tablicy
            //for (int i = 0; i < array1Length; i++)
            //    Console.Write(array1[i] + " ");
            //Console.WriteLine();

            //Sprawdzenie czy nie malejace
            for (int i = 0; i < array1Length - 1; i++)
            {
                if (array1[i] > array1[i + 1])
                {
                    Console.WriteLine("Porządek liczb nie jest niemalejący ");
                    break;
                }
                else if (i == array1Length - 2)
                {
                    Console.WriteLine("Porządek liczb jest niemalejący ");
                }
            }

            Console.WriteLine("Czas : {0}", watch.Elapsed);
            Console.WriteLine();            
        }
    }
}
