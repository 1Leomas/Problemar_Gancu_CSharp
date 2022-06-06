using System;

namespace OII_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fete, baieti, total;
            Console.Write("Introduceti numarul de fete: ");
            fete = int.Parse(Console.ReadLine());
            baieti = fete + 10;
            total = fete + baieti;
            Console.WriteLine("Numarul total de copii: " + total);
        }
    }
}
