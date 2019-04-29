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
            var info = db.users.SingleOrDefault(x => x.email == "hesham@mail.com");

            homePage hp = new homePage
            {
                
                projects = proj,
                usr = info
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

       /* public ActionResult Register(homePage user)
        {
            user us =new user();
            us.Fname = user.usr.Fname;
            us.Lname = user.usr.Lname;
            us.mobile = user.usr.mobile;
            //us.photo = user.usr.photo;
            us.email = user.usr.email;
            us.password = user.usr.password;
            
           
            db.users.Add(us);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        */

    }
}