using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bunlar ekrandaki açılır kutular

            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //Bir nevi soyutlama
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager);
            basvuruManager.BasvuruYap(konutKrediManager);
        }
    }
}
