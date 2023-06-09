using MimeKit;
using MailKit.Net.Smtp;
using EasyCashIdentity.BusinessLayer.Abstract;

namespace EasyCashIdentity.BusinessLayer.Concrete
{
    public class MailManager : IMailService
    {
        public void SendConfirmCodeToUser(string email, int confirmCode)
        {
            MimeMessage mimeMessage = new();
            MailboxAddress mailboxAddressFrom = new("Easy Cash Admin", "info@easycashidentity.com");
            MailboxAddress mailboxAddressTo = new("User", email);
            mimeMessage.From.Add(mailboxAddressFrom);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder = new BodyBuilder
            {
                TextBody = "Kayıt işlemini gerçekleştirmek için onay kodunuz: " + confirmCode
            };
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = "Easy Cash Onay Kodu";
            SmtpClient client = new();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("keremberk53@gmail.com", "ucuwriemxswsjxly");
            client.Send(mimeMessage);
            client.Disconnect(true);
        }
    }
}