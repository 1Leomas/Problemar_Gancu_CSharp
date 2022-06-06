using System;

namespace FOR_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = a; i >= b; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
