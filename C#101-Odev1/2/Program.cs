using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen 2 pozitif sayidan 1. olani giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int [diziUzunlugu];

            Console.Write("Lutfen 2 pozitif sayidan 2. olani giriniz: ");
            int m = int.Parse(Console.ReadLine());
            
            for (int i=0; i<diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. sayiyi giriniz: ",i+1);
                sayiDizisi [i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("2. sayiya esit veya tam bolunen sayilar:");
            foreach (var sayi in sayiDizisi)
            {
                if (sayi % m == 0 || sayi == m)
                {
                    Console.WriteLine(sayi);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
