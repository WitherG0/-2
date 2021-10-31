using System;

namespace _1
{
    class First
    {
        static void Main(string[] args)
        {
            float a, b, c;
            double x1, x2, d;
            Console.WriteLine("Введите значения a, b и c, принадлежащих уравнению вида ax^2+bx+c=0");
            Console.WriteLine("a:");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("b:");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("c:");
            c = float.Parse(Console.ReadLine());
            d = (Math.Pow(b, 2) - 4 * a * c);
            switch (d)
            {
                case > 0:
                    x1 = (-b + Math.Sqrt(d)) / 2 * a; x2 = (-b - Math.Sqrt(d)) / 2 * a;
                    x1 = (float)x1; x2 = (float)x2;
                    Console.WriteLine($"x1={x1}; \ax2={x2}");
                    break;
                case < 0:
                    x1 = -b / 2 * a; x2 = Math.Sqrt(-d) / 2 * a;
                    x1 = (float)x1; x2 = (float)x2;
                    Console.WriteLine($"x1={x1}+i{x2}; \ax2={x1}-i{x2}");
                    break;
                default:
                    x1 = -b / 2 * a;
                    x1 = (float)x1;
                    Console.WriteLine($"x={x1}");
                    break;
            }
        }
    }
}
