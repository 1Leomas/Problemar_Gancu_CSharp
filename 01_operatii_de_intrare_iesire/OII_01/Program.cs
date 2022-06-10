using System;

namespace OII_01
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a char: ");
            char caracter = char.Parse(Console.ReadLine());

            Console.Write("a)");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(caracter);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nb)");
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.Write($"{caracter}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nc)");
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < 4 ; j++)
                {
                    
                    Console.Write($"{caracter} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nd)");
            for (var i = 0; i < 4; i++)
            {
                for (int x = 3; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (var j = 0; j <= i; j++)
                {
                    Console.Write($"{caracter} ");
                }
                Console.WriteLine();
            }
        }
    }
}