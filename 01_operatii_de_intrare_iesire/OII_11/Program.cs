using System;

namespace OII_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Numarul de ani: ");
            int ani = int.Parse(Console.ReadLine());
            int zile = 365 * ani;
            int luni = 12 * ani;
            int ore = (365 * 24) * ani;

            Console.WriteLine(luni + " luni " + zile + " zile " + ore + " ore");
            Console.ReadLine();
        }
    }
}
