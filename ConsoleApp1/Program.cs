using Accord.Math;
using System;

namespace zad1
{
    class Program
    {
        static double Deg2Rad(double angle)
        {            
            return angle*Math.PI/180;
        }
        static void Main(string[] args)
        {
            //a
            for (int i = 0; i <= 90; i = i + 10)
            {
                Console.WriteLine($"Wartość funkcji sinus dla kąta {i} wynosi: {Math.Sin(i * Math.PI / 180)}");
            }
            Console.WriteLine();
            //b
            for (int i=0; i<=90; i=i+10)
            {
                Console.WriteLine($"Wartość funkcji sinus dla kąta {i} wynosi: {Math.Sin(Deg2Rad(i))}");                
            }
            Console.WriteLine();
            //c
            for (int i = 0; i <= 90; i += 10)
            {
                Console.WriteLine($"Wartość funkcji sinus dla kąta {i} wynosi: {ExtendingClass.SinFmDeg(i)}");
            }
            Console.WriteLine();
            //d
            for (int i = 0; i <= 90; i += 10)
            { 
                Console.WriteLine($"Wartość funkcji sinus dla kąta {i} wynosi: {i.SinFmDeg()}");
            }
        }
    }
}
