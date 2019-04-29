using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA_PM.Models;

namespace IA_PM.Controllers
{
    public class CustomerController : Controller
    {
        IAEntitiesPM db = new IAEntitiesPM();

        public ActionResult Index()
        {

            var custtomer = db.users.SingleOrDefault(x => x.email == "hesham@mail.com");

            var proj = db.projects.ToList();
            var usrs = db.users.ToList();

            CustomerPage cust = new CustomerPage
            {
                customer = custtomer,
                users = usrs,
                projects = proj
            };
            return View(cust);
        }
        public ActionResult ListUsers()
        {
            var usrs = db.users.ToList();
            return View(usrs);
        }
        public ActionResult ListProjects()
        {
            var proj = db.projects.ToList();

            return View(proj);
        }

        public ActionResult SaveRecord(CustomerPage proj)
        {
            project pro = new project();
            pro.name = proj.project.name;
            pro.date = Convert.ToDateTime(proj.project.date);
            pro.descreption = proj.project.descreption;
            pro.price = proj.project.price;

            db.projects.Add(pro);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
