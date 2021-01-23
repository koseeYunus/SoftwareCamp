using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class IhtiyacKrediManager : IKrediManager
    {
        public void GeriBildir()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesapla..");
        }
    }
}
