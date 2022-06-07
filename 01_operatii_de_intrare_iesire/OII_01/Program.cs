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
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {

                    Console.Write($"{caracter} ");
                }
                Console.WriteLine();
            }
        }
    }
}

/*static void Main(string[] args)
{
    string carcater = Console.ReadLine();

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(carcater);
        }
        Console.WriteLine();
    }

    Console.WriteLine(" ");

    for (int i = 0; i < 5; i++)
    {
        for (int j = 5; j > i; j--)
        {
            Console.Write(carcater);
        }
        Console.WriteLine();
    }

    Console.WriteLine(" ");

    for (int i = 0; i < 5; i++)
    {
        for (int j = 5; j > i; j--)
        {
            Console.Write(" ");
        }
        for (int j = 0; j <= i; j++)
        {
            Console.Write(carcater);
        }
        Console.WriteLine();
    }

    Console.WriteLine(" ");

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(" ");
        }
        for (int j = 5; j > i; j--)
        {
            Console.Write(carcater);
        }
        Console.WriteLine();
    }
}*/