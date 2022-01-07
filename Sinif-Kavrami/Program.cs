using System;

namespace Sinif_Kavrami
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

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayse";
            calisan1.Soyad = "Kara";
            calisan1.No = 15253645;
            calisan1.Departman = "Insan Kaynaklari";

            calisan1.CalisanBilgileri();

            Console.WriteLine("-----------------------------");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 74586932;
            calisan2.Departman = "Satin Alma";

            calisan2.CalisanBilgileri();
            
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin Adi:{0}",Ad);
            Console.WriteLine("Calisanin Soyadi:{0}",Soyad);
            Console.WriteLine("Calisanin Numarasi:{0}",No);
            Console.WriteLine("Calisanin Departmani:{0}",Departman);
        }
    }
}
