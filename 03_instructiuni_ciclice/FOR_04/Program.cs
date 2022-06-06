using System;

namespace FOR_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
