using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class MessageController : Controller
    {
        DbMyPortfolioEntities context=new DbMyPortfolioEntities();
        public ActionResult Inbox()
        {
            var values=context.Contacts.ToList();
            return View(values);
        }
        public ActionResult ChangeMessageToTrue (int id)
        {
            var value =context.Contacts.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public ActionResult ChangeMessageToFalse(int id)
        {
            var value = context.Contacts.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}