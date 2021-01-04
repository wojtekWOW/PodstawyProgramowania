using System;

namespace zad3
{
    class Program
    {
        class Temperature
        {
            private float celcius;

            public float Celcius
            {
                get
                {
                    return celcius;
                }
                set
                {
                    celcius = value;
                }
            }            
        }

        static void Main(string[] args)
        {

            Temperature temperature1 = new Temperature();
            Temperature temperature2 = new Temperature();

            Console.WriteLine(temperature1.Celcius);
            temperature1.Celcius = 6;
            temperature2.Celcius = -9;
            Console.WriteLine(temperature1.Celcius);
            Console.WriteLine(temperature2.Celcius);
            temperature2.Celcius = temperature1.Celcius;
            Console.WriteLine(temperature2.Celcius);
        }
    }
}
