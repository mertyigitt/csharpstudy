using System;

namespace Proje2_ToDoUygulaması
{
    public class TodoLine
    {
        public string Baslik;
        public string Icerik;
        public BoardSize Buyukluk;
        public int AtananKisi;

        public TodoLine(string baslik, string icerik, BoardSize buyukluk, int atananKisi)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.Buyukluk = buyukluk;
            this.AtananKisi = atananKisi;
        }

    }
    public class InProgress
    {
        public string Baslik;
        public string Icerik;
        public BoardSize Buyukluk;
        public int AtananKisi;

        public InProgress(string baslik, string icerik, BoardSize buyukluk, int atananKisi)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.Buyukluk = buyukluk;
            this.AtananKisi = atananKisi;
        }
    }

    public class Done
    {
        public string Baslik;
        public string Icerik;
        public BoardSize Buyukluk;
        public int AtananKisi;

        public Done(string baslik, string icerik, BoardSize buyukluk, int atananKisi)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.Buyukluk = buyukluk;
            this.AtananKisi = atananKisi;
        }
    }

    public class Gec
    {
        public string Baslik;
        public string Icerik;
        public BoardSize Buyukluk;
        public int AtananKisi;

        public Gec(string baslik, string icerik, BoardSize buyukluk, int atananKisi)
        {
            this.Baslik = baslik;
            this.Icerik = icerik;
            this.Buyukluk = buyukluk;
            this.AtananKisi = atananKisi;
        }
    }
}