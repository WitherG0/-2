using System;

namespace Six
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine("Введите возраст (в годах)");
                string text = $"{i}";
                Console.WriteLine("|||||||||||||||||||||||||||");
                int y = text[text.Length - 1] - '0';
                int a = int.Parse(text);
                if (y == 1 && a != 11)
                {
                    Console.WriteLine($"{text} год");
                }
                else if (a == 12 || a == 13 || a == 14)
                    {
                    Console.WriteLine($"{text} лет");
                    }
                    else if (y == 2 || y == 3 || y == 4)
                    {
                    Console.WriteLine($"{text} года");
                    } else
                {
                    Console.WriteLine($"{text} лет");
                }
            }
        }
    }
}
