using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Proje4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz :");
            int n = int.Parse(Console.ReadLine());
            int[,] matris = new int[n, n];
            Random rand = new Random();
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    matris[i, j] = rand.Next(1, 11);
                }
            }
            for (int i = 0; i < matris.GetLength(0); i++)
            {
                for (int j = 0; j < matris.GetLength(1); j++)
                {
                    Console.Write(matris[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int toplam = new int();

            for (int i = 1; i < n + 1; i++)
            {
                for (int j = 1; j < n + 1; j++)
                {
                    if (i == j || j == (n + 1 - i))
                    {

                        toplam = toplam + matris[i - 1, j - 1];
                    }
                    else
                    {

                    }
                }

            }

            Console.WriteLine("Çapraz toplamlar :" + toplam);

            Console.ReadLine();


        }


    }
}
