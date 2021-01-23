using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //Bilgileri değerlendir...

            krediManager.Hesapla();
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
