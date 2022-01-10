using System;

namespace Kurucu_Metotlar
{
    class Program
    {
                static void Main(string[] args)
        {
            //Soz Dizimi
            // class SinifAdi
            // {
            //     [Erişim Belirleyici][Veri Tipi] ÖzellikAdı;
            //     [Erişim Belirleyici][Geri Dönüş Değerinin Tipi] MetotAdi([Parametreler])
            //     {
            //         //Metot Gövdesi
            //     }
            // }

            //Erisim Belirleyiciler
            // * Public
            // * Private
            // * Internal
            // * Protected

            Console.WriteLine("Calisan1 Bilgileri");
            Calisan calisan1 = new Calisan("Ayse","Kara",15253645,"Insan Kaynaklari");
            calisan1.CalisanBilgileri();

            Console.WriteLine("Calisan2 Bilgileri");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 74586932;
            calisan2.Departman = "Satin Alma";
            calisan2.CalisanBilgileri();

            Console.WriteLine("Calisan3 Bilgileri");
            Calisan calisan3 = new Calisan("Mert","Yigit");
            calisan3.CalisanBilgileri();
            
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin Adi:{0}",Ad);
            Console.WriteLine("Calisanin Soyadi:{0}",Soyad);
            Console.WriteLine("Calisanin Numarasi:{0}",No);
            Console.WriteLine("Calisanin Departmani:{0}",Departman);
        }
    }
}