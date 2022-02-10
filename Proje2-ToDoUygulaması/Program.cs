using System;
using System.Collections.Generic;

namespace Proje2_ToDoUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kisiler = new();
            kisiler.Add(1,"Mevrve Kacar");
            kisiler.Add(2,"Mert Yilmaz");
            kisiler.Add(3,"Cansu Ozdemir");
            kisiler.Add(4,"Ahmet Mentes");
            kisiler.Add(5,"Yasar Ugur");
            List<InProgress> InPro = new();
            List<Done> Done = new();
            List<TodoLine> ToDo = new();
            List<Gec> Gec = new();

            int iptal = 0;
            while(iptal != 5)
            {
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : \n*******************************************\n(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak\n(5) Programı Sonlandırmak : ");
                int secim = int.Parse(Console.ReadLine());
                Program metot = new();
                switch(secim)
                {
                    case 1:
                        metot.Listeleme(ToDo,Done,InPro,kisiler);
                        break;
                    case 2:
                        metot.Ekleme(ToDo,Done,InPro,kisiler);
                        break;
                    case 3:
                        metot.Silme(ToDo,Done,InPro);
                        break;
                    case 4:
                        metot.Tasima(ToDo,Done,InPro,kisiler,Gec);
                        break;
                    case 5:
                        Console.WriteLine("Program sonlandiriliyor.");
                        iptal = 5;
                        break;
                    default:
                        Console.WriteLine("Lutfen doru bir giris yapiniz.");
                        break;
                }
            }
        }




        public void Listeleme(List<TodoLine> ToDo,List<Done> Done,List<InProgress> InPro,Dictionary<int,string> kisiler)
        {
            Console.WriteLine("\nTODO Line\n ************************");
            if(ToDo.Count >0)
            {
                foreach (var item in ToDo)
                {
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOS ~");
            Console.WriteLine("\n");
            Console.WriteLine("IN PROGRESS Line\n ************************");
            if(InPro.Count >0)
            {
                foreach (var item in InPro)
                {
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOS ~");
            Console.WriteLine("\n");
            Console.WriteLine("DONE Line\n ************************");
            if(Done.Count >0)
            {
                foreach (var item in Done)
                {
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Console.WriteLine("-");
                }
            }
            else
                Console.WriteLine("~ BOS ~");
            Console.WriteLine("\n");
        }



        public void Ekleme(List<TodoLine> ToDo,List<Done> Done,List<InProgress> InPro,Dictionary<int,string> kisiler)
        {
            
            Console.Write("Başlık Giriniz                                  :");
            string baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz                                  :");
            string icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
            int buyukluk =int.Parse(Console.ReadLine()); 
            Console.Write("Kişi Seçiniz                                    :");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Lütfen eklemek istediğiniz Line'ı seçiniz: \n(1) TODO\n(2) IN PROGRESS\n(3) DONE :");
            int line = int.Parse(Console.ReadLine());
            if(line == 1)
                ToDo.Add(new TodoLine(baslik,icerik,(BoardSize)buyukluk,id));
            else if(line == 2)
                InPro.Add(new InProgress(baslik,icerik,(BoardSize)buyukluk,id));
            else if(line == 3)
                Done.Add(new Done(baslik,icerik,(BoardSize)buyukluk,id));
            else
                Console.WriteLine("Lutfen Dogru bir giris yapiniz.");
        }




        public void Silme(List<TodoLine> ToDo,List<Done> Done,List<InProgress> InPro)
        {
            Console.Write("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız: ");
            string baslikal = Console.ReadLine();
            var degis5 = ToDo.ToArray();
            foreach (var item in degis5)
            {
                if(baslikal == item.Baslik)
                {
                    ToDo.Remove(item);
                    Console.WriteLine("Kart basari ile silinmistir.");
                }
                else
                {
                    Console.Write("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2) : ");
                    int sec = int.Parse(Console.ReadLine());
                    if(sec == 2)
                        Silme(ToDo,Done,InPro);
                }

            }
            var degis6 = InPro.ToArray();
            foreach (var item in degis6)
            {
                if(baslikal == item.Baslik)
                {
                    InPro.Remove(item);
                    Console.WriteLine("Kart basari ile silinmistir.");
                }
                else
                {
                    Console.Write("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2) : ");
                    int sec = int.Parse(Console.ReadLine());
                    if(sec == 2)
                        Silme(ToDo,Done,InPro);
                }

            }
            var degis7 = Done.ToArray();
            foreach (var item in degis7)
            {
                if(baslikal == item.Baslik)
                {
                    Done.Remove(item);
                    Console.WriteLine("Kart basari ile silinmistir.");
                }
                else
                {
                    Console.Write("Aradığınız ktiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n* Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2) : ");
                    int sec = int.Parse(Console.ReadLine());
                    if(sec == 2)
                        Silme(ToDo,Done,InPro);
                }
            }
        }



        public void Tasima(List<TodoLine> ToDo,List<Done> Done,List<InProgress> InPro,Dictionary<int,string> kisiler,List<Gec> Gec)
        {
            Console.Write("Öncelikle tasimak istediğiniz kartı seçmeniz gerekiyor. \nLütfen kart başlığını yazınız: ");
            string tasi = Console.ReadLine();
            var degis1 = ToDo.ToArray();
            int bulundu = 0;
            foreach (var item in degis1)
            {
                if(tasi == item.Baslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Gec.Add(new Gec (item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    ToDo.Remove(item);
                    bulundu++;
                }
            }

            var degis2 = InPro.ToArray();
            foreach (var item in degis2)
            {
                if(tasi == item.Baslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Gec.Add(new Gec (item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    InPro.Remove(item);
                    bulundu++;
                }
            }

            var degis3 = Done.ToArray();
            foreach (var item in degis3)
            {
                if(tasi == item.Baslik)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:\n**************************************");
                    Console.WriteLine("Başlık      : "+item.Baslik);
                    Console.WriteLine("İçerik      : "+item.Icerik);
                    foreach (var item1 in kisiler.Keys)
                    {
                        if(item1 == item.AtananKisi)
                        {
                            Console.WriteLine("Atanan Kişi : "+kisiler[item1]);
                        }
                    }
                    Console.WriteLine("Büyüklük    : "+item.Buyukluk);
                    Gec.Add(new Gec (item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    Done.Remove(item);
                    bulundu++;
                }

            }
            if(bulundu > 0)
            {
                Console.Write("\nLütfen taşımak istediğiniz Line'ı seçiniz: \n(1) TODO\n(2) IN PROGRESS\n(3) DONE : ");
                int secim1 = int.Parse(Console.ReadLine());
                if(secim1 == 1)
                {
                    foreach (var item in Gec)
                    {
                        ToDo.Add(new TodoLine(item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    }
                    var degis7 = Gec.ToArray();
                    foreach (var item in degis7)
                    {
                        Gec.Remove(item);
                    }
                }
                if(secim1 == 2)
                {
                    foreach (var item in Gec)
                    {
                        InPro.Add(new InProgress(item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    }
                    var degis7 = Gec.ToArray();
                    foreach (var item in degis7)
                    {
                        Gec.Remove(item);
                    }
                }
                if(secim1 == 3)
                {
                    foreach (var item in Gec)
                    {
                        Done.Add(new Done(item.Baslik,item.Icerik,(BoardSize)item.Buyukluk,item.AtananKisi));
                    }
                    var degis7 = Gec.ToArray();
                    foreach (var item in degis7)
                    {
                        Gec.Remove(item);
                    }
                }
                else
                    Console.WriteLine("Hatalı bir seçim yaptınız!");
            }
            else
            {
                Console.Write("Aradığınız kriterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.\n* Tasimayi sonlandırmak için : (1)\n* Yeniden denemek için : (2) : ");
                int sec1 = int.Parse(Console.ReadLine());
                if(sec1 == 2)
                    Tasima(ToDo,Done,InPro,kisiler,Gec);
            }
        }
    }
}
