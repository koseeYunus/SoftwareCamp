using System;
using System.Collections.Generic;
using System.Text;

namespace ManagerAndMethod
{
    //Manager oparasyon tutar....
    class SepetManager
    {
        //Add A büyük yazılmasına naming convision denir.
        public void Add(Product proc)
        {
            Console.WriteLine("Sepete " + proc.Isim + " eklendi..");
        }

        public void Delete(Product proc)
        {
            Console.WriteLine(proc.Isim + " ürünü silindi..");
        }
    }
}
