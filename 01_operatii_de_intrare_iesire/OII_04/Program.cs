using System;

namespace OII_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int albe, rosii, albastre, total;

            albe = int.Parse(Console.ReadLine());

            rosii = albe + 3;
            albastre = (rosii + albe) - 2;
            total = rosii + albe + albastre;

            Console.WriteLine(total);
        }
    }
}
