using System;

namespace Ind2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 1;
            for (int i = 1; i < 10;  i++) 
            {
                a = a * i;
                Console.WriteLine(a);
                Console.WriteLine();
            }

        }
    }
}
