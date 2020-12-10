using System;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg liczb rozdzielonych przecinkami lub spacjami");
            string input = Console.ReadLine();
            
            string[] stringNumbers = input.Split(',');
            for(int i =0; i<stringNumbers.Length;i++)
            {
                int index;
                if (stringNumbers[i].Contains(' '))
                {
                    index = stringNumbers[i].IndexOf(' ');
                    char[] chars = stringNumbers[i].ToCharArray();
                    
                    chars[index] = '0';
                    string a = new string(chars);
                    stringNumbers[i] = a;                    
                }
            }

            int[] intNumbers = new int[stringNumbers.Length];
            for (int i = 0; i < stringNumbers.Length; i++)
            {
                bool parse = int.TryParse(stringNumbers[i], out intNumbers[i]);                
                    
                Console.Write(intNumbers[i]+" ");
                Console.WriteLine(intNumbers[i] * intNumbers[i]);
            }
        }         
    }
}
