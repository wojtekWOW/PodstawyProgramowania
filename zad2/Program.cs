using System;

namespace zad2
{
    class Program
    {
        class Temperature
        {
            public float celcius;

            public float ChangeTemperature(float x)
            {
                return this.celcius + x;
            }
        }
        static void Main(string[] args)
        {

            Temperature temperature1 = new Temperature();
            Temperature temperature2 = new Temperature();
            Console.WriteLine(temperature1.celcius);
            temperature1.celcius = temperature1.ChangeTemperature(6);
            temperature2 = temperature1;
            Console.WriteLine(temperature2.celcius);
        }
    }
}
