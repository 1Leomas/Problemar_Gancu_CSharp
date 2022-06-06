using System;

namespace FOR_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Limita: ");
            int limit = int.Parse(Console.ReadLine());

            for (int i = 1; i < limit; i++)
            {
                int nr = 1;
                nr += i;

                if (i % 6 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
