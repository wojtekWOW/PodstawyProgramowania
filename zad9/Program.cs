using System;
using System.Globalization;

namespace zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culturePl = new CultureInfo("pl-PL");
            CultureInfo cultureUs = new CultureInfo("en-US");
            CultureInfo cultureGb = new CultureInfo("en-GB");

            DateTime dateTime = DateTime.Now;

            string s = String.Format(cultureGb, "{0:D}", dateTime);
            s = String.Format(culturePl, "{0:D}", dateTime);            
            string r = String.Format(cultureUs, "{0:f}", dateTime);
            Console.WriteLine(s);
            Console.WriteLine(r);
        }
    }
}
