using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayse";
            ogrenci1.Soyisim = "Yilmaz";
            ogrenci1.OgrenciNo = 293;
            ogrenci1.Sinif = 3;            
            ogrenci1.OgrenciBilgileriYaz();

            ogrenci1.SinifAtlat();
            ogrenci1.OgrenciBilgileriYaz();

            Ogrenci ogrenci2 = new Ogrenci("Deniz","Arda",256,1);
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();
            ogrenci2.OgrenciBilgileriYaz();
        }
    }
    
    
    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        {
            get {return isim;} 
            set {isim = value;} 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get {return sinif;} 
            set {
                if (value<1)
                    {
                        Console.WriteLine("Sinif 1 den Kucuk Olamaz!");
                        sinif = 1;
                    }
                else
                    sinif = value;
                }
            }
        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){}

        public void OgrenciBilgileriYaz()
        {
            Console.WriteLine("*** Ogrenci Bilgileri ***");
            Console.WriteLine("Ogrenci Adi :{0}",this.Isim);
            Console.WriteLine("Ogrenci Soyadi :{0}",this.Soyisim);
            Console.WriteLine("Ogrenci Numarasi :{0}",this.OgrenciNo);
            Console.WriteLine("Ogrenci Sinifi :{0}",this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif-1;
        }
    }
}
