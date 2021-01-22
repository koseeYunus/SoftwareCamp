using System;
using System.Collections.Generic;
using System.Text;

namespace LetgoExample
{
    class LetgoUrun
    {
        public string resimLink { get; set; }
        public string konum { get; set; }
        public double uzaklik { get; set; }
        public string baslik { get; set; }
        public string kategori { get; set; }
        public double fiyat { get; set; }
        public bool favori { get; set; }

        //LetgoUrun()
        //{
        //    this.resimLink = "Tanımlanmadı";
        //    this.konum = "Belirlenmedi";
        //    this.uzaklik = 0;
        //    this.baslik = "Tanımlanmadı";
        //    this.kategori = "Tanımlanmadı";
        //    this.fiyat = 0;
        //    this.favori = false;
        //}
        public void Listele()
        {
            Console.WriteLine("Resim : " + this.resimLink + "\n" + "Konum : " + this.konum + "\n" + "Uzaklık : " + this.uzaklik + " km" + "\n" + "Baslik : " + this.baslik + "\n" + "Kategori : " + this.kategori + "\n" + "Fiyat : " + this.fiyat + " TL" + "\n" + "Favori Durumu : " + this.favori + "\n");
        }
    }
}
