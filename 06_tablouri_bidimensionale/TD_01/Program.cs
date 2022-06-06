using System;

namespace TD_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];

            int h = arr.GetLength(0);
            int w = arr.GetLength(1);
            int pare = 0, oCifra = 0, max = 0;

            Random random = new Random();

            // a) Cream matricia si o afisam
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    arr[x, y] = random.Next(10);
                    arr2[x, y] = arr[x, y];
                    arr3[x, y] = arr[x, y];
                    Console.Write(arr[x, y] + "\t");
                }
                Console.WriteLine();
            }
            // b) aflam numarul de elemente pare
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (arr[x, y] % 2 == 0)
                    {
                        pare++;
                    }
                }
            }
            // c) aflam nuamrul de elemente dintr-o cifra
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (arr[x, y] / 10 == 0)
                    {
                        oCifra++;
                    }
                }
            }
            // d) aflam valoarea elementului max
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (arr[x, y] > max)
                    {
                        max = arr[x, y];
                    }
                }
            }
            // d) inlocuim elementele divizibile cu 3 cu valoarea elementului max * 3
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (arr2[x, y] != 0)
                    {
                        if (arr2[x, y] % 3 == 0)
                        {
                            arr2[x, y] = max * 3;
                        }
                    }
                }
            }
            // e) inlocuim elementele pare cu valoarea elementului max * 2
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    if (arr3[x, y] % 2 == 0)
                    {
                        arr3[x, y] = max * 2;
                    }
                }
            }

            Console.WriteLine("\nNumarul de elemente pare: " + pare);

            Console.WriteLine("\nNumarul de elemente din o singura cifra: " + oCifra);

            Console.WriteLine("\nElementele divizibile cu 3 inlocuim cu max * 3");
            // d) afisam matricia noua
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    Console.Write(arr2[x, y] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nElementele pare inlocuim max * 2");
            // e) afisam matricia noua
            for (int x = 0; x < h; x++)
            {
                for (int y = 0; y < w; y++)
                {
                    Console.Write(arr3[x, y] + "\t");
                }
                Console.WriteLine();
            }
            // f) afisam elementele de pe coloana 2 si linia 1
            Console.Write("\nElementele de pe coloana 2 si linia 1: ");
            for (int y = 0; y == 0; y++)
            {
                for (int x = 1; x == 1; x++)
                {
                    Console.Write(arr[y, x] + " ");
                }
            }

            Console.WriteLine();

            // g) afisam elementele de pe coloana 1 si linia 2
            Console.Write("\nElementele de pe coloana 1 si linia 2: ");
            for (int y = 1; y == 1; y++)
            {
                for (int x = 0; x == 0; x++)
                {
                    Console.Write(arr[y, x] + " ");
                }
            }

            Console.WriteLine();

            //  h) afisam elementele de pe coloana a si linia b
            Console.WriteLine("\nElementele de pe coloana a si linia b: ");

            Console.Write("\na = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nb = ");
            int b = int.Parse(Console.ReadLine());

            for (int y = a - 1; y == a - 1; y++)
            {
                for (int x = b - 1; x == b - 1; x++)
                {
                    Console.Write("\nElementele de pe coloana a si linia b: " + arr[y, x] + " ");
                }
            }

            Console.ReadLine();
        }
    }
}
