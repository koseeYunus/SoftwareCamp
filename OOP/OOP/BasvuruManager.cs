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
    }
}
