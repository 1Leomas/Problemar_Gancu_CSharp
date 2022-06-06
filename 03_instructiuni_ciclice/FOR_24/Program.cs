using System;

namespace FOR_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num;
            uint sum = 0;
            uint max = 0;
            uint min = 9999;

            do
            {
                num = uint.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }
            } while (sum % 3 != 0);
            Console.WriteLine("max= " + max + " min= " + min);
        }
    }
}
