using System;
using System.Collections.Generic;
using System.Text;

namespace zad2
{
    public static class ExtendingClass
    {
        public static double Log(this int x, int p)
        {
            return Math.Log10(x) / Math.Log10(p);
        }
    }
}
