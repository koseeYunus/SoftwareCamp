using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.Adi = "Engin";
            //musteri1.Soyadi = "Demirog";
            //musteri1.Id = 1;
            //musteri1.TcNo = "12312312312";
            //musteri1.MusteriNo = "112311";
            //musteri1.SirketAdi = "?";
            //YANLIŞ KULLANIM !!!

            //Gerçek Müşteri - Tüzel(Şirket) Müşteri ayrı ayrı ele alınmalıydı
            //SOLID in L harfi açıklar

            //implemantation = uygulama
            //Entity = varlık

            //Engin Demirog
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "123123";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "12312312312";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1233453";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "123-123-2341234";

            //new görülen yer referans numarısıdır. Burada Musteri her ikisininde referansını tutabilir.
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            CostomerManager costomerManager = new CostomerManager();
            costomerManager.Add(musteri1);
            costomerManager.Add(musteri2);
        }
    }
}
