using System;

namespace Six
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст (в годах)");
            string text = Console.ReadLine();
            Console.WriteLine("|||||||||||||||||||||||||||");
            int y = text[text.Length - 1] - '0';
            int a = int.Parse(text);
            if (y == 1 && a != 11) 
            { 
                Console.WriteLine($"{text} год"); 
            }else if (y == 2 || y == 3 || y == 4 && a != 12 && a != 13 && a != 14) 
            {
                Console.WriteLine($"{text} годa"); 
            } else 
            { 
                Console.WriteLine($"{text} лет"); 
            }
        }
    }
}
