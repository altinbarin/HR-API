using System.Net;
using System.Net.Mail;

namespace Business.Helpers
{
    public static class EmailSender
    {
        public static bool SendPasswordCodeEmail(string recipientEmail, out string generatedPassword)
        {
            generatedPassword = null;

            try
            {
                generatedPassword = new Random().Next(100000, 999999).ToString();

                MailMessage mesaj = new MailMessage();
                SmtpClient client = new SmtpClient();

                // E-posta gönderimi için gerekli bilgiler
                client.Credentials = new NetworkCredential("fohmkaloritakip@gmail.com", "znyj ajxp mjyl vvyh");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                // Mesaj oluşturma
                mesaj.From = new MailAddress("fohmkaloritakip@gmail.com");
                mesaj.Subject = "TOALL Human Resources Kullanıcı Şifresi";
                mesaj.Body = $"Tek kullanımlık şifreniz:  {generatedPassword}. Lütfen giriş yaptıktan sonra şifrenizi değiştirin. ";
                mesaj.To.Add(recipientEmail);

                // E-posta gönderme
                client.Send(mesaj);

                // E-posta gönderimi başarılı olduysa true döndür
                return true;
            }
            catch (Exception ex)
            {
                // Hata durumunda false döndür
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }

        // Kullanım örneği:
        // string password;
        // bool isEmailSent = SendPasswordCodeEmail(txtKullaniciAdi.Text, out password);
        // if (isEmailSent)
        // {
        //     // Şifre oluşturuldu ve e-posta gönderildi, password değişkenini kullanabilirsiniz.
        // }
    }
}
