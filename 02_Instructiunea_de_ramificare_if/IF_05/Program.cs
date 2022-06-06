using System;

namespace IF_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num1: ");
            double num1 = int.Parse(Console.ReadLine());

            Console.Write("Num2: ");
            double num2 = int.Parse(Console.ReadLine());

            if (num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }
            else
                Console.WriteLine("Impartite imposibila!!!");
            Console.ReadLine();
        }
    }
}
