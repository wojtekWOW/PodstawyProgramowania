using System;
using System.IO;

namespace SystemPlikow
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //Console.WriteLine(Pulpit);
          
            
            StreamWriter writeStream = new StreamWriter(Path.Combine(Pulpit, "test.txt"));
            writeStream.WriteLine("Dziś mamy {0}", DateTime.Now);
            writeStream.Close();

        }
    }
}
