using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Core.Entities;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "araba eklendi";
        public static string DescriptionInvalid = "araba ismi geçersiz";
        public static string MaintenanceTime = "sistem bakımda";
        public static string CarsListed = "arabalar listelendi";
        public static string CarsDeleted = "arabalar silindi";
        public static string CarError = "hata!!";
        public static string CarUpdated = "güncelleme yapıldı";
        public static string CarImageLimitExceded ="limit kontrol";
        public static string UserRegistered  = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Sisteme giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Access token başarıyla oluşturuldu";
        public static string AuthorizationDenied="yetkiniz yok";
    }
}
