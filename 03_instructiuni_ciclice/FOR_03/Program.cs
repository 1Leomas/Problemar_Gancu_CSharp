using System;

namespace FOR_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Tabla inmultirii cu n\n");
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"\n{n} * {i} = {n * i}");
            }
        }
    }
}
