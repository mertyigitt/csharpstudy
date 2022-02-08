using System;
using System.Collections;
using System.Collections.Generic;

namespace Proje1_TelefonRehberiUygulaması
{
    class aaa
    {
        public void kisis()
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("Ali","Yilmaz","54356985"));
            kisiler.Add(new Kisi("Merve","Sarac","55698569"));
            kisiler.Add(new Kisi("Kemal","Basbug","53258696"));
            kisiler.Add(new Kisi("Mert","Cetin","57585696"));
            kisiler.Add(new Kisi("Kirac","Ozen","55545896"));

            foreach (var item in kisiler)
            {
                Console.WriteLine(item);
            }
        }
    }
}