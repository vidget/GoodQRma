using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;


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
 
       
        //[HttpGet]
        //public ActionResult Contacts()
        //{
        //    return View();
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Contact(HelpForm model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
        //        var message = new MailMessage();
        //        message.To.Add(new MailAddress("goodqrma@gmail.com"));  // replace with valid value 
        //        message.From = new MailAddress("hemaak91@yahoo.com");  // replace with valid value
        //        message.Subject = "Your email subject";
        //        message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
        //        message.IsBodyHtml = true;

        //        using (var smtp = new SmtpClient())
        //        {
        //            var credential = new NetworkCredential
        //            {
        //                UserName = "goodqrma@gmail.com",  // replace with valid value
        //                Password = "4goodqrma"  // replace with valid value
        //            };
        //            smtp.Credentials = credential;
        //            smtp.Host = "smtp.gmail.com";
        //            smtp.Port = 587;
        //            smtp.EnableSsl = true;
        //            await smtp.SendMailAsync(message);
        //            return RedirectToAction("Sent");
        //        }
        //    }
        //    return View(model);
        //}

        //public ActionResult Sent()
        //{
        //    return View();
        //}

//    }
//}
