using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen pozitif bir sayi giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int[diziUzunlugu];

            for (int i=0 ; i<diziUzunlugu ; i++)
            {
                Console.Write("Lutfen {0}. sayiyi giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Cift Sayilar:");
            foreach (var sayi in sayiDizisi)
            {
                if(sayi%2==0)
                {
                    Console.WriteLine(sayi);
                }
                else
                    continue;
            }
        }
    }
}
