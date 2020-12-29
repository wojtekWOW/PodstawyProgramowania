using System;
using System.IO;

namespace zad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku");
            string path = Console.ReadLine();
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamReader text = new StreamReader(Path.Combine(Pulpit, path));
            while (!text.EndOfStream)
            {
                int textLine;
                bool parse= int.TryParse(text.ReadLine(),out textLine);
                Console.Write(textLine + " ");
                Console.WriteLine(textLine * textLine);
            }
        }
    }
}
