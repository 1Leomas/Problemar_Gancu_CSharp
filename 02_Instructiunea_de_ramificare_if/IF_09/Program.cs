using System;

namespace IF_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Num{i}: ");
                int num1 = int.Parse(Console.ReadLine());

                if (num1 % 2 == 0)
                    Console.WriteLine(num1 + " par");
                else
                    Console.WriteLine(num1 + " impar");
            }
            Console.ReadLine();
        }
    }
}
