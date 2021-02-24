using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductListed = "Ürün listelendi";
        internal static string MaintenanceTime = "Sistem bakımda";

        public static string ProductCountOfCategoryError = "max 10 ürün olabilir";
        public static string ProductNameAlreadyExist="Ürün ismi daha önce alınmış olabilir";

        public static string CategoryLimitExceded = "Kategori limiti aşıldı.";
    }
}
