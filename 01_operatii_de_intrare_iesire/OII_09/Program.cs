using System;

namespace OII_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, s1, s2, s3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            s1 = n1 + n2;
            s2 = n1 + n3;
            s3 = n2 + n3;

            Console.Write($"{n1} + {n2} = " + s1 + " | ");
            Console.Write($"{n1} + {n3} = " + s2 + " | ");
            Console.Write($"{n2} + {n3} = " + s3);

            Console.ReadLine();
        }
    }
}
