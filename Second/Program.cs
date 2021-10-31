using System;

namespace Second
{
    class Program
    {
        static void Main(string[] args)
        {
            double P = 1;
            int a;
            Console.WriteLine("Сколько слагаемых для вычисления числа Пи вы хотите использовать?");
            a = int.Parse(Console.ReadLine());
            double b = 3;
            if (a % 2 == 0) 
            {
                a = a / 2;
                for (int i = 0; i <= a; i++)
                {
                    P = P - 1 / b + 1 / (b + 2);
                    b = b + 4;
                }
            } else
            {
                a = (a - 1) / 2;
                for (int i = 0; i <= a; i++)
                {
                    P = P - 1 / b + 1 / (b + 2);
                    b = b + 4;
                }
                P = P - 1 / (b);
            }
            P = P * 4;
            Console.WriteLine(P);
        }
    }
}
