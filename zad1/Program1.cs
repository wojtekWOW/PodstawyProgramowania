using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program1
    {
        
        
        static void Main(string[] args)
        {
            //Polecenie 1 Stworzenie tablicy   
            int arrayLength;
            Console.WriteLine("Podaj rozmiar tablicy:");
            arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];
            int randomNumber;

            for (int i = 0; i < arrayLength; i++)
            {
                Random number = new Random();
                randomNumber = number.Next(0, 4*arrayLength);
                array[i] = randomNumber;
            }

            //Wyświetlenie nie posortowanej tablicy
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine();


            
            #region Polecenie 10 niedokonczone
            /*
            
            */
            #endregion
            
        }
    }
}
