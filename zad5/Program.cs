using System;

namespace zad5
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double a, b, c, delta, x0, x1, x2;
            const double  four = 4, two =2;

            Console.WriteLine("Podaj wspolczynniki a, b i c ");
            Console.WriteLine(" Podaj a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" Podaj b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(" Podaj c");
            c = double.Parse(Console.ReadLine());

            delta = (Math.Pow(b, 2)).Substract((four.Multiply(a.Multiply(c))));
            Console.WriteLine("Delta wynosi: " + (delta));
            if (delta > 0)
            {
                x1 = (-b).Substract(Math.Sqrt(delta)).Divide(two.Multiply(a));            
                x2 = (-b).Sum(Math.Sqrt(delta)).Divide(two.Multiply(a));
                Console.WriteLine("X1 wynosi: {0:0.###}", x1);
                Console.WriteLine("X2 wynosi: {0:0.###}", x2);
                Console.ReadKey();
            }

            else if (delta == 0)
            {
                x0 = (-b).Divide(two.Multiply(a));
                Console.WriteLine("X0 wynosi: {0:0.###}", x0);
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych ");
            }
        }
    }
}
