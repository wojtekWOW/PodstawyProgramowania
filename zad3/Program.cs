using System;

namespace zad3
{
    class Program
    {
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby :");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            //a
            Console.WriteLine(Sum(2*x, 3*y));
            Console.WriteLine();
            //b
            Console.WriteLine(Sum(x*y,7));
            Console.WriteLine();
            //c
            Console.WriteLine(Sum(Math.Sqrt(x), Math.Pow(y,2)));
            Console.WriteLine();
            //d
            Console.WriteLine(Sum(Sum(x,y),1));
        }
    }
}
