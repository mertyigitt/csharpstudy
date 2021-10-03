using System;

namespace Donguler_While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            // 1 den baslayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplama.

            Console.WriteLine("Lutfen bir sayi giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac<=sayi)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);


            // 'a' dan 'z' ye kadar tum harfleri console a yazar.
            char character = 'a';
            while (character<='z')
            {
                Console.Write(character);
                character++;
            }

            Console.WriteLine("***Foreach***");
            string[] arabalar = {"bmw","ford","Toyota"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
