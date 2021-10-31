
using System;

namespace Fourth
{
    class Program
    {
        static void Main(string[] args)
        {

            float x;
            double i, q, d, a;
            int p, k, K, g;
            Console.WriteLine("Введите х:");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("Точность?(от 1 до 0,00...01)");
            q = double.Parse(Console.ReadLine());
            a = 1; g = 2;
            p = 2;K = 0; d = 1;
            k = 2;
            d = d * g;
            a = a + Math.Pow(-1, 1 + K) * Math.Pow(x, p) / d;
            i = Math.Abs(Math.Pow(-1, 1 + K) * Math.Pow(x, p + 2) / d);
            p = p + 2;
            Console.WriteLine(d);
            k++;
            K++;
            d = 2;
            do
            {
                g++;
                d = d * g;
                g++;
                d = d * g;
                a = a + Math.Pow(-1, 1 + K) * Math.Pow(x, p) / d;
                i = Math.Abs(Math.Pow(-1, 1 + K) * Math.Pow(x, p + 2) / d);
                k++;
                p = p + 2;
                K++;               
            } while (i > q);
            /*(╯°□°）╯︵ ┻━┻*/
            Console.WriteLine($"cos(x)={a}");
            Console.WriteLine(K);
        }
    }
}
