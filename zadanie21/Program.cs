using System;


namespace zadanie21
{
    class Program
    {
        //funkcja dla ktorej obliczamy calke
        private static double func(double x)
        {
            return x*x;
        }

        /// <summary>
        /// Oblicza całke metodą prostokątów
        /// </summary>
        /// <param name="xp">poczatek przedziału całkowania</param>
        /// <param name="xk">koniec przedziału całkowania</param>
        /// <param name="n">dokładnośc całkowania</param>
        /// <returns>Całka z funkcji</returns>
        private static double Integral(double xp, double xk, int n)
        {
            double dx;
            double result=0;
            
            dx = (xk - xp) / n;

            for (int i = 1; i <= n; i++)
            {
                result += (func(xp + i * dx)) *dx;
            }

            return result;
        }
        static void Main(string[] args)
        {
            double xp, xk;
            int n;            

            Console.WriteLine("Podaj poczatek przedzialu calkowania");
            xp = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj koniec przedzialu calkowania");
            xk = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dokladnosc calkowania");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Wartosc calki wynosi w przyblizeniu wynosi:" + Integral(xp, xk, n));
        }
    }
}
