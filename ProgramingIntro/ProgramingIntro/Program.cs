using System;

namespace ProgramingIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool girisYapildimi = false;

            if (girisYapildimi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            string[] kurslar = new string[] { "Yazilim Geliştrime Kampı", "Prpgramlama Başlangıç İçin Temel Kurs", "Java" };
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            kurslar[kurslar.Length - 1] = "C#";
            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "Yazılımm Geliştirme Kampı";
            kurs1.egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 46;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Programlamaya Giriş Kampı";
            kurs2.egitmen = "Yunus Köse";
            kurs2.izlenmeOrani = 98;

            Console.WriteLine(kurs1.kursAdi + " - " + kurs1.egitmen + " - " + kurs1.izlenmeOrani);

            Kurs[] classKurslar = new Kurs[] { kurs1, kurs2 };

            foreach (var k in classKurslar)
            {
                Console.WriteLine(k.kursAdi + " : " + k.egitmen + " -> " + k.izlenmeOrani);
            }
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }

}
