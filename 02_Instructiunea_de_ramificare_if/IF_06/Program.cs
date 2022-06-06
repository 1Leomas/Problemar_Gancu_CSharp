using System;

namespace IF_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Greutatea primului copil: ");
            int copil1 = int.Parse(Console.ReadLine());

            Console.Write("Greutatea copilului2: ");
            int copil2 = int.Parse(Console.ReadLine());

            if (copil1 + copil2 <= 100)
            {
                Console.WriteLine("Pot intra ambii copii");
            }
            else
                Console.WriteLine("Intra pe rand");
            Console.ReadLine();
        }
    }
}
