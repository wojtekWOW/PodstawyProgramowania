
using System;

namespace zad8
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

            Console.WriteLine("Podaj zakres liczb:");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

            int l = 0;
            int i = 0;
            int j = 0;
            while (l != 1)
            {
                for(i=n; i<=m; i++)
                {
                    for(j =i; j<=m;j++)
                    {
                        l = nwd(i, j);
                    }
                }                
            }

            Console.WriteLine($"NWD liczb {i} i {j} to {nwd(i, j)}");
        }
    }
}
