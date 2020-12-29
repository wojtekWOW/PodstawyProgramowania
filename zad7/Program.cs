using System;
using System.IO;

namespace zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwe pliku");
            string path = Console.ReadLine();
            if (!path.Contains(".txt"))
                path = String.Concat(path, ".txt");

            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamReader text = new StreamReader(Path.Combine(Pulpit, path));
            while (!text.EndOfStream)
            {
                int textLine;
                bool parse = int.TryParse(text.ReadLine(), out textLine);
                Console.Write(textLine + " ");
                Console.WriteLine(textLine * textLine);
            }
        }
    }
}
