using System;

namespace IF_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Num1: ");
            num1 = int.Parse(Console.ReadLine());

            Console.Write("Num2: ");
            num2 = int.Parse(Console.ReadLine());

            if ((num1 + 1) == num2 || (num1 - 1) == num2)
                Console.WriteLine("Da");
            else
                Console.WriteLine("Nu");
            Console.ReadLine();
        }
    }
}
