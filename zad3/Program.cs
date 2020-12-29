using System;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Polecenie 3
            
            for (int a = 0; a <= 3; a++)
            {
                //tutaj znajduje się zestaw instrukcji wykonywany w pętli A
                for (int b = 0; b <= 2; b++)
                {
                    Console.WriteLine(a +" + " + b +" = " + (a + b));
                }
            }
            
        }
    }
}
