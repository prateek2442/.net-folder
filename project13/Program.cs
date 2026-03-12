using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project13       // Email sender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string email, sub, msg;
            Console.Write("Enter email ID  to Sen Email");
            email = Console.ReadLine();
            Console.Write("enter subject of the mail");
            sub = Console.ReadLine();
            Console.Write("Type here Email Message");
            msg = Console.ReadLine();
            mailer mr = new mailer();
            bool res = mr.SendMyEmail(email, sub, msg);
            if (res == true) Console.Write("Email sent");
            
            else Console.Write("Sorry! email not sent");
        }
    }
}
