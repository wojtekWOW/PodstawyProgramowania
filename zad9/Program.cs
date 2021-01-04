using System;
using System.Collections.Generic;

namespace zad9
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
            
            public override string ToString()
            {
                return celcius + " stopni C";
            }
            public Temperature()
            {
                celcius = 100;
            }
            public Temperature(float celcius)
            {
                this.celcius = celcius;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'add' for adding temerature record, 'view' for viewing all temerature records");
            string choice="add";
            List<Temperature> LogMeteo = new List<Temperature>();

            while (choice == "add" || choice == "view")
            {
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "add":
                        {
                            Console.WriteLine("Podaj temerature do zapisania");
                            float t = float.Parse(Console.ReadLine());
                            LogMeteo.Add(new Temperature(t));                            
                            break;
                        }
                    case "view":
                        {
                            foreach (Temperature t in LogMeteo)
                                Console.WriteLine(t);
                            break;
                        }
                }
            }
        }
    }
}
