using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
   public static class Messages
    {
        

        //public olanlar pascal keys yazılır normalde priv olan propertyi olanlar camel keys yazılır
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string MaintenanceTime = "Sistem bakımdadır.";
        public static  string ProductCountOfCategoryError="Category sınırı aşılmıştır.";
        public static string ProductNameAlreadyExists = "Bu isimde halihazırda isim vardır";
    }
}
