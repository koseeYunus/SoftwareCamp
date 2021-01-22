using System;

namespace ManagerAndMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Isim = "Armut";
            product1.Fiyati = 5;
            product1.Aciklama = "Isparta elması.";
            product1.StokAdedi = 1500;

            Product product2 = new Product();
            product2.Isim = "Domates";
            product2.Fiyati = 4;
            product2.Aciklama = "Çarşamba taze domates.";

            Product[] products = new Product[] { product1, product2 };

            foreach (Product p in products)
            {
                Console.WriteLine("İsim : " + p.Isim + "\n" + "Fiyat : " + p.Fiyati + "\n" + "Aciklama : " + p.Aciklama + "\n\n-----------------------\n");
            }

            //instance - örnek
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Delete(product1);
        }
    }
}
