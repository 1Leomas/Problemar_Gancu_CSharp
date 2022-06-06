using System;

namespace FOR_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int sum = 0;
            while (num != 0)
            {
                Console.Write("Num= ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            Console.WriteLine("Suma numerelor introduse: " + sum);
            Console.ReadLine();
        }
    }
}
