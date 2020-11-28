using System;
using System.Collections.Generic;
using System.Text;

namespace zad5
{
    public static class ExtendingClass
    {
        public static double Sum(this double a, double b)
        {
            return a + b;
        }
        public static double Substract(this double a, double b)
        {
            return a - b;
        }
        public static double Multiply(this double a, double b)
        {
            return a * b;
        }
        public static double Divide(this double a, double b)
        {
            return a / b;
        }
    }
}
