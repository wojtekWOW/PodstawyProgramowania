using System;
using System.Globalization;
using System.Linq;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków zawierający litery i cyfry w notacji naukowej");
            string scientific_notation = Console.ReadLine();
            
            //check if char is a number and replace letter with "?"
            for (int i = 0; i < scientific_notation.Length; i++)
            {
                if (Char.IsLetter(scientific_notation[i]) && !scientific_notation[i].Equals('E') && !scientific_notation[i].Equals(',') && !scientific_notation[i].Equals('-') && !scientific_notation[i].Equals('+'))
                    scientific_notation = scientific_notation.Replace(scientific_notation[i], '?');
            }

            //Split input string to create array of strings 
            string[] stringNumbers = scientific_notation.Split('?');

            //Crate list from array of strings
            var stringNumbersList = stringNumbers.ToList();

            //Remove empty strings from list
            var predicate = new Predicate<string>(isEmpty);
            var filteredNumbersList = stringNumbersList.RemoveAll(predicate);

            //Change list back to array
            stringNumbers = stringNumbersList.ToArray();                      

            //Display numbers
            for (int i=0; i<stringNumbers.Length;i++)
            {
                double b = Double.Parse(stringNumbers[i], style: NumberStyles.Float);
                Console.WriteLine(b);
            }

            //Criteria method for checking if string in List of strings is empty
            static bool isEmpty(string a)
            {
                if (a.Equals(""))
                    return 1 > 0;
                else return 1 < 0;
            }
        }
    }
}
