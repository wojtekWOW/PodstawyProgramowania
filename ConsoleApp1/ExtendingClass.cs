using System;
using System.Collections.Generic;
using System.Text;

namespace zad1
{
    public static class ExtendingClass
    {           
        public static double SinFmDeg(this int angle)
        {
            return Math.Sin(angle * Math.PI / 180);
        }        
    }
}
