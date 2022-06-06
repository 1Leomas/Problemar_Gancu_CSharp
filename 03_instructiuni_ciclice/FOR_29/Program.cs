using System;

namespace FOR_29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 0;
            for (uint a = 1; a <= 20; a++)
            {
                for (uint b = a; b <= 20; b++)
                {

                    c = Math.Pow(a, 2) + Math.Pow(b, 2);
                    Console.WriteLine($"{Math.Pow(a, 2)} + {Math.Pow(b, 2)} = {c}");
                }

            }
        }
    }
}
