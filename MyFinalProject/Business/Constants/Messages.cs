using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductAddedError = "Ürün eklenemedi.";
        public static string ProductNameInValid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime ="Sistem bakımda.";
        public static string ProductsListed ="Ürünler listelendi.";

        public static string ProductNameAlreadyExists = "Aynı isimde ürün eklenemez.";
        public static string ProductCountOfCategoryCorrect = "Aynı kategorideki ürün sayısı 10'dan fazla !";
        public static string CategoryLimitExceded="Kategori limiti 15'i geçtiğinden dolayı yeni ürün eklenemiyor.";
    }
}
