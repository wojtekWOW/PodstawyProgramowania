using System;
using System.IO;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamReader text = new StreamReader(Path.Combine(Pulpit, "liczby.txt"));
            while (!text.EndOfStream)
            {
                int textLine;
                bool parse = int.TryParse(text.ReadLine(), out textLine);
                Console.Write(textLine+" ");
                Console.WriteLine(textLine*textLine);
            }
        }
    }
}
