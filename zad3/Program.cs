using System;
using System.IO;


namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Console.WriteLine(File.ReadAllText(Path.Combine(Pulpit, "test2.txt"))); 
        }
    }
}
