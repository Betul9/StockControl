using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi";
        internal static string ProductCountOfCategoryError = "Kategori sayısı aşıldı";
        internal static string ProductNameAlreadyExist = "Ürün adı zaten mevcut";
        internal static string CategoryLimitExceeded = "Kategori Limiti Aşıldı";
        internal static string AuthorizationDenied = "Yetkiniz yok";
        internal static string AccessTokenCreated;
        internal static string UserAlreadyExists;
        internal static string SuccessfulLogin;
        internal static User PasswordError;
        internal static User UserNotFound;
        internal static string UserRegistered;
    }
}
