﻿using Core.Entities.Concrete;
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
        internal static string AccessTokenCreated = "Token oluşturuldu";
        internal static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        internal static string SuccessfulLogin = "Başarılı giriş";
        internal static string PasswordError = "Parola hatası";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string UserRegistered = "Kullanıcı kaydedildi";
    }
}
