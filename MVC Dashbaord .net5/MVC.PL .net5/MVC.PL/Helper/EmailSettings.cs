using MVC.DAL.Entites;
using System.Net;
using System.Net.Mail;

namespace MVC.PL.Helper
{
    public static class EmailSettings
    {
        public static void SendEmail(Email email)
        {
            var client = new SmtpClient("smtp.gmail.com", 587);

            client.EnableSsl = true;
            client.Credentials = new NetworkCredential("osama.h.mohamed44@gmail.com", "zjqxktmzhzczeszk");

            client.Send("osama.h.mohamed44@gmail.com",email.To, email.Title, email.Body);
        }
    }
}
