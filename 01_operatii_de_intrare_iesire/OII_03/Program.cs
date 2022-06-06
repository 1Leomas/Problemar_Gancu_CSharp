using System;

namespace OII_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elevi_autobuz = 7;

            Console.Write("Cati elevi sau urcat la prima scoala: ");
            int scoala1 = int.Parse(Console.ReadLine());

            Console.Write("Cati elevi sau urcat la a 2a scoala: ");
            int scoala2 = int.Parse(Console.ReadLine());

            elevi_autobuz += scoala1 + scoala2;

            Console.Write("In excursie pleca: " + elevi_autobuz + " copiii");

            Console.ReadLine();
        }
    }
}
