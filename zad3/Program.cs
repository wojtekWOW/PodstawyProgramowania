using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków zawierający litery i cyfry");
            string LettersAndDigits = Console.ReadLine();
            char[] CharArray = LettersAndDigits.ToCharArray();
            string[] NumbersArray = new string[CharArray.Length];
            decimal[] decimalNumbersArray = new decimal[NumbersArray.Length];
            int a = 0;
            int i, j = 0;

            for (i = a; i < CharArray.Length; i++)
            {
                if (Char.IsDigit(CharArray[i])|| Char.Equals(CharArray[i],','))
                {
                    NumbersArray[j] += CharArray[i].ToString();
                }
                else 
                {
                    a = i;
                    j++;
                }
            }

            for (int k = 0; k < NumbersArray.Length; k++)
            {
                bool parse = decimal.TryParse(NumbersArray[k], out decimalNumbersArray[k]);
                if (decimalNumbersArray[k] != 0)
                    Console.WriteLine(decimalNumbersArray[k]);
            }
        }
    }
}
