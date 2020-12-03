using System;

namespace zadanie16
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
        public static double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dwie liczby :");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //a
            var sumDelegate = new Manipulate(Sum);
            var sum = sumDelegate(x, y);
            Console.WriteLine($"Suma liczb {x} i {y} to {sum}");

            var multiplyDelegate = new Manipulate(Multiply);
            var multiplication = multiplyDelegate(x, y);
            Console.WriteLine($"Iloczyn liczb {x} i {y} to {multiplication}");

            //b
            Manipulate lambdaDelegate = (a, b) => { return a + b; };
            Console.WriteLine($"Suma liczb {x} i {y} to {lambdaDelegate(x, y)}");

            Manipulate lambdaDelegate2 = (a, b) => { return a * b; };
            Console.WriteLine($"Iloczyn liczb {x} i {y} to {lambdaDelegate2(x, y)}");
        }
    }
}
