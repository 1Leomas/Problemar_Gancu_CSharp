using System;

namespace IF_01
{
    class Program
    {
        static void Main(string[] args)
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
        }
    }
}
