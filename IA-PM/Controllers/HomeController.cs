using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA_PM.Models;

namespace IA_PM.Controllers
{
    public class HomeController : Controller
    {
        IAEntitiesPM db = new IAEntitiesPM();

        public ActionResult Index()
        {
            var proj = db.projects.ToList();

            homePage hp = new homePage
            {
                
                projects = proj
            };
            return View(hp);
        }
           


        
       
        public ActionResult SaveRecord(homePage proj)
        {
            project pro =new project();
            pro.name = proj.project.name;
            pro.date =Convert.ToDateTime(proj.project.date);
            pro.descreption = proj.project.descreption;
            pro.price = proj.project.price;

            db.projects.Add(pro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ListProjects()
        {
            var proj = db.projects.ToList();
           
            return View(proj);
        }
    }
}