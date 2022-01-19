using System;

namespace struck_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            // dikdortgen.KisaKenar = 3;
            // dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabi: {0}",dikdortgen.AlanHesapla());

            Dikdortgen_Struck dikdortgen_struck;
            dikdortgen_struck.KisaKenar = 3;
            dikdortgen_struck.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabi: {0}",dikdortgen_struck.AlanHesapla());


        }
    }
    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;

        // public Dikdortgen()
        // {
        //     KisaKenar = 3;
        //     UzunKenar = 4;
        // }
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struck
    {
        public int KisaKenar;
        public int UzunKenar;

        // public Dikdortgen(int uzunKenar, int kisaKenar)
        // {
        //     UzunKenar = uzunKenar;
        //     KisaKenar = kisaKenar;
        // }

        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
