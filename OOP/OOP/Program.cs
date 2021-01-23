using System;
using System.Collections.Generic;

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


            ILoggerService databaseLoggerService = new FileLogerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new FileLogerService(), new FileLogerService() };


            //Bir nevi soyutlama
            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(konutKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatebaseLogerService(), new FileLogerService() });
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { databaseLoggerService, new FileLogerService() });

            basvuruManager.BasvuruYap(konutKrediManager,loggers);
        }
    }
}
