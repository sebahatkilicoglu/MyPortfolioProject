using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class StatisticsController : Controller
    {
        DbMyPortfolioEntities context= new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            // Lambda ifadeler// x=>Linq

            ViewBag.totalMessageCount = context.Contacts.Count();
            ViewBag.messageIsReadTrueCount=context.Contacts.Where(x=>x.IsRead==true).Count();
            ViewBag.messageIsReadFalseCount = context.Contacts.Where(y=>y.IsRead==false).Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.skillRateSum = context.Skills.Sum(x=>x.Rate);
            ViewBag.skillRateAvg= context.Skills.Average(x=>x.Rate);

            var maxRate=context.Skills.Max(x=>x.Rate);
            ViewBag.maxRateSkillName = context.Skills.Where(x => x.Rate == maxRate).Select(x => x.SkillName).FirstOrDefault();
            
            ViewBag.getMessageCountBySubjectReferences=context.Contacts.Where(x=>x.Subject=="Referans").Count();
            ViewBag.getMessageCountByEmailContainSAndIsReadTrue=context.Contacts.Where(x=>x.IsRead== true && x.Email.Contains("s")).Count();
            ViewBag.getSkillNameByRate90=context.Skills.Where(x=>x.Rate==90).Select(y=>y.SkillName).FirstOrDefault();

            return View();
        }
    }
}