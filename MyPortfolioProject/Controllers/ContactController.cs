using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
       DbMyPortfolioEntities context= new DbMyPortfolioEntities();
        public PartialViewResult PartialContactSidebar()
        {
            return PartialView();
        }
        public PartialViewResult PartialContactDetail()
        {
            ViewBag.address= context.Profiles.Select(p => p.Address).FirstOrDefault();
            ViewBag.description= context.Profiles.Select(p => p.Description).FirstOrDefault();
            ViewBag.phone= context.Profiles.Select(p => p.Phone).FirstOrDefault();
            ViewBag.email= context.Profiles.Select(p => p.Email).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialContactLocation() 
        {
            return PartialView();
        }
    }
}