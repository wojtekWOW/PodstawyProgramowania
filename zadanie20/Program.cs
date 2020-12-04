using System;

namespace zadanie20
{
    class Program
    {
        //Define delegate method signature => takes an array and arrayLength as parameters and returns a new sorted array 
        public delegate int[] Sort(int[] array, int arrayLength);

        /// <summary>
        /// Creates a new random array
        /// </summary>
        /// <param name="arrayLength">Length of an array</param>
        /// <returns>Random array</returns>
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

        static void Main(string[] args)
        {
            int array1Length;
            Console.WriteLine("Podaj rozmiar tablicy:");
            array1Length = int.Parse(Console.ReadLine());

            //Create new random array
            int[] array1 = CreateArray(array1Length);

            array1.DisplayArray(array1Length);
            array1.CheckSorted(array1Length);

            //Create delegate method to sort an array => odd numbers to the left, even numbers to the right
            Sort sortEven = new Sort(ExtendingClass.EvenSort);
            int[] finalarray1 = sortEven(array1, array1Length);            
            finalarray1.DisplayArray(array1Length);
            finalarray1.CheckSorted(array1Length);

            //Create delegate method to sort an array => GnomSort=>
            Sort sortGnom = new Sort(ExtendingClass.GnomSort);
            int[] finalarray2 = sortGnom(array1, array1Length);
            finalarray2.DisplayArray(array1Length);
            finalarray2.CheckSorted(array1Length);
        }
    }
}
