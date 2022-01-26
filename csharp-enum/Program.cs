using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)Gunler.Pazartesi);
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik = 32;

            if(sicaklik<=(int)HavaDurumu.Normal)
                Console.WriteLine("Hava Soguk");
            else if (sicaklik >=(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hava Cok Sicak");
            else if(sicaklik >=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.Sicak)
                Console.WriteLine("Hava Cok Guzel");
        }
    }
    enum Gunler
    {
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar,
    }
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30,
    }
}
