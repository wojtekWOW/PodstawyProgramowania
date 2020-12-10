using System;
using System.Collections.Generic;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            List <string> numbers = new List<string>();
            Console.WriteLine("Podaj ciąg liczb rozdzielonych przecinkami");
            string input = Console.ReadLine();

            while (input.Contains(','))
            {
                numbers.Add(input.Substring(0, input.IndexOf(',')));
                input = input.Remove(0, input.IndexOf(',') + 1);
            }

            foreach( string number in numbers)
            {
                Console.WriteLine(int.Parse(number) + " " + (int.Parse(number)*int.Parse(number)));
            }

            if(input.Length>0)
            Console.WriteLine(int.Parse(input) + " " + (int.Parse(input) * int.Parse(input)));
        }
    }
}
