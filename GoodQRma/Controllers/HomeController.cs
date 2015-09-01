using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using GoodQRma.Models;

namespace GoodQRma.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View("Index", "_LayoutHOME");

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact us.";
            return View();
        }

        [HttpPost]
        public ViewResult Contact(GoodQRma.Models.HelpForm hform)
        {

            if (ModelState.IsValid)
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(hform.To);
                mail.From = new MailAddress(hform.From);
                mail.Subject = hform.Subject;
                string Body = hform.Body;
                mail.Body = Body;
                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential
                ("goodqrma@gmail.com", "4goodqrma");// Enter seders User name and password  
                smtp.EnableSsl = true;
                smtp.Send(mail);
                return View("Index", hform);
            }

            else
            {
                return View();
            }
        }
    }
}