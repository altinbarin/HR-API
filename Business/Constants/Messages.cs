using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string NotAValidTc = "Geçerli bir Tc kimlik numarası giriniz";

        public static string NotAValidPhoneNumber = "Geçerli bir telefon numarası giriniz.";

        public static string NotAValidSalary = "Maaş değeri sıfırdan küçük olamaz";

        public static string NotAValidEmail = "Geçerli bir email adresi giriniz.";

        public static string PhoneNumberAlreadyExist = "Bu telefon numarası zaten kayıtlı.";

        public static string HeadOfDepartmentUpdated = "Yönetici güncellendi.";

        public static string PasswordChanged= "Parola güncellendi.";


        public static string EmployeeUpdated = "Personel güncellendi.";

        public static string ThisFieldIsRequired = "Bu alan boş bırakılamaz";

        public static string LetterOnly = "Sadece harf giriniz";
        

        public static string MaintenanceTime = "Sistem bakımda";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Personel başarıyla kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string EmailNotSent = "Tek kullanımlık şifre gönderilemedi";
    }
}
