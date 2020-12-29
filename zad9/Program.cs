using System;
using System.IO;
using System.Collections.Generic;


namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            String Pulpit = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            FileStream fileStream = new FileStream(Path.Combine(Pulpit, "tada.wav"), FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream);

            for (int i = 0; i < 5; i++)
            {
                byte[] tabWav = binaryReader.ReadBytes(4);
                foreach (byte tab in tabWav)
                Console.Write(tab + " ");
                Console.WriteLine();                
            }
            for (int i = 0; i < 2; i++)
            {
                byte[] tabWav = binaryReader.ReadBytes(2);
                foreach (byte tab in tabWav)
                    Console.Write(tab + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                byte[] tabWav = binaryReader.ReadBytes(4);
                foreach (byte tab in tabWav)
                    Console.Write(tab + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                byte[] tabWav = binaryReader.ReadBytes(2);
                foreach (byte tab in tabWav)
                    Console.Write(tab + " ");
                Console.WriteLine();
            }
            for (int i = 0; i < 2; i++)
            {
                byte[] tabWav = binaryReader.ReadBytes(4);
                foreach (byte tab in tabWav)
                    Console.Write(tab + " ");
                Console.WriteLine();
            }
            //var data = Wav.FromFile(Path.Combine(Pulpit, "tada.wav"));
        }
    }
}
