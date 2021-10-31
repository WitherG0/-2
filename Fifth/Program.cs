using System;

namespace Lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;
            Console.WriteLine("Программа выводящая на экран все комбинации  натуральных  чисел x, y, z,таких что x^3 + y^3 + z^3 = N");
            Console.WriteLine("Введите число N");
            double N = double.Parse(Console.ReadLine());
            int j = 0;
            for (x = 0; x <= N; x++)
            {

                int xa = (int)Math.Pow(x, 3);
                for (y = 0; y <= N; y++)
                {
                    int ya = (int)Math.Pow(y, 3);
                    for (z = 0; z <= N; z++)
                    {
                        int za = (int)Math.Pow(z, 3);
                        double sum = xa + ya + za;
                        if (sum == N)
                        {
                            Console.WriteLine($"{xa}+{ya}+{za} = {N}");
                            j++;

                        } /*else
                        {
                            sum = xa - ya + za;
                            if (sum == N)
                            {
                                Console.WriteLine($"{xa}-{ya}+{za} = {N}");
                                Console.WriteLine($"{xa}+{za}-{ya} = {N}");
                                Console.WriteLine($"-{ya}+{za}+{xa} = {N}");

                                j++;

                            }else 
                            {
                                sum = xa - ya - za;
                                if (sum == N && Math.Pow(xa, 1.0/3.0)%1 == 0)
                                {
                                    Console.WriteLine($"{xa}-{ya}-{za}/{j} = {N}");
                                    Console.WriteLine($"-{ya}-{za}+{xa}/{j} = {N}");
                                    Console.WriteLine($"{xa}-{za}-{ya}/{j} = {N}");
                                    j++;
                                }
                            }
                        }*/

                    }

                }

            }

            if (j == 0)
            {
                Console.WriteLine("No such combinations!");

            }


        }
    }
}
