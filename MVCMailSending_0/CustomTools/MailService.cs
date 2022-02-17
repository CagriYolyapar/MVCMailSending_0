using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net;

namespace MVCMailSending_0.CustomTools
{

    //Gmail hesabı ile Mail gönderme işlemlerini yapacak iseniz öncelikle Gmail'in ayarlarından diger uygulamalardan Mail göndermeye izin ver secenegini işaretlemeniz gerekir...

    //yms34243423@gmail.com

    //password: 34243424


    //Git'e bu projeyi göndecekseniz (proje private olacaksa bile) kesinlikle sifre ve mail kısmını bos gönderin... Aynı zamanda kesinlikle Front End'de sifre ile ilgili bir şey yazılmasın...

    //Git ile calısıyorsanız Git'e gönderdiginiz dosyalarda sifre ile ilgili bir şeyler olmamasına cok dikkat etmelisiniz...

    public static class MailService
    {
        //"asdad@gmail.com,sdadsd@gmail.com,asdasd@hotmail.com"
        
        public static void Send(string receiver,string password = "3152yms3152", string body = "Test mesajıdır",string subject = "Email testi",string sender = "yms3152test@gmail.com")
        {
            MailAddress senderEmail = new MailAddress(sender);
            MailAddress receiverEmail = new MailAddress(receiver);

            //Bizim Email işlemlerimiz SMTP'ye göre yapılır...
            //Kullandıgımız gmail hesabının baska uygulamalar tarafından mesaj gönderme özelliginin acıldıgına emin olmalıyız...

            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(senderEmail.Address, password),
                
            };

            using(MailMessage message = new MailMessage(senderEmail, receiverEmail)
            {
                Subject = subject,
                Body = body,
                
                
                
            })
            { 
              
                smtp.Send(message);
            }



        }
    }
}