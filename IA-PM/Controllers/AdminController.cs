using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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


        public ActionResult SaveRecord(homePage proj)
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



        // GET: /Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user usr = db.users.Find(id);
            if (usr == null)
            {
                return HttpNotFound();
            }
            return View(usr);
        }

        // POST: /Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            user usr = db.users.Find(id);
            db.users.Remove(usr);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}