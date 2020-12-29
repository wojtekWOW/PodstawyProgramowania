using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                string command = Console.ReadLine();
                if (String.Equals(command, "c:", StringComparison.OrdinalIgnoreCase))
                { 
                    Directory.SetCurrentDirectory(@"C:\");
                    Console.WriteLine(Directory.GetCurrentDirectory());                    
                }
                else if(String.Equals(command, "d:", StringComparison.OrdinalIgnoreCase))
                {                    
                    Directory.SetCurrentDirectory(@"D:\");
                    Console.WriteLine(Directory.GetCurrentDirectory());                    
                }
                else if(String.Equals(command, "dir", StringComparison.OrdinalIgnoreCase))
                {
                    List<string> paths = new List<string>(); 
                    paths= Directory.EnumerateDirectories(Directory.GetCurrentDirectory()).ToList();
                    foreach(var path in paths )
                    Console.WriteLine(path);
                }
                else if(command.Contains(@"cd\", StringComparison.OrdinalIgnoreCase))
                {
                    command = command.Remove(0,3);                    
                    Directory.SetCurrentDirectory(Path.Combine(Directory.GetCurrentDirectory(), command));
                    Console.WriteLine(Directory.GetCurrentDirectory());
                }
                else if(command.Contains("type ", StringComparison.OrdinalIgnoreCase))
                {
                    command = command.Remove(0, 5);
                    string[] file = File.ReadAllLines(Path.Combine(Directory.GetCurrentDirectory(), command));
                    foreach(string line in file)
                        Console.WriteLine(line);
                }
                else
                    Console.WriteLine("Błędne polecenie");
            }            
        }
    }
}
