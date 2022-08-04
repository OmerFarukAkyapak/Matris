using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dizinin Boyutunu Giriniz :");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[size];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = r.Next(10, 100);

            BubbleSort(arr); 
            ekranaYaz(arr); 

            Console.Write("Aramak istediğiniz değeri giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());

            int deger = BinarySearch(arr, a);
            if (deger == -1) Console.WriteLine("Aradığınız değer yok.");
            else Console.WriteLine("Aradiğiniz değer " + deger + ". indistedir.");
            Console.ReadLine();

        }
        static void ekranaYaz(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Dizinin " + (i) + ".nci indisi elemanı :" + arr[i]);
            Console.ReadLine();
        }

        static void BubbleSort(int[] d)
        {
           
            for (int n = d.Length; 0 < n; n--) 
                for (int i = 0; i < n - 1; i++) 
                    if (d[i] > d[i + 1])
                    {
                        int temp = d[i + 1];
                        d[i + 1] = d[i];
                        d[i] = temp;
                    }
            Console.ReadLine();

        }

        static int BinarySearch(int[] arr, int a)
        {
            int mostMin = 0;
            int mostMax = arr.Length - 1;
            while (mostMin <= mostMax)
            {
                int medium = (mostMax + mostMin) / 2;

                if (a < arr[medium])
                    mostMax = medium - 1;
                else if (a > arr[medium])
                    mostMin = medium + 1;
                else if (a == arr[medium])
                    return medium;

            }
            return -1;
            Console.ReadLine();
        }
    }
}
