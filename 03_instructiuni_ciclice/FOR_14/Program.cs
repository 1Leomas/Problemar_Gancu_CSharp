using System;

namespace FOR_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dati inaltimea dreptunghiului: ");
            int inaltime = int.Parse(Console.ReadLine());
            Console.Write("Dati lungimea dreptunghiului: ");
            int lungime = int.Parse(Console.ReadLine());

            Console.WriteLine("a)");
            for (int i = 1; i <= inaltime; i++)
            {
                for (int j = 1; j <= lungime; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            Console.WriteLine("b)");
            for (int i = 1; i <= inaltime; i++)
            {
                for (int j = 1; j <= lungime; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
