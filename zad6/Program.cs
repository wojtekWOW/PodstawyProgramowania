using System;

namespace zad6
{
    class Program
    {   
        static void Main(string[] args)
        {
            RandomNumbers rand1 = new RandomNumbers();
            RandomNumbers rand2 = new RandomNumbers();
            Counters drawingLoop = new Counters();
            Counters insideLoop = new Counters();
            int n,m;            

            Console.WriteLine("Podaj zakres liczb:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            
            RandomNumbers.DrawRandomNumbers(n,m, ref rand1, ref rand2, ref drawingLoop, ref insideLoop);

            Console.WriteLine($"NWD liczb {rand1.DrawnValue} i {rand2.DrawnValue} to {rand1.value}");
            Console.WriteLine($"Petla wewnętrzna wykonala sie  {insideLoop.counter} razy");
            Console.WriteLine($"Petla losująca liczbę wykonala sie  {drawingLoop.counter} razy");
        }               
    }
}
