using System;

//ÖMER FARUK AKYAPAK 190401008

namespace Soru1
{
    class Program
    {
        public static void matrisYaz(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.Write(a[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        public static int Toplam(int[,] a)
        {
            int toplam = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (i + j != a.GetLength(0) - 1 && i != j) 
                    {
                        if (((j >= i + 1) && (j <= (a.GetLength(0) - i - 1))))
                        {
                            toplam += a[i, j];
                        }
                        if ((i > a.GetLength(0) / 2 && j >= a.GetLength(0) - (i + 1)) && (j < a.GetLength(0) - 1))
                        {
                            toplam += a[i, j];
                        }
                    }
                }
            }
            return toplam;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Dizinin boyutunu giriniz : ");
            int dizinin_satırsayısı = Convert.ToInt32(Console.ReadLine());

            int[,] matris = new int[dizinin_satırsayısı, dizinin_satırsayısı];
            Random r = new Random();

            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(0); j++)
                {
                    int say = r.Next(10, 100);
                    while (say % 2 == 0)
                    {
                        say = r.Next(10, 100);
                    }
                    matris[i, j] = say;
                }
            }
            Console.WriteLine("Toplam: " + Toplam(matris));
            matrisYaz(matris);
            Console.ReadLine();
        }
    }
}

