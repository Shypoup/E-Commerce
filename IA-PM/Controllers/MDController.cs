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
        // GET: MD
        IAEn db = new IAEn();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult add_project()
        {
            return View();}
        [HttpPost]
        public ActionResult add_project(project pro)
        {
            db.projects.Add(pro);
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}