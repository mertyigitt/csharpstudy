using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanimlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"kedi","kopek","kus","maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere deger atama ve Erisim
            renkler [0] = "mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Dongulerde dizi kullanami
            //Klavyeden girilen n tane sayinin ortalamasini hesaplayan program
            Console.WriteLine("Lutfen dizinin eleman sayisini giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int [] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lutfen {0}. sayisi giriniz: ",i+1);
                sayiDizisi[i]=int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (var sayi in sayiDizisi)
            {
                toplam+= sayi;
            }
            Console.WriteLine("ortalama :" + toplam/diziUzunlugu);
        }
    }
}
