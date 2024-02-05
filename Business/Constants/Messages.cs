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
        public static string MaxValue100 = "Maksimum 100 karakter olmalıdır";
        public static string MaxValue250 = "Maksimum 250 karakter olmalıdır";
        public static string Value16 = "16 karakter olmalıdır";
        public static string Value10 = "10 karakter olmalıdır";


        public static string SpendingRequestUpdated = "Harcama talebi başarıyla güncellendi";
        public static string SpendingRequestNotUpdated = "Harcama talebi güncellenemedi!";
        public static string SpendingRequestAdded = "Harcama talebi başarıyla eklendi";
        public static string SpendingRequestNotAdded = "Harcama talebi eklenemedi!";
        public static string TheAmountCanNotBeLessThanZero = "Harcama tutarı 0'dan küçük olamaz";
        public static string NumberOnly = "Sadece sayı giriniz";
        public static string AdvanceRequestNotFound = "Avans talebi bulunamadı";
        public static string FirmCanNotAdded = "Firma eklenirken bir hata oluştu!";
        public static string FirmAdded = "Firma eklendi";


        
        public static string AdvanceRequestUpdated = "Avans talebi başarıyla güncellendi";
        public static string AdvanceRequestNotUpdated = "Avans talebi güncellenemedi!";
        public static string AdvanceRequestAdded = "Avans talebi eklendi!";
        public static string AdvanceRequestNotAdded = "Avans talebi eklenemedi!";
        public static string PriceCanNotBeMoreThanSalarysThirdTimes = "Avans talebi maaşın 3 katından fazla olamaz";



        public static string NotAValidPhoneNumber = "Geçerli bir telefon numarası giriniz.";

        public static string NotAValidSalary = "Maaş değeri sıfırdan küçük olamaz";

        public static string NotAValidEmail = "Geçerli bir email adresi giriniz.";

        public static string PhoneNumberAlreadyExist = "Bu telefon numarası zaten kayıtlı.";

        public static string HeadOfDepartmentUpdated = "Yönetici güncellendi.";

        public static string TheDateCanNotBeAPreviousDate = "İleri bir tarih seçin";

        public static string PasswordChanged= "Parola güncellendi.";

        public static string VocationLeaveRequestNotFound = "İzin talebi bulunamadı.";

        public static string EmployeeUpdated = "Personel güncellendi.";

        public static string ThisFieldIsRequired = "Bu alan boş bırakılamaz";

        public static string LetterOnly = "Sadece harf giriniz";
        public static string VocationLeaveRequestUpdated = "İzin durumu başarıyla güncellendi";
        public static string VocationLeaveRequestNotUpdated = "İzin durumu güncellenemedi!";
        
        public static string SpendingRequestNotFound = "Harcama talebi bulunamadı.";

        public static string MaintenanceTime = "Sistem bakımda";

        public static string AuthorizationDenied = "Yetkiniz yok";

        public static string UserRegistered = "Personel başarıyla kaydedildi";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
        public static string EmailNotSent = "Tek kullanımlık şifre gönderilemedi";

        public static string VocationLeaveRequestAdded = "İzin isteği başarıyla eklendi.";
        public static string VocationLeaveRequestNotAdded = "İzin isteği eklenemedi";

    }
}
