using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje1_TelefonRehberiUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("Ali","Yilmaz","54356985"));
            kisiler.Add(new Kisi("Merve","Sarac","55698569"));
            kisiler.Add(new Kisi("Kemal","Basbug","53258696"));
            kisiler.Add(new Kisi("Mert","Cetin","57585696"));
            kisiler.Add(new Kisi("Kirac","Ozen","55545896"));
            kisiler.Add(new Kisi("Kirac","Ozen","55545896"));

            int iptal = 0;
            while(iptal != 6)
            {
                Console.Write("(1) Yeni Numara Kaydetme\n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme\n(4) Rehberi Listelemek\n(5) Rehberde Arama Yapmak\n(6) Programi Sonlandirmak\n*******************************************\nLütfen yapmak istediğiniz işlemi seçiniz :");
                int secim = int.Parse(Console.ReadLine());
                Program metot = new Program();

                switch(secim)
                {
                    case 1:
                        metot.NumaraEkleme(kisiler);
                        break;
                    case 2:
                        metot.NumaraSilme(kisiler);
                        break;
                    case 3:
                        metot.NumaraGuncelleme(kisiler);
                        break;
                    case 4:
                        metot.Listele(kisiler);
                        break;
                    case 5:
                        metot.Arama(kisiler);
                        break;
                    case 6:
                        Console.WriteLine("Program Sonlandiriliyor...");
                        iptal = 6;
                        break;
                    default:
                        Console.WriteLine("Lutfen seceneklerden birisini giriniz.");
                        break;
                
                }
            }
        }
        public void NumaraEkleme(List<Kisi> kisiler)
        {
            Console.Write("Lütfen isim giriniz             :");
            string i = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz          :");
            string s = Console.ReadLine();
            Console.Write("Lütfen telefon numarası giriniz :");
            string t = Console.ReadLine();

            kisiler.Add(new Kisi(i,s,t));
        }

        public void NumaraSilme(List<Kisi> kisiler)
        {
            Console.Write("Lutfen silmek istediginiz kisinin adini veya soyadini giriniz :");
            string sil1 = Console.ReadLine();
            int karar2 = 0;
            foreach (var item in kisiler)
            {
                if(item.Isim == sil1 || item.Soyisim == sil1)
                {
                    karar2++;
                }
            }
            if(karar2 > 0)
            {
                    Console.Write(sil1 +" isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n) :");
                    string yn1 = Console.ReadLine();
                    if (yn1 == "y")
                    {
                        foreach (var item in kisiler)
                        {
                            if(item.Isim == sil1 || item.Soyisim == sil1)
                            {
                                kisiler.Remove(item);
                                Console.WriteLine("Kisi basariyla silinmistir.");
                                break;
                            }
                        }
                    }
                    else
                        Console.WriteLine("Islem sonlandirildi.");
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.Write("* Silmeyi sonlandirmak icin : (1)\n* Yeniden denemek için      : (2)");
                int yn2 = int.Parse(Console.ReadLine());
                if(yn2 == 2)
                    NumaraSilme(kisiler);
                else
                    Console.WriteLine("Islem sonlandirildi.");
            }
        }


        public void NumaraGuncelleme(List<Kisi> kisiler)
        {
            Console.Write("Lütfen numarasını guncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string mevcut = Console.ReadLine();
            int karar3 = 0;
            foreach (var item in kisiler)
            {
                if(item.Isim == mevcut || item.Soyisim == mevcut)
                {
                    karar3++;
                }
            }

            if(karar3 > 0)
            {
                Console.Write(mevcut + " adli kisinin guncel numarasini giriniz : ");
                string guncel = Console.ReadLine();
                foreach (var item in kisiler)
                {
                    if (item.Isim == mevcut || item.Soyisim == mevcut)
                    {
                        item.TelNo = guncel;
                        Console.WriteLine("Numara basariyla guncellenmistir.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.Write("* Güncellemeyi sonlandırmak için  (1)  : \n* Yeniden denemek için            (2)  : ");
                int yn3 = int.Parse(Console.ReadLine());
                if (yn3 == 2)
                    NumaraGuncelleme(kisiler);
                else
                    Console.WriteLine("Islem sonlandirildi.");
            }
        }


        public void Listele(List<Kisi> kisiler)
        {
            
            Console.Write("Lutfen A-Z siralama icin 1'i\nZ-A siralama icin 2'yi tuslayiniz :");
            int onay = Convert.ToInt16(Console.ReadLine());
            if (onay == 1 )
                kisiler.Sort((u1,u2) => u1.Isim.CompareTo(u2.Isim));
            else if (onay == 2)
            {
                kisiler.Sort((u1,u2) => u1.Isim.CompareTo(u2.Isim));
                kisiler.Reverse();
            }
            Console.WriteLine("Telefon Rehberi\n**********************************************");
            foreach (var item in kisiler)
            {
                Console.WriteLine("Isim : "+item.Isim);
                Console.WriteLine("Soyisim : "+item.Soyisim);
                Console.WriteLine("Telefon Numarasi : "+item.TelNo);
                Console.WriteLine("-");
            }
        }

        public void Arama(List<Kisi> kisiler)
        {
            Console.Write(" Arama yapmak istediğiniz tipi seçiniz.\n**********************************************\n\nİsim veya soyisime göre arama yapmak için(1): \nTelefon numarasına göre arama yapmak için(2): ");
            int karar1 = int.Parse(Console.ReadLine());
            if (karar1 == 1)
            {
                Console.Write("Lutfen aradiginiz kisinin adini veya soyadini giriniz : ");
                string ara1 = Console.ReadLine();
                int karar4 = 0;
                foreach (var item in kisiler)
                {
                    if(item.Isim == ara1 || item.Soyisim == ara1)
                    {
                        karar4++;
                    }
                }
                if(karar4 > 0 )
                {
                    Console.WriteLine(" Arama Sonuçlarınız:\n**********************************************");
                    foreach (var item in kisiler)
                    {
                        if(item.Isim == ara1 || item.Soyisim == ara1)
                        {
                            Console.WriteLine("Isim : "+item.Isim);
                            Console.WriteLine("Soyisim : "+item.Soyisim);
                            Console.WriteLine("Telefon Numurasi : "+item.TelNo);
                            Console.WriteLine("----------------------------------");
                        }
                    }
                }
                else
                    Console.WriteLine("Aradiginiz kisi rehberde bulunamadi.");
            }
            else if (karar1 == 2)
            {
                Console.Write("Lutfen aradiginiz kisinin telefon numarasini giriniz : ");
                string ara2 = Console.ReadLine();
                int karar5 = 0;
                foreach (var item in kisiler)
                {
                    if(item.TelNo == ara2)
                    {
                        karar5++;
                    }
                }
                if(karar5 > 0)
                {
                    foreach (var item in kisiler)
                    {
                        if(item.TelNo == ara2)
                        {
                            Console.WriteLine(" Arama Sonuçlarınız:\n**********************************************");
                            Console.WriteLine("Isim : "+item.Isim);
                            Console.WriteLine("Soyisim : "+item.Soyisim);
                            Console.WriteLine("Telefon Numurasi : "+item.TelNo);
                            Console.WriteLine("----------------------------------");
                        }
                    }
                }
                else
                    Console.WriteLine("Aradiginiz numara rehberde bulunamadi.");
                    Console.WriteLine("----------------------------------");
            }
            else
                Console.WriteLine("Lutfen dogru bir giris yapiniz...");
        }
    }




    class Kisi
    {
        public string Isim;
        public string Soyisim;
        public string TelNo;
        public Kisi(string isim,string soyisim,string telno)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.TelNo = telno;
        }
        
    }
}