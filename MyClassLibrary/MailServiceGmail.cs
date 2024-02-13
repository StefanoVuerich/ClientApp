namespace MyClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MailServiceGmail : IMailService
    {
        public void SendMail(string from, string to)
        {
            Console.WriteLine($"Sending mail to {to} from {from} with gmail");
        }
    }
}
