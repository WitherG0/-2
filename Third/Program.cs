using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, i, k;
            a = 1; i = 0;
            b = 0; k = 0;
            int[] a1 = { i }; 
            do
            {

               
                c = a + b;
                a = b;
                b = c;
                k++;
                if (a >999)
                {
                    if (a < 10000)
                    {
                        /* foreach (int j in a1)
                         {
                             Console.WriteLine($"{a}  {k}");
                         }*/
                        i++;
                    }
                }
            } while (a < 10000);
            Console.WriteLine($"В ряду Фибоначчи {i} четырехзначных числа");
        }
    }
}
