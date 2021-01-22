using System;

namespace LetgoExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LetgoUrun urun1 = new LetgoUrun();
            urun1.resimLink = "resim1";
            urun1.konum = "Ankara";
            urun1.uzaklik = 2.7;
            urun1.baslik = "Samsung Galaxy A3 2016";
            urun1.kategori = "Elektronik";
            urun1.fiyat = 700;
            urun1.favori = false;

            LetgoUrun urun2 = new LetgoUrun();
            urun2.resimLink = "resim2";
            urun2.konum = "Mamak";
            urun2.uzaklik = 1;
            urun2.baslik = "Tv Ünitesi Sıfır İmalatttan";
            urun2.kategori = "Ev ve Bahçe";
            urun2.fiyat = 420;
            urun2.favori = true;

            LetgoUrun urun3 = new LetgoUrun();
            urun3.resimLink = "resim3";
            urun3.konum = "Ulus";
            urun3.uzaklik = 3.6;
            urun3.baslik = "Ford Tourneo 2008 Model";
            urun3.kategori = "Motorlu Taşıt";
            urun3.fiyat = 52000;
            urun3.favori = false;

            LetgoUrun[] urunler = new LetgoUrun[] { urun1, urun2, urun3 };

            for (int i = 0; i < urunler.Length; i++)
            {
                urunler[i].Listele();
            }

            foreach (var urun in urunler)
            {
                urun.Listele();
            }

            int w = 0;
            while (w < urunler.Length)
            {
                urunler[w].Listele();
                w += 1;
            }
        }
    }
}
