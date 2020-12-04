using System;

namespace zadanie22
{
    class Program
    {
        public delegate double FUNC(double x);

        //funkcja dla ktorej obliczamy calke
        private static double func(double x)
        {
            return x;
        }

        /// <summary>
        /// Oblicza calke metoda prostokatow w przedziale od xp do xk z dokladnoscia n dla funkcji fun
        /// </summary>
        /// <param name="xp">poczatek przedzialu calkowania</param>
        /// <param name="xk">koniec przedzialu calkowania</param>
        /// <param name="n">dokladnosc calkowania</param>
        /// <param name="func">funkcja calkowana</param>
        /// <returns></returns>        
        private static double Integral(double xp, double xk, int n, FUNC func)
        {
            double dx;
            double result = 0;

            dx = (xk - xp) / n;

            for (int i = 1; i <= n; i++)
            {
                result += (func(xp + i * dx)) * dx;
            }

            return result;
        }        

        static void Main(string[] args)
        {
            double xp, xk;
            int n;
            FUNC function = new FUNC(func);

            Console.WriteLine("Podaj poczatek przedzialu calkowania");
            xp = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj koniec przedzialu calkowania");
            xk = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj dokladnosc calkowania");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Wartosc calki wynosi w przyblizeniu wynosi:" + Integral(xp, xk, n, function));
        }
    }
}
