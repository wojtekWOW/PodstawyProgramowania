using System;
using System.Collections.Generic;
using System.Text;

namespace zadanie11
{
     public static class Silnia
    {
        /// <summary>
        /// Silnia rekurencyjnie
        /// </summary>
        /// <param name="i">i</param>
        /// <returns>i!</returns>
        public static double silnia1(this int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia1(i - 1);
        }        
    }
}
