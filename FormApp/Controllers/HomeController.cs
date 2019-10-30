using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace FormApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SendEmail(string name, string email, string password)
        {
            MailAddress from = new MailAddress(email, name);

            MailAddress to = new MailAddress("samurrrai.r@gmail.com");

            MailMessage m = new MailMessage(from, to);

            m.Subject = "Тест";
            m.Body = "Отправлено";
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 587);
            smtp.Credentials = new NetworkCredential(email, password);
            smtp.EnableSsl = true;
            smtp.Send(m);
            return Redirect("https://google.kz");
        }
    }
}