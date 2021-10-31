
using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float x;
            double i, q, a;
            int p, k, K, d;
            Console.WriteLine("Введите х:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Точность?(от 1 до 0,00...01)");
            q = double.Parse(Console.ReadLine());
            a = 0;
            p = 0;
            K = 0; d = 1;
            k = 2;
            d = d * k;
            a = a + Math.Pow(-1, 1 + K) * Math.Pow(x, p + 2) / d;
            i = Math.Abs(Math.Pow(-1, 1 + K) * Math.Pow(x, p + 2) / d);

            k++;
            K++;
            do
            {
                d = d * k;
                a = a + Math.Pow(-1, 1+K)*Math.Pow(x, p + 2) / d;
                i = Math.Abs(Math.Pow(-1, 1 + K) * Math.Pow(x, p + 2) / d);
                k++;
                K++;
            } while (i > q);
            a = a + 1;
            /*(╯°□°）╯︵ ┻━┻*/
            Console.WriteLine($"cos(x)={a}");
            Console.WriteLine(K);
        }
    }
}
