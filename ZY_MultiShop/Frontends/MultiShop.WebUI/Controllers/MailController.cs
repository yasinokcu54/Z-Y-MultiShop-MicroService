using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MultiShop.WebUI.Models;

namespace MultiShop.WebUI.Controllers
{
    public class MailController : Controller
    {
        [HttpGet]
        public IActionResult SendMail()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMail(MailRequest mailRequest)
        {
            var mimeMessage = new MimeMessage();

            var from = new MailboxAddress("MultiShop Katalog", "yasinokcu2015@outlook.com");
            var to = new MailboxAddress("User", mailRequest.ReceiverMail);

            mimeMessage.From.Add(from);
            mimeMessage.To.Add(to);
            mimeMessage.Subject = mailRequest.Subject;

            var bodyBuilder = new BodyBuilder
            {
                TextBody = mailRequest.MessageContent
            };
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                // Buraya uygulama şifresini yaz!
                client.Authenticate("yasinokcu2015@outlook.com", "etad kwol lwaq fmgc");

                client.Send(mimeMessage);
                client.Disconnect(true);
            }

            return View();
        }

    }
}
