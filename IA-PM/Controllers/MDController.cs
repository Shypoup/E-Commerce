using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IA_PM.Models;

namespace IA_PM.Controllers
{

    public class MDController : Controller
    {
        IAEntitiesPM db = new IAEntitiesPM();

        public ActionResult Index()
        {

            var md = db.users.SingleOrDefault(x => x.email == "hesham@mail.com");

            var proj = db.projects.ToList();

            MDPage Md = new MDPage
            {
                MD = md,

                projects = proj
            };
            return View(Md);
        }

        public ActionResult ListProjects()
        {
            var proj = db.projects.ToList();

            return View(proj);
        }

    }
}