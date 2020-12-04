using System;

namespace zadanie15
{
    class Program
    {
        //Delegate defines the signature => return type and parameters of a delegated method
        public delegate double Manipulate(double a, double b);
        /// <summary>
        /// Calculates sum of 2 values
        /// </summary>
        /// <param name="a">first value</param>
        /// <param name="b">second value</param>
        /// <returns>The sum of two values</returns>
        
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
            Manipulate sumDelegate = new Manipulate(Sum);
            double sum = sumDelegate(x, y);
            Console.WriteLine($"Suma liczb {x} i {y} to {sum}");

            //b
            Manipulate lambdaDelegate = (a, b) => { return a + b; };
            Console.WriteLine($"Suma liczb {x} i {y} to {lambdaDelegate(x,y)}");
        }
    }
}
