using System;
using System.Collections.Generic;
using System.Text;

namespace zad9zad10
{
     class Silnia
    {
        /// <summary>
        /// Silnia rekurencyjnie
        /// </summary>
        /// <param name="i">i</param>
        /// <returns>i!</returns>
        public static int silnia1(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia1(i - 1);
        }

        /// <summary>
        /// Silnia iteracyjnie
        /// </summary>
        /// <param name="i">n</param>
        /// <returns>n!</returns>
        public static int silnia2(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
