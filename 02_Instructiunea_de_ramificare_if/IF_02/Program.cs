using System;

namespace IF_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Primul numar: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Al 2lea numar: ");
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                num1 *= 2;
                num2 *= 3;
            }
            else
            {
                num1 *= 3;
                num2 *= 2;
            }
            Console.WriteLine(num1 + " " + num2);
            Console.ReadLine();
        }
    }
}
