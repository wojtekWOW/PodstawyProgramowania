using System;
using System.IO;


namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamReader text = new StreamReader(Path.Combine(Pulpit, "test2.txt"));
            while (!text.EndOfStream)
            {
                string textLine = text.ReadLine();
                Console.WriteLine(textLine);
            }
        }
    }
}
