using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace MVC_Sepet.Utilies
{
    public class MailSender
    {
        public static void OrderMail(string email,string subject,string message)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("yzl3156yzl@gmail.com", "YZL3156");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("yzl3156yzl@gmail.com", "Yzl3156--");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            smtp.Send(mail);
        }
    }
}