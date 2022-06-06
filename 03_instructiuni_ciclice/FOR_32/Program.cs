using System;

namespace FOR_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Enter a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            c = int.Parse(Console.ReadLine());

            Console.WriteLine($"Max digit is: {MaxDigitSum(a, b, c)}");

            Console.WriteLine($"Max multiplicity is: {MaxMultiplicity(a, b, c)}");

            Console.WriteLine($"Max CMMDC is: {MaxCMMDC(a, b, c)}"); //TO DO
        }

        private static object MaxCMMDC(int a, int b, int c)
        {
            return Math.Max(CMMDC(a), Math.Max(CMMDC(b), CMMDC(c)));
        }

        private static int CMMDC(int a)
        {
            int i = a / 2;
            int div = 1;
            while (a > 0)
            {
                if (a % i == 0) return i;
                i--;
            }

            return div;
        }

        private static int MaxMultiplicity(int a, int b, int c)
        {
            int pordA = DigitMultiplicity(a);
            int pordB = DigitMultiplicity(b);
            int pordC = DigitMultiplicity(c);

            return Math.Max(pordA, Math.Max(pordB, pordC));
        }

        private static int DigitMultiplicity(int n)
        {
            int sum = 1;
            while (n > 0)
            {
                sum *= n % 10;
                n /= 10;
            }

            return sum;
        }

        private static int MaxDigitSum(int a, int b, int c)
        {
            int sumA = DigitSum(a);
            int sumB = DigitSum(b);
            int sumC = DigitSum(c);

            return Math.Max(sumA, Math.Max(sumB, sumC));
        }

        private static int DigitSum(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }


    }
}
