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
            
            for (int i = 0; i < scientific_notation.Length; i++)
            {
                if (Char.IsLetter(scientific_notation[i]) && !scientific_notation[i].Equals('E') && !scientific_notation[i].Equals(',') && !scientific_notation[i].Equals('-') && !scientific_notation[i].Equals('+'))
                    scientific_notation = scientific_notation.Replace(scientific_notation[i], '?');
            }
            string[] stringNumbers = scientific_notation.Split('?');
            var stringNumbersList = stringNumbers.ToList();
            var predicate = new Predicate<string>(isEmpty);
            var filteredNumbersList = stringNumbersList.RemoveAll(predicate);
            stringNumbers = stringNumbersList.ToArray();                      

            for (int i=0; i<stringNumbers.Length;i++)
            {
                double b = Double.Parse(stringNumbers[i], style: NumberStyles.Float);
                Console.WriteLine(b);
            }

            static bool isEmpty(string a)
            {
                if (a.Equals(""))
                    return 1 > 0;
                else return 1 < 0;
            }
        }
    }
}
