
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Kodmark_Azerice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Missia()
        {
            return View();
        }
        public ActionResult CapOlunmusEtiket()
        {
            return View();
        }
        public ActionResult YazılmamısEtiket()
        {
            return View();
        }
        public ActionResult LentNövlari()
        {
            return View();
        }
        public ActionResult SənayeYazıcılar()
        {
            return View();
        }
        public ActionResult MasaustuYazıcılar()
        {
            return View();
        }
        public ActionResult MobilYazıcılar()
        {
            return View();
        }
        public ActionResult BarkodAksesuarları()
        {
            return View();
        }
        public ActionResult BarkodOxucular()
        {
            return View();
        }
        public ActionResult alaqa()
        {
            return View();
        }
        //public ActionResult alaqa(iletisim form)
        //{
        //    SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
        //    NetworkCredential cred = new NetworkCredential("kodmark2@gmail.com", "Kodmark123");
        //    mailClient.Credentials = cred;
        //    MailMessage iletisim = new MailMessage();
        //    iletisim.From = new MailAddress("kodmark2@gmail.com"); //burası kendi maili
        //    iletisim.Subject = "İletişim Formu " + DateTime.Now;
        //    iletisim.IsBodyHtml = true;
        //    iletisim.Body = "kodmark.com web sitesinden iletişim formu dolduruldu. <br/>";
        //    iletisim.Body += "<br/>Ad Soyad: " + form.Ad;
        //    iletisim.Body += "<br/>Email: " + form.Mail;
        //    iletisim.Body += "<br/>Telefon: " + form.Telefon;

        //    iletisim.Body += "<br/>Mesaj: " + form.Mesaj;
        //    mailClient.EnableSsl = true;
        //    iletisim.To.Add("mdilek3496@gmail.com"); //burası info maili
        //    mailClient.EnableSsl = true;
        //    mailClient.Send(iletisim);
        //    return RedirectToAction("alaqa");
        //}
    }
}