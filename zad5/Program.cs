using System;

namespace zad5
{
    class Program
    {
        class Temperature
        {
            private float celcius;

            public float Celcius
            {
                get {return celcius;}
                set 
                {
                    if (value < -273)
                        throw new ArgumentOutOfRangeException();
                    celcius = value;
                }
            }

            public void ShowTemperature()
            {
                Console.WriteLine(this.Celcius);
            }
        }

        static void Main(string[] args)
        {

            Temperature temperature1 = new Temperature();
            Temperature temperature2 = new Temperature();

            Console.WriteLine("Sprawdz temerature w poniedziałek => press 1");            
            Console.WriteLine("Zaktualizuj temerature w poniedziałek => press 2");
            for(; ;)
            {
                int choice;
                bool parse = int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        {
                            temperature1.ShowTemperature();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Podaj temerature");
                            int inputTemperature;
                            bool parse2 = int.TryParse(Console.ReadLine(), out inputTemperature);
                            temperature1.Celcius = inputTemperature;
                            break;
                        }
                    default:
                        return;
                }
            }
        }
    }
}
