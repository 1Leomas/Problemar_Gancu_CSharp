using System;

namespace OII_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numar = int.Parse(Console.ReadLine());

            numar -= 2;

            for (int i = 0; i < 5; i++)
            {
                Console.Write(numar + " ");
                numar++;
            }
            Console.ReadLine();
        }
    }
}
