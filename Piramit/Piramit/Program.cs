using System;

namespace Piramit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input1 :");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input2 :");
            int y = Convert.ToInt32(Console.ReadLine());

            int ekleme = 1;
            int[] arr = new int[x + 1];
            for (int sayac = 1; sayac <=x; sayac++)
            {
                arr[sayac] = ekleme;
                ekleme = ekleme + y;

            }
            Console.WriteLine(arr[arr.Length - 1]);

            int toplam = 0;
            for (int sayac = 1; sayac <= x; sayac++)
                toplam = toplam + arr[sayac];
            Console.WriteLine(toplam);
            Console.ReadLine();

        }
    }
}
