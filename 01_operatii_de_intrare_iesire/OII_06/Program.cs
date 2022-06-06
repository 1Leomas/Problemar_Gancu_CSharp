using System;

namespace OII_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mere, copil1, copil2;

            mere = int.Parse(Console.ReadLine());

            copil1 = mere - 2;
            copil2 = mere + 1;

            Console.WriteLine("Primu copil are: " + copil1 + " mere");
            Console.WriteLine("Al 2lea copil are: " + copil2 + " mere");

            Console.ReadLine();
        }
    }
}
