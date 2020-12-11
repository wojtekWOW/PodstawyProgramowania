
using System;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków zawierający litery i cyfry");
            string LettersAndDigits = Console.ReadLine();
            char[] CharArray = LettersAndDigits.ToCharArray();

            for (int i = 0; i < CharArray.Length; i++)
            {
                if (Char.IsDigit(CharArray[i]))
                {
                    Console.Write(CharArray[i]+" ");
                }
            }
        }
    }
}
