using System;
using System.Text.RegularExpressions;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków zawierający litery i cyfry");
            string LettersAndDigits = Console.ReadLine();
            char[] CharArray = LettersAndDigits.ToCharArray();
            string[] NumbersArray = new string[CharArray.Length];
            int [] intNumbersArray = new int[NumbersArray.Length];
            int a=0;
            int i, j=0;

            for (i = a; i < CharArray.Length; i++)
                {
                    if (Char.IsDigit(CharArray[i]))
                    {
                        NumbersArray[j] += CharArray[i].ToString();
                    }
                    else if (!Char.IsDigit(CharArray[i]))
                    {
                        a = i;
                        j++;
                    }
                }

            for (int k = 0; k < NumbersArray.Length; k++)
            {                
                bool parse = int.TryParse(NumbersArray[k],out intNumbersArray[k]);
                    if(intNumbersArray[k]!=0)
                    Console.WriteLine(intNumbersArray[k]);
            }                
        }        
    }
}
