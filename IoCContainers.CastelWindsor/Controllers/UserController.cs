﻿using System.Web.Mvc;
using IoCConteiners.Models;
using IoCConteiners.Resipository;
using IoCConteiners.Resipository.Implementation;

namespace IoCConteiners.CastleWindsor.Controllers
{
    public class UserController : Controller
    {

        private readonly IRepository<User> db;
        public UserController(IRepository<User> repo)
        {
            db = repo;
        }
        public ActionResult Index()
        {
            return View(db.GetEntitysList());
        }

        public ActionResult Details(int id)
        {
            User user = db.GetEntity(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,Email,Gender")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Create(user);
                return RedirectToAction("Index");
            }

            return View(user);
        }

        public ActionResult Edit(int id)
        {
            User user = db.GetEntity(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Email,Gender")] User user)
        {
            if (ModelState.IsValid)
            {
                db.Edit(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        public ActionResult Delete(int id)
        {
            User user = db.GetEntity(id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.GetEntity(id);
            db.Delete(user);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                db.Dispose();
            base.Dispose(disposing);
        }
    }
}