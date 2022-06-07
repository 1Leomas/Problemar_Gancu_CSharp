using System;

namespace FOR_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 1; i < c; i++)
            {
                if (i % a == 0 || i % b == 0)
                {
                    if (i % 10 == 0) Console.Write("\n");
                    Console.Write($"{i} ");
                }
            }
        }
    }
}
