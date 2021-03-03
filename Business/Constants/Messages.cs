using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities.Concrete;
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

        public static string AuthorizationDenied = "Yetkiniz bulunmamaktadır..";
        internal static string UserRegistered="kayıt yapıldı.";
        internal static string UserNotFound="kullanıcı bulunamadı.";
        internal static string PasswordError="hatalı şifre";
        internal static string SuccessfulLogin="başarılı giriş";
        internal static string UserAlreadyExists="kullanıcı zaten var.";
        internal static string AccessTokenCreated="oluşturuldu.";
    }
}
