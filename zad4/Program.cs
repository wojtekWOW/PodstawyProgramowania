using System;

namespace zad4
{
    class Program
    {
        public static double Sum(double a,double b)
        {
            return a + b;
        }
        public static double Substract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            return a / b;
        }
        static void Main(string[] args)
        {
            double a, b, c, delta, x0, x1, x2;

            Console.WriteLine("Podaj wspolczynniki a, b i c ");
            Console.WriteLine(" Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(" Podaj c");
            c = double.Parse(Console.ReadLine());

            delta = Substract((Math.Pow(b, 2)) , (Multiply(Multiply( 4 , a),  c)));
            Console.WriteLine("Delta wynosi: " + (delta));
            if (delta > 0)
            {
                x1 = Divide(Substract(-b , Math.Sqrt(delta)) , Multiply(2 , a));
                x2 = Divide(Sum(-b, Math.Sqrt(delta)), Multiply(2, a));
                Console.WriteLine("X1 wynosi: {0:0.###}", x1);
                Console.WriteLine("X2 wynosi: {0:0.###}", x2);
                Console.ReadKey();
            }

            else if (delta == 0)
            {
                x0 = (-b) / (2 * a); Divide(-b, Multiply(2, a));
                Console.WriteLine("X0 wynosi: {0:0.###}", x0);
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych ");
            }
        }
    }
}
