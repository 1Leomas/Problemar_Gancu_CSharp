using System;

namespace OII_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numar, rez;
            Console.Write("Introduceti un nr : ");
            numar = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                rez = numar * i;
                Console.WriteLine($"{i}x{numar}=" + rez + " ");
            }
            Console.ReadLine();
        }
    }
}
