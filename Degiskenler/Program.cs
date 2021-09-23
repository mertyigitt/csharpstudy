using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 5; // 1 byte yer kaplar
            sbyte c = 5; // 1 byte yer kaplar

            short s = 5; //2 byte yer kaplar
            ushort us = 5; // 2 byte yer kaplar

            Int16 i16 = 2; // 2 byte yer kaplar
            int i = 2; // 4 byte yer kaplar
            Int32 i32 = 2; // 4 byte yer kaplar
            Int64 i64 = 2; // 8 byte yer kaplar
            uint ui = 2; // 4 byte yer kaplar
            
            long l = 4; // 8 byte yer kaplar
            ulong ul = 4; // 8 byte yer kaplar

            //Reel sayı tutabilir
            float f = 5; // 4 byte yer kaplar
            double d = 5; // 8 byte yer kaplar
            decimal de = 5; // 16 byte yer kaplar
            
            char ch = '2'; // 2 byte yer kaplar
            string str = "Mert"; // Sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String Ifadeler
            
            string str1 = "";
            string str2 = null;
            string str3 = string.Empty;
            str3 = "Mert Yigit";
            
            string ad = "Mert";
            string soyad = "Yigit";
            string tamAd = ad + " " + soyad;

            //Integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //Boolean

            bool bool1 = 10<2; //false
            bool bool2 = 10>2; //true

            //Değişken Dönüşümleri

            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); // Çıktısı 40

            int int22 = int20 + int.Parse(str20); // Çıktısı 40

            // dateTime

            string dateTime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(dateTime);

            string dateTime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(dateTime2);

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
