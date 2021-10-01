using System;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            //Expression
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayindasiniz!");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayindasiniz!");
                    break;
                case 4:
                    Console.WriteLine("Nisan Ayindasiniz!");
                    break;
                case 3:
                    Console.WriteLine("Mart Ayindasiniz!");
                    break;
                default:
                    Console.WriteLine("Yanlis bir veri girdiniz!");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis Mevsimindesiniz!");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Mevsimindesiniz!");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Mevsimindesiniz!");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Mevsimindesiniz!");
                    break;
                default:
                    break;
            }
        }
    }
}
