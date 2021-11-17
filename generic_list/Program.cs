using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T->object turundedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(1);
            sayiListesi.Add(99);
            sayiListesi.Add(45);
            sayiListesi.Add(56);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Beyaz");
            
            //Count
            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(renkListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erisim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);
            foreach (var renk in renkListesi)
                Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Listeden eleman cikartma
            sayiListesi.Remove(10);
            renkListesi.Remove("Sari");

            sayiListesi.RemoveAt(2);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste icerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste Icerisinde Bulundu");

            //Eleman ile indexe erisim
            Console.WriteLine(renkListesi.BinarySearch("Kirmizi"));

            //Diziyi Liste cevirme
            string[] hayvanlar = {"Ayi","Sincap","Kartal"};
            List<string> hayvanList = new List<string>(hayvanlar);

            //Liste Temizleme
            hayvanList.Clear();

            //Liste icersinde nesne tutma
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yilmaz";
            kullanici1.Yas = 25;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ozcan";
            kullanici2.Soyisim = "Caliskan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24,
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi:" + kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi:" + kullanici.Soyisim);
                Console.WriteLine("Kullanici Yasi:" + kullanici.Yas);
            }
            
            yeniListe.Clear();
            
        }
    }

    public class Kullanicilar{
        
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }




    }
}
