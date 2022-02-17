using MVCMailSending_0.CustomTools;
using MVCMailSending_0.DesignPatterns.SingletonPattern;
using MVCMailSending_0.Models.Context;
using MVCMailSending_0.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMailSending_0.Controllers
{
    public class MailSendController : Controller
    {

        MyContext _db;

        public MailSendController()
        {
            _db = DBTool.DBInstance;
        }
        // GET: MailSend
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AppUser appUser)
        {
            MailService.Send(appUser.Email, body: "Hello World!!", subject: ":)");
            ViewBag.Message = "Mail basarılı bir şekilde gönderilmiştir";
            return View();
        }
    }
}