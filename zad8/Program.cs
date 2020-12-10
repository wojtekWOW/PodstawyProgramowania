using System;
using System.Globalization;

namespace zad8
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo culturePl = new CultureInfo("pl-PL");
            CultureInfo cultureUs = new CultureInfo("en-US");
            CultureInfo cultureGb = new CultureInfo("en-GB");

            object[] cash = { 112.236677 };
            string currency1 = String.Format(culturePl, "{0:C8}", cash);
            currency1 = String.Format(cultureGb, "{0:C8}", cash);
            string currency2 = String.Format(cultureUs,"{0:C1}", cash);
            Console.WriteLine(currency1);
            Console.WriteLine(currency2);

        }
    }
}
