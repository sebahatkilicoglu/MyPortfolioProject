using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;
namespace MyPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
      DbMyPortfolioEntities context= new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();   
        }

        public PartialViewResult PartialHeader() 
        {
            ViewBag.title= context.Profiles.Select(x=>x.Title).FirstOrDefault();
            ViewBag.description = context.Profiles.Select(x=> x.Description).FirstOrDefault();
            ViewBag.address = context.Profiles.Select(x=> x.Address).FirstOrDefault();
            ViewBag.email = context.Profiles.Select(x=> x.Email).FirstOrDefault();
            ViewBag.phone = context.Profiles.Select(x=> x.Phone).FirstOrDefault();
            ViewBag.github = context.Profiles.Select(x=> x.Github).FirstOrDefault();
            ViewBag.imageUrl = context.Profiles.Select(x=> x.ImageUrl).FirstOrDefault();

            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = context.Abouts.ToList();
            return PartialView(values);   
        }

        public PartialViewResult PartialExperience()
        {
            var values= context.Experiences.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        { 
            var values= context.Skills.Where(x=>x.Status==true).ToList();
            return PartialView(values);        
        }
    }
}