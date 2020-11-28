using System;

namespace zad7
{
    class Program
    {
        static int nwd(int a, int b)
        {
            if (a == 0)
                return b;
            return nwd(b % a, a);
        }
        static void Main(string[] args)
        {
            int n, m;
            int rand1=0, rand2=0;
            int rand1tmp=0, rand2tmp=0;

            Console.WriteLine("Podaj zakres liczb:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int l = 0;
            while (l != 1)
            {
                Random liczba1 = new Random();
                rand1 = liczba1.Next(n, m);

                Random liczba2 = new Random();
                rand2 = liczba2.Next(n, m);

                rand1tmp = rand1;
                rand2tmp = rand2;
                l = nwd(rand1,rand2);
            }
            
            Console.WriteLine($"NWD liczb {rand1tmp} i {rand2tmp} to {nwd(rand1, rand2)}");          
        }
    }
}
