using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace project13
{
    internal class mailer
    {
        string MyEmail = "";
        string MyEmailpassword = "";

        public bool SendMyEmail(string SendTo, string subject, string message)
        {
            try
            {


                // step 1 : Perform setting of message
                MailMessage msg = new MailMessage();
                MailAddress maform = new MailAddress(MyEmail);
                msg.From = maform;
                msg.Subject = subject;
                msg.To.Add(SendTo);
                msg.Body = message;

                // step 2 : Create and set SMTP Protocol
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                NetworkCredential nc = new NetworkCredential(MyEmail, MyEmailpassword);
                client.Credentials = nc;
                // step 2 : Send Email
                client.Send(msg);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
