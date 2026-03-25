using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace CAMPUS_FIX.Models
{
    public class mailer
    {
        // public mailer() { }
        string MyEmailMail = "";
        string MyMailAppPassword = "";
        public bool SendMyEmail(string sendTo, string Subject, string message)
        {
            try
            {
                // 1- perform setting of msg
                MailMessage msg = new MailMessage();
                MailAddress mafrom = new MailAddress(MyEmailMail);
                msg.From = mafrom;
                msg.Subject = Subject;
                msg.To.Add(sendTo);
                msg.Body = message;
                // 2- create and set smtp protocol
                SmtpClient client = new SmtpClient();
                client.Host = "localhost";
                client.Port = 587;
                client.EnableSsl = true;
                //client.Send(msg);
                NetworkCredential nc = new NetworkCredential(MyEmailMail, MyMailAppPassword);
                client.Credentials = nc;


                // 3- send email
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