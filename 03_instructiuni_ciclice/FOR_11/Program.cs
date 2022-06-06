using System;

namespace FOR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            Console.Write("n1= ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("n2= ");
            int n2 = int.Parse(Console.ReadLine());

            while (n2 != 0)
            {
                r = n1 % n2;
                n1 = n2;
                n2 = r;
            }
            Console.WriteLine("cmmdc = " + n1);
            Console.ReadLine();
        }
    }
}
