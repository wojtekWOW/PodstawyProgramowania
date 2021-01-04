using System;

namespace zad8
{
    class Program
    {
        class Temperature
        {
            private float celcius;

            public float Celcius
            {
                get { return celcius; }
                set { celcius = value; }
            }
            public float Farenheit
            {
                get { return celcius * 9 / 5 + 32; }
                set { celcius = (value - 32) * 5 / 9; }
            }
            public override string ToString()
            {
                return celcius + " stopni C" ;
            }
            public Temperature()
            {
                celcius = 100;
            }
        }

        static void Main(string[] args)
        {

            Temperature temperature1 = new Temperature();
            Temperature temperature2 = new Temperature();

            //Console.WriteLine("Temperatura 1 w skali farenheita: " + temperature1.Farenheit);
            Console.WriteLine("Temperatura 1 w skali celciusa: " + temperature1);
            temperature1.Farenheit = 6;
            temperature2.Farenheit = -9;
            //Console.WriteLine("Temperatura 1 w skali farenheita: " + temperature1.Farenheit);
            Console.WriteLine("Temperatura 1 w skali celciusa: " + temperature1);
           // Console.WriteLine("Temperatura 2 w skali farenheita: " + temperature2.Farenheit);
            Console.WriteLine("Temperatura 2 w skali celciusa: " + temperature2);
            temperature2.Farenheit = temperature1.Farenheit;
            Console.WriteLine("Temperatura 2 w skali celciusa: " + temperature2);
        }
    }
}
