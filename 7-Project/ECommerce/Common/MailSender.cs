using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MailSender
    {
        public static void SendMail(string email, string subject, string message)
        {
            //Sender
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("yzl3156yzl@gmail.com", "YZL3156");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;


            //Smtp
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("yzl3156yzl@gmail.com", "Yzl3156--");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            smtp.Send(mail);

            //NOT!!
            //Eğer tanımlı gmail hesabınız üzerinden mail göndermek istediğinizde bir hata ile karşılaşıyorsanız aşağıdaki link üzerinden izin tanımlaması yapmanız gerekmektedir.
            //https://www.google.com/settings/security/lesssecureapps
        }
    }
}
