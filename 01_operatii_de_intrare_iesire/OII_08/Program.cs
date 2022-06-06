using System;

namespace OII_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string r1, r2, r3, r4, r5, s;
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            s = " ";
            r1 = s + n1 + n3 + n2;
            r2 = s + n2 + n1 + n3;
            r3 = s + n2 + n3 + n1;
            r4 = s + n3 + n1 + n2;
            r5 = s + n3 + n2 + n1;

            Console.WriteLine(r1 + " " + r2 + " " + r3 + " " + r4 + " " + r5);

            Console.ReadLine();
        }
    }
}
