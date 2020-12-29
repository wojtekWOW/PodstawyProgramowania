using System;
using System.IO;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool noname = true;
            while (noname)
            {
                Console.WriteLine("Podaj nazwe pliku");
                string path = Console.ReadLine();
                if (!path.Contains(".txt"))
                    path = String.Concat(path, ".txt");

                String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                try
                {
                    StreamReader text = new StreamReader(Path.Combine(Pulpit, path));
                    while (!text.EndOfStream)
                    {
                        try
                        {
                            int textLine = int.Parse(text.ReadLine());
                            Console.Write(textLine + " ");
                            Console.WriteLine(textLine * textLine);
                            noname = false;
                        }
                        catch
                        {
                            Console.WriteLine("Czy ten plik zawiera liczby?");
                        }                        
                    }
                    
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Podaj prawidłową nazwe pliku");
                }                
            }
        }
    }
}
