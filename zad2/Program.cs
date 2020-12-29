using System;
using System.IO;
using System.Text;

namespace zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            
            StreamWriter writeStream = new StreamWriter(Path.Combine(Pulpit, "test2.txt"));
            writeStream.WriteLine("Dziś mamy {0}", DateTime.Now, Encoding.ASCII);
            writeStream.Close();
        }
    }
}
