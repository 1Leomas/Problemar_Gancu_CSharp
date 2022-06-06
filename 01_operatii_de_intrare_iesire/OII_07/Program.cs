using System;

namespace OII_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v, greutate, inaltime;

            Console.WriteLine("Introduceti varsta: ");
            v = int.Parse(Console.ReadLine());

            greutate = 2 * v + 8;
            inaltime = 5 * v + 80;

            Console.WriteLine("Greutatea ideala: " + greutate);
            Console.WriteLine("Inaltimea ideala: " + inaltime);
        }
    }
}
