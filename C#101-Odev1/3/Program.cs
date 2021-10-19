using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen pozitif bir sayi giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            string [] metinDizisi = new string [diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. metiniz giriniz:");
                metinDizisi[i] = Console.ReadLine(); 
            }
            Array.Reverse(metinDizisi);
            Console.WriteLine("Girdiginiz metinler:");
            foreach (var metin in metinDizisi)
            {
                Console.WriteLine(metin);
            }
        }
    }
}
