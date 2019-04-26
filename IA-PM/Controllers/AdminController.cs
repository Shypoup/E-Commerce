using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA_PM.Models;

namespace IA_PM.Controllers
{
    public class AdminController : Controller
    {
        IAEntitiesPM db = new IAEntitiesPM();
        // GET: Admin
        public ActionResult Index()
        {
            var info = db.users.SingleOrDefault(x => x.email == "hesham@mail.com");
            var alus = db.users.ToList();
            var proj = db.projects.ToList();

            adminPage ap=new adminPage
            {
                admin = info,
                allusers = alus,
                projects =proj 
            };
            return View(ap);
        }

        public ActionResult ListUsers()
        {
            var usrs = db.users.ToList();
            return View(usrs);
        }

    }
}