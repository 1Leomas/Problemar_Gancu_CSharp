using System;

namespace FOR_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            bool prim;
            for (int i = n / 2; i > 0 ; i--)
            {
                if (n % i == 0)
                {
                    
                    break;
                }
            }
            Console.WriteLine("Nu este prim");
        }
    }
}
