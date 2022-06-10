using System;

namespace IF_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti notele lui Ionel: ");
            Console.Write("Nota1: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.Write("Nota2: ");
            int nota2 = int.Parse(Console.ReadLine());
            Console.Write("Nota3: ");
            int nota3 = int.Parse(Console.ReadLine());

            Console.Write("Notele pe care le-a zis parintilor sunt:");
            if (nota1 >= 7) Console.Write($" {nota1}");
            if (nota2 >= 7) Console.Write($" {nota2}");
            if (nota3 >= 7) Console.Write($" {nota3}");
        }
    }
}
