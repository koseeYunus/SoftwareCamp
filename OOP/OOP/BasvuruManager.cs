using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)
        {
            //Bilgileri değerlendir...

            krediManager.Hesapla();
            foreach (ILoggerService item in loggerService)
            {
                item.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager item in krediler)
            {
                item.Hesapla();
            }
        }
    }
}
