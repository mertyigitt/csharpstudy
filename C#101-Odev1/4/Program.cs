using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lutfen bir cumle giriniz: ");
            string metinDizisi = Console.ReadLine();

            int toplamHarf = 0;

            foreach (var karakter in metinDizisi)
            {
                toplamHarf++;
            }
            Console.WriteLine("Harf sayisi: "+toplamHarf);


            string [] kelimeler = metinDizisi.Split(' ');
            Console.WriteLine("Kelime sayisi: "+kelimeler.Length);
            
        }
    }
}
