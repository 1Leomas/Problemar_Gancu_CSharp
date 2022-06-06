/*
 De la tastatura se citesc doua numere pozitive a si n. Elaborati un program prin intermediul caruia
 se va afisa numarul a urmat de n zerouri. 
 Exemplu: Date de intrare a=34 n=5 Date de iesire 3400000.
 */

using System;

namespace FOR_02p16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                a *= 10;
            }

            Console.WriteLine($"Rezultatul este: {a}");
        }
    }
}
