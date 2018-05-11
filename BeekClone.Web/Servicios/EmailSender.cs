using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace BeekClone.Web.Servicios
{
    public class EmailSender
    {

        public void Send(string email, string subject, string body )
        {
            MailMessage mail = new MailMessage();
            SmtpClient client = new SmtpClient();

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new System.Net.NetworkCredential("me52635@gmail.com", "OUhDQS9Tr%S2");
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";

            mail.From = new MailAddress("to@example.com");
            mail.To.Add(email);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = true;

            client.Send(mail);
        }

    }
}